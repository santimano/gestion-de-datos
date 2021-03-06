﻿using System;
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

        public void Guardar_Respuesta(int pregunta, string respuesta)
        {
            String query = "INSERT INTO C_R.Respuestas(Pre_Id, Res_Texto, Res_Fecha) VALUES (@Pregunta, @Respuesta, @Fecha)";

            DateTime fecha = new DateTime(Main.FechaSistema.Year,
                            Main.FechaSistema.Month,
                            Main.FechaSistema.Day,
                            DateTime.Now.Hour,
                            DateTime.Now.Minute,
                            DateTime.Now.Second);

            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Pregunta", SqlDbType.Int);
            command.Parameters.Add("@Respuesta", SqlDbType.VarChar, 255);
            command.Parameters.Add("@Fecha", SqlDbType.DateTime);
            command.Parameters["@Pregunta"].Value = pregunta;
            command.Parameters["@Respuesta"].Value = respuesta;
            command.Parameters["@Fecha"].Value = fecha;

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

        public DataSet Respuestas_Grilla(string estado, bool respondidas, bool sinResponder)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexion;
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@Usuario", SqlDbType.Int);
            command.Parameters["@Usuario"].Value = Main.Usuario;

            String query = "SELECT Publicacion, Precio, Stock, Estado, Pregunta, Fecha_Pregunta, Respuesta FROM C_R.Respondidas_VW WHERE User_Id = @Usuario ";

            if (respondidas)
            {
                query += " AND Respuesta IS NOT NULL ";
            }
            if (sinResponder)
            {
                query += " AND Respuesta IS NULL ";
            }
            if (estado != null && !"".Equals(estado))
            {
                query += " AND Estado = @Estado ";
                command.Parameters.Add("@Estado", SqlDbType.VarChar, 255);
                command.Parameters["@Estado"].Value = estado;
            }

            query += "ORDER BY Fecha_Pregunta DESC ";

            command.CommandText = query;  

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
