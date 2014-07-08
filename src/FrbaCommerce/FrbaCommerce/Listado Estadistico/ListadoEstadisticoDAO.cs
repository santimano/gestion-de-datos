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

        public DataSet GenerarReporte(string anio, string trimestre, string reporte, string mes, string visibilidad)
        {
            string query = "";

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@Anio", anio);
            parametros.Add("@Trimestre", trimestre);

            switch (reporte.ToLower())
            {
                case "vendedores con mayor cantidad de productos no vendidos":
                    query = "SELECT TOP 5 U.User_Name Usuario, V.Pub_Visible_Descripcion Visibilidad "
                          + ", MONTH(P.Pub_Fecha) AS Mes, SUM(P.Pub_Stock) AS Cantidad "
                          + "FROM C_R.Publicaciones P, C_R.Publicaciones_Visibilidad V, C_R.Usuarios U "
                          + "WHERE P.Pub_Visible_Cod = V.Pub_Visible_Cod "
                          + "AND U.User_Id = P.Pub_User_Id "
                          + "AND YEAR(P.Pub_Fecha) = @Anio "
                          + "AND DATENAME(QUARTER, P.Pub_Fecha) = @Trimestre "
                          + "AND V.Pub_Visible_Descripcion = @Visibilidad "
                          + "AND MONTH(P.Pub_Fecha) = @Mes "
                          + "GROUP BY MONTH(P.Pub_Fecha), U.User_Name, V.Pub_Visible_Descripcion, V.Pub_Visible_Precio "
                          + "ORDER BY Mes, V.Pub_Visible_Precio DESC, Cantidad DESC ";
                    parametros.Add("@Visibilidad", visibilidad);
                    parametros.Add("@Mes", mes);
                    break;
                case "vendedores con mayor facturacion":
                    query = "SELECT U.User_Name Usuario, FACT.Facturacion FROM "
                        + "(SELECT TOP 5 P.Pub_User_Id Usuario,SUM(V.Ven_Monto * V.Ven_Cantidad) Facturacion "
                        + "FROM C_R.Ventas V "
                        + "INNER JOIN C_R.Publicaciones P ON V.Pub_Codigo = P.Pub_Codigo "
                        + "AND DATENAME(QUARTER, V.Ven_Fecha) = @Trimestre "
                        + "AND YEAR(V.Ven_Fecha) = @Anio "
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
                        + "AND DATENAME(QUARTER, V.Ven_Fecha) = @Trimestre "
                        + "AND YEAR(V.Ven_Fecha) = @Anio "
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
                        + "AND DATENAME(QUARTER, V.Ven_Fecha) = @Trimestre "
                        + "AND YEAR(V.Ven_Fecha) = @Anio "
                        + "GROUP BY P.Pub_User_Id "
                        + "ORDER BY Ventas_Sin_Calificar DESC) AS VTAS "
                        + "INNER JOIN C_R.Usuarios U ON U.User_Id = VTAS.Usuario";
                    break;
            }

            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;

            foreach (KeyValuePair<string, object> entry in parametros)
            {
                command.Parameters.AddWithValue(entry.Key, entry.Value);
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
