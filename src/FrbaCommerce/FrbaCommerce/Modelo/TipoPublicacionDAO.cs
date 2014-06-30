using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrbaCommerce.Modelo
{

    class TipoPublicacionDAO
    {
        private SqlConnection Conexion;
        
        public TipoPublicacionDAO(SqlConnection Conexion)
        {
            this.Conexion = Conexion;
        }

        public List<string> FindAll()
        {
            List<String> visibilidades = new List<String>();

            String query = "SELECT Pub_Descripcion "
             + "FROM C_R.Publicaciones_Tipo";

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
    }
}
