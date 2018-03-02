namespace Soporte.Formularios
{
    partial class FormUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.gbUsuarios = new System.Windows.Forms.GroupBox();
            this.gbDatosUsuarios = new System.Windows.Forms.GroupBox();
            this.chbActivo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbApellidoMaterno = new System.Windows.Forms.TextBox();
            this.tbApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.btnEjecutarAccion = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gbUsuarios.SuspendLayout();
            this.gbDatosUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(6, 19);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(243, 268);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // gbUsuarios
            // 
            this.gbUsuarios.Controls.Add(this.dgvUsuarios);
            this.gbUsuarios.Location = new System.Drawing.Point(12, 12);
            this.gbUsuarios.Name = "gbUsuarios";
            this.gbUsuarios.Size = new System.Drawing.Size(255, 295);
            this.gbUsuarios.TabIndex = 1;
            this.gbUsuarios.TabStop = false;
            this.gbUsuarios.Text = "Lista de usuarios";
            // 
            // gbDatosUsuarios
            // 
            this.gbDatosUsuarios.Controls.Add(this.chbActivo);
            this.gbDatosUsuarios.Controls.Add(this.label5);
            this.gbDatosUsuarios.Controls.Add(this.label4);
            this.gbDatosUsuarios.Controls.Add(this.tbContraseña);
            this.gbDatosUsuarios.Controls.Add(this.label3);
            this.gbDatosUsuarios.Controls.Add(this.tbUsername);
            this.gbDatosUsuarios.Controls.Add(this.label2);
            this.gbDatosUsuarios.Controls.Add(this.tbApellidoMaterno);
            this.gbDatosUsuarios.Controls.Add(this.tbApellidoPaterno);
            this.gbDatosUsuarios.Controls.Add(this.label1);
            this.gbDatosUsuarios.Controls.Add(this.tbNombres);
            this.gbDatosUsuarios.Controls.Add(this.btnEjecutarAccion);
            this.gbDatosUsuarios.Location = new System.Drawing.Point(273, 41);
            this.gbDatosUsuarios.Name = "gbDatosUsuarios";
            this.gbDatosUsuarios.Size = new System.Drawing.Size(328, 266);
            this.gbDatosUsuarios.TabIndex = 2;
            this.gbDatosUsuarios.TabStop = false;
            this.gbDatosUsuarios.Text = "Datos del usuario";
            // 
            // chbActivo
            // 
            this.chbActivo.AutoSize = true;
            this.chbActivo.Location = new System.Drawing.Point(256, 182);
            this.chbActivo.Name = "chbActivo";
            this.chbActivo.Size = new System.Drawing.Size(56, 17);
            this.chbActivo.TabIndex = 3;
            this.chbActivo.Text = "Activo";
            this.chbActivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre de usuario:";
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(135, 156);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(177, 20);
            this.tbContraseña.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido materno:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(135, 130);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(177, 20);
            this.tbUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido paterno:";
            // 
            // tbApellidoMaterno
            // 
            this.tbApellidoMaterno.Location = new System.Drawing.Point(135, 75);
            this.tbApellidoMaterno.Name = "tbApellidoMaterno";
            this.tbApellidoMaterno.Size = new System.Drawing.Size(177, 20);
            this.tbApellidoMaterno.TabIndex = 1;
            // 
            // tbApellidoPaterno
            // 
            this.tbApellidoPaterno.Location = new System.Drawing.Point(135, 47);
            this.tbApellidoPaterno.Name = "tbApellidoPaterno";
            this.tbApellidoPaterno.Size = new System.Drawing.Size(177, 20);
            this.tbApellidoPaterno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombres:";
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(135, 19);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(177, 20);
            this.tbNombres.TabIndex = 1;
            // 
            // btnEjecutarAccion
            // 
            this.btnEjecutarAccion.Location = new System.Drawing.Point(222, 205);
            this.btnEjecutarAccion.Name = "btnEjecutarAccion";
            this.btnEjecutarAccion.Size = new System.Drawing.Size(100, 53);
            this.btnEjecutarAccion.TabIndex = 0;
            this.btnEjecutarAccion.Text = "Editar";
            this.btnEjecutarAccion.UseVisualStyleBackColor = true;
            this.btnEjecutarAccion.Click += new System.EventHandler(this.btnEjecutarAccion_Click);
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Location = new System.Drawing.Point(516, 12);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(85, 23);
            this.btnNuevoUsuario.TabIndex = 3;
            this.btnNuevoUsuario.Text = "Nuevo usuario";
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 321);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.gbDatosUsuarios);
            this.Controls.Add(this.gbUsuarios);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gbUsuarios.ResumeLayout(false);
            this.gbDatosUsuarios.ResumeLayout(false);
            this.gbDatosUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox gbUsuarios;
        private System.Windows.Forms.GroupBox gbDatosUsuarios;
        private System.Windows.Forms.CheckBox chbActivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbApellidoMaterno;
        private System.Windows.Forms.TextBox tbApellidoPaterno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.Button btnEjecutarAccion;
        private System.Windows.Forms.Button btnNuevoUsuario;
    }
}