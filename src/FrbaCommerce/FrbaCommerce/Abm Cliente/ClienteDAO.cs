using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Cliente
{
    public class ClienteDAO
    {
        private SqlConnection Conexion;

        public ClienteDAO(SqlConnection Conexion)
        {
            this.Conexion = Conexion;
        }

        public DataSet ClientesGrilla(string nombre, string apellido, string mail, string documento, string tipo_doc)
        {
            String query = "SELECT C.Cli_Id"
                        + ",C.Cli_Nombre"
                        + ",C.Cli_Apellido"
                        + ",D.Des_Corta"
                        + ",C.Cli_Doc"
                        + ",C.Cli_Cuil"
                        + ",C.Cli_Fecha_Nac"
                        + ",C.Cli_Mail"
                        + ",C.Cli_Dir_Calle"
                        + ",C.Cli_Dir_Nro"
                        + ",C.Cli_Dir_Piso"
                        + ",C.Cli_Dir_CodPostal"
                        + ",C.Cli_Dir_Depto"
                        + ",C.Cli_Dir_Localidad"
                        + ",C.Cli_Telefono "
                        + ",U.User_Estado "
                        + "FROM C_R.Clientes C "
                        + "INNER JOIN C_R.Tipo_Docs D on C.Cli_TipoDoc = D.Cli_TipoDoc "
                        + "INNER JOIN C_R.Usuarios U on C.Cli_User_Id = U.User_Id "
                        + "WHERE U.User_Eliminado = 0 ";

            if (nombre.Length > 0)
                query += "AND C.Cli_Nombre = @nombre ";
            if (apellido.Length > 0)
                query += "AND C.Cli_Apellido like '%'+@apellido+'%' ";
            if (mail.Length > 0)
                query += "AND C.Cli_Mail like '%'+@mail+'%' ";
            if (tipo_doc.Length > 0)
                query += "AND D.Des_Corta = @tipo_doc ";
            if (documento.Length > 0)
                query += "AND C.Cli_Doc = @documento ";

            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;

            if (nombre.Length > 0)
            {
                command.Parameters.Add("@nombre", SqlDbType.VarChar, 255);
                command.Parameters["@nombre"].Value = nombre;
            }
            if (apellido.Length > 0)
            {
                command.Parameters.Add("@apellido", SqlDbType.VarChar, 255);
                command.Parameters["@apellido"].Value = apellido;
            }
            if (mail.Length > 0)
            {
                command.Parameters.Add("@mail", SqlDbType.VarChar, 255);
                command.Parameters["@mail"].Value = mail;
            }
            if (tipo_doc.Length > 0)
            {
                command.Parameters.Add("@tipo_doc", SqlDbType.VarChar, 10);
                command.Parameters["@tipo_doc"].Value = tipo_doc;
            }
            if (documento.Length > 0)
            {
                command.Parameters.Add("@documento", SqlDbType.Int);
                command.Parameters["@documento"].Value = Convert.ToInt32(documento);
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

        public List<String> TipoDocumento()
        {
            List<String> tipos = new List<String>();

            String query = "SELECT Des_Corta "
                        + "FROM C_R.Tipo_Docs";

            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;

            SqlDataReader datareader;

            try
            {
                Conexion.Open();
                datareader = command.ExecuteReader();

                if (datareader.HasRows)
                {
                    while (datareader.Read())
                    {
                        tipos.Add(datareader.GetString(0));
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error");
            }
            finally
            {
                Conexion.Close();
            }

            return tipos;

        }

        public bool GuardarCliente(string id_cliente, string nombre, string apellido, string tipodoc, string doc, 
            string cuil, string fecha_nac, string mail, string calle, string nro, string piso, string cod_postal, 
            string depto, string localidad, string telefono, string estado, string usuario, string password)
        {

            bool resultado = true;

            SqlCommand command = new SqlCommand("C_R.SP_CLIENTE_SAVE", this.Conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@Cli_Id", SqlDbType.Int);
            command.Parameters.Add("@Cli_Nombre", SqlDbType.VarChar,255);
            command.Parameters.Add("@Cli_Apellido", SqlDbType.VarChar, 255);
            command.Parameters.Add("@Des_Corta", SqlDbType.VarChar, 10);
            command.Parameters.Add("@Cli_Doc", SqlDbType.Int);
            command.Parameters.Add("@Cli_Cuil", SqlDbType.VarChar, 18);
            command.Parameters.Add("@Cli_Fecha_Nac", SqlDbType.DateTime);
            command.Parameters.Add("@Cli_Mail", SqlDbType.VarChar, 255);
            command.Parameters.Add("@Cli_Dir_Calle", SqlDbType.VarChar, 255);
            command.Parameters.Add("@Cli_Dir_Nro", SqlDbType.Int);
            command.Parameters.Add("@Cli_Dir_Piso", SqlDbType.Int);
            command.Parameters.Add("@Cli_Dir_CodPostal", SqlDbType.VarChar, 50);
            command.Parameters.Add("@Cli_Dir_Depto", SqlDbType.VarChar, 50);
            command.Parameters.Add("@Cli_Dir_Localidad", SqlDbType.VarChar, 50);
            command.Parameters.Add("@Cli_Telefono", SqlDbType.VarChar, 50);
            command.Parameters.Add("@User_Estado", SqlDbType.VarChar, 10);
            command.Parameters.Add("@User_Nombre", SqlDbType.VarChar, 255);
            command.Parameters.Add("@User_Password", SqlDbType.VarChar, 255);

            command.Parameters["@Cli_Id"].Value = (id_cliente.Length > 0) ? Convert.ToInt32(id_cliente) : (object)DBNull.Value;
            command.Parameters["@Cli_Nombre"].Value = nombre;
            command.Parameters["@Cli_Apellido"].Value = apellido;
            command.Parameters["@Des_Corta"].Value = tipodoc;
            command.Parameters["@Cli_Doc"].Value = Convert.ToInt32(doc);
            command.Parameters["@Cli_Cuil"].Value = cuil;
            command.Parameters["@Cli_Fecha_Nac"].Value = Convert.ToDateTime(fecha_nac, new System.Globalization.CultureInfo("es-AR", true));
            command.Parameters["@Cli_Mail"].Value = mail;
            command.Parameters["@Cli_Dir_Calle"].Value = calle;
            command.Parameters["@Cli_Dir_Nro"].Value = Convert.ToInt32(nro);
            command.Parameters["@Cli_Dir_Piso"].Value = Convert.ToInt32(piso);
            command.Parameters["@Cli_Dir_CodPostal"].Value = cod_postal;
            command.Parameters["@Cli_Dir_Depto"].Value = depto;
            command.Parameters["@Cli_Dir_Localidad"].Value = localidad;
            command.Parameters["@Cli_Telefono"].Value = telefono;
            command.Parameters["@User_Estado"].Value = estado;
            command.Parameters["@User_Nombre"].Value = (usuario != null) ? usuario : (object)DBNull.Value;
            command.Parameters["@User_Password"].Value = (password != null) ? password : (object)DBNull.Value;

            try
            {
                this.Conexion.Open();
                command.ExecuteNonQuery();
                MessageBox.Show(null, "El cliente ha sido actualizado con exito.", "Informacion");
            }
            catch (Exception ex)
            {
                if (ex.Message.ToUpper().Contains("UQ_CLIENTE_TEL"))
                    MessageBox.Show(null, "El telefono ingresado ya corresponde a un cliente.", "Error");
                else if (ex.Message.ToUpper().Contains("UQ_CLIENTE_DOC"))
                    MessageBox.Show(null, "El tipo y numero de documento ingresado ya corresponde a un cliente.", "Error");
                else if (ex.Message.ToUpper().Contains("UQ_CLIENTE_CUIL"))
                    MessageBox.Show(null, "El numero de CUIL ingresado ya corresponde a un cliente.", "Error");
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

        public void EliminarCliente(string id_cliente)
        {
            string query = "UPDATE C_R.Usuarios "
                         + "SET User_Eliminado = 1 "
                         + "WHERE User_Id = (SELECT Cli_User_Id FROM C_R.Clientes WHERE Cli_Id = @Cli_Id)";

            SqlCommand command = new SqlCommand(query, Conexion);

            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Cli_Id", SqlDbType.Int);
            command.Parameters["@Cli_Id"].Value = Convert.ToInt32(id_cliente);

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
