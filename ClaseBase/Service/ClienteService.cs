using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesBase.Entity;

namespace ClasesBase.Service
{
    public static class ClienteService
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public static bool ExisteCliente(string dni)
        {
            return clientes.Any(c => c.Cli_DNI == dni);
        }

        public static void AgregarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public static List<Cliente> ObtenerClientes()
        {
            return clientes;
        }
    }
}
