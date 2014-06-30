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
            List<String> clientes = new List<String>();

            String query = "SELECT C.Cli_Nombre"
                        + ",C.Cli_Apellido"
                        + ",D.Des_Corta"
                        + ",C.Cli_Doc"
                        + ",C.Cli_Fecha_Nac"
                        + ",C.Cli_Mail"
                        + ",C.Cli_Dir_Calle"
                        + ",C.Cli_Dir_Nro"
                        + ",C.Cli_Dir_Piso"
                        + ",C.Cli_Dir_CodPostal"
                        + ",C.Cli_Dir_Depto"
                        + ",C.Cli_Dir_Localidad"
                        + ",C.Cli_Telefono "
                        + "FROM C_R.Clientes C inner join C_R.Tipo_Docs D "
                        + "on C.Cli_TipoDoc = D.Cli_TipoDoc "
                        + "where 1 = 1 ";

            if (nombre.Length > 0)
                query += "and C.Cli_Nombre = @nombre ";
            if (apellido.Length > 0)
                query += "and C.Cli_Apellido like '%'+@apellido+'%' ";
            if (mail.Length > 0)
                query += "and C.Cli_Mail like '%'+@mail+'%' ";
            if (tipo_doc.Length > 0)
                query += "and D.Des_Corta = @tipo_doc ";
            if (documento.Length > 0)
                query += "and C.Cli_Doc = @documento ";

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


    }
}
