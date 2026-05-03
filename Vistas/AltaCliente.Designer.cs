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
            this.txtClienteOS = new System.Windows.Forms.TextBox();
            this.txtClienteNroCarnet = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblAltaCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Font = new System.Drawing.Font("Calibri", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAltaCliente.Location = new System.Drawing.Point(314, 470);
            this.btnAltaCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(111, 39);
            this.btnAltaCliente.TabIndex = 13;
            this.btnAltaCliente.Text = "Aceptar";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            this.btnAltaCliente.MouseLeave += new System.EventHandler(this.Botones_MouseLeave);
            this.btnAltaCliente.MouseHover += new System.EventHandler(this.Botones_MouseHover);
            // 
            // lblClienteDNI
            // 
            this.lblClienteDNI.AutoSize = true;
            this.lblClienteDNI.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteDNI.Location = new System.Drawing.Point(242, 108);
            this.lblClienteDNI.Name = "lblClienteDNI";
            this.lblClienteDNI.Size = new System.Drawing.Size(52, 27);
            this.lblClienteDNI.TabIndex = 1;
            this.lblClienteDNI.Text = "DNI:";
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNombre.Location = new System.Drawing.Point(242, 223);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(93, 27);
            this.lblClienteNombre.TabIndex = 5;
            this.lblClienteNombre.Text = "Nombre:";
            // 
            // lblClienteApellido
            // 
            this.lblClienteApellido.AutoSize = true;
            this.lblClienteApellido.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteApellido.Location = new System.Drawing.Point(242, 165);
            this.lblClienteApellido.Name = "lblClienteApellido";
            this.lblClienteApellido.Size = new System.Drawing.Size(93, 27);
            this.lblClienteApellido.TabIndex = 3;
            this.lblClienteApellido.Text = "Apellido:";
            // 
            // lblClienteDireccion
            // 
            this.lblClienteDireccion.AutoSize = true;
            this.lblClienteDireccion.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteDireccion.Location = new System.Drawing.Point(242, 281);
            this.lblClienteDireccion.Name = "lblClienteDireccion";
            this.lblClienteDireccion.Size = new System.Drawing.Size(103, 27);
            this.lblClienteDireccion.TabIndex = 7;
            this.lblClienteDireccion.Text = "Direccion:";
            // 
            // lblClienteOS
            // 
            this.lblClienteOS.AutoSize = true;
            this.lblClienteOS.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteOS.Location = new System.Drawing.Point(242, 336);
            this.lblClienteOS.Name = "lblClienteOS";
            this.lblClienteOS.Size = new System.Drawing.Size(90, 27);
            this.lblClienteOS.TabIndex = 9;
            this.lblClienteOS.Text = "OS CUIT:";
            // 
            // lblClienteNroCarnet
            // 
            this.lblClienteNroCarnet.AutoSize = true;
            this.lblClienteNroCarnet.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNroCarnet.Location = new System.Drawing.Point(242, 389);
            this.lblClienteNroCarnet.Name = "lblClienteNroCarnet";
            this.lblClienteNroCarnet.Size = new System.Drawing.Size(133, 27);
            this.lblClienteNroCarnet.TabIndex = 11;
            this.lblClienteNroCarnet.Text = "N° de Carnet:";
            // 
            // txtClienteDNI
            // 
            this.txtClienteDNI.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtClienteDNI.Location = new System.Drawing.Point(402, 104);
            this.txtClienteDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClienteDNI.Name = "txtClienteDNI";
            this.txtClienteDNI.Size = new System.Drawing.Size(313, 34);
            this.txtClienteDNI.TabIndex = 2;
            // 
            // txtClienteApellido
            // 
            this.txtClienteApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtClienteApellido.Location = new System.Drawing.Point(402, 160);
            this.txtClienteApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClienteApellido.Name = "txtClienteApellido";
            this.txtClienteApellido.Size = new System.Drawing.Size(313, 34);
            this.txtClienteApellido.TabIndex = 4;
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtClienteNombre.Location = new System.Drawing.Point(402, 218);
            this.txtClienteNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(313, 34);
            this.txtClienteNombre.TabIndex = 6;
            // 
            // txtClienteDireccion
            // 
            this.txtClienteDireccion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtClienteDireccion.Location = new System.Drawing.Point(402, 276);
            this.txtClienteDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClienteDireccion.Name = "txtClienteDireccion";
            this.txtClienteDireccion.Size = new System.Drawing.Size(313, 34);
            this.txtClienteDireccion.TabIndex = 8;
            // 
            // txtClienteOS
            // 
            this.txtClienteOS.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtClienteOS.Location = new System.Drawing.Point(402, 331);
            this.txtClienteOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClienteOS.Name = "txtClienteOS";
            this.txtClienteOS.Size = new System.Drawing.Size(313, 34);
            this.txtClienteOS.TabIndex = 10;
            // 
            // txtClienteNroCarnet
            // 
            this.txtClienteNroCarnet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtClienteNroCarnet.Location = new System.Drawing.Point(402, 384);
            this.txtClienteNroCarnet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClienteNroCarnet.Name = "txtClienteNroCarnet";
            this.txtClienteNroCarnet.Size = new System.Drawing.Size(313, 34);
            this.txtClienteNroCarnet.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCancelar.Location = new System.Drawing.Point(510, 470);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 39);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.Botones_MouseLeave);
            this.btnCancelar.MouseHover += new System.EventHandler(this.Botones_MouseHover);
            // 
            // lblAltaCliente
            // 
            this.lblAltaCliente.AutoSize = true;
            this.lblAltaCliente.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaCliente.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblAltaCliente.Location = new System.Drawing.Point(396, 40);
            this.lblAltaCliente.Name = "lblAltaCliente";
            this.lblAltaCliente.Size = new System.Drawing.Size(167, 31);
            this.lblAltaCliente.TabIndex = 0;
            this.lblAltaCliente.Text = "Alta de Cliente";
            this.lblAltaCliente.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 580);
            this.Controls.Add(this.lblAltaCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtClienteNroCarnet);
            this.Controls.Add(this.txtClienteOS);
            this.Controls.Add(this.txtClienteDireccion);
            this.Controls.Add(this.txtClienteNombre);
            this.Controls.Add(this.txtClienteApellido);
            this.Controls.Add(this.txtClienteDNI);
            this.Controls.Add(this.lblClienteNroCarnet);
            this.Controls.Add(this.lblClienteOS);
            this.Controls.Add(this.lblClienteDireccion);
            this.Controls.Add(this.lblClienteApellido);
            this.Controls.Add(this.lblClienteNombre);
            this.Controls.Add(this.lblClienteDNI);
            this.Controls.Add(this.btnAltaCliente);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AltaCliente";
            this.Text = "AltaCliente";
            this.Load += new System.EventHandler(this.AltaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtClienteOS;
        private System.Windows.Forms.TextBox txtClienteNroCarnet;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblAltaCliente;
    }
}