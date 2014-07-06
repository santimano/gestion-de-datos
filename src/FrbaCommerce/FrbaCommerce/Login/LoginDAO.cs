using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using FrbaCommerce.ABM_Rol;

namespace FrbaCommerce.Login
{
    public class LoginDAO
    {
        private SqlConnection Conexion;

        public LoginDAO(SqlConnection Conexion)
        {
            this.Conexion = Conexion;
        }

        public byte Login(String usuario, String pass, String nuevopass)
        {
            byte resultado = 255;
            DateTime fecha = new DateTime(Main.FechaSistema.Year,
                                        Main.FechaSistema.Month,
                                        Main.FechaSistema.Day,
                                        DateTime.Now.Hour,
                                        DateTime.Now.Minute,
                                        DateTime.Now.Second);

            SqlCommand command = new SqlCommand("C_R.SP_LOGIN", Conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@nombre", SqlDbType.VarChar, 255);
            command.Parameters.Add("@password", SqlDbType.VarChar, 255);
            command.Parameters.Add("@nuevo_password", SqlDbType.VarChar, 255);
            command.Parameters.Add("@fecha", SqlDbType.DateTime);
            command.Parameters.Add("@resultado", SqlDbType.TinyInt).Direction = ParameterDirection.Output;
            command.Parameters["@nombre"].Value = usuario;
            command.Parameters["@password"].Value = Encripcion.CalcularHash(pass);
            command.Parameters["@fecha"].Value = fecha;
            command.Parameters["@nuevo_password"].Value = (nuevopass == null) ? (object)DBNull.Value : Encripcion.CalcularHash(nuevopass);

            try
            {
                Conexion.Open();
                command.ExecuteNonQuery();
                resultado = (byte)command.Parameters["@resultado"].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error");
            }
            finally
            {
                Conexion.Close();
            }

            return resultado;

        }

        public List<Rol> Roles(String usuario)
        {
            List<Rol> roles = new List<Rol>();

            String query = "SELECT R.Rol_Descripcion, R.Rol_Id "
             + "FROM C_R.Roles R "
             + "INNER JOIN C_R.RL_Usuarios_Roles UR ON R.Rol_Id = UR.Rol_Id "
             + "INNER JOIN C_R.Usuarios U ON UR.User_Id = U.User_Id "
             + "WHERE LOWER(U.User_Name) = LOWER(@usuario)";

            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@usuario", SqlDbType.VarChar, 255);
            command.Parameters["@usuario"].Value = usuario;

            SqlDataReader datareader;

            try
            {
                Conexion.Open();
                datareader = command.ExecuteReader();

                if (datareader.HasRows)
                {
                    while (datareader.Read())
                    {
                        Rol rol = new Rol();
                        rol.Name = datareader.GetString(0);
                        rol.Id = datareader.GetInt32(1);
                        roles.Add(rol);
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
            foreach (Rol rol in roles)
            {
                rol.Funciones = Funcionalidades(rol.Id);
            }
            return roles;

        }

        public bool ValidarUsuario(string usuario)
        {
            bool rc = true;

            String query = "SELECT 1 "
             + "FROM C_R.Usuarios "
             + "WHERE LOWER(User_Name) = LOWER(@usuario)";

            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@usuario", SqlDbType.VarChar, 255);
            command.Parameters["@usuario"].Value = usuario;

            SqlDataReader datareader;

            try
            {
                Conexion.Open();
                datareader = command.ExecuteReader();

                if (datareader.HasRows)
                    rc = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error");
            }
            finally
            {
                Conexion.Close();
            }

            return rc;
        }

        public List<string> Funcionalidades(int rolId)
        {
            List<string> funcionalidades = new List<string>();
            Conexion.Open();
            try
            {
                string query = "SELECT Sis_Fun_Des FROM C_R.Sis_Funciones F, C_R.RL_Roles_Funciones RL ";
                query += " WHERE RL.Rol_Id = @RolId AND F.Sis_Fun_Id = RL.Sis_Fun_Id";

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
