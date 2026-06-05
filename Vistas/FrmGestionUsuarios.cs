using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClasesBase;
using ClasesBase.Service;
using ClasesBase.Entity;
using System.Data.SqlClient;

namespace Vistas
{
    public partial class FrmGestionUsuarios : Form
    {
        private int idUsuarioSeleccionado = 0;

        public FrmGestionUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            load_combo_roles();
            load_usuarios();
        }

        private void load_combo_roles()
        {
            cmbRoles.DisplayMember = "rol_descripcion";
            cmbRoles.ValueMember = "rol_codigo";
            cmbRoles.DataSource = UsuarioService.list_roles();
            cmbRoles.SelectedIndex = -1; 
        }

        private void load_usuarios()
        {
            dgwUsuarios.Columns.Clear();
            dgwUsuarios.AutoGenerateColumns = true;
            dgwUsuarios.DataSource = UsuarioService.list_usuarios();
        }

        private void LimpiarCajasEdicion()
        {
            idUsuarioSeleccionado = 0;
            txtNomUsuario.Clear();
            txtContrasenia.Clear();
            txtNombreCompleto.Clear();
            cmbRoles.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBusqueda.Text.Trim();

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                dgwUsuarios.DataSource = UsuarioService.search_usuarios(filtro);
            }
            else
            {
                MessageBox.Show("Debe ingresar texto a buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomUsuario.Text))
            {
                MessageBox.Show("Seleccione un usuario de la lista para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea modificar los datos de este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (!ValidarCampos()) return;

                Usuario user = new Usuario()
                {
                    Usu_ID = idUsuarioSeleccionado,
                    Usu_NombreUsuario = txtNomUsuario.Text.Trim(),
                    Usu_Contrasenia = txtContrasenia.Text.Trim(),
                    Usu_ApellidoNombre = txtNombreCompleto.Text.Trim(),
                    Usu_Rol = (int)cmbRoles.SelectedValue
                };

                UsuarioService.update_usuario(user);

                load_usuarios();
                LimpiarCajasEdicion();
            }
        }

        private bool ValidarCampos()
        {
            List<TextBox> camposEdicion = new List<TextBox>() { 
                txtNomUsuario, txtContrasenia, txtNombreCompleto 
            };

            foreach (TextBox txt in camposEdicion)
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    MessageBox.Show("Complete todos los campos de edición.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt.Focus();
                    return false;
                }
            }

            if (cmbRoles.SelectedIndex == -1 || cmbRoles.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un rol para el usuario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRoles.Focus();
                return false;
            }

            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomUsuario.Text))
            {
                MessageBox.Show("Seleccione un usuario de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro que desea ELIMINAR a este usuario? Esta acción no se puede deshacer.", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                UsuarioService.delete_usuario(idUsuarioSeleccionado);

                load_usuarios();
                LimpiarCajasEdicion();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            load_usuarios();
            LimpiarCajasEdicion();
        }

        private void dgwUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwUsuarios.CurrentRow != null && dgwUsuarios.CurrentRow.Cells["Usuario"].Value != null)
            {
                txtNomUsuario.Text = dgwUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                txtContrasenia.Text = dgwUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                txtNombreCompleto.Text = dgwUsuarios.CurrentRow.Cells["Apellido y Nombre"].Value.ToString();

                // Descomenté y ajusté tu lógica del Rol para que se asigne automáticamente en el combo
                if (dgwUsuarios.CurrentRow.Cells["Rol"].Value != null)
                {
                    cmbRoles.SelectedValue = dgwUsuarios.CurrentRow.Cells["Rol"].Value;
                }
            }
        }

        private void dgwUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgwUsuarios.Rows[e.RowIndex].Cells["Usuario"].Value != null)
            {
                DataGridViewRow filaActual = dgwUsuarios.Rows[e.RowIndex];

                idUsuarioSeleccionado = Convert.ToInt32(filaActual.Cells["Codigo"].Value);

                txtNomUsuario.Text = filaActual.Cells["Usuario"].Value.ToString();
                txtContrasenia.Text = filaActual.Cells["Contraseña"].Value.ToString();
                txtNombreCompleto.Text = filaActual.Cells["Apellido y Nombre"].Value.ToString();

                if (filaActual.Cells["Rol"].Value != null)
                {
                    string nombreRol = filaActual.Cells["Rol"].Value.ToString();
                    cmbRoles.SelectedIndex = cmbRoles.FindStringExact(nombreRol);
                }
            }

        }
    }
}