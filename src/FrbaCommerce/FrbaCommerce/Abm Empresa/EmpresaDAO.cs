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

        public bool GuardarEmpresa(string id_empresa, string cuit, string razon_social, string fecha_creacion,
            string mail, string contacto, string telefono, string ciudad, string calle, string nro, string piso,
            string cod_postal, string depto, string localidad, string estado, string usuario, string password)
        {

            bool resultado = true;

            SqlCommand command = new SqlCommand("C_R.SP_EMPRESA_SAVE", this.Conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@Emp_Id", SqlDbType.Int);
            command.Parameters.Add("@Emp_Cuit", SqlDbType.VarChar, 255);
            command.Parameters.Add("@Emp_RazonSocial", SqlDbType.VarChar, 255);
            command.Parameters.Add("@Emp_Fecha_Creacion", SqlDbType.DateTime);
            command.Parameters.Add("@Emp_Mail", SqlDbType.VarChar, 255);
            command.Parameters.Add("@Emp_Contacto", SqlDbType.VarChar, 255);
            command.Parameters.Add("@Emp_Telefono", SqlDbType.VarChar, 50);
            command.Parameters.Add("@Emp_Dir_Ciudad", SqlDbType.VarChar, 255);
            command.Parameters.Add("@Emp_Dir_Calle", SqlDbType.VarChar, 255);
            command.Parameters.Add("@Emp_Dir_Nro", SqlDbType.Int);
            command.Parameters.Add("@Emp_Dir_Piso", SqlDbType.Int);
            command.Parameters.Add("@Emp_Dir_CodPostal", SqlDbType.VarChar, 50);
            command.Parameters.Add("@Emp_Dir_Depto", SqlDbType.VarChar, 50);
            command.Parameters.Add("@Emp_Dir_Localidad", SqlDbType.VarChar, 50);
            command.Parameters.Add("@User_Estado", SqlDbType.VarChar, 10);
            command.Parameters.Add("@User_Nombre", SqlDbType.VarChar, 255);
            command.Parameters.Add("@User_Password", SqlDbType.VarChar, 255);

            command.Parameters["@Emp_Id"].Value = (id_empresa.Length > 0) ? Convert.ToInt32(id_empresa) : (object)DBNull.Value;
            command.Parameters["@Emp_Cuit"].Value = cuit;
            command.Parameters["@Emp_RazonSocial"].Value = razon_social;
            command.Parameters["@Emp_Fecha_Creacion"].Value = Convert.ToDateTime(fecha_creacion, new System.Globalization.CultureInfo("es-AR", true));
            command.Parameters["@Emp_Mail"].Value = mail;
            command.Parameters["@Emp_Contacto"].Value = contacto;
            command.Parameters["@Emp_Telefono"].Value = telefono;
            command.Parameters["@Emp_Dir_Ciudad"].Value = ciudad;
            command.Parameters["@Emp_Dir_Calle"].Value = calle;
            command.Parameters["@Emp_Dir_Nro"].Value = Convert.ToInt32(nro);
            command.Parameters["@Emp_Dir_Piso"].Value = Convert.ToInt32(piso);
            command.Parameters["@Emp_Dir_CodPostal"].Value = cod_postal;
            command.Parameters["@Emp_Dir_Depto"].Value = depto;
            command.Parameters["@Emp_Dir_Localidad"].Value = localidad;
            command.Parameters["@User_Estado"].Value = estado;
            command.Parameters["@User_Nombre"].Value = (usuario != null) ? usuario : (object)DBNull.Value;
            command.Parameters["@User_Password"].Value = (password != null) ? password : (object)DBNull.Value;

            try
            {
                this.Conexion.Open();
                command.ExecuteNonQuery();
                MessageBox.Show(null, "La empresa ha sido actualizada con exito.", "Informacion");
            }
            catch (Exception ex)
            {
                if (ex.Message.ToUpper().Contains("UQ_EMPRESA_TEL"))
                    MessageBox.Show(null, "El telefono ingresado ya corresponde a una empresa.", "Error");
                else if (ex.Message.ToUpper().Contains("UQ_EMPRESA_CUIT"))
                    MessageBox.Show(null, "El numero de CUIT ingresado ya corresponde a una empresa.", "Error");
                else if (ex.Message.ToUpper().Contains("UQ_EMPRESA_RAZONSOCIAL"))
                    MessageBox.Show(null, "La razon social ingresada ya corresponde a una empresa.", "Error");
                else
                    MessageBox.Show(null, ex.Message, "Error");
                resultado = false;
            }
            finally
            {
                this.Conexion.Close();
            }

            return resultado;
        }


        public void EliminarEmpresa(string id_empresa)
        {
            string query = "UPDATE C_R.Usuarios "
                         + "SET User_Eliminado = 1 "
                         + "WHERE User_Id = (SELECT Emp_User_Id FROM C_R.Empresas WHERE Emp_Id = @Emp_Id)";

            SqlCommand command = new SqlCommand(query, Conexion);

            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Emp_Id", SqlDbType.Int);
            command.Parameters["@Emp_Id"].Value = Convert.ToInt32(id_empresa);

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

        public void CambiarPassword(string id_empresa, string password, bool cambio_pass)
        {
            string query = "UPDATE C_R.Usuarios "
             + "SET User_Password = @User_Password, User_CambioPass = @User_CambioPass "
             + "WHERE User_Id = (SELECT Emp_User_Id FROM C_R.Empresas WHERE Emp_Id = @Emp_Id)";

            SqlCommand command = new SqlCommand(query, Conexion);

            command.CommandType = CommandType.Text;
            command.Parameters.Add("@User_Password", SqlDbType.VarChar, 255);
            command.Parameters["@User_Password"].Value = Login.Encripcion.CalcularHash(password);
            command.Parameters.Add("@User_CambioPass", SqlDbType.VarChar, 255);
            command.Parameters["@User_CambioPass"].Value = (cambio_pass == true) ? 1 : 0;
            command.Parameters.Add("@Emp_Id", SqlDbType.Int);
            command.Parameters["@Emp_Id"].Value = Convert.ToInt32(id_empresa);

            try
            {
                Conexion.Open();
                command.ExecuteNonQuery();
                MessageBox.Show(null, "El password fue actualizado con exito.", "Informacion");

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
