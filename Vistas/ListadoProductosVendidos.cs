using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase.Service;

namespace Vistas
{
    public partial class ListadoProductosVendidos : Form
    {
        public ListadoProductosVendidos()
        {
            InitializeComponent();
        }

        private void ListadoProductosVendidos_Load(object sender, EventArgs e)
        {
            load_combo_roles();
        }

        private void load_combo_roles()
        {
            cmbCliente.DisplayMember = "Cli_Apellido";
            cmbCliente.ValueMember = "Cli_DNI";
            cmbCliente.DataSource = ClienteService.list_clientes();
            cmbCliente.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex != -1 && cmbCliente.SelectedValue != null) {
                string dni = cmbCliente.SelectedValue.ToString();
                dgwListadoProductosVendidos.DataSource = ProductoService.ListarProductosVendidosPorCliente(dni);
            }
            else {
                MessageBox.Show("Por favor, seleccione un cliente de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
