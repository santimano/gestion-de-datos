using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrbaCommerce.Historial_Cliente
{
    class CalificacionDAO
    {
        private SqlConnection Conexion;

        public CalificacionDAO(SqlConnection Conexion)
        {
            this.Conexion = Conexion;
        }


        public DataSet Calificaciones_Grilla(bool otorgadas)
        {
            String query = "SELECT * FROM C_R.Calificaciones_VW WHERE ";
            if (otorgadas)
            {
                query += " idComprador = @Usuario ";
            }
            else
            {
                query += " idVendedor = @Usuario ";
            }
            query += " ORDER BY Fecha DESC ";

            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Usuario", SqlDbType.Int);
            command.Parameters["@Usuario"].Value = Main.Usuario;

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
