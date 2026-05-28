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

        public static void AgregarCliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Cliente ";
            cmd.CommandText += " (Cli_DNI, Cli_Apellido, Cli_Nombre, Cli_Direccion, OS_CUIT, Cli_NroCarnet) ";
            cmd.CommandText += " VALUES ( ";
            cmd.CommandText += " '" + cliente.Cli_DNI + "', ";
            cmd.CommandText += " '" + cliente.Cli_Apellido + "', ";
            cmd.CommandText += " '" + cliente.Cli_Nombre + "', ";
            cmd.CommandText += " '" + cliente.Cli_Direccion + "', ";
            cmd.CommandText += " '" + cliente.OS_CUIT + "', ";
            cmd.CommandText += " '" + cliente.Cli_NroCarnet + "' ";
            cmd.CommandText += " ) ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el cliente en la base de datos: " + ex.Message);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        public static void UpdateCliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Cliente SET ";
            cmd.CommandText += " Cli_Apellido = '" + cliente.Cli_Apellido + "', ";
            cmd.CommandText += " Cli_Nombre = '" + cliente.Cli_Nombre + "', ";
            cmd.CommandText += " Cli_Direccion = '" + cliente.Cli_Direccion + "', ";
            cmd.CommandText += " OS_CUIT = '" + cliente.OS_CUIT + "', ";
            cmd.CommandText += " Cli_NroCarnet = '" + cliente.Cli_NroCarnet + "' ";
            cmd.CommandText += " WHERE Cli_DNI = '" + cliente.Cli_DNI + "' ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el cliente en la base de datos: " + ex.Message);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        public static void DeleteCliente(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Cliente ";
            cmd.CommandText += " WHERE Cli_DNI = '" + dni + "' ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el cliente de la base de datos: " + ex.Message);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        public static DataTable ObtenerClientes()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Cli_DNI as 'DNI', Cli_Apellido as 'Apellido', Cli_Nombre as 'Nombre', ";
            cmd.CommandText += " Cli_Direccion as 'Dirección', OS_CUIT as 'CUIT OS', Cli_NroCarnet as 'Nro Carnet' ";
            cmd.CommandText += " FROM Cliente";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public static DataTable SearchClientesCombinado(string sPatternApellido, string sPatternDNI)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Cli_DNI as 'DNI', Cli_Apellido as 'Apellido', Cli_Nombre as 'Nombre', ";
            cmd.CommandText += " Cli_Direccion as 'Dirección', OS_CUIT as 'CUIT OS', Cli_NroCarnet as 'Nro Carnet' ";
            cmd.CommandText += " FROM Cliente ";
            cmd.CommandText += " WHERE Cli_Apellido LIKE '%" + sPatternApellido + "%' AND Cli_DNI LIKE '%" + sPatternDNI + "%' ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

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

        public static DataTable list_usuarios(){
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            
            return dt;
        }

    }
}