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

        public List<Rol> obtenerRoles(string descripcion, string estado)
        {
            Dictionary<string, object> parametros = new Dictionary<string,object>();
            Dictionary<string, object> tipos = new Dictionary<string, object>();
            Dictionary<string, object> sizes = new Dictionary<string, object>();
            String query = " SELECT Rol_Descripcion, Rol_Estado, Rol_Id FROM C_R.Roles WHERE 1 = 1 ";
            if (null != descripcion && descripcion.Length != 0)
            {
                query += " AND Rol_Descripcion like @descripcion+'%' ";
            }
            if (null != estado)
            {
                query += " AND Rol_Estado = @estado ";
            }

            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;

            if (null != descripcion && descripcion.Length != 0)
            {
                command.Parameters.Add("@descripcion", SqlDbType.VarChar, 50);
                command.Parameters["@descripcion"].Value = descripcion;
            }
            if (null != estado)
            {
                command.Parameters.Add("@estado", SqlDbType.VarChar, 50);
                command.Parameters["@estado"].Value = estado;
            }

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
                        Rol rol = new Rol(datareader.GetString(0), datareader.GetString(1));
                        rol.Id = datareader.GetInt32(2);
                        roles.Add(rol);
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

        public void actualizarRol(Rol rol)
        {
            String query = "UPDATE C_R.Roles set Rol_Descripcion = @descripcion, Rol_Estado = @estado WHERE Rol_Id = @id";
            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;
            try
            {
                Conexion.Open();
                command.Parameters.Add("@descripcion", SqlDbType.NVarChar, 50);
                command.Parameters["@descripcion"].Value = rol.Descripcion;
                command.Parameters.Add("@estado", SqlDbType.VarChar, 50);
                command.Parameters["@estado"].Value = rol.Estado;
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = rol.Id;
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

        public void borrarRol(Rol rol)
        {
            String query = "DELETE C_R.Roles WHERE Rol_Id = @id";
            SqlCommand command = new SqlCommand(query, Conexion);
            command.CommandType = CommandType.Text;
            try
            {
                Conexion.Open();
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = rol.Id;
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
