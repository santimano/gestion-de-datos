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
        private BD() { }

        public static BD Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BD();
                    String connectionString = FrbaCommerce.Properties.Settings.Default.ConnectionString;
                    instance.Conexion = new System.Data.SqlClient.SqlConnection(connectionString);
                }
                return instance;
            }
        }
        public String InvocarSP(String usuario, String pass)
        {
            using (var command = new SqlCommand("SELECT C_R.LOGIN('"+usuario+"','"+pass+"')", Conexion)
            {
                CommandType = CommandType.Text
            })
            {
                Conexion.Open();
                bool result = Boolean.Parse(command.ExecuteScalar().ToString());
                Conexion.Close();
                return result.ToString();
            }
        }
    }
}
