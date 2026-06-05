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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            txtContrasenia.UseSystemPasswordChar = true;
            picMostrarPassword.Image = Properties.Resources.ojo_abierto;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text.Trim();
            string contrasenia = txtContrasenia.Text.Trim();

            Usuario usuarioLogueado =
                UsuarioService.ValidarLogin(nombreUsuario, contrasenia);

            if (usuarioLogueado != null)
            {
                MessageBox.Show(
                    "Bienvenido: " + usuarioLogueado.Usu_ApellidoNombre,
                    "Ingreso Correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Principal frmPrincipal = new Principal(usuarioLogueado);

                this.Hide();
                frmPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsuario.Clear();
                txtContrasenia.Clear();
                txtUsuario.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir de la aplicación?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
                Application.Exit();
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

        private void picMostrarPassword_Click(object sender, EventArgs e)
        {
            txtContrasenia.UseSystemPasswordChar = !txtContrasenia.UseSystemPasswordChar;
            if (txtContrasenia.UseSystemPasswordChar)
                picMostrarPassword.Image = Properties.Resources.ojo_abierto;
            else
                picMostrarPassword.Image = Properties.Resources.ojo_cerrado;
        }

    }
}