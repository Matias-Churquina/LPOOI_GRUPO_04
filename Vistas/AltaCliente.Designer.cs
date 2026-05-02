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
            this.SuspendLayout();
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAltaCliente.Location = new System.Drawing.Point(335, 380);
            this.btnAltaCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(123, 52);
            this.btnAltaCliente.TabIndex = 0;
            this.btnAltaCliente.Text = "Aceptar";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            this.btnAltaCliente.MouseLeave += new System.EventHandler(this.Botones_MouseLeave);
            this.btnAltaCliente.MouseHover += new System.EventHandler(this.Botones_MouseHover);
            // 
            // lblClienteDNI
            // 
            this.lblClienteDNI.AutoSize = true;
            this.lblClienteDNI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteDNI.Location = new System.Drawing.Point(227, 23);
            this.lblClienteDNI.Name = "lblClienteDNI";
            this.lblClienteDNI.Size = new System.Drawing.Size(49, 28);
            this.lblClienteDNI.TabIndex = 1;
            this.lblClienteDNI.Text = "DNI";
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblClienteNombre.Location = new System.Drawing.Point(227, 138);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(99, 28);
            this.lblClienteNombre.TabIndex = 2;
            this.lblClienteNombre.Text = "NOMBRE";
            // 
            // lblClienteApellido
            // 
            this.lblClienteApellido.AutoSize = true;
            this.lblClienteApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblClienteApellido.Location = new System.Drawing.Point(227, 80);
            this.lblClienteApellido.Name = "lblClienteApellido";
            this.lblClienteApellido.Size = new System.Drawing.Size(105, 28);
            this.lblClienteApellido.TabIndex = 3;
            this.lblClienteApellido.Text = "APELLIDO";
            // 
            // lblClienteDireccion
            // 
            this.lblClienteDireccion.AutoSize = true;
            this.lblClienteDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblClienteDireccion.Location = new System.Drawing.Point(227, 196);
            this.lblClienteDireccion.Name = "lblClienteDireccion";
            this.lblClienteDireccion.Size = new System.Drawing.Size(117, 28);
            this.lblClienteDireccion.TabIndex = 4;
            this.lblClienteDireccion.Text = "DIRECCION";
            // 
            // lblClienteOS
            // 
            this.lblClienteOS.AutoSize = true;
            this.lblClienteOS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblClienteOS.Location = new System.Drawing.Point(227, 251);
            this.lblClienteOS.Name = "lblClienteOS";
            this.lblClienteOS.Size = new System.Drawing.Size(88, 28);
            this.lblClienteOS.TabIndex = 5;
            this.lblClienteOS.Text = "OS CUIT";
            // 
            // lblClienteNroCarnet
            // 
            this.lblClienteNroCarnet.AutoSize = true;
            this.lblClienteNroCarnet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblClienteNroCarnet.Location = new System.Drawing.Point(227, 304);
            this.lblClienteNroCarnet.Name = "lblClienteNroCarnet";
            this.lblClienteNroCarnet.Size = new System.Drawing.Size(152, 28);
            this.lblClienteNroCarnet.TabIndex = 6;
            this.lblClienteNroCarnet.Text = "Nª DE CARNET";
            // 
            // txtClienteDNI
            // 
            this.txtClienteDNI.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtClienteDNI.Location = new System.Drawing.Point(457, 14);
            this.txtClienteDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClienteDNI.Name = "txtClienteDNI";
            this.txtClienteDNI.Size = new System.Drawing.Size(313, 34);
            this.txtClienteDNI.TabIndex = 7;
            // 
            // txtClienteApellido
            // 
            this.txtClienteApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtClienteApellido.Location = new System.Drawing.Point(457, 70);
            this.txtClienteApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClienteApellido.Name = "txtClienteApellido";
            this.txtClienteApellido.Size = new System.Drawing.Size(313, 34);
            this.txtClienteApellido.TabIndex = 8;
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtClienteNombre.Location = new System.Drawing.Point(457, 128);
            this.txtClienteNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(313, 34);
            this.txtClienteNombre.TabIndex = 9;
            // 
            // txtClienteDireccion
            // 
            this.txtClienteDireccion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtClienteDireccion.Location = new System.Drawing.Point(457, 186);
            this.txtClienteDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClienteDireccion.Name = "txtClienteDireccion";
            this.txtClienteDireccion.Size = new System.Drawing.Size(313, 34);
            this.txtClienteDireccion.TabIndex = 10;
            // 
            // txtClienteOS
            // 
            this.txtClienteOS.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtClienteOS.Location = new System.Drawing.Point(457, 241);
            this.txtClienteOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClienteOS.Name = "txtClienteOS";
            this.txtClienteOS.Size = new System.Drawing.Size(313, 34);
            this.txtClienteOS.TabIndex = 11;
            // 
            // txtClienteNroCarnet
            // 
            this.txtClienteNroCarnet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtClienteNroCarnet.Location = new System.Drawing.Point(457, 294);
            this.txtClienteNroCarnet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClienteNroCarnet.Name = "txtClienteNroCarnet";
            this.txtClienteNroCarnet.Size = new System.Drawing.Size(313, 34);
            this.txtClienteNroCarnet.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCancelar.Location = new System.Drawing.Point(593, 380);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 52);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.Botones_MouseLeave);
            this.btnCancelar.MouseHover += new System.EventHandler(this.Botones_MouseHover);
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 446);
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
    }
}