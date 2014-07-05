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

        public DataSet Pendientes_Grilla()
        {
            String query = "SELECT * FROM C_R.Calificaciones_Pendientes_VW WHERE Comprador = @Usuario";
            query += " ORDER BY Fecha ";

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

        public void Insertar_Calificacion(decimal venta, int estrellas, string descripcion)
        {
            String query = "INSERT INTO C_R.Calificaciones(Cal_CantEstrellas, Cal_Descripcion, Ven_Codigo)";
            query += " VALUES(@Estrellas, @Descripcion, @Venta) ";

            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Estrellas", SqlDbType.Int);
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255);
            command.Parameters.Add("@Venta", SqlDbType.Int);
            command.Parameters["@Estrellas"].Value = estrellas;
            command.Parameters["@Descripcion"].Value = descripcion;
            command.Parameters["@Venta"].Value = venta;

            try
            {
                Conexion.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error");
            }
            finally
            {
                Conexion.Close();
            }
        }
    }
}
