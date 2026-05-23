using System;
using System.Data;
using System.Windows.Forms;
using ClasesBase.Service;

namespace Vistas
{
    public partial class ListadoVentas : Form
    {
        public ListadoVentas()
        {
            InitializeComponent();
        }

        private void ListadoVentas_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarVentasGeneral();
        }

        private void CargarClientes()
        {
            DataTable dt = ClienteService.ObtenerClientes();
            if (dt != null && dt.Rows.Count > 0)
            {
                DataTable dtCombo = dt.Copy();
                cmbClientes.DataSource = dtCombo;
                cmbClientes.DisplayMember = "Apellido";
                cmbClientes.ValueMember = "DNI";
            }
        }

        private void CargarVentasGeneral()
        {
            DataTable dt = VentaService.list_ventas();
            dgvVentas.DataSource = dt;
            CalcularTotalAcumulado();
        }

        private void CalcularTotalAcumulado()
        {
            decimal totalAcumulado = 0;
            if (dgvVentas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvVentas.Rows)
                {
                    if (row.Cells["Total"].Value != DBNull.Value)
                    {
                        totalAcumulado += Convert.ToDecimal(row.Cells["Total"].Value);
                    }
                }
            }
            lblTotalValor.Text = "$ " + totalAcumulado.ToString("N2");
        }

        private void chkCliente_CheckedChanged(object sender, EventArgs e)
        {
            cmbClientes.Enabled = chkCliente.Checked;
        }

        private void chkFechas_CheckedChanged(object sender, EventArgs e)
        {
            lblDesde.Enabled = chkFechas.Checked;
            dtpDesde.Enabled = chkFechas.Checked;
            lblHasta.Enabled = chkFechas.Checked;
            dtpHasta.Enabled = chkFechas.Checked;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string dni = chkCliente.Checked && cmbClientes.SelectedValue != null ? cmbClientes.SelectedValue.ToString() : string.Empty;
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;

            DataTable dt = VentaService.list_ventas_filtradas(dni, desde, hasta, chkCliente.Checked, chkFechas.Checked);
            dgvVentas.DataSource = dt;
            CalcularTotalAcumulado();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            chkCliente.Checked = false;
            chkFechas.Checked = false;
            CargarVentasGeneral();
        }
    }
}
