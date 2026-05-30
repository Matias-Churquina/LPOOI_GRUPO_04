namespace Vistas
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAltaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGestionClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAltaProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProductosVendidos = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuObrasSociales = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAltaObrasSociales = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listadoDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 13F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSistema,
            this.mnuClientes,
            this.mnuProductos,
            this.mnuObrasSociales,
            this.usuariosToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.mnuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1142, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSistema
            // 
            this.mnuSistema.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.mnuSistema.Name = "mnuSistema";
            this.mnuSistema.Size = new System.Drawing.Size(119, 39);
            this.mnuSistema.Text = "Sistema";
            // 
            // mnuClientes
            // 
            this.mnuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAltaCliente,
            this.btnGestionClientes,
            this.consultarClientesToolStripMenuItem});
            this.mnuClientes.Font = new System.Drawing.Font("Calibri", 14F);
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Size = new System.Drawing.Size(117, 39);
            this.mnuClientes.Text = "Clientes";
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(298, 40);
            this.btnAltaCliente.Text = "Alta";
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // btnGestionClientes
            // 
            this.btnGestionClientes.Name = "btnGestionClientes";
            this.btnGestionClientes.Size = new System.Drawing.Size(298, 40);
            this.btnGestionClientes.Text = "Gestionar Clientes";
            this.btnGestionClientes.Click += new System.EventHandler(this.btnGestionClientes_Click);
            // 
            // consultarClientesToolStripMenuItem
            // 
            this.consultarClientesToolStripMenuItem.Name = "consultarClientesToolStripMenuItem";
            this.consultarClientesToolStripMenuItem.Size = new System.Drawing.Size(298, 40);
            this.consultarClientesToolStripMenuItem.Text = "Consultar Clientes";
            this.consultarClientesToolStripMenuItem.Click += new System.EventHandler(this.consultarClientesToolStripMenuItem_Click);
            // 
            // mnuProductos
            // 
            this.mnuProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnuProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAltaProductos,
            this.btnProductosVendidos,
            this.consultarProductosToolStripMenuItem,
            this.listadoDeProductosToolStripMenuItem});
            this.mnuProductos.Font = new System.Drawing.Font("Calibri", 14F);
            this.mnuProductos.Name = "mnuProductos";
            this.mnuProductos.Size = new System.Drawing.Size(143, 39);
            this.mnuProductos.Text = "Productos";
            // 
            // btnAltaProductos
            // 
            this.btnAltaProductos.Name = "btnAltaProductos";
            this.btnAltaProductos.Size = new System.Drawing.Size(328, 40);
            this.btnAltaProductos.Text = "Alta";
            this.btnAltaProductos.Click += new System.EventHandler(this.btnAltaProductos_Click);
            // 
            // btnProductosVendidos
            // 
            this.btnProductosVendidos.Name = "btnProductosVendidos";
            this.btnProductosVendidos.Size = new System.Drawing.Size(328, 40);
            this.btnProductosVendidos.Text = "Vendidos";
            this.btnProductosVendidos.Click += new System.EventHandler(this.btnProductosVendidos_Click);
            // 
            // consultarProductosToolStripMenuItem
            // 
            this.consultarProductosToolStripMenuItem.Name = "consultarProductosToolStripMenuItem";
            this.consultarProductosToolStripMenuItem.Size = new System.Drawing.Size(328, 40);
            this.consultarProductosToolStripMenuItem.Text = "Consultar Productos";
            this.consultarProductosToolStripMenuItem.Click += new System.EventHandler(this.consultarProductosToolStripMenuItem_Click);
            // 
            // mnuObrasSociales
            // 
            this.mnuObrasSociales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnuObrasSociales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAltaObrasSociales});
            this.mnuObrasSociales.Font = new System.Drawing.Font("Calibri", 14F);
            this.mnuObrasSociales.Name = "mnuObrasSociales";
            this.mnuObrasSociales.Size = new System.Drawing.Size(190, 39);
            this.mnuObrasSociales.Text = "Obras Sociales";
            // 
            // btnAltaObrasSociales
            // 
            this.btnAltaObrasSociales.Name = "btnAltaObrasSociales";
            this.btnAltaObrasSociales.Size = new System.Drawing.Size(134, 40);
            this.btnAltaObrasSociales.Text = "Alta";
            this.btnAltaObrasSociales.Click += new System.EventHandler(this.btnAltaObrasSociales_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsuarios});
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 14F);
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(126, 39);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(236, 40);
            this.btnUsuarios.Text = "Op. Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regVentasToolStripMenuItem,
            this.listadoDeVentasToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(99, 39);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // regVentasToolStripMenuItem
            // 
            this.regVentasToolStripMenuItem.Name = "regVentasToolStripMenuItem";
            this.regVentasToolStripMenuItem.Size = new System.Drawing.Size(277, 36);
            this.regVentasToolStripMenuItem.Text = "Reg. Ventas";
            this.regVentasToolStripMenuItem.Click += new System.EventHandler(this.regVentasToolStripMenuItem_Click);
            // 
            // listadoDeVentasToolStripMenuItem
            // 
            this.listadoDeVentasToolStripMenuItem.Name = "listadoDeVentasToolStripMenuItem";
            this.listadoDeVentasToolStripMenuItem.Size = new System.Drawing.Size(277, 36);
            this.listadoDeVentasToolStripMenuItem.Text = "Listado de Ventas";
            this.listadoDeVentasToolStripMenuItem.Click += new System.EventHandler(this.listadoDeVentasToolStripMenuItem_Click);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(72, 39);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(956, 465);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(97, 32);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(956, 505);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(48, 32);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "Rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(848, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(848, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rol:";
            // 
            // listadoDeProductosToolStripMenuItem
            // 
            this.listadoDeProductosToolStripMenuItem.Name = "listadoDeProductosToolStripMenuItem";
            this.listadoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(328, 40);
            this.listadoDeProductosToolStripMenuItem.Text = "Listado de Productos";
            this.listadoDeProductosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProductosToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 558);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSistema;
        private System.Windows.Forms.ToolStripMenuItem mnuClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuObrasSociales;
        private System.Windows.Forms.ToolStripMenuItem btnAltaCliente;
        private System.Windows.Forms.ToolStripMenuItem btnAltaProductos;
        private System.Windows.Forms.ToolStripMenuItem btnAltaObrasSociales;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnUsuarios;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnGestionClientes;
        private System.Windows.Forms.ToolStripMenuItem btnProductosVendidos;
        private System.Windows.Forms.ToolStripMenuItem consultarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProductosToolStripMenuItem;
    }
}

