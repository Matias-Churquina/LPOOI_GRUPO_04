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
    public partial class FrmRegVentas : Form
    {
        public FrmRegVentas()
        {
            InitializeComponent();
        }

        private void FrmRegVentas_Load(object sender, EventArgs e)
        {
            // Configuración inicial del NumericUpDown
            nupCantidad.Minimum = 1;
            nupCantidad.Maximum = 1000;
            nupCantidad.Value = 1;

            DataTable dtClientes = ClienteService.list_clientes();
            if (dtClientes != null && dtClientes.Rows.Count > 0)
            {
                cmbCliente.DataSource = dtClientes;
                cmbCliente.ValueMember = "DNI";
                cmbCliente.DisplayMember = "Apellido";
            }

            DataTable dtProductos = ProductoService.ObtenerProductosBD();
            if (dtProductos != null && dtProductos.Rows.Count > 0)
            {
                cmbProducto.DataSource = dtProductos;
                cmbProducto.ValueMember = "Codigo";
                cmbProducto.DisplayMember = "Descripcion";
            }

            LimpiarForm();
        }

        private void ActualizarPrecioYTotal()
        {
            if (cmbProducto.SelectedIndex != -1 && cmbProducto.SelectedItem != null)
            {
                DataRowView rowSelected = (DataRowView)cmbProducto.SelectedItem;
                if (rowSelected != null)
                {
                    decimal precio = Convert.ToDecimal(rowSelected["Precio"]);
                    txtPrecio.Text = precio.ToString("0.00");

                    decimal cantidad = nupCantidad.Value;
                    decimal total = precio * cantidad;
                    txtTotal.Text = total.ToString("0.00");
                }
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                string dniCliente = cmbCliente.SelectedValue.ToString();
                DateTime fecha = dateTimePicker1.Value;
                string codigoProducto = cmbProducto.SelectedValue.ToString();
                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                decimal cantidad = nupCantidad.Value;
                decimal total = Convert.ToDecimal(txtTotal.Text);

                DialogResult confirm = MessageBox.Show(
                    "¿Está seguro que desea confirmar y registrar esta venta?",
                    "Confirmación de Compra",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    bool success = VentaService.RegistrarVenta(dniCliente, fecha, codigoProducto, precio, cantidad, total);

                    if (success)
                    {
                        MessageBox.Show("Venta registrada y guardada con éxito en la base de datos!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidarCampos()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox && string.IsNullOrWhiteSpace(c.Text))
                {
                    MessageBox.Show("Complete todos los campos de texto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    c.Focus();
                    return false;
                }
            }

            if (cmbCliente.SelectedIndex == -1 || cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCliente.Focus();
                return false;
            }

            if (cmbProducto.SelectedIndex == -1 || cmbProducto.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProducto.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarForm()
        {
            cmbCliente.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;
            nupCantidad.Value = 1;
            txtPrecio.Clear();
            txtTotal.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea cancelar la operación?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
                this.Close();
        }


        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            ActualizarPrecioYTotal();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ActualizarPrecioYTotal();
        }

    }
}