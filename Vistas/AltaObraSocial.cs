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
    public partial class AltaObraSocial : Form
    {
        public AltaObraSocial()
        {
            InitializeComponent();
        }

        private void btnAltaObrasSociales_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            if (ObraSocialService.ExisteOSocial(txtOSCuit.Text.Trim()))
            {
                MessageBox.Show(
                    "Ya existe una Obra Social con este CUIT.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtOSCuit.Focus();
                return;
            }

            ObraSocial nuevaObraSocial = new ObraSocial()
            {
                OS_CUIT = txtOSCuit.Text.Trim(),
                OS_RazonSocial = txtOSRazonSocial.Text.Trim(),
                OS_Direccion = txtOSDireccion.Text.Trim(),
                OS_Telefono = txtOSTelefono.Text.Trim()
            };

            DialogResult respuesta = MessageBox.Show(
                "¿Desea guardar la obra social?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                ObraSocialService.AgregarOSocial(nuevaObraSocial);

                MessageBox.Show(
                    "Obra social registrada correctamente.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
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

        private void AltaObrasSociales_Load(object sender, System.EventArgs e)
        {

        }
    }
}
