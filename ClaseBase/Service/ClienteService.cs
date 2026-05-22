using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ClasesBase.Entity;

namespace ClasesBase.Service
{
    public static class ClienteService
    {
        private static List<Cliente> clientes = new List<Cliente>();

        static ClienteService()
        {
    
        }

        public static void AgregarCliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);
            string query = "INSERT INTO Cliente(Cli_DNI, Cli_Apellido, Cli_Nombre, Cli_Direccion, OS_CUIT, Cli_NroCarnet) " +
                           "VALUES (@dni, @apellido, @nombre, @direccion, @cuit, @carnet)";

            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@dni", cliente.Cli_DNI);
            cmd.Parameters.AddWithValue("@apellido", cliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@nombre", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@direccion", cliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@cuit", cliente.OS_CUIT);
            cmd.Parameters.AddWithValue("@carnet", cliente.Cli_NroCarnet);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente registrado con éxito.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Close();
            }
        }

       
        public static void UpdateCliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);
            string query = "UPDATE Cliente SET " +
                           "Cli_Apellido = @apellido, " +
                           "Cli_Nombre = @nombre, " +
                           "Cli_Direccion = @direccion, " +
                           "OS_CUIT = @cuit, " +
                           "Cli_NroCarnet = @carnet " +
                           "WHERE Cli_DNI = @dni";

            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@dni", cliente.Cli_DNI);
            cmd.Parameters.AddWithValue("@apellido", cliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@nombre", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@direccion", cliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@cuit", cliente.OS_CUIT);
            cmd.Parameters.AddWithValue("@carnet", cliente.Cli_NroCarnet);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos del cliente actualizados correctamente.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Close();
            }
        }

       
        public static void DeleteCliente(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);
            string query = "DELETE FROM Cliente WHERE Cli_DNI = @dni";

            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@dni", dni);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Close();
            }
        }

        
        public static DataTable ObtenerClientes()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);
            SqlCommand cmd = new SqlCommand("SELECT Cli_DNI as 'DNI', Cli_Apellido as 'Apellido', Cli_Nombre as 'Nombre', Cli_Direccion as 'Dirección', OS_CUIT as 'CUIT OS', Cli_NroCarnet as 'Nro Carnet' FROM Cliente", cnn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar clientes: " + ex.Message);
            }
            return dt;
        }

        public static DataTable SearchClientesCombinado(string sPatternApellido, string sPatternDNI)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);
            SqlCommand cmd = new SqlCommand();

            
            cmd.CommandText = "SELECT Cli_DNI as 'DNI', Cli_Apellido as 'Apellido', Cli_Nombre as 'Nombre', " +
                              "Cli_Direccion as 'Dirección', OS_CUIT as 'CUIT OS', Cli_NroCarnet as 'Nro Carnet' " +
                              "FROM Cliente " +
                              "WHERE Cli_Apellido LIKE @patternApellido AND Cli_DNI LIKE @patternDNI";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            
            cmd.Parameters.AddWithValue("@patternApellido", "%" + sPatternApellido + "%");
            cmd.Parameters.AddWithValue("@patternDNI", "%" + sPatternDNI + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda combinada: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }
    }
}
