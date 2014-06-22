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

        public List<Rol> obtenerRoles()
        {
            String query = "SELECT Rol_Descripcion, Rol_Estado FROM C_R.Roles";

            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;

            SqlDataReader datareader;
            List<Rol> roles = new List<Rol>();
            try
            {
                Conexion.Open();
                datareader = command.ExecuteReader();

                if (datareader.HasRows)
                {
                    while (datareader.Read())
                    {
                        roles.Add(new Rol(datareader.GetString(0),datareader.GetString(1)));
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

            return roles;
        }

        public void agregarRol(Rol rol)
        {
            String query = "INSERT INTO C_R.Roles(Rol_Descripcion, Rol_Estado) VALUES (@descripcion, @estado)";
            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;
            try
            {
                Conexion.Open();
                command.Parameters.Add("@descripcion", SqlDbType.NVarChar, 50);
                command.Parameters["@descripcion"].Value = rol.Descripcion;
                command.Parameters.Add("@estado", SqlDbType.VarChar, 50);
                command.Parameters["@estado"].Value = rol.Estado;
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
