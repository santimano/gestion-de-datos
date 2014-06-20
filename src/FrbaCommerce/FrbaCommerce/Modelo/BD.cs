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
        public String InvocarSP()
        {
            using (var command = new SqlCommand("SELECT C_R.LOGIN('DMedina1930','P4SSM1GR4D0')", Conexion)
            {
                CommandType = CommandType.Text
            })
            {
                Conexion.Open();
                bool result;
                String s = command.ExecuteScalar().ToString();
                bool correcto = Boolean.TryParse(s, out result);
                Conexion.Close();
                return correcto.ToString();
            }
        }
    }
}
