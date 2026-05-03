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
    public partial class AltaProducto : Form
    {
        public AltaProducto()
        {
            InitializeComponent();
        }

        private void btnAltaProductos_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            float precio;
            if (!float.TryParse(txtProdPrecio.Text.Trim(), out precio))
            {
                MessageBox.Show(
                    "Ingrese un precio válido.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtProdPrecio.Focus();
                return;
            }

            try
            {
                Producto nuevoProducto = new Producto()
                {
                    Prod_Codigo = txtProdCodigo.Text.Trim(),
                    Prod_Categoria = txtProdCategoria.Text.Trim(),
                    Prod_Descripcion = txtProdDescripcion.Text.Trim(),
                    Prod_Precio = precio
                };

                DialogResult respuesta = MessageBox.Show("¿Desea guardar el producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    ProductoService.AgregarProducto(nuevoProducto);

                    MessageBox.Show("Producto registrado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private bool ValidarCampos()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox &&
                    string.IsNullOrWhiteSpace(control.Text))
                {
                    MessageBox.Show(
                        "Complete todos los campos.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    control.Focus();
                    return false;
                }
            }

            return true;
        }
        private void LimpiarForm()
        {
            txtProdCodigo.Clear();
            txtProdCategoria.Clear();
            txtProdDescripcion.Clear();
            txtProdPrecio.Clear();
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

        private void Botones_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Black;
            btn.ForeColor = Color.White;
        }

        private void Botones_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = SystemColors.Control;
            btn.ForeColor = Color.Black;
        }

        private void AltaProductos_Load(object sender, System.EventArgs e)
        {

        }
    }
}
