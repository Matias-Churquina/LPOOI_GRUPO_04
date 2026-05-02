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
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            if (ClienteService.ExisteCliente(txtClienteDNI.Text.Trim()))
            {
                MessageBox.Show(
                    "Ya existe un cliente con ese DNI.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtClienteDNI.Focus();
                return;
            }

            Cliente nuevo = new Cliente()
            {
                Cli_DNI = txtClienteDNI.Text.Trim(),
                Cli_Apellido = txtClienteApellido.Text.Trim(),
                Cli_Nombre = txtClienteNombre.Text.Trim(),
                Cli_Direccion = txtClienteDireccion.Text.Trim(),
                OS_CUIT = txtClienteOS.Text,
                Cli_NroCarnet = txtClienteNroCarnet.Text.Trim()
            };

            DialogResult respuesta = MessageBox.Show(
                "¿Desea guardar el cliente?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                ClienteService.AgregarCliente(nuevo);

                MessageBox.Show(
                    "Cliente registrado correctamente.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
        }

        private bool ValidarCampos()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox && string.IsNullOrWhiteSpace(c.Text))
                {
                    MessageBox.Show(
                        "Complete todos los campos.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    c.Focus();
                    return false;
                }
            }

            return true;
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

        private void AltaCliente_Load(object sender, System.EventArgs e)
        {

        }
    }
}