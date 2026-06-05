using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesBase.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClasesBase.Service
{
    public static class UsuarioService
    {

        public static Usuario ValidarLogin(string username, string password)
        {
            DataTable usuarios = list_usuarios();
            Usuario[] oUsuarios=usuarios.AsEnumerable().Select(row=>new Usuario{
                Usu_NombreUsuario = row.Field<string>("Usuario"),
                Usu_Contrasenia = row.Field<string>("Contraseña"),
                Usu_ApellidoNombre = row.Field<string>("Apellido y Nombre"),
                Usu_Rol = row.Field<int>("RolCode")
            }).ToArray();
            return oUsuarios.FirstOrDefault(u =>
                u.Usu_NombreUsuario == username &&
                u.Usu_Contrasenia == password);
        }

        public static DataTable list_roles()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);
            SqlCommand cmd = new SqlCommand("SELECT * FROM roles", cnn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void insert_usuario(Usuario user)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);
            SqlCommand cmd = new SqlCommand("INSERT INTO Usuario(Usu_NombreUsuario,Usu_Contrasenia,Usu_ApellidoNombre,Rol_Codigo) values(@usuario,@pass,@nya,@rol)",
                                            cnn);
            cmd.Parameters.AddWithValue("@usuario", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@pass", user.Usu_Contrasenia);
            cmd.Parameters.AddWithValue("@nya", user.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", user.Usu_Rol);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        public static DataTable list_usuarios()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " Usu_ID as 'Codigo', ";
            cmd.CommandText += " Usu_NombreUsuario as 'Usuario', ";
            cmd.CommandText += " Usu_Contrasenia as 'Contraseña', ";
            cmd.CommandText += " Usu_ApellidoNombre as 'Apellido y Nombre', ";
            cmd.CommandText += " U.Rol_Codigo as 'RolCode', ";
            cmd.CommandText += " Rol_Descripcion as 'Rol' ";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.Rol_Codigo=U.Rol_Codigo)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable search_usuarios(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " Usu_NombreUsuario as 'Usuario', ";
            cmd.CommandText += " Usu_Contrasenia as 'Contraseña', ";
            cmd.CommandText += " Usu_ApellidoNombre as 'Apellido y Nombre', ";
            cmd.CommandText += " Rol_Descripcion as 'Rol' ";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.rol_codigo=U.rol_Codigo)";
            cmd.CommandText += " WHERE";
            cmd.CommandText += " Usu_NombreUsuario LIKE @pattern";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void update_usuario(Usuario user)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);

            SqlCommand cmd = new SqlCommand(
                "UPDATE Usuario SET " +
                "Usu_NombreUsuario = @usuario, " +
                "Usu_Contrasenia = @pass, " +
                "Usu_ApellidoNombre = @nya, " +
                "Rol_Codigo = @rol " +
                "WHERE Usu_ID = @codigo",
                cnn);

            cmd.Parameters.AddWithValue("@usuario", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@pass", user.Usu_Contrasenia);
            cmd.Parameters.AddWithValue("@nya", user.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", user.Usu_Rol);
            cmd.Parameters.AddWithValue("@codigo", user.Usu_ID);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario modificado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        public static void delete_usuario(int idUsuario)
        {
            SqlConnection cnn = new SqlConnection(
                ClasesBase.Properties.Settings.Default.opticaConnectionString1);
            
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Usuario WHERE Usu_ID = @id", 
                cnn);

            cmd.Parameters.AddWithValue("@id", idUsuario);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuario eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
