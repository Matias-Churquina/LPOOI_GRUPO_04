using System;
using System.Data;
using System.Windows.Forms;
using ClasesBase.Service;

namespace Vistas
{
    public partial class ListadoProductos : Form
    {
        public ListadoProductos()
        {
            InitializeComponent();
        }

        private void ListadoProductos_Load(object sender, EventArgs e)
        {
            CargarClientes();
            LimpiarGrilla();
        }

        private void CargarClientes()
        {
            try
            {
                DataTable dt = ClienteService.list_clientes();
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataTable dtCombo = dt.Copy();
                    cmbClientes.DataSource = dtCombo;
                    cmbClientes.DisplayMember = "Apellido";
                    cmbClientes.ValueMember = "DNI";
                    cmbClientes.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarGrilla()
        {
            dgvVentas.DataSource = null;
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
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
                if (radioButton1.Checked)
                {
                    if (cmbClientes.SelectedValue == null)
                    {
                        MessageBox.Show("Por favor seleccione un cliente de la lista.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string dni = cmbClientes.SelectedValue.ToString();
                    dgvVentas.DataSource = ProductoService.ListarProductosVendidosPorCliente(dni);
                }
                else if (radioButton2.Checked)
                {
                    DateTime desde = dtpDesde.Value;
                    DateTime hasta = dtpHasta.Value;
                    dgvVentas.DataSource = ProductoService.ListarProductosVendidosPorFechas(desde, hasta);
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un criterio de filtro.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar productos vendidos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            LimpiarGrilla();
        }

        private void grpFiltros_Enter(object sender, EventArgs e)
        {

        }
    }
}
