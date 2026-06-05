namespace Vistas
{
    partial class ListadoObrasSociales
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
            this.dgwObrasSociales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwObrasSociales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwObrasSociales
            // 
            this.dgwObrasSociales.AllowUserToAddRows = false;
            this.dgwObrasSociales.AllowUserToDeleteRows = false;
            this.dgwObrasSociales.AllowUserToOrderColumns = true;
            this.dgwObrasSociales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwObrasSociales.Location = new System.Drawing.Point(85, 53);
            this.dgwObrasSociales.Name = "dgwObrasSociales";
            this.dgwObrasSociales.ReadOnly = true;
            this.dgwObrasSociales.RowTemplate.Height = 24;
            this.dgwObrasSociales.Size = new System.Drawing.Size(876, 402);
            this.dgwObrasSociales.TabIndex = 0;
            // 
            // ListadoObrasSociales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 537);
            this.Controls.Add(this.dgwObrasSociales);
            this.Name = "ListadoObrasSociales";
            this.Text = "ListadoObrasSociales";
            this.Load += new System.EventHandler(this.ListadoObrasSociales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwObrasSociales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwObrasSociales;
    }
}