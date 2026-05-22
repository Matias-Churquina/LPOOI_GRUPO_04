using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase.Entity;
using ClasesBase.Service;

namespace Vistas
{
    public partial class FrmGestionClientes : Form
    {
        public FrmGestionClientes()
        {
            InitializeComponent();
        }

        private void FrmGestionClientes_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dgvClientes.DataSource = ClienteService.ObtenerClientes();
        }


        private void LimpiarCajasEdicion()
        {
            txtDNI.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtCuit.Clear();
            txtNroCarnet.Clear();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Seleccione un cliente de la lista para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea modificar los datos de este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Cliente clienteModificado = new Cliente()
                {
                    Cli_DNI = txtDNI.Text, 
                    Cli_Apellido = txtApellido.Text.Trim(),
                    Cli_Nombre = txtNombre.Text.Trim(),
                    Cli_Direccion = txtDireccion.Text.Trim(),
                    OS_CUIT = txtCuit.Text.Trim(),
                    Cli_NroCarnet = txtNroCarnet.Text.Trim()
                };

                ClienteService.UpdateCliente(clienteModificado);
                CargarGrilla(); 
                LimpiarCajasEdicion();
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Seleccione un cliente de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea ELIMINAR a este cliente? Esta acción no se puede deshacer.", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                string dniSeleccionado = txtDNI.Text;
                ClienteService.DeleteCliente(dniSeleccionado);
                CargarGrilla(); 
                LimpiarCajasEdicion();
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void txtBuscarDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string filtroApellido = txtBuscarApellido.Text.Trim();
            string filtroDNI = txtBuscarDNI.Text.Trim();

          
            dgvClientes.DataSource = ClienteService.SearchClientesCombinado(filtroApellido, filtroDNI);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarApellido.Clear();
            txtBuscarDNI.Clear();
            CargarGrilla(); 
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

               
                txtDNI.Text = fila.Cells["DNI"].Value.ToString();
                txtApellido.Text = fila.Cells["Apellido"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtDireccion.Text = fila.Cells["Dirección"].Value.ToString();
                txtCuit.Text = fila.Cells["CUIT OS"].Value.ToString();
                txtNroCarnet.Text = fila.Cells["Nro Carnet"].Value.ToString();
            }
        }
    }
}