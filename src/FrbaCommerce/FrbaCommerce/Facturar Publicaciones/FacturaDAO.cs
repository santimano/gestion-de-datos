using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Modelo;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrbaCommerce.Facturar_Publicaciones
{
    class FacturaDAO
    {
        private SqlConnection Conexion;

        public FacturaDAO(SqlConnection Conexion)
        {
            this.Conexion = Conexion;
        }

        public DataSet Ventas_Grilla(int usuario)
        {
            String query = "SELECT * FROM C_R.Ventas_No_Facturadas_VW WHERE Vendedor = @Usuario "
                + "ORDER BY Fecha_Finalizacion ";

            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Usuario", SqlDbType.Int);
            command.Parameters["@Usuario"].Value = usuario;

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

        public void Facturar(List<Item> items, string FormaPago, string Titular, long Numero, string Vencimiento)
        {
            SqlCommand command = new SqlCommand("C_R.SP_FACTURAR", this.Conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Publicaciones", CrearPublicacionesTable(items));
            command.Parameters.AddWithValue("@FormaPago", FormaPago);
            command.Parameters.AddWithValue("@TarjetaTitular", Titular);
            command.Parameters.AddWithValue("@TarjetaNumero", Numero);
            command.Parameters.AddWithValue("@TarjetaVencimiento", Vencimiento);

            try
            {
                this.Conexion.Open();
                command.ExecuteNonQuery();
                MessageBox.Show(null, "Se facturaron " + items.Count + " publicaciones", "Informacion");
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error");
            }
            finally
            {
                this.Conexion.Close();
            }
        }

        private DataTable CrearPublicacionesTable(List<Item> items)
        {
            var tbl = new DataTable();
            tbl.Columns.Add("Cantidad", typeof(decimal));
            tbl.Columns.Add("Unitario", typeof(decimal));
            tbl.Columns.Add("Publicacion", typeof(string));
            tbl.Columns.Add("Pub_Codigo", typeof(decimal));
            tbl.Columns.Add("Total", typeof(decimal));
            foreach (var item in items)
            {
                tbl.Rows.Add(item.Vendidos, item.Unitario, item.Publicacion, item.PubCodigo, item.Total);
            }

            return tbl;
        }

        public int Usuario_A_Facturar(string usuario)
        {
            String query = "SELECT CASE WHEN User_Estado = 'ACTIVO' THEN -1 ELSE User_Id END User_Id ";
            query += " FROM C_R.Usuarios ";
            query += " WHERE User_Name = @Usuario and User_Eliminado = 0 ";

            SqlCommand command = new SqlCommand(query, this.Conexion);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Usuario", usuario);
            int userId = -2;
            try
            {
                this.Conexion.Open();
                object result = command.ExecuteScalar();
                if (result != null) userId = (int)result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error");
            }
            finally
            {
                this.Conexion.Close();
            }
            return userId;
        }
    }
}
