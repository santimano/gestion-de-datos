using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrbaCommerce.Comprar_Ofertar
{
    class CompraDAO
    {
        private SqlConnection Conexion;

        public CompraDAO(SqlConnection Conexion)
        {
            this.Conexion = Conexion;
        }

        public void Preguntar(decimal Pub_Codigo, string Pregunta, int Usuario)
        {
            String query = "INSERT INTO C_R.Preguntas(Pre_Fecha, Pre_Texto, Pub_Codigo, User_Id)";
            query += " VALUES(@Fecha, @Pregunta, @PubCodigo, @Usuario) ";
            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@PubCodigo", Pub_Codigo);
            command.Parameters.AddWithValue("@Fecha", Main.FechaSistema);
            command.Parameters.AddWithValue("@Pregunta", Pregunta);
            command.Parameters.AddWithValue("@Usuario", Main.Usuario);

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

        public void Comprar(decimal Pub_Codigo, int Usuario, decimal Cantidad, decimal Monto, string Tipo)
        {
            String query = "C_R.SP_Comprar";
            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Pub_Codigo", Pub_Codigo);
            command.Parameters.AddWithValue("@Fecha", Main.FechaSistema);
            command.Parameters.AddWithValue("@Monto", Monto);
            command.Parameters.AddWithValue("@Cantidad", Cantidad);
            command.Parameters.AddWithValue("@Usuario", Main.Usuario);
            command.Parameters.AddWithValue("@Tipo", Tipo);

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

        public List<Oferta> Ofertas(decimal PubCodigo)
        {
            List<Oferta> ofertas = new List<Oferta>();

            String query = "SELECT Ofe_Fecha, Ope_Monto FROM C_R.Ofertas "
             + " WHERE Pub_Codigo =  @PubCodigo "
             + " ORDER BY Ofe_Fecha DESC, Ope_Monto DESC ";

            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@PubCodigo", PubCodigo);

            SqlDataReader datareader;

            try
            {
                Conexion.Open();
                datareader = command.ExecuteReader();

                if (datareader.HasRows)
                {
                    while (datareader.Read())
                    {
                        ofertas.Add(new Oferta(datareader.GetDecimal(1),datareader.GetDateTime(0)));
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

            return ofertas;
        }

        public Vendedor Vendedor(int Vendedor)
        {
            Vendedor vendedor = null;

            String query = "SELECT C.Cli_Nombre + ' ' + C.Cli_Apellido, C.Cli_Mail, C.Cli_Telefono FROM C_R.Clientes C WHERE C.Cli_User_Id = @Vendedor "
             + " UNION "
             + " SELECT E.Emp_RazonSocial, E.Emp_Mail, E.Emp_Telefono FROM C_R.Empresas E WHERE E.Emp_User_Id = @Vendedor ";

            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Vendedor", Vendedor);

            SqlDataReader datareader;

            try
            {
                Conexion.Open();
                datareader = command.ExecuteReader();

                if (datareader.HasRows)
                {
                    while (datareader.Read())
                    {
                        vendedor = new Vendedor(datareader.GetString(0), datareader.GetString(2), datareader.GetString(1));
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

            return vendedor;
        }
    }
}
