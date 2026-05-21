using System;
using System.Drawing;
using System.Windows.Forms;
using ClasesBase.Entity;
using ClasesBase.Service;

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
            lblRol.Text = RolService.getDescripcion(usuarioLogueado.Usu_Rol);

            AsignarPermisos();
        }

        private void AsignarPermisos()
        {
            // Habilitar todo por defecto
            mnuClientes.Enabled = true;
            btnAltaCliente.Enabled = true;
            mnuProductos.Enabled = true;
            btnAltaProductos.Enabled = true;
            mnuObrasSociales.Enabled = true;
            btnAltaObrasSociales.Enabled = true;
            usuariosToolStripMenuItem.Enabled = true;
            btnUsuarios.Enabled = true;
            ventasToolStripMenuItem.Enabled = true;
            regVentasToolStripMenuItem.Enabled = true;

            switch (RolService.getDescripcion(usuarioLogueado.Usu_Rol))
            {
                case "Administrador":
                    // Acceso a Usuarios y Productos únicamente
                    mnuClientes.Enabled = false;
                    btnAltaCliente.Enabled = false;
                    mnuObrasSociales.Enabled = false;
                    btnAltaObrasSociales.Enabled = false;
                    ventasToolStripMenuItem.Enabled = false;
                    regVentasToolStripMenuItem.Enabled = false;
                    break;

                case "Operador":
                    // Acceso a Clientes y Ventas únicamente
                    mnuProductos.Enabled = false;
                    btnAltaProductos.Enabled = false;
                    usuariosToolStripMenuItem.Enabled = false;
                    btnUsuarios.Enabled = false;
                    break;

                case "Auditor":
                    // Sin restricciones (acceso completo a todo)
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



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnAltaObrasSociales_Click(object sender, EventArgs e)
        {
            AltaObraSocial frm = new AltaObraSocial();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes) Application.Exit();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuario frm = new FormUsuario();
            frm.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void regVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegVentas frm = new FrmRegVentas();
            frm.ShowDialog();
        }

    }
}
