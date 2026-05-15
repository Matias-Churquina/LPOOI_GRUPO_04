using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesBase.Entity;

namespace ClasesBase.Service
{
    public static class RolService
    {
        public static List<Rol> roles = new List<Rol>()
        {
            new Rol(1, "Administrador"),
            new Rol(2, "Operador"),
            new Rol(3, "Auditor")
        };

        public static String getDescripcion(int id)
        {
            foreach (Rol rol in roles)
            {
                if (rol.Rol_Codigo == id)
                {
                    return rol.Rol_Descripcion;
                }
            }

            return null;
        }
    }
}
