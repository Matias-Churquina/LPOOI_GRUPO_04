using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesBase.Entity;

namespace ClasesBase.Service
{
    public static class ObraSocialService
    {
        private static List<ObraSocial> oSociales = new List<ObraSocial>();

        private static bool ExisteOSocial(string cuil)
        {
            return oSociales.Any(os => os.OS_CUIT == cuil);
        }

        public static void AgregarOSocial(ObraSocial oSocial)
        {
            if (ExisteOSocial(oSocial.OS_CUIT)) throw new Exception("El CUIT ya se encuentra registrado");

            oSociales.Add(oSocial);
        }

        public static List<ObraSocial> ObtenerObrasSociales()
        {
            return oSociales;
        }
    }
}
