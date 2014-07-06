using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrbaCommerce.ABM_Rol
{
    public class RolDAO
    {

        private SqlConnection Conexion;

        public RolDAO(SqlConnection Conexion)
        {
            this.Conexion = Conexion;
        }

        public DataSet Roles_Grilla()
        {

            String query = "SELECT * "
           + "FROM C_R.Roles";


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

        public void guardar(int Codigo, string Desc, string Estado, ListBox.SelectedObjectCollection Funciones)
        {

            SqlCommand command = new SqlCommand("C_R.SP_Rol_SAVE", Conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@Codigo", SqlDbType.Int);
            command.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@Estado", SqlDbType.VarChar, 50);
            command.Parameters["@Codigo"].Value = Codigo;
            command.Parameters["@Descripcion"].Value = Desc;
            command.Parameters["@Estado"].Value = Estado;
            command.Parameters.AddWithValue("@Funciones", CrearFuncionesTable(Funciones));

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

        private DataTable CrearFuncionesTable(ListBox.SelectedObjectCollection items)
        {
            var tbl = new DataTable();
            tbl.Columns.Add("Funcion", typeof(string));
            foreach (var item in items)
            {
                tbl.Rows.Add(item.ToString());
            }
            return tbl;
        }

        public void borrar(int id)
        {

            SqlCommand commandUpdate = new SqlCommand("UPDATE C_R.Roles SET Rol_Estado = 'INACTIVO'"
            + "WHERE Rol_Id = @Rol_Id", Conexion);

            commandUpdate.CommandType = CommandType.Text;
            commandUpdate.Parameters.Add("@Rol_Id", SqlDbType.Int);
            commandUpdate.Parameters["@Rol_Id"].Value = id;

            SqlCommand commandDelete = new SqlCommand("DELETE C_R.RL_Usuarios_Roles WHERE Rol_Id = @Rol_Id"
            , Conexion);

            commandDelete.CommandType = CommandType.Text;
            commandDelete.Parameters.Add("@Rol_Id", SqlDbType.Int);
            commandDelete.Parameters["@Rol_Id"].Value = id;

            try
            {
                Conexion.Open();
                commandUpdate.ExecuteNonQuery();
                commandDelete.ExecuteNonQuery();
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


        public List<string> Funcionalidades()
        {
            List<string> funcionalidades = new List<string>();
            try
            {
                string query = "SELECT Sis_Fun_Des FROM C_R.Sis_Funciones";
                Conexion.Open();
                using (SqlCommand command = new SqlCommand(query, Conexion))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                funcionalidades.Add(reader.GetString(0));
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
            return funcionalidades;
        }

        public List<string> Funcionalidades(int rolId)
        {
            List<string> funcionalidades = new List<string>();
            try
            {
                string query = "SELECT Sis_Fun_Des FROM C_R.Sis_Funciones F, C_R.RL_Roles_Funciones RL ";
                query += " WHERE RL.Rol_Id = @RolId AND F.Sis_Fun_Id = RL.Sis_Fun_Id";
                Conexion.Open();
                using (SqlCommand command = new SqlCommand(query, Conexion))
                {
                    command.Parameters.AddWithValue("@RolId", rolId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                funcionalidades.Add(reader.GetString(0));
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
            return funcionalidades;
        }
    }

}