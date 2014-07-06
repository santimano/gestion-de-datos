using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrbaCommerce.Registro_de_Usuario
{
    public class RegistroDAO
    {
        private SqlConnection Conexion;

        public RegistroDAO(SqlConnection Conexion)
        {
            this.Conexion = Conexion;
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

    }
}
