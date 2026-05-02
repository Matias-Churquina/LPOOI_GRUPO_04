using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesBase.Entity;

namespace ClasesBase.Service
{
    public static class UsuarioService
    {
        private static List<Usuario> usuarios =
            new List<Usuario>();

        static UsuarioService()
        {
            Rol admin = new Rol(1, "Administrador");
            Rol operador = new Rol(2, "Operador");
            Rol auditor = new Rol(3, "Auditor");

            usuarios.Add(new Usuario(1, "Juan", "123", "Juan Perez", admin));
            usuarios.Add(new Usuario(2, "Maria", "456", "Maria Gomez", operador));
            usuarios.Add(new Usuario(2, "Sofia", "890", "Sofia Martinez", auditor));
        }

        public static Usuario ValidarLogin(string username, string password)
        {
            return usuarios.FirstOrDefault(u =>
                u.Usu_NombreUsuario == username &&
                u.Usu_Contrasenia == password);
        }
    }
}
