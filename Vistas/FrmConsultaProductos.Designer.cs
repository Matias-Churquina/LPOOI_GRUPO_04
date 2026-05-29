namespace Vistas
{
    partial class FrmConsultaProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPorDescripcion = new System.Windows.Forms.RadioButton();
            this.btnPorCategoria = new System.Windows.Forms.RadioButton();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.opticaDataSet = new Vistas.opticaDataSet();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new Vistas.opticaDataSetTableAdapters.ProductoTableAdapter();
            this.prodCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPrecioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orden = new System.Windows.Forms.GroupBox();
            this.btnListarProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opticaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.Orden.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPorDescripcion
            // 
            this.btnPorDescripcion.AutoSize = true;
            this.btnPorDescripcion.Checked = true;
            this.btnPorDescripcion.Location = new System.Drawing.Point(6, 19);
            this.btnPorDescripcion.Name = "btnPorDescripcion";
            this.btnPorDescripcion.Size = new System.Drawing.Size(103, 17);
            this.btnPorDescripcion.TabIndex = 0;
            this.btnPorDescripcion.TabStop = true;
            this.btnPorDescripcion.Text = "Por Descripcion:";
            this.btnPorDescripcion.UseVisualStyleBackColor = true;
            // 
            // btnPorCategoria
            // 
            this.btnPorCategoria.AutoSize = true;
            this.btnPorCategoria.Location = new System.Drawing.Point(6, 51);
            this.btnPorCategoria.Name = "btnPorCategoria";
            this.btnPorCategoria.Size = new System.Drawing.Size(92, 17);
            this.btnPorCategoria.TabIndex = 1;
            this.btnPorCategoria.TabStop = true;
            this.btnPorCategoria.Text = "Por Categorìa:";
            this.btnPorCategoria.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoGenerateColumns = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodCodigoDataGridViewTextBoxColumn,
            this.prodCategoriaDataGridViewTextBoxColumn,
            this.prodDescripcionDataGridViewTextBoxColumn,
            this.prodPrecioDataGridViewTextBoxColumn});
            this.dgvProductos.DataSource = this.productoBindingSource;
            this.dgvProductos.Location = new System.Drawing.Point(12, 12);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(443, 416);
            this.dgvProductos.TabIndex = 2;
            // 
            // opticaDataSet
            // 
            this.opticaDataSet.DataSetName = "opticaDataSet";
            this.opticaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.opticaDataSet;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // prodCodigoDataGridViewTextBoxColumn
            // 
            this.prodCodigoDataGridViewTextBoxColumn.DataPropertyName = "Prod_Codigo";
            this.prodCodigoDataGridViewTextBoxColumn.HeaderText = "Prod_Codigo";
            this.prodCodigoDataGridViewTextBoxColumn.Name = "prodCodigoDataGridViewTextBoxColumn";
            // 
            // prodCategoriaDataGridViewTextBoxColumn
            // 
            this.prodCategoriaDataGridViewTextBoxColumn.DataPropertyName = "Prod_Categoria";
            this.prodCategoriaDataGridViewTextBoxColumn.HeaderText = "Prod_Categoria";
            this.prodCategoriaDataGridViewTextBoxColumn.Name = "prodCategoriaDataGridViewTextBoxColumn";
            // 
            // prodDescripcionDataGridViewTextBoxColumn
            // 
            this.prodDescripcionDataGridViewTextBoxColumn.DataPropertyName = "Prod_Descripcion";
            this.prodDescripcionDataGridViewTextBoxColumn.HeaderText = "Prod_Descripcion";
            this.prodDescripcionDataGridViewTextBoxColumn.Name = "prodDescripcionDataGridViewTextBoxColumn";
            // 
            // prodPrecioDataGridViewTextBoxColumn
            // 
            this.prodPrecioDataGridViewTextBoxColumn.DataPropertyName = "Prod_Precio";
            this.prodPrecioDataGridViewTextBoxColumn.HeaderText = "Prod_Precio";
            this.prodPrecioDataGridViewTextBoxColumn.Name = "prodPrecioDataGridViewTextBoxColumn";
            // 
            // Orden
            // 
            this.Orden.Controls.Add(this.btnListarProductos);
            this.Orden.Controls.Add(this.btnPorDescripcion);
            this.Orden.Controls.Add(this.btnPorCategoria);
            this.Orden.Location = new System.Drawing.Point(12, 438);
            this.Orden.Name = "Orden";
            this.Orden.Size = new System.Drawing.Size(286, 81);
            this.Orden.TabIndex = 3;
            this.Orden.TabStop = false;
            this.Orden.Text = "Orden:";
            // 
            // btnListarProductos
            // 
            this.btnListarProductos.Location = new System.Drawing.Point(174, 45);
            this.btnListarProductos.Name = "btnListarProductos";
            this.btnListarProductos.Size = new System.Drawing.Size(94, 23);
            this.btnListarProductos.TabIndex = 2;
            this.btnListarProductos.Text = "Listar Productos";
            this.btnListarProductos.UseVisualStyleBackColor = true;
            this.btnListarProductos.Click += new System.EventHandler(this.btnListarProductos_Click);
            // 
            // FrmConsultaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 531);
            this.Controls.Add(this.Orden);
            this.Controls.Add(this.dgvProductos);
            this.Name = "FrmConsultaProductos";
            this.Text = "FrmConsultaProductos";
            this.Load += new System.EventHandler(this.FrmConsultaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opticaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.Orden.ResumeLayout(false);
            this.Orden.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton btnPorDescripcion;
        private System.Windows.Forms.RadioButton btnPorCategoria;
        private System.Windows.Forms.DataGridView dgvProductos;
        private opticaDataSet opticaDataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private opticaDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPrecioDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox Orden;
        private System.Windows.Forms.Button btnListarProductos;
    }
}