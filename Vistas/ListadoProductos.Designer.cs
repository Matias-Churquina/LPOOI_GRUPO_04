namespace Vistas
{
    partial class ListadoProductos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.grpFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(18, 218);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(1140, 463);
            this.dgvVentas.TabIndex = 1;
            // 
            // grpFiltros
            // 
            this.grpFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFiltros.Controls.Add(this.button2);
            this.grpFiltros.Controls.Add(this.radioButton2);
            this.grpFiltros.Controls.Add(this.radioButton1);
            this.grpFiltros.Controls.Add(this.button1);
            this.grpFiltros.Controls.Add(this.dtpHasta);
            this.grpFiltros.Controls.Add(this.lblHasta);
            this.grpFiltros.Controls.Add(this.dtpDesde);
            this.grpFiltros.Controls.Add(this.lblDesde);
            this.grpFiltros.Controls.Add(this.cmbClientes);
            this.grpFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltros.Location = new System.Drawing.Point(18, 18);
            this.grpFiltros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFiltros.Size = new System.Drawing.Size(1140, 175);
            this.grpFiltros.TabIndex = 0;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = " Filtros de Busqueda ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(975, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 46);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(30, 114);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(258, 29);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Filtrar por Rango de Fechas:";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(30, 47);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(176, 29);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Filtrar por Cliente:";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(975, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Enabled = false;
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(675, 111);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(178, 31);
            this.dtpHasta.TabIndex = 6;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Enabled = false;
            this.lblHasta.Location = new System.Drawing.Point(606, 117);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(61, 25);
            this.lblHasta.TabIndex = 5;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Enabled = false;
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(402, 111);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(178, 31);
            this.dtpDesde.TabIndex = 4;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Enabled = false;
            this.lblDesde.Location = new System.Drawing.Point(330, 117);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(66, 25);
            this.lblDesde.TabIndex = 3;
            this.lblDesde.Text = "Desde:";
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.Enabled = false;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(330, 43);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(523, 33);
            this.cmbClientes.TabIndex = 1;
            // 
            // ListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1176, 709);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.dgvVentas);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1189, 739);
            this.Name = "ListadoProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Productos Vendidos";
            this.Load += new System.EventHandler(this.ListadoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button2;
    }
}
