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

        public static DataTable list_ventas()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT V.Ven_Nro AS 'Numero Venta', " +
                "V.Ven_Fecha AS 'Fecha', " +
                "V.Cli_DNI AS 'DNI Cliente', " +
                "C.Cli_Apellido + ', ' + C.Cli_Nombre AS 'Cliente', " +
                "D.Prod_Codigo AS 'Codigo Producto', " +
                "P.Prod_Descripcion AS 'Producto', " +
                "D.Det_Precio AS 'Precio', " +
                "D.Det_Cantidad AS 'Cantidad', " +
                "D.Det_Total AS 'Total' " +
                "FROM Venta V " +
                "INNER JOIN VentaDetalle D ON V.Ven_Nro = D.Ven_Nro " +
                "LEFT JOIN Cliente C ON V.Cli_DNI = C.Cli_DNI " +
                "LEFT JOIN Producto P ON D.Prod_Codigo = P.Prod_Codigo", cnn);

            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar ventas: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public static DataTable list_ventas_filtradas(string dniCliente, DateTime desde, DateTime hasta, bool filtrarCliente, bool filtrarFechas)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString1);
            string query = "SELECT V.Ven_Nro AS 'Numero Venta', " +
                           "V.Ven_Fecha AS 'Fecha', " +
                           "V.Cli_DNI AS 'DNI Cliente', " +
                           "C.Cli_Apellido + ', ' + C.Cli_Nombre AS 'Cliente', " +
                           "D.Prod_Codigo AS 'Codigo Producto', " +
                           "P.Prod_Descripcion AS 'Producto', " +
                           "D.Det_Precio AS 'Precio', " +
                           "D.Det_Cantidad AS 'Cantidad', " +
                           "D.Det_Total AS 'Total' " +
                           "FROM Venta V " +
                           "INNER JOIN VentaDetalle D ON V.Ven_Nro = D.Ven_Nro " +
                           "LEFT JOIN Cliente C ON V.Cli_DNI = C.Cli_DNI " +
                           "LEFT JOIN Producto P ON D.Prod_Codigo = P.Prod_Codigo WHERE 1=1";

            if (filtrarCliente)
            {
                query += " AND V.Cli_DNI = @dni";
            }
            if (filtrarFechas)
            {
                query += " AND V.Ven_Fecha >= @desde AND V.Ven_Fecha <= @hasta";
            }

            SqlCommand cmd = new SqlCommand(query, cnn);
            if (filtrarCliente)
            {
                cmd.Parameters.AddWithValue("@dni", dniCliente);
            }
            if (filtrarFechas)
            {
                // Ajustamos las fechas para cubrir el rango completo del dia
                cmd.Parameters.AddWithValue("@desde", desde.Date);
                cmd.Parameters.AddWithValue("@hasta", hasta.Date.AddDays(1).AddSeconds(-1));
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar ventas: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
    }
}
