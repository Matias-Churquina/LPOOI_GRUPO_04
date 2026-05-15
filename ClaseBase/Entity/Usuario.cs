using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase.Entity
{
    public class Usuario
    {
        public int Usu_ID { get; set; }
        public string Usu_NombreUsuario { get; set; }
        public string Usu_Contrasenia { get; set; }
        public string Usu_ApellidoNombre { get; set; }
        public int Usu_Rol { get; set; }

        public Usuario()
        {
        }

        public Usuario(int id, string usuario, string contrasenia,
                       string nombre, int rol)
        {
            Usu_ID = id;
            Usu_NombreUsuario = usuario;
            Usu_Contrasenia = contrasenia;
            Usu_ApellidoNombre = nombre;
            Usu_Rol = rol;
        }
    }
}
