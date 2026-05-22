using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClasesBase.Service
{
    public static class VentaService
    {
        public static bool RegistrarVenta(string dniCliente, DateTime fecha, string codigoProducto, decimal precio, decimal cantidad, decimal total)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);
            SqlTransaction transaction = null;

            try
            {
                cnn.Open();
                transaction = cnn.BeginTransaction();

                SqlCommand cmdMaxVenta = new SqlCommand("SELECT ISNULL(MAX(Ven_Nro), 0) + 1 FROM Venta", cnn, transaction);
                int ventaNro = Convert.ToInt32(cmdMaxVenta.ExecuteScalar());

                SqlCommand cmdVenta = new SqlCommand("INSERT INTO Venta(Ven_Nro, Ven_Fecha, Cli_DNI) VALUES (@ven_nro, @fecha, @dni)", cnn, transaction);
                cmdVenta.Parameters.AddWithValue("@ven_nro", ventaNro);
                cmdVenta.Parameters.AddWithValue("@fecha", fecha);
                cmdVenta.Parameters.AddWithValue("@dni", dniCliente);
                cmdVenta.ExecuteNonQuery();

                SqlCommand cmdMaxDetalle = new SqlCommand("SELECT ISNULL(MAX(Det_Nro), 0) + 1 FROM VentaDetalle", cnn, transaction);
                int detNro = Convert.ToInt32(cmdMaxDetalle.ExecuteScalar());

                SqlCommand cmdDetalle = new SqlCommand("INSERT INTO VentaDetalle(Det_Nro, Ven_Nro, Prod_Codigo, Det_Precio, Det_Cantidad, Det_Total) VALUES (@det_nro, @ven_nro, @prod_codigo, @precio, @cantidad, @total)", cnn, transaction);
                cmdDetalle.Parameters.AddWithValue("@det_nro", detNro);
                cmdDetalle.Parameters.AddWithValue("@ven_nro", ventaNro);
                cmdDetalle.Parameters.AddWithValue("@prod_codigo", codigoProducto);
                cmdDetalle.Parameters.AddWithValue("@precio", precio);
                cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad);
                cmdDetalle.Parameters.AddWithValue("@total", total);
                cmdDetalle.ExecuteNonQuery();

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show("Error al registrar la transaccion de venta: " + ex.Message, "Error de Persistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
