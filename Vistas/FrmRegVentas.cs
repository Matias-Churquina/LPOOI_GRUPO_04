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
            if (comboBox2.SelectedValue != null && comboBox2.DataSource != null)
            {
                DataRowView rowSelected = (DataRowView)comboBox2.SelectedItem;
                if (rowSelected != null)
                {
                    decimal precio = Convert.ToDecimal(rowSelected["Precio"]);
                    textBox1.Text = precio.ToString("0.00");

                    decimal cantidad = numericUpDown1.Value;
                    decimal total = precio * cantidad;
                    textBox2.Text = total.ToString("0.00");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox2.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un producto.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dniCliente = comboBox1.SelectedValue.ToString();
            DateTime fecha = dateTimePicker1.Value;
            string codigoProducto = comboBox2.SelectedValue.ToString();
            decimal precio = Convert.ToDecimal(textBox1.Text);
            decimal cantidad = numericUpDown1.Value;
            decimal total = Convert.ToDecimal(textBox2.Text);

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

        private void FrmRegVentas_Load_1(object sender, EventArgs e)
        {
            DataTable dtClientes = ClienteService.ObtenerClientes();
            if (dtClientes != null && dtClientes.Rows.Count > 0)
            {
                comboBox1.DataSource = dtClientes;
                comboBox1.ValueMember = "DNI";
                comboBox1.DisplayMember = "Apellido";
            }

            DataTable dtProductos = ProductoService.ObtenerProductosBD();
            if (dtProductos != null && dtProductos.Rows.Count > 0)
            {
                comboBox2.DataSource = dtProductos;
                comboBox2.ValueMember = "Codigo";
                comboBox2.DisplayMember = "Descripcion";
            }

            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 1000;
            numericUpDown1.Value = 1;

            ActualizarPrecioYTotal();
        }
    }
}
