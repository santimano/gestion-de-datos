using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrbaCommerce.Generar_Publicacion
{
    class PublicacionDAO
    {
        private SqlConnection Conexion;

        public PublicacionDAO(SqlConnection Conexion)
        {
            this.Conexion = Conexion;
        }

        public void Persist(int Codigo, string Descripcion, int Stock, DateTime Fecha
                , DateTime FechaVenc, decimal Precio, string Visibilidad, ListBox.SelectedObjectCollection Rubros
                , string Tipo, string Estado, int Usuario
            )
        {
            String query = "C_R.SP_Publicacion_SAVE";
            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@Codigo", SqlDbType.Int);
            command.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 255);
            command.Parameters.Add("@Stock", SqlDbType.BigInt, 18);
            command.Parameters.Add("@Fecha", SqlDbType.DateTime);
            command.Parameters.Add("@Fecha_Venc", SqlDbType.DateTime);
            command.Parameters.Add("@Precio", SqlDbType.Decimal, 18);
            command.Parameters.Add("@Visibilidad", SqlDbType.NVarChar, 255);
            command.Parameters.Add("@Tipo", SqlDbType.NVarChar, 255);
            command.Parameters.Add("@Estado", SqlDbType.NVarChar, 255);
            command.Parameters.Add("@Usuario", SqlDbType.Int);

            command.Parameters["@Codigo"].Value = Codigo;
            command.Parameters["@Descripcion"].Value = Descripcion;
            command.Parameters["@Stock"].Value = Stock;
            command.Parameters["@Fecha"].Value = Fecha;
            command.Parameters["@Fecha_Venc"].Value = FechaVenc;
            command.Parameters["@Precio"].Value = Precio;
            command.Parameters["@Visibilidad"].Value = Visibilidad;
            command.Parameters["@Tipo"].Value = Tipo;
            command.Parameters["@Estado"].Value = Estado;
            command.Parameters["@Usuario"].Value = Usuario;

            command.Parameters.AddWithValue("@Rubros", CrearRubrosTable(Rubros));

            try
            {
                Conexion.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error");
            }
            finally
            {
                Conexion.Close();
            }
        }

        public Publicacion FindById(int Codigo)
        {
            Publicacion pub = new Publicacion();
            string query = "SELECT P.Pub_Descripcion, P.Pub_Stock, P.Pub_Fecha_Venc, P.Pub_Fecha "
                + ", P.Pub_Precio, V.Pub_Visible_Descripcion "
                + ", T.Pub_Descripcion as Tipo, E.Pub_Estado_Desc "
                + "FROM C_R.Publicaciones P, C_R.Publicaciones_Estados E "
                + ", C_R.Publicaciones_Visibilidad V "
                + ", C_R.Publicaciones_Tipo T "
                + "WHERE P.Pub_Estado_Id = E.Pub_Estado_Id "
                + "AND P.Pub_Visible_Cod = V.Pub_Visible_Cod "
                + "AND T.Pub_Tipo = P.Pub_Tipo_Id "
                + "AND P.Pub_Codigo = @Codigo";

            string queryRubros = "SELECT Pub_Descripcion FROM C_R.Publicaciones_Rubro R, C_R.RL_Publicaciones_Rubros P_R";
            queryRubros += " WHERE R.Pub_RubroId = P_R.Pub_RubroId ";
            queryRubros += " AND P_R.Pub_Codigo = @Codigo ";


            try
            {
                Conexion.Open();
                using (SqlCommand command = new SqlCommand(query, Conexion))
                {
                    command.Parameters.Add("@Codigo", SqlDbType.Int, 18);
                    command.Parameters["@Codigo"].Value = Codigo;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                pub.Descripcion = reader.GetString(0);
                                pub.Stock = reader.GetDecimal(1);
                                pub.FechaVenc = reader.GetDateTime(2);
                                pub.Fecha = reader.GetDateTime(3);
                                pub.Precio = reader.GetDecimal(4);
                                pub.Visibilidad = reader.GetString(5);
                                pub.Tipo = reader.GetString(6);
                                pub.Estado = reader.GetString(7);
                                pub.Rubros = new List<string>();
                            }
                        }
                    }
                }
                using (SqlCommand command = new SqlCommand(queryRubros, Conexion))
                {
                    command.Parameters.Add("@Codigo", SqlDbType.Int, 18);
                    command.Parameters["@Codigo"].Value = Codigo;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                pub.Rubros.Add(reader.GetString(0));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error");
            }
            finally
            {
                Conexion.Close();
            }
            return pub;
        }

        public DataSet Publicaciones_Grilla(string Estado, string Descripcion)
        {
            String query = "SELECT P.Pub_Codigo, P.Pub_Descripcion, P.Pub_Stock, P.Pub_Precio, E.Pub_Estado_Desc"
            + " FROM C_R.Publicaciones P, C_R.Publicaciones_Estados E "
            + " WHERE P.Pub_Estado_Id = E.Pub_Estado_Id "
            + " AND P.Pub_Descripcion LIKE '%'+@Descripcion+'%' "
            + " AND P.Pub_User_Id = @Usuario "
            + " AND E.Pub_Estado_Desc LIKE '%'+@Estado+'%' ";

            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Estado", SqlDbType.VarChar, 255);
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255);
            command.Parameters.Add("@Usuario", SqlDbType.Int);
            command.Parameters["@Estado"].Value = Estado;
            command.Parameters["@Descripcion"].Value = Descripcion;
            command.Parameters["@Usuario"].Value = Main.Usuario;

            DataSet Ds = new DataSet();
            try
            {
                Conexion.Open();
                SqlDataAdapter sDa = new SqlDataAdapter(command);
                sDa.Fill(Ds);

            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error");
            }
            finally
            {
                Conexion.Close();
            }
            return Ds;

        }

        private DataTable CrearRubrosTable(ListBox.SelectedObjectCollection items)
        {
            var tbl = new DataTable();
            tbl.Columns.Add("Rubro", typeof(string));
            foreach (var item in items)
            {
                tbl.Rows.Add(item.ToString());
            }
            return tbl;
        }

        public int CantidadPublicacionesGratuitas()
        {
            String query = "select COUNT(1) from C_R.Publicaciones P, C_R.Publicaciones_Estados E";
            query += " WHERE P.Pub_Estado_Id = E.Pub_Estado_Id ";
            query += " AND E.Pub_Estado_Desc = 'Activa' ";
            query += " AND P.Pub_User_Id = @Usuario ";
            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Usuario", Main.Usuario);
            int cantidad = 0;
            try
            {
                Conexion.Open();
                cantidad = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error");
            }
            finally
            {
                Conexion.Close();
            }
            return cantidad;
        }

        public DataSet Publicaciones_Grilla(string Descripcion, ListBox.SelectedObjectCollection Rubros)
        {
            String query = "SELECT P.* FROM C_R.Publicaciones P, C_R.Publicaciones_Visibilidad V, C_R.Publicaciones_Estados E"
            + " WHERE P.Pub_Visible_Cod = V.Pub_Visible_Cod "
            + " AND P.Pub_Estado_Id = E.Pub_Estado_Id "
            //+ " AND E.Pub_Estado_Desc = 'Activa' "
            //+ " AND P.Pub_Fecha_Venc > @Fecha "
            + " AND P.Pub_User_Id != @Usuario "
            + " AND (@Descripcion IS NULL OR P.Pub_Descripcion LIKE '%'+@Descripcion+'%') "
            + " AND (NOT EXISTS (SELECT 1 FROM @Rubros) "
            + " OR EXISTS (SELECT Pub_Codigo, Pub_Descripcion FROM C_R.RL_Publicaciones_Rubros RL, C_R.Publicaciones_Rubro R, @Rubros Rub "
                            + " WHERE R.Pub_RubroId = RL.Pub_RubroId "
                            + " AND R.Pub_Descripcion = Rub.Rubro "
                            + " AND RL.Pub_Codigo = P.Pub_Codigo)) "
            + " ORDER BY V.Pub_Visible_Precio DESC ";

            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Rubros", SqlDbType.Structured);
            command.Parameters["@Rubros"].Value = CrearRubrosTable(Rubros);
            command.Parameters["@Rubros"].TypeName = "C_R.RubrosTableType";
            command.Parameters.AddWithValue("@Descripcion",Descripcion);
            command.Parameters.AddWithValue("@Usuario", Main.Usuario);
            command.Parameters.AddWithValue("@Fecha", Main.FechaSistema);

            DataSet Ds = new DataSet();
            try
            {
                Conexion.Open();
                SqlDataAdapter sDa = new SqlDataAdapter(command);
                sDa.Fill(Ds);

            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error");
            }
            finally
            {
                Conexion.Close();
            }
            return Ds;

        }
    }
}
