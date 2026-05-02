using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesBase.Entity;

namespace ClasesBase
{
    public static class Datos
    {
        public static Cliente[] clientes = new Cliente[100];
        public static int indiceClientes = 0;

        public static Producto[] productos = new Producto[100];
        public static int indiceProductos = 0;

        public static ObraSocial[] obrasSociales = new ObraSocial[100];
        public static int indiceObraSociales = 0;

    }
}
