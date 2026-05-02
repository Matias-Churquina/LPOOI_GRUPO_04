using System;
using System.Drawing;
using System.Windows.Forms;
using ClasesBase.Entity;

namespace Vistas
{
    public partial class Principal : Form
    {
        private Usuario usuarioLogueado;

        public Principal(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuarioLogueado.Usu_ApellidoNombre;
            lblRol.Text = usuarioLogueado.Rol.Rol_Descripcion;

            AsignarPermisos();
        }

        private void AsignarPermisos()
        {
            switch (usuarioLogueado.Rol.Rol_Descripcion)
            {
                case "Administrador":
                    break;

                case "Operador":
                    btnAltaObrasSociales.Enabled = false;
                    break;

                case "Auditor":
                    btnAltaCliente.Enabled = false;
                    btnAltaProductos.Enabled = false;
                    btnAltaObrasSociales.Enabled = false;
                    break;
            }
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            AltaCliente frm = new AltaCliente();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnAltaProductos_Click(object sender, EventArgs e)
        {
            AltaProducto frm = new AltaProducto();
            
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnAltaObrasSociales_Click(object sender, EventArgs e)
        {
            AltaObraSocial frm = new AltaObraSocial();
            
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
