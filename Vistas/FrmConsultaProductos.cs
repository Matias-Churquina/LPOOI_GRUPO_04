using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase.Service;

namespace Vistas
{
    public partial class FrmConsultaProductos : Form
    {
        public FrmConsultaProductos()
        {
            InitializeComponent();
        }

        private void FrmConsultaProductos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'opticaDataSet.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.opticaDataSet.Producto);

        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            // 1. Verificamos cuál RadioButton está seleccionado
            string criterio = "";

            if (btnPorCategoria.Checked == true)
            {
                criterio = "Categoria";
            }
            else if (btnPorDescripcion.Checked == true)
            {
                criterio = "Descripcion";
            }

            // 2. Llamamos al servicio pasando el criterio y llenamos la grilla
            try
            {
                dgvProductos.DataSource = ProductoService.ObtenerProductosOrdenados(criterio);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
