namespace Vistas
{
    partial class FormUsuario
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
            this.dgtUsuarios = new System.Windows.Forms.DataGridView();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opticaDataSet1 = new Vistas.opticaDataSet1();
            this.usuarioTableAdapter = new Vistas.opticaDataSet1TableAdapters.UsuarioTableAdapter();
            this.textPattern = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboRoles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new Vistas.opticaDataSet1TableAdapters.RolesTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNombAp = new System.Windows.Forms.TextBox();
            this.textNombreUsu = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opticaDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgtUsuarios
            // 
            this.dgtUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtUsuarios.Location = new System.Drawing.Point(13, 116);
            this.dgtUsuarios.Name = "dgtUsuarios";
            this.dgtUsuarios.RowTemplate.Height = 24;
            this.dgtUsuarios.Size = new System.Drawing.Size(740, 370);
            this.dgtUsuarios.TabIndex = 0;
            this.dgtUsuarios.CurrentCellChanged += new System.EventHandler(this.dgtUsuarios_CurrentCellChanged);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.opticaDataSet1;
            // 
            // opticaDataSet1
            // 
            this.opticaDataSet1.DataSetName = "opticaDataSet1";
            this.opticaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // textPattern
            // 
            this.textPattern.Location = new System.Drawing.Point(13, 71);
            this.textPattern.Name = "textPattern";
            this.textPattern.Size = new System.Drawing.Size(602, 22);
            this.textPattern.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(636, 71);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnSaveUser);
            this.groupBox1.Controls.Add(this.textPass);
            this.groupBox1.Controls.Add(this.textNombreUsu);
            this.groupBox1.Controls.Add(this.textNombAp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboRoles);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(769, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 369);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre y Apellido:";
            // 
            // comboRoles
            // 
            this.comboRoles.FormattingEnabled = true;
            this.comboRoles.Location = new System.Drawing.Point(152, 36);
            this.comboRoles.Name = "comboRoles";
            this.comboRoles.Size = new System.Drawing.Size(243, 24);
            this.comboRoles.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rol:";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.opticaDataSet1;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre de Usuario:";
            // 
            // textNombAp
            // 
            this.textNombAp.Location = new System.Drawing.Point(152, 81);
            this.textNombAp.Name = "textNombAp";
            this.textNombAp.Size = new System.Drawing.Size(243, 22);
            this.textNombAp.TabIndex = 5;
            // 
            // textNombreUsu
            // 
            this.textNombreUsu.Location = new System.Drawing.Point(152, 123);
            this.textNombreUsu.Name = "textNombreUsu";
            this.textNombreUsu.Size = new System.Drawing.Size(243, 22);
            this.textNombreUsu.TabIndex = 6;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(152, 164);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(243, 22);
            this.textPass.TabIndex = 7;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Location = new System.Drawing.Point(235, 215);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(138, 35);
            this.btnSaveUser.TabIndex = 8;
            this.btnSaveUser.Text = "Guardar";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(51, 215);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(138, 35);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(51, 276);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 35);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textPattern);
            this.Controls.Add(this.dgtUsuarios);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opticaDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtUsuarios;
        private opticaDataSet1 opticaDataSet1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private opticaDataSet1TableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.TextBox textPattern;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private opticaDataSet1TableAdapters.RolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.ComboBox comboRoles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textNombreUsu;
        private System.Windows.Forms.TextBox textNombAp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}