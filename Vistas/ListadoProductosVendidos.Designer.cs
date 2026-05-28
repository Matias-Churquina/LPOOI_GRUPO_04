namespace Vistas
{
    partial class ListadoProductosVendidos
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
            this.dgwListadoProductosVendidos = new System.Windows.Forms.DataGridView();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListadoProductosVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwListadoProductosVendidos
            // 
            this.dgwListadoProductosVendidos.AllowUserToAddRows = false;
            this.dgwListadoProductosVendidos.AllowUserToDeleteRows = false;
            this.dgwListadoProductosVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListadoProductosVendidos.Location = new System.Drawing.Point(258, 71);
            this.dgwListadoProductosVendidos.Name = "dgwListadoProductosVendidos";
            this.dgwListadoProductosVendidos.ReadOnly = true;
            this.dgwListadoProductosVendidos.RowTemplate.Height = 24;
            this.dgwListadoProductosVendidos.Size = new System.Drawing.Size(776, 361);
            this.dgwListadoProductosVendidos.TabIndex = 0;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(48, 71);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(183, 24);
            this.cmbCliente.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(135, 123);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 27);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ListadoProductosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 514);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.dgwListadoProductosVendidos);
            this.Name = "ListadoProductosVendidos";
            this.Text = "ProductosVendidos";
            this.Load += new System.EventHandler(this.ListadoProductosVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListadoProductosVendidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwListadoProductosVendidos;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Button btnBuscar;
    }
}