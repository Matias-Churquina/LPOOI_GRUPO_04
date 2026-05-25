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

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbProducto.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un producto.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dniCliente = cmbCliente.SelectedValue.ToString();
            DateTime fecha = dateTimePicker1.Value;
            string codigoProducto = cmbProducto.SelectedValue.ToString();
            decimal precio = Convert.ToDecimal(txtPrecio.Text);
            decimal cantidad = nupCantidad.Value;
            decimal total = Convert.ToDecimal(txtTotal.Text);

            DialogResult confirm = MessageBox.Show(
                "Esta seguro que desea confirmar y registrar esta venta?",
                "Confirmacion de Compra",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                bool success = VentaService.RegistrarVenta(dniCliente, fecha, codigoProducto, precio, cantidad, total);

                if (success)
                {
                    MessageBox.Show("Venta registrada y guardada con exito en la base de datos!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            ActualizarPrecioYTotal();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ActualizarPrecioYTotal();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FrmRegVentas_Load(object sender, EventArgs e)
        {
            nupCantidad.Minimum = 1;
            nupCantidad.Maximum = 1000;
            nupCantidad.Value = 1;

            DataTable dtClientes = ClienteService.ObtenerClientes();
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

            cmbCliente.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;

            txtPrecio.Text = "";
            txtTotal.Text = "";
        }
    }
}
