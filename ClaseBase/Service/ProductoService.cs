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
    public static class ProductoService
    {
        public static void AgregarProducto(Producto producto)
        {
            if (producto.Prod_Precio <= 0) throw new Exception("El precio debe ser mayor a cero.");

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Producto ";
            cmd.CommandText += " (Prod_Codigo, Prod_Categoria, Prod_Descripcion, Prod_Precio) ";
            cmd.CommandText += " VALUES ( ";
            cmd.CommandText += " '" + producto.Prod_Codigo + "', ";
            cmd.CommandText += " '" + producto.Prod_Categoria + "', ";
            cmd.CommandText += " '" + producto.Prod_Descripcion + "', ";
            cmd.CommandText += " " + producto.Prod_Precio.ToString().Replace(",", ".") + " "; 
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
                throw new Exception("Error al insertar el producto en la base de datos: " + ex.Message);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        public static DataTable ObtenerProductosBD()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Prod_Codigo as 'Codigo', Prod_Descripcion as 'Descripcion', Prod_Precio as 'Precio' FROM Producto";
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
                MessageBox.Show("Error al cargar productos de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }
        public static DataTable ObtenerProductosActivos() {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarProductosActivos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void GuardarCambios(DataSet ds) {
            if (ds.HasChanges()) {
                SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "eliminarProducto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;
                cmd.Parameters.Add("@Codigo", SqlDbType.VarChar, 50, "Codigo").SourceVersion = DataRowVersion.Original;

                SqlCommand cmdSave = new SqlCommand();
                cmdSave.CommandType = CommandType.StoredProcedure;
                cmdSave.CommandText = "guardarProducto";
                cmdSave.Connection = cnn;
                cmdSave.Parameters.Add("@Codigo", SqlDbType.VarChar, 50, "Codigo");
                cmdSave.Parameters.Add("@Categoria", SqlDbType.VarChar, 50, "Categoria");
                cmdSave.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50, "Descripcion");
                cmdSave.Parameters.Add("@Precio", SqlDbType.Decimal, 0, "Precio");


                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = cmdSave;
                da.UpdateCommand = cmdSave;
                da.DeleteCommand = cmd;
                try
                {
                    cnn.Open();
                    da.Update(ds, "Producto");
                }
                catch (Exception)
                {
                    throw;
                }
                finally {
                    cnn.Close();
                }
                
            }

        }

        public static DataTable ObtenerProductosOrdenados(string criterioOrden)
        {
            DataTable dt = new DataTable();

            // Reemplaza esto con el nombre exacto de tu cadena de conexión
            string cadenaConexion = Properties.Settings.Default.opticaConnectionString1;

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                // Armamos la consulta base
                string consulta = "SELECT * FROM Producto";

                // Concatenamos el ORDER BY dependiendo de lo que elija el usuario
                if (criterioOrden == "Categoria")
                {
                    consulta += " ORDER BY Prod_Categoria ASC";
                }
                else
                {
                    consulta += " ORDER BY Prod_Descripcion ASC";
                }

                SqlCommand comando = new SqlCommand(consulta, conexion);

                try
                {
                    conexion.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al consultar los productos: " + ex.Message);
                }
            }

            return dt;
        }


        // Listar 
        public static DataTable ListarProductosVendidosPorCliente(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listarProductosVendidosPorCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable ListarProductosVendidosPorFechas(DateTime desde, DateTime hasta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listarProductosVendidosPorFecha";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fechaDesde", desde);
            cmd.Parameters.AddWithValue("@fechaHasta", hasta);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

    }

}
