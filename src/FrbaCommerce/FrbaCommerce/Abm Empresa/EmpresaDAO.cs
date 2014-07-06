using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Empresa
{
    public class EmpresaDAO
    {
        private SqlConnection Conexion;

        public EmpresaDAO(SqlConnection Conexion)
        {
            this.Conexion = Conexion;
        }

        public DataSet EmpresasGrilla(string cuit, string razon_social, string mail)
        {
            String query = "SELECT E.Emp_Id"
                        + ",E.Emp_Fecha_Creacion"
                        + ",E.Emp_Mail"
                        + ",E.Emp_Contacto"
                        + ",E.Emp_Telefono"
                        + ",E.Emp_RazonSocial"
                        + ",E.Emp_Dir_Ciudad"
                        + ",E.Emp_Dir_Calle"
                        + ",E.Emp_Dir_Nro"
                        + ",E.Emp_Dir_Piso"
                        + ",E.Emp_Dir_CodPostal"
                        + ",E.Emp_Dir_Depto"
                        + ",E.Emp_Dir_Localidad"
                        + ",E.Emp_Cuit"
                        + ",U.User_Estado "
                        + "FROM C_R.Empresas E "
                        + "INNER JOIN C_R.Usuarios U on E.Emp_User_Id = U.User_Id "
                        + "WHERE U.User_Eliminado = 0 ";

            if (cuit.Length > 0)
                query += "AND E.Emp_Cuit = @cuit ";
            if (razon_social.Length > 0)
                query += "AND E.Emp_RazonSocial like '%'+@razon_social+'%' ";
            if (mail.Length > 0)
                query += "AND E.Emp_Mail like '%'+@mail+'%' ";

            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;

            if (cuit.Length > 0)
            {
                command.Parameters.Add("@cuit", SqlDbType.VarChar, 50);
                command.Parameters["@cuit"].Value = cuit;
            }
            if (razon_social.Length > 0)
            {
                command.Parameters.Add("@razon_social", SqlDbType.VarChar, 255);
                command.Parameters["@razon_social"].Value = razon_social;
            }
            if (mail.Length > 0)
            {
                command.Parameters.Add("@mail", SqlDbType.VarChar, 255);
                command.Parameters["@mail"].Value = mail;
            }

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
