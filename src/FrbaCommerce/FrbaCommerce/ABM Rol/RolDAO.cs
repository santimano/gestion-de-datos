using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrbaCommerce.ABM_Rol
{
    public class RolDAO
    {

        private SqlConnection Conexion;

        public RolDAO(SqlConnection Conexion)
        {
            this.Conexion = Conexion;
        }

        public DataSet Roles_Grilla()
        {
            List<String> roles = new List<String>();

            String query = "SELECT * "
           + "FROM C_R.Roles";


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

        public void guardar(int Codigo, string Desc, string Estado)
        {

            SqlCommand command = new SqlCommand("C_R.SP_Rol_SAVE", Conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@Codigo", SqlDbType.Int);
            command.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@Estado", SqlDbType.VarChar, 50);
            command.Parameters["@Codigo"].Value = Codigo;
            command.Parameters["@Descripcion"].Value = Desc;
            command.Parameters["@Estado"].Value = Estado;

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

        public void borrar(int id)
        {

            SqlCommand command = new SqlCommand("UPDATE C_R.Roles SET Rol_Estado = 'INACTIVO'"
            + "WHERE Rol_Id = @Rol_Id", Conexion);
            
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Rol_Id", SqlDbType.Int);
            command.Parameters["@Rol_Id"].Value = id;

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