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

        public static DataTable list_ObrasSociales(){
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);

            SqlCommand cmd = new SqlCommand("SELECT OS_CUIT, OS_RazonSocial FROM ObraSocial", cnn);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traer Obras Sociales: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        public static DataTable list_ObrasSocialesTodo()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);
            SqlCommand cmd = new SqlCommand("SELECT OS_CUIT, OS_RazonSocial, OS_Direccion, OS_Telefono FROM ObraSocial", cnn);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar todas las Obras Sociales: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }
    }
}
