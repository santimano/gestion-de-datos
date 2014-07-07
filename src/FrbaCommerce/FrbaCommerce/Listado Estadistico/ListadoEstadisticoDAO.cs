using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrbaCommerce.Listado_Estadistico
{
    public class ListadoEstadisticoDAO
    {
        private SqlConnection Conexion;

        public ListadoEstadisticoDAO(SqlConnection Conexion)
        {
            this.Conexion = Conexion;
        }

        public DataSet GenerarReporte(string anio, string trimestre, string reporte)
        {
            string fecha_inicio = "";
            string fecha_fin = "";
            string query = "";

            switch (trimestre)
            {
                case "1":
                    fecha_inicio = "01/01/";
                    fecha_fin = "31/03/";
                    break;
                case "2":
                    fecha_inicio = "01/04/";
                    fecha_fin = "30/06/";
                    break;
                case "3":
                    fecha_inicio = "01/07/";
                    fecha_fin = "30/09/";
                    break;
                case "4":
                    fecha_inicio = "01/10/";
                    fecha_fin = "31/12/";
                    break;
            }

            fecha_inicio += anio;
            fecha_fin += anio;

            switch (reporte.ToLower())
            {
                case "vendedores con mayor cantidad de productos no vendidos":
                    query = "";
                    break;
                case "vendedores con mayor facturacion":
                    query = "SELECT U.User_Name Usuario, FACT.Facturacion FROM "
                        + "(SELECT TOP 5 P.Pub_User_Id Usuario,SUM(V.Ven_Monto * V.Ven_Cantidad) Facturacion "
                        + "FROM C_R.Ventas V "
                        + "INNER JOIN C_R.Publicaciones P ON V.Pub_Codigo = P.Pub_Codigo "
                        + "WHERE V.Ven_Fecha BETWEEN @fecha_inicio AND @fecha_fin "
                        + "GROUP BY P.Pub_User_Id "
                        + "ORDER BY Facturacion DESC) AS FACT "
                        + "INNER JOIN C_R.Usuarios U ON FACT.Usuario = U.User_Id";
                    break;
                case "vendedores con mayores calificaciones":
                    query = "SELECT U.User_Name Usuario, CALIF.Calificaciones FROM "
                        + "(SELECT TOP 5 P.Pub_User_Id Usuario,SUM(C.Cal_CantEstrellas) Calificaciones "
                        + "FROM C_R.Calificaciones C "
                        + "INNER JOIN C_R.Ventas V ON C.Ven_Codigo = V.Ven_Codigo "
                        + "INNER JOIN C_R.Publicaciones P ON V.Pub_Codigo = P.Pub_Codigo "
                        + "WHERE V.Ven_Fecha BETWEEN @fecha_inicio AND @fecha_fin "
                        + "GROUP BY P.Pub_User_Id "
                        + "ORDER BY Calificaciones desc) AS CALIF "
                        + "INNER JOIN C_R.Usuarios U ON CALIF.Usuario = U.User_Id";
                    break;
                case "clientes con mayor cantidad de publicaciones sin calificar":
                    query = "SELECT U.User_Name Usuario, VTAS.Ventas_Sin_Calificar FROM "
                        + "(SELECT TOP 5 P.Pub_User_Id Usuario,COUNT(*) Ventas_Sin_Calificar "
                        + "FROM C_R.Ventas V "
                        + "INNER JOIN C_R.Publicaciones P ON V.Pub_Codigo = P.Pub_Codigo "
                        + "WHERE NOT EXISTS (SELECT 1 FROM C_R.Calificaciones C WHERE C.Ven_Codigo = V.Ven_Codigo) "
                        + "AND V.Ven_Fecha BETWEEN @fecha_inicio AND @fecha_fin "
                        + "GROUP BY P.Pub_User_Id "
                        + "ORDER BY Ventas_Sin_Calificar DESC) AS VTAS "
                        + "INNER JOIN C_R.Usuarios U ON U.User_Id = VTAS.Usuario";
                    break;
            }

            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;

            command.Parameters.Add("@fecha_inicio", SqlDbType.DateTime);
            command.Parameters.Add("@fecha_fin", SqlDbType.DateTime);
            command.Parameters["@fecha_inicio"].Value = Convert.ToDateTime(fecha_inicio, new System.Globalization.CultureInfo("es-AR", true));
            command.Parameters["@fecha_fin"].Value = Convert.ToDateTime(fecha_fin, new System.Globalization.CultureInfo("es-AR", true));

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
