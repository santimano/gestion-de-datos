using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Modelo;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrbaCommerce.Gestion_de_Preguntas
{

    class PreguntasDAO
    {
        private SqlConnection Conexion;

        public PreguntasDAO(SqlConnection Conexion)
        {
            this.Conexion = Conexion;
        }



        public DataSet Preguntas_Grilla()
        {
            String query = "SELECT * FROM C_R.Preguntas_Pendientes_VW WHERE Pub_User_Id = @Usuario "
                + "ORDER BY Pre_Fecha ";

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

        internal void Guardar_Respuesta(int pregunta, string respuesta)
        {
            String query = "INSERT INTO C_R.Respuestas(Pre_Id, Res_Texto) VALUES (@Pregunta, @Respuesta)";

            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Pregunta", SqlDbType.Int);
            command.Parameters.Add("@Respuesta", SqlDbType.VarChar, 255);
            command.Parameters["@Pregunta"].Value = pregunta;
            command.Parameters["@Respuesta"].Value = respuesta;

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
