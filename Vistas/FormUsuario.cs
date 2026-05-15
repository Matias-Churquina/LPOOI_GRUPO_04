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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
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
            comboRoles.DisplayMember = "rol_descripcion";
            comboRoles.ValueMember = "rol_codigo";
            comboRoles.DataSource = UsuarioService.list_roles();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();

            user.Usu_NombreUsuario = textNombreUsu.Text;
            user.Usu_Contrasenia = textPass.Text;
            user.Usu_ApellidoNombre = textNombAp.Text;
            if (comboRoles.SelectedValue != null && Convert.ToInt32(comboRoles.SelectedValue) > 0)
            {
                user.Usu_Rol = Convert.ToInt32(comboRoles.SelectedValue);
                UsuarioService.insert_usuario(user);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rol");
            }
            UsuarioService.insert_usuario(user);
            load_usuarios();
        }

        private void load_usuarios()
        {
            dgtUsuarios.DataSource = UsuarioService.list_usuarios();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (textPattern.Text != "")
            {
                dgtUsuarios.DataSource = UsuarioService.search_usuarios(textPattern.Text);
            }
            else
            {
                load_usuarios();
            }
        }

        private void dgtUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgtUsuarios.CurrentRow != null)
            {
                //comboRoles.SelectedValue = dgtUsuarios.CurrentRow.Cells["Rol"].Value.ToString();
                textNombreUsu.Text = dgtUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                textPass.Text = dgtUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                textNombAp.Text = dgtUsuarios.CurrentRow.Cells["Apellido y Nombre"].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();

            user.Usu_NombreUsuario = textNombreUsu.Text;
            user.Usu_Contrasenia = textPass.Text;
            user.Usu_ApellidoNombre = textNombAp.Text;
            user.Usu_Rol = (int)comboRoles.SelectedValue;

            UsuarioService.update_usuario(user);

            dgtUsuarios.DataSource = UsuarioService.list_usuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgtUsuarios.CurrentRow != null)
            {
                string nombreApellido =
                    dgtUsuarios.CurrentRow.Cells["Apellido y Nombre"].Value.ToString();

                DialogResult resultado = MessageBox.Show(
                    "¿Desea eliminar este usuario?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    UsuarioService.delete_usuario(nombreApellido);

                    dgtUsuarios.DataSource = UsuarioService.list_usuarios();
                }
            }
        }

    }
}
