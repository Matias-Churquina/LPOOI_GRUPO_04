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
    public partial class FrmGestionProductos : Form
    {
        public FrmGestionProductos()
        {
            InitializeComponent();
        }

        private void FrmGestionProductos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'opticaDataSet.Producto' table. You can move, or remove it, as needed.
            //this.productoTableAdapter.Fill(this.opticaDataSet.Producto);
           load_productos();
        }
        private void load_productos() {
            bindingSource1.DataSource = ProductoService.ObtenerProductosActivos();
            bindingNavigator1.BindingSource = bindingSource1;

            txtCodigo.DataBindings.Add("Text", bindingSource1, "Codigo", true);
            txtCategoria.DataBindings.Add("Text", bindingSource1, "Categoria", true);
            txtDescripcion.DataBindings.Add("Text", bindingSource1, "Descripcion", true);
            txtPrecio.DataBindings.Add("Text", bindingSource1, "Precio", true);

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = bindingSource1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.dataGridView1.EndEdit();
            this.bindingSource1.EndEdit();
            DataTable dt = (DataTable)bindingSource1.DataSource;
            dt.TableName = "Producto";

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            ProductoService.GuardarCambios(ds);
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;
            bindingSource1.DataSource = ProductoService.ObtenerProductosActivos();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
        
    }
}
