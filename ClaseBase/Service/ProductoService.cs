using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesBase.Entity;

namespace ClasesBase.Service
{
    public static class ProductoService
    {
        private static List<Producto> productos = new List<Producto>();

        public static bool existeProducto(string codigo)
        {
            return productos.Any(p => p.Prod_Codigo == codigo);
        }

        public static void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public static List<Producto> ObtenerProductos()
        {
            return productos;
        }
    }
}
