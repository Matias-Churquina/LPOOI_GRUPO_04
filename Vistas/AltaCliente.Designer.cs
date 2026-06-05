namespace Vistas
{
    partial class AltaCliente
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
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.lblClienteDNI = new System.Windows.Forms.Label();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.lblClienteApellido = new System.Windows.Forms.Label();
            this.lblClienteDireccion = new System.Windows.Forms.Label();
            this.lblClienteOS = new System.Windows.Forms.Label();
            this.lblClienteNroCarnet = new System.Windows.Forms.Label();
            this.txtClienteDNI = new System.Windows.Forms.TextBox();
            this.txtClienteApellido = new System.Windows.Forms.TextBox();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.txtClienteDireccion = new System.Windows.Forms.TextBox();
            this.txtClienteNroCarnet = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbObraSocial = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Location = new System.Drawing.Point(121, 391);
            this.btnAltaCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(96, 36);
            this.btnAltaCliente.TabIndex = 13;
            this.btnAltaCliente.Text = "Aceptar";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // lblClienteDNI
            // 
            this.lblClienteDNI.AutoSize = true;
            this.lblClienteDNI.Location = new System.Drawing.Point(53, 51);
            this.lblClienteDNI.Name = "lblClienteDNI";
            this.lblClienteDNI.Size = new System.Drawing.Size(35, 17);
            this.lblClienteDNI.TabIndex = 1;
            this.lblClienteDNI.Text = "DNI:";
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Location = new System.Drawing.Point(53, 166);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(62, 17);
            this.lblClienteNombre.TabIndex = 5;
            this.lblClienteNombre.Text = "Nombre:";
            // 
            // lblClienteApellido
            // 
            this.lblClienteApellido.AutoSize = true;
            this.lblClienteApellido.Location = new System.Drawing.Point(53, 108);
            this.lblClienteApellido.Name = "lblClienteApellido";
            this.lblClienteApellido.Size = new System.Drawing.Size(62, 17);
            this.lblClienteApellido.TabIndex = 3;
            this.lblClienteApellido.Text = "Apellido:";
            // 
            // lblClienteDireccion
            // 
            this.lblClienteDireccion.AutoSize = true;
            this.lblClienteDireccion.Location = new System.Drawing.Point(53, 224);
            this.lblClienteDireccion.Name = "lblClienteDireccion";
            this.lblClienteDireccion.Size = new System.Drawing.Size(71, 17);
            this.lblClienteDireccion.TabIndex = 7;
            this.lblClienteDireccion.Text = "Direccion:";
            // 
            // lblClienteOS
            // 
            this.lblClienteOS.AutoSize = true;
            this.lblClienteOS.Location = new System.Drawing.Point(53, 279);
            this.lblClienteOS.Name = "lblClienteOS";
            this.lblClienteOS.Size = new System.Drawing.Size(67, 17);
            this.lblClienteOS.TabIndex = 9;
            this.lblClienteOS.Text = "OS CUIT:";
            // 
            // lblClienteNroCarnet
            // 
            this.lblClienteNroCarnet.AutoSize = true;
            this.lblClienteNroCarnet.Location = new System.Drawing.Point(53, 332);
            this.lblClienteNroCarnet.Name = "lblClienteNroCarnet";
            this.lblClienteNroCarnet.Size = new System.Drawing.Size(94, 17);
            this.lblClienteNroCarnet.TabIndex = 11;
            this.lblClienteNroCarnet.Text = "N° de Carnet:";
            // 
            // txtClienteDNI
            // 
            this.txtClienteDNI.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtClienteDNI.Location = new System.Drawing.Point(161, 38);
            this.txtClienteDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClienteDNI.Name = "txtClienteDNI";
            this.txtClienteDNI.Size = new System.Drawing.Size(313, 34);
            this.txtClienteDNI.TabIndex = 2;
            // 
            // txtClienteApellido
            // 
            this.txtClienteApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtClienteApellido.Location = new System.Drawing.Point(161, 94);
            this.txtClienteApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClienteApellido.Name = "txtClienteApellido";
            this.txtClienteApellido.Size = new System.Drawing.Size(313, 34);
            this.txtClienteApellido.TabIndex = 4;
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtClienteNombre.Location = new System.Drawing.Point(161, 152);
            this.txtClienteNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(313, 34);
            this.txtClienteNombre.TabIndex = 6;
            // 
            // txtClienteDireccion
            // 
            this.txtClienteDireccion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtClienteDireccion.Location = new System.Drawing.Point(161, 210);
            this.txtClienteDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClienteDireccion.Name = "txtClienteDireccion";
            this.txtClienteDireccion.Size = new System.Drawing.Size(313, 34);
            this.txtClienteDireccion.TabIndex = 8;
            // 
            // txtClienteNroCarnet
            // 
            this.txtClienteNroCarnet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtClienteNroCarnet.Location = new System.Drawing.Point(161, 318);
            this.txtClienteNroCarnet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClienteNroCarnet.Name = "txtClienteNroCarnet";
            this.txtClienteNroCarnet.Size = new System.Drawing.Size(313, 34);
            this.txtClienteNroCarnet.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(305, 391);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 36);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbObraSocial);
            this.groupBox1.Controls.Add(this.txtClienteNroCarnet);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAltaCliente);
            this.groupBox1.Controls.Add(this.txtClienteDireccion);
            this.groupBox1.Controls.Add(this.txtClienteNombre);
            this.groupBox1.Controls.Add(this.txtClienteApellido);
            this.groupBox1.Controls.Add(this.txtClienteDNI);
            this.groupBox1.Controls.Add(this.lblClienteNroCarnet);
            this.groupBox1.Controls.Add(this.lblClienteOS);
            this.groupBox1.Controls.Add(this.lblClienteDireccion);
            this.groupBox1.Controls.Add(this.lblClienteApellido);
            this.groupBox1.Controls.Add(this.lblClienteNombre);
            this.groupBox1.Controls.Add(this.lblClienteDNI);
            this.groupBox1.Location = new System.Drawing.Point(185, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 447);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta de Cliente";
            // 
            // cmbObraSocial
            // 
            this.cmbObraSocial.FormattingEnabled = true;
            this.cmbObraSocial.Location = new System.Drawing.Point(161, 269);
            this.cmbObraSocial.Name = "cmbObraSocial";
            this.cmbObraSocial.Size = new System.Drawing.Size(313, 24);
            this.cmbObraSocial.TabIndex = 15;
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 580);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AltaCliente";
            this.Text = "AltaCliente";
            this.Load += new System.EventHandler(this.AltaCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.Label lblClienteDNI;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.Label lblClienteApellido;
        private System.Windows.Forms.Label lblClienteDireccion;
        private System.Windows.Forms.Label lblClienteOS;
        private System.Windows.Forms.Label lblClienteNroCarnet;
        private System.Windows.Forms.TextBox txtClienteDNI;
        private System.Windows.Forms.TextBox txtClienteApellido;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.TextBox txtClienteDireccion;
        private System.Windows.Forms.TextBox txtClienteNroCarnet;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbObraSocial;
    }
}