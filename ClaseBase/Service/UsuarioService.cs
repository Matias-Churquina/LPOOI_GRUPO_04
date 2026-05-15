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
        private static List<Usuario> usuarios =
            new List<Usuario>();

        static UsuarioService()
        {
            Rol admin = RolService.roles[0];
            Rol operador = RolService.roles[1];
            Rol auditor = RolService.roles[2];

            usuarios.Add(new Usuario(1, "Juan", "123", "Juan Perez", admin.Rol_Codigo));
            usuarios.Add(new Usuario(2, "Maria", "456", "Maria Gomez", operador.Rol_Codigo));
            usuarios.Add(new Usuario(2, "Sofia", "890", "Sofia Martinez", auditor.Rol_Codigo));
        }

        public static Usuario ValidarLogin(string username, string password)
        {
            return usuarios.FirstOrDefault(u =>
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
            cmd.CommandText += " Usu_NombreUsuario as 'Usuario', ";
            cmd.CommandText += " Usu_Contrasenia as 'Contraseña', ";
            cmd.CommandText += " Usu_ApellidoNombre as 'Apellido y Nombre', ";
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
                "WHERE Usu_Codigo = @codigo",
                cnn);

            cmd.Parameters.AddWithValue("@usuario", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@pass", user.Usu_Contrasenia);
            cmd.Parameters.AddWithValue("@nya", user.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", user.Usu_Rol);

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

        public static void delete_usuario(string nombreApellido)
        {
            SqlConnection cnn = new SqlConnection(
                ClasesBase.Properties.Settings.Default.opticaConnectionString1);
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Usuario WHERE Usu_ApellidoNombre = @nya",
                cnn);
            cmd.Parameters.AddWithValue("@nya", nombreApellido);
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
