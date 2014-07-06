using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Visibilidad
{
    class VisibilidadDAO
    {
        private SqlConnection Conexion;

        public VisibilidadDAO(SqlConnection Conexion)
        {
            this.Conexion = Conexion;
        }

        public List<string> FindAll()
        {
            List<String> visibilidades = new List<String>();

            String query = "SELECT Pub_Visible_Descripcion "
             + "FROM C_R.Publicaciones_Visibilidad ";

            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;

            SqlDataReader datareader;
            try
            {
                Conexion.Open();
                datareader = command.ExecuteReader();

                if (datareader.HasRows)
                {
                    while (datareader.Read())
                    {
                        visibilidades.Add(datareader.GetString(0));
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

            return visibilidades;
        }

        public DataSet Productos_Visibilidad_Grilla()
        {
            String query = "SELECT * "
           + "FROM C_R.Publicaciones_Visibilidad";


            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;
            DataSet Ds = new DataSet();
            try
            {
                Conexion.Open();

                // Conexion Abierta
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

        public void Productos_Visibilidad_SAVE(int Codigo, string Desc, decimal Precio, decimal Porc, string Estado, int Duracion)
        {

            SqlCommand command = new SqlCommand("C_R.SP_Visibilidad_SAVE", Conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@Codigo", SqlDbType.Int);
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255);
            command.Parameters.Add("@Precio", SqlDbType.Decimal);
            command.Parameters.Add("@Porc", SqlDbType.Decimal);
            command.Parameters.Add("@Estado", SqlDbType.VarChar, 15);
            command.Parameters.Add("@Duracion", SqlDbType.Int);
            command.Parameters["@Codigo"].Value = Codigo;
            command.Parameters["@Descripcion"].Value = Desc;
            command.Parameters["@Precio"].Value = Precio;
            command.Parameters["@Porc"].Value = Porc;
            command.Parameters["@Estado"].Value = Estado;
            command.Parameters["@Duracion"].Value = Duracion;

            try
            {
                Conexion.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                if (ex.Message.ToUpper().Contains("UQ_PUBLICACIONES_VISIBILIDAD_DESCRIPCION"))
                    MessageBox.Show(null, "Ya existe una publicacion con esa descripcion.", "Error");
                else
                    MessageBox.Show(null, ex.Message, "Error");
            }
            finally
            {
                Conexion.Close();
            }

        }


        public int Duracion(string visibilidad)
        {
            SqlCommand command = new SqlCommand("SELECT Pub_Visible_Duracion FROM C_R.Publicaciones_Visibilidad WHERE Pub_Visible_Descripcion = @Visibilidad", Conexion);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@Visibilidad", visibilidad);

            int duracion = 0;

            try
            {
                Conexion.Open();
                duracion = (int)command.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error");
            }
            finally
            {
                Conexion.Close();
            }
            return duracion;
        }
    }
}
