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
            btnConsularCliente.Enabled = true;

            btnAltaProductos.Enabled = true;
            btnGestionDeProductos.Enabled = true;
            btnListadoProductos.Enabled = true;
            btnConsultarProductos.Enabled = true;

            btnAltaObrasSociales.Enabled = true;
            btnListadoObrasSociales.Enabled = true;

            btnAltaUsuario.Enabled = true;
            btnGestionUsuarios.Enabled = true;

            btnRegistrarVentas.Enabled = true;
            btnListadoVentas.Enabled = true;


            switch (RolService.getDescripcion(usuarioLogueado.Usu_Rol))
            {
                case "Administrador":
                    btnAltaCliente.Enabled = false;
                    btnGestionClientes.Enabled = false;
                    btnConsularCliente.Enabled = false;

                    btnAltaObrasSociales.Enabled = false;
                    btnListadoObrasSociales.Enabled = false;

                    btnRegistrarVentas.Enabled = false;
                    btnListadoVentas.Enabled = false;
                    break;

                case "Operador":
                    btnAltaProductos.Enabled = false;
                    btnGestionDeProductos.Enabled = false;
                    btnListadoProductos.Enabled = false;
                    btnConsultarProductos.Enabled = false;

                    btnAltaObrasSociales.Enabled = false;
                    btnListadoObrasSociales.Enabled = false;

                    btnAltaUsuario.Enabled = false;
                    btnGestionUsuarios.Enabled = false;
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
            FrmGestionUsuarios frm = new FrmGestionUsuarios();
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

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            AltaUsuario frm = new AltaUsuario();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            FrmGestionUsuarios frm = new FrmGestionUsuarios();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnListadoObrasSociales_Click(object sender, EventArgs e)
        {
            ListadoObrasSociales frm = new ListadoObrasSociales();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
