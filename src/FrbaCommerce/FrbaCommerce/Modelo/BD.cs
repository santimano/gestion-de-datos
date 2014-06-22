using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using FrbaCommerce.Login;

namespace FrbaCommerce.Modelo
{
    class BD
    {
        private static BD instance;
        public SqlConnection Conexion { get; private set; }

        private BD() { }

        public static BD Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BD();
                    String connectionString;
                    DateTime fecha;
                    instance.LeerConfig(out connectionString, out fecha);
                    Main.FechaSistema = fecha;
                    instance.Conexion = new System.Data.SqlClient.SqlConnection(connectionString);
                }
                return instance;
            }
        }
        public byte Login(String usuario, String pass, String nuevopass)
        {
            byte resultado = 255;

            SqlCommand command = new SqlCommand("C_R.SP_LOGIN", Conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@nombre", SqlDbType.VarChar, 255);
            command.Parameters.Add("@password", SqlDbType.VarChar, 255);
            command.Parameters.Add("@nuevo_password", SqlDbType.VarChar, 255);
            command.Parameters.Add("@resultado", SqlDbType.TinyInt).Direction = ParameterDirection.Output;
            command.Parameters["@nombre"].Value = usuario;
            command.Parameters["@password"].Value = Encripcion.CalcularHash(pass);
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

        public List<String> Roles(String usuario)
        {
            List<String> roles = new List<String>();

            String query = "SELECT R.Rol_Descripcion "
             + "FROM C_R.Roles R "
             + "INNER JOIN C_R.RL_Clientes_Roles RC ON R.Rol_Id = RC.Rol_Id "
             + "INNER JOIN C_R.Clientes C ON RC.Cli_Id = C.Cli_Id "
             + "WHERE C.Cli_UserName = @usuario";

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
                        roles.Add(datareader.GetString(0));
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

            return roles;

        }

         private void LeerConfig(out String connection, out DateTime fecha)
        {
            string linea = "";
            string user = "";
            string pass = "";
            string db = "";
            string server = "";

            connection = "";
            fecha = new DateTime();

            System.IO.StreamReader file = new System.IO.StreamReader(@"..\..\Config\config.cfg");

            while ((linea = file.ReadLine()) != null)
            {
                if (linea.StartsWith("user", true, null))
                    user = linea.Split('=')[1];
                else if (linea.StartsWith("password", true, null))
                    pass = linea.Split('=')[1];
                else if (linea.StartsWith("db", true, null))
                    db = linea.Split('=')[1];
                else if (linea.StartsWith("server", true, null))
                    server = linea.Split('=')[1];
                else if (linea.StartsWith("fecha", true, null))
                    fecha = new DateTime(Convert.ToInt32(linea.Split('=')[1].Split('-')[2])
                                         , Convert.ToInt32(linea.Split('=')[1].Split('-')[1])
                                         , Convert.ToInt32(linea.Split('=')[1].Split('-')[0]));
            }
            connection = "Data Source=" + server + ";"
                + "Initial Catalog=" + db + ";"
                + "User ID=" + user + ";"
                + "Password=" + pass;
        }
    }
}
