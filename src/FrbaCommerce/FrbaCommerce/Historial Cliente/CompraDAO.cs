using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrbaCommerce.Historial_Cliente
{
    class CompraDAO
    {
        private SqlConnection Conexion;

        public CompraDAO(SqlConnection Conexion)
        {
            this.Conexion = Conexion;
        }


        public DataSet Compras_Grilla(string Descripcion, string Tipo)
        {
            String query = "SELECT * FROM C_R.Compras_VW WHERE Ven_User_Id = @Usuario "
                + "AND Pub_Descripcion LIKE '%'+@Descripcion+'%' "
                + "AND Tipo LIKE @Tipo+'%' "
                + "ORDER BY Ven_Fecha DESC, Pub_Descripcion";

            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Usuario", SqlDbType.Int);
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255);
            command.Parameters.Add("@Tipo", SqlDbType.VarChar, 15);
            command.Parameters["@Usuario"].Value = Main.Usuario;
            command.Parameters["@Descripcion"].Value = Descripcion;
            command.Parameters["@Tipo"].Value = Tipo;

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
