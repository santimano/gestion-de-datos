using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace FrbaCommerce.Modelo
{
    class BD
    {
        private static BD instance;
        public SqlConnection Conexion { get; private set; }         
        // la fecha no me parece que tenga que ser parte de la BD
        public DateTime FechaSistema { get; private set; }
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
                    instance.FechaSistema = fecha;
                    instance.Conexion = new System.Data.SqlClient.SqlConnection(connectionString);
                }
                return instance;
            }
        }
        public byte Login(String usuario, String pass, String nuevopass)
        {
            byte resultado = 1;

            Conexion.Open();

            SqlCommand command = new SqlCommand("C_R.SP_LOGIN", Conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@nombre", SqlDbType.VarChar, 255);
            command.Parameters.Add("@password", SqlDbType.VarChar, 255);
            command.Parameters.Add("@nuevo_password", SqlDbType.VarChar, 255);
            command.Parameters.Add("@resultado", SqlDbType.TinyInt).Direction = ParameterDirection.Output;
            command.Parameters["@nombre"].Value = usuario;
            command.Parameters["@password"].Value = pass;
            command.Parameters["@nuevo_password"].Value = (nuevopass == null) ? (object)DBNull.Value : nuevopass;

            command.ExecuteNonQuery();

            resultado = (byte)command.Parameters["@resultado"].Value;
                     
            Conexion.Close();
            return resultado;
            
        }
        private void LeerConfig(out String connection, out DateTime fecha)
        {
            string linea="";
            string user="";
            string pass="";
            string db="";
            string server="";

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
