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
        private static List<Producto> productos = new List<Producto>();

        private static bool existeProducto(string codigo)
        {
            return productos.Any(p => p.Prod_Codigo == codigo);
        }

        public static void AgregarProducto(Producto producto)
        {
            if (producto.Prod_Precio <= 0) throw new Exception("El precio debe ser mayor a cero.");
            if (existeProducto(producto.Prod_Codigo)) throw new Exception("El codigo ya se encuentra registrado");

            productos.Add(producto);
        }

        public static List<Producto> ObtenerProductos()
        {
            return productos;
        }

        public static DataTable ObtenerProductosBD()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);
            SqlCommand cmd = new SqlCommand("SELECT Prod_Codigo as 'Codigo', Prod_Descripcion as 'Descripcion', Prod_Precio as 'Precio' FROM Producto", cnn);
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
    }
}
