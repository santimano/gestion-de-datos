using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Rubro
{
    class RubroDAO
    {
        private SqlConnection Conexion;

        public RubroDAO(SqlConnection Conexion)
        {
            this.Conexion = Conexion;
        }

        public List<string> FindAll()
        {
            List<String> rubros = new List<String>();

            String query = "SELECT Pub_Descripcion "
             + "FROM C_R.Publicaciones_Rubro ";

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
                        rubros.Add(datareader.GetString(0));
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

            return rubros;
        }
    }
}
