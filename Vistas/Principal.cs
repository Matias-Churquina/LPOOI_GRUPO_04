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
            mnuClientes.Enabled = true;
            btnAltaCliente.Enabled = true;
            btnGestionClientes.Enabled = true;
            mnuProductos.Enabled = true;
            btnAltaProductos.Enabled = true;
            mnuObrasSociales.Enabled = true;
            btnAltaObrasSociales.Enabled = true;
            usuariosToolStripMenuItem.Enabled = true;
            btnUsuarios.Enabled = true;
            ventasToolStripMenuItem.Enabled = true;
            regVentasToolStripMenuItem.Enabled = true;
            listadoDeVentasToolStripMenuItem.Enabled = true;

            switch (RolService.getDescripcion(usuarioLogueado.Usu_Rol))
            {
                case "Administrador":
                    mnuClientes.Enabled = false;
                    btnAltaCliente.Enabled = false;
                    btnGestionClientes.Enabled = false;
                    mnuObrasSociales.Enabled = false;
                    btnAltaObrasSociales.Enabled = false;
                    ventasToolStripMenuItem.Enabled = false;
                    regVentasToolStripMenuItem.Enabled = false;
                    listadoDeVentasToolStripMenuItem.Enabled = false;
                    break;

                case "Operador":
                    mnuProductos.Enabled = false;
                    btnAltaProductos.Enabled = false;
                    usuariosToolStripMenuItem.Enabled = false;
                    btnUsuarios.Enabled = false;
                    break;

                case "Auditor":
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

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes) Application.Exit();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuario frm = new FormUsuario();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }


        private void regVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegVentas frm = new FrmRegVentas();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            FrmGestionClientes frm = new FrmGestionClientes();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void listadoDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoVentas frm = new ListadoVentas(); 
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnProductosVendidos_Click(object sender, EventArgs e)
        {
            ListadoProductosVendidos frm = new ListadoProductosVendidos();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        

        private void consultarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaProductos frm = new FrmConsultaProductos();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaClientes frm = new FrmConsultaClientes();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoProductos frm = new ListadoProductos();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnGestionDeProductos_Click(object sender, EventArgs e)
        {
            FrmGestionProductos frm = new FrmGestionProductos();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
