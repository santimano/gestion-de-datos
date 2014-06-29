using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Visibilidad
{
    public class VisibilidadDAO
    {
        private SqlConnection Conexion;

        public VisibilidadDAO(SqlConnection Conexion)
        {
            this.Conexion = Conexion;
        }

        public DataSet Productos_Visibilidad_Grilla()
        {
            List<String> roles = new List<String>();

            String query = "SELECT * "
           + "FROM C_R.Publicaciones_Visibilidad";


            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;
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

        public void Productos_Visibilidad_SAVE(int Codigo, string Desc, decimal Precio, decimal Porc)
        {

            SqlCommand command = new SqlCommand("C_R.SP_Visibilidad_SAVE", Conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@Codigo", SqlDbType.Int);
            command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255);
            command.Parameters.Add("@Precio", SqlDbType.Decimal);
            command.Parameters.Add("@Porc", SqlDbType.Decimal);
            command.Parameters["@Codigo"].Value = Codigo;
            command.Parameters["@Descripcion"].Value = Desc;
            command.Parameters["@Precio"].Value = Precio;
            command.Parameters["@Porc"].Value = Porc;

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
