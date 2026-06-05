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
    public partial class AltaUsuario : Form
    {
        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            load_combo_roles();
        }

        private void load_combo_roles()
        {
            cmbRoles.DisplayMember = "rol_descripcion";
            cmbRoles.ValueMember = "rol_codigo";
            cmbRoles.DataSource = UsuarioService.list_roles();
            cmbRoles.SelectedIndex = -1;
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                Usuario nuevo = new Usuario()
                {
                    Usu_NombreUsuario = txtNomUsuario.Text.Trim(),
                    Usu_Contrasenia = txtContrasenia.Text.Trim(),
                    Usu_ApellidoNombre = txtNombreCompleto.Text.Trim(),
                    Usu_Rol = (int)cmbRoles.SelectedValue
                };

                DialogResult respuesta = MessageBox.Show("¿Desea guardar el usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    UsuarioService.insert_usuario(nuevo);
                    MessageBox.Show("Usuario registrado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomUsuario.Clear();
                txtNomUsuario.Focus();
            }
        }

        private bool ValidarCampos()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox && string.IsNullOrWhiteSpace(c.Text))
                {
                    MessageBox.Show("Complete todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    c.Focus();
                    return false;
                }
            }

            if (cmbRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un rol para el usuario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRoles.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarForm()
        {
            txtNomUsuario.Clear();
            txtContrasenia.Clear();
            txtNombreCompleto.Clear();
            cmbRoles.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea cancelar la operación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                this.Close();
        }


    }
}