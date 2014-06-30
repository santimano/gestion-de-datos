using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrbaCommerce.Historial_Cliente
{
    class OfertaDAO
    {
        private SqlConnection Conexion;

        public OfertaDAO(SqlConnection Conexion)
        {
            this.Conexion = Conexion;
        }

        public DataSet Ofertas_Grilla(string Descripcion, string Estado)
        {
            String query = "SELECT * FROM C_R.Ofertas_Estado_VW WHERE Ofe_User_Id = @Usuario "
                + "AND Pub_Descripcion LIKE '%'+@Descripcion+'%' "
                + "AND Estado LIKE @Estado+'%' "
                + "ORDER BY Pub_Descripcion, Ope_Monto DESC";

            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Usuario", SqlDbType.Int);
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255);
            command.Parameters.Add("@Estado", SqlDbType.VarChar, 9);
            command.Parameters["@Usuario"].Value = Main.Usuario;
            command.Parameters["@Descripcion"].Value = Descripcion;
            command.Parameters["@Estado"].Value = Estado;

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

    }
}
