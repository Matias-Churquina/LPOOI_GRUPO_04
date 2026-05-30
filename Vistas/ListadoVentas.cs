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
                cmbClientes.SelectedIndex = -1;
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Habilita combobox de clientes y deshabilita fechas
            cmbClientes.Enabled = radioButton1.Checked;
            
            if (radioButton1.Checked)
            {
                lblDesde.Enabled = false;
                dtpDesde.Enabled = false;
                lblHasta.Enabled = false;
                dtpHasta.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Habilita fechas y deshabilita combobox de clientes
            lblDesde.Enabled = radioButton2.Checked;
            dtpDesde.Enabled = radioButton2.Checked;
            lblHasta.Enabled = radioButton2.Checked;
            dtpHasta.Enabled = radioButton2.Checked;

            if (radioButton2.Checked)
            {
                cmbClientes.Enabled = false;
                cmbClientes.SelectedIndex = -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = radioButton1.Checked && cmbClientes.SelectedValue != null ? cmbClientes.SelectedValue.ToString() : string.Empty;
                DateTime desde = dtpDesde.Value;
                DateTime hasta = dtpHasta.Value;

                DataTable dt = VentaService.list_ventas_filtradas(dni, desde, hasta, radioButton1.Checked, radioButton2.Checked);
                dgvVentas.DataSource = dt;
                CalcularTotalAcumulado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar las ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            cmbClientes.Enabled = false;
            cmbClientes.SelectedIndex = -1;
            
            lblDesde.Enabled = false;
            dtpDesde.Enabled = false;
            lblHasta.Enabled = false;
            dtpHasta.Enabled = false;

            CargarVentasGeneral();
        }
    }
}
