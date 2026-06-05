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
            this.btnConsularCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAltaProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGestionDeProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListadoProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultarProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuObrasSociales = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAltaObrasSociales = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListadoObrasSociales = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAltaUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGestionUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegistrarVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListadoVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.mnuUsuarios,
            this.mnuVentas,
            this.mnuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1015, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSistema
            // 
            this.mnuSistema.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.mnuSistema.Name = "mnuSistema";
            this.mnuSistema.Size = new System.Drawing.Size(104, 33);
            this.mnuSistema.Text = "Sistema";
            // 
            // mnuClientes
            // 
            this.mnuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAltaCliente,
            this.btnGestionClientes,
            this.btnConsularCliente});
            this.mnuClientes.Font = new System.Drawing.Font("Calibri", 14F);
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Size = new System.Drawing.Size(104, 33);
            this.mnuClientes.Text = "Clientes";
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(265, 34);
            this.btnAltaCliente.Text = "Alta de Cliente";
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // btnGestionClientes
            // 
            this.btnGestionClientes.Name = "btnGestionClientes";
            this.btnGestionClientes.Size = new System.Drawing.Size(265, 34);
            this.btnGestionClientes.Text = "Gestionar Clientes";
            this.btnGestionClientes.Click += new System.EventHandler(this.btnGestionClientes_Click);
            // 
            // btnConsularCliente
            // 
            this.btnConsularCliente.Name = "btnConsularCliente";
            this.btnConsularCliente.Size = new System.Drawing.Size(265, 34);
            this.btnConsularCliente.Text = "Consultar Clientes";
            this.btnConsularCliente.Click += new System.EventHandler(this.consultarClientesToolStripMenuItem_Click);
            // 
            // mnuProductos
            // 
            this.mnuProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnuProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAltaProductos,
            this.btnGestionDeProductos,
            this.btnListadoProductos,
            this.btnConsultarProductos});
            this.mnuProductos.Font = new System.Drawing.Font("Calibri", 14F);
            this.mnuProductos.Name = "mnuProductos";
            this.mnuProductos.Size = new System.Drawing.Size(124, 33);
            this.mnuProductos.Text = "Productos";
            // 
            // btnAltaProductos
            // 
            this.btnAltaProductos.Name = "btnAltaProductos";
            this.btnAltaProductos.Size = new System.Drawing.Size(291, 34);
            this.btnAltaProductos.Text = "Alta de Producto";
            this.btnAltaProductos.Click += new System.EventHandler(this.btnAltaProductos_Click);
            // 
            // btnGestionDeProductos
            // 
            this.btnGestionDeProductos.Name = "btnGestionDeProductos";
            this.btnGestionDeProductos.Size = new System.Drawing.Size(291, 34);
            this.btnGestionDeProductos.Text = "Gestionar Productos";
            this.btnGestionDeProductos.Click += new System.EventHandler(this.btnGestionDeProductos_Click);
            // 
            // btnListadoProductos
            // 
            this.btnListadoProductos.Name = "btnListadoProductos";
            this.btnListadoProductos.Size = new System.Drawing.Size(291, 34);
            this.btnListadoProductos.Text = "Listado de Productos";
            this.btnListadoProductos.Click += new System.EventHandler(this.listadoDeProductosToolStripMenuItem_Click);
            // 
            // btnConsultarProductos
            // 
            this.btnConsultarProductos.Name = "btnConsultarProductos";
            this.btnConsultarProductos.Size = new System.Drawing.Size(291, 34);
            this.btnConsultarProductos.Text = "Consultar Productos";
            this.btnConsultarProductos.Click += new System.EventHandler(this.consultarProductosToolStripMenuItem_Click);
            // 
            // mnuObrasSociales
            // 
            this.mnuObrasSociales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnuObrasSociales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAltaObrasSociales,
            this.btnListadoObrasSociales});
            this.mnuObrasSociales.Font = new System.Drawing.Font("Calibri", 14F);
            this.mnuObrasSociales.Name = "mnuObrasSociales";
            this.mnuObrasSociales.Size = new System.Drawing.Size(167, 33);
            this.mnuObrasSociales.Text = "Obras Sociales";
            // 
            // btnAltaObrasSociales
            // 
            this.btnAltaObrasSociales.Name = "btnAltaObrasSociales";
            this.btnAltaObrasSociales.Size = new System.Drawing.Size(334, 34);
            this.btnAltaObrasSociales.Text = "Alta de Obra Social";
            this.btnAltaObrasSociales.Click += new System.EventHandler(this.btnAltaObrasSociales_Click);
            // 
            // btnListadoObrasSociales
            // 
            this.btnListadoObrasSociales.Name = "btnListadoObrasSociales";
            this.btnListadoObrasSociales.Size = new System.Drawing.Size(334, 34);
            this.btnListadoObrasSociales.Text = "Listado de Obras Sociales";
            this.btnListadoObrasSociales.Click += new System.EventHandler(this.btnListadoObrasSociales_Click);
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAltaUsuario,
            this.btnGestionUsuarios});
            this.mnuUsuarios.Font = new System.Drawing.Font("Calibri", 14F);
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(110, 33);
            this.mnuUsuarios.Text = "Usuarios";
            // 
            // btnAltaUsuario
            // 
            this.btnAltaUsuario.Name = "btnAltaUsuario";
            this.btnAltaUsuario.Size = new System.Drawing.Size(271, 34);
            this.btnAltaUsuario.Text = "Alta de Usuario";
            this.btnAltaUsuario.Click += new System.EventHandler(this.btnAltaUsuario_Click);
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(271, 34);
            this.btnGestionUsuarios.Text = "Gestionar Usuarios";
            this.btnGestionUsuarios.Click += new System.EventHandler(this.btnGestionUsuarios_Click);
            // 
            // mnuVentas
            // 
            this.mnuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegistrarVentas,
            this.btnListadoVentas});
            this.mnuVentas.Name = "mnuVentas";
            this.mnuVentas.Size = new System.Drawing.Size(85, 33);
            this.mnuVentas.Text = "Ventas";
            // 
            // btnRegistrarVentas
            // 
            this.btnRegistrarVentas.Name = "btnRegistrarVentas";
            this.btnRegistrarVentas.Size = new System.Drawing.Size(243, 32);
            this.btnRegistrarVentas.Text = "Registrar Venta";
            this.btnRegistrarVentas.Click += new System.EventHandler(this.regVentasToolStripMenuItem_Click);
            // 
            // btnListadoVentas
            // 
            this.btnListadoVentas.Name = "btnListadoVentas";
            this.btnListadoVentas.Size = new System.Drawing.Size(243, 32);
            this.btnListadoVentas.Text = "Listado de Ventas";
            this.btnListadoVentas.Click += new System.EventHandler(this.listadoDeVentasToolStripMenuItem_Click);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(63, 33);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(849, 372);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(83, 27);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(849, 404);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(41, 27);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "Rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(753, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(753, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rol:";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
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
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem btnAltaUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnuVentas;
        private System.Windows.Forms.ToolStripMenuItem btnRegistrarVentas;
        private System.Windows.Forms.ToolStripMenuItem btnListadoVentas;
        private System.Windows.Forms.ToolStripMenuItem btnGestionClientes;
        private System.Windows.Forms.ToolStripMenuItem btnConsultarProductos;
        private System.Windows.Forms.ToolStripMenuItem btnConsularCliente;
        private System.Windows.Forms.ToolStripMenuItem btnListadoProductos;
        private System.Windows.Forms.ToolStripMenuItem btnGestionDeProductos;
        private System.Windows.Forms.ToolStripMenuItem btnGestionUsuarios;
        private System.Windows.Forms.ToolStripMenuItem btnListadoObrasSociales;
    }
}

