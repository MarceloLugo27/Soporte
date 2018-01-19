namespace Soporte.Formularios
{
    partial class FormEquiposAdministrativos
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
            this.btnAñadir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaRevision = new System.Windows.Forms.DateTimePicker();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.gbAsistentes = new System.Windows.Forms.GroupBox();
            this.cbAsistente3 = new System.Windows.Forms.ComboBox();
            this.cbAsistente2 = new System.Windows.Forms.ComboBox();
            this.cbAsistente1 = new System.Windows.Forms.ComboBox();
            this.gbRevision = new System.Windows.Forms.GroupBox();
            this.chbLimpieza = new System.Windows.Forms.CheckBox();
            this.chbPerifericos = new System.Windows.Forms.CheckBox();
            this.chbRendimiento = new System.Windows.Forms.CheckBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gbEquipos = new System.Windows.Forms.GroupBox();
            this.dgvAulasAdministrativas = new System.Windows.Forms.DataGridView();
            this.gbAsistentes.SuspendLayout();
            this.gbRevision.SuspendLayout();
            this.gbEquipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulasAdministrativas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(739, 262);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(121, 52);
            this.btnAñadir.TabIndex = 22;
            this.btnAñadir.Text = "Añadir revisión";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Fecha de la revisión:";
            // 
            // dtpFechaRevision
            // 
            this.dtpFechaRevision.Location = new System.Drawing.Point(660, 218);
            this.dtpFechaRevision.Name = "dtpFechaRevision";
            this.dtpFechaRevision.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRevision.TabIndex = 20;
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Location = new System.Drawing.Point(552, 158);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(308, 55);
            this.tbObservaciones.TabIndex = 19;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(552, 142);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 18;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // gbAsistentes
            // 
            this.gbAsistentes.Controls.Add(this.cbAsistente3);
            this.gbAsistentes.Controls.Add(this.cbAsistente2);
            this.gbAsistentes.Controls.Add(this.cbAsistente1);
            this.gbAsistentes.Location = new System.Drawing.Point(710, 31);
            this.gbAsistentes.Name = "gbAsistentes";
            this.gbAsistentes.Size = new System.Drawing.Size(150, 104);
            this.gbAsistentes.TabIndex = 17;
            this.gbAsistentes.TabStop = false;
            this.gbAsistentes.Text = "Asistentes";
            // 
            // cbAsistente3
            // 
            this.cbAsistente3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsistente3.FormattingEnabled = true;
            this.cbAsistente3.Location = new System.Drawing.Point(15, 73);
            this.cbAsistente3.Name = "cbAsistente3";
            this.cbAsistente3.Size = new System.Drawing.Size(121, 21);
            this.cbAsistente3.TabIndex = 5;
            // 
            // cbAsistente2
            // 
            this.cbAsistente2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsistente2.FormattingEnabled = true;
            this.cbAsistente2.Location = new System.Drawing.Point(15, 46);
            this.cbAsistente2.Name = "cbAsistente2";
            this.cbAsistente2.Size = new System.Drawing.Size(121, 21);
            this.cbAsistente2.TabIndex = 5;
            // 
            // cbAsistente1
            // 
            this.cbAsistente1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsistente1.FormattingEnabled = true;
            this.cbAsistente1.Location = new System.Drawing.Point(15, 19);
            this.cbAsistente1.Name = "cbAsistente1";
            this.cbAsistente1.Size = new System.Drawing.Size(121, 21);
            this.cbAsistente1.TabIndex = 5;
            // 
            // gbRevision
            // 
            this.gbRevision.Controls.Add(this.chbLimpieza);
            this.gbRevision.Controls.Add(this.chbPerifericos);
            this.gbRevision.Controls.Add(this.chbRendimiento);
            this.gbRevision.Location = new System.Drawing.Point(552, 31);
            this.gbRevision.Name = "gbRevision";
            this.gbRevision.Size = new System.Drawing.Size(139, 104);
            this.gbRevision.TabIndex = 15;
            this.gbRevision.TabStop = false;
            this.gbRevision.Text = "Revisiones";
            // 
            // chbLimpieza
            // 
            this.chbLimpieza.AutoSize = true;
            this.chbLimpieza.Location = new System.Drawing.Point(26, 69);
            this.chbLimpieza.Name = "chbLimpieza";
            this.chbLimpieza.Size = new System.Drawing.Size(67, 17);
            this.chbLimpieza.TabIndex = 3;
            this.chbLimpieza.Text = "Limpieza";
            this.chbLimpieza.UseVisualStyleBackColor = true;
            // 
            // chbPerifericos
            // 
            this.chbPerifericos.AutoSize = true;
            this.chbPerifericos.Location = new System.Drawing.Point(26, 46);
            this.chbPerifericos.Name = "chbPerifericos";
            this.chbPerifericos.Size = new System.Drawing.Size(75, 17);
            this.chbPerifericos.TabIndex = 3;
            this.chbPerifericos.Text = "Periféricos";
            this.chbPerifericos.UseVisualStyleBackColor = true;
            // 
            // chbRendimiento
            // 
            this.chbRendimiento.AutoSize = true;
            this.chbRendimiento.Location = new System.Drawing.Point(26, 23);
            this.chbRendimiento.Name = "chbRendimiento";
            this.chbRendimiento.Size = new System.Drawing.Size(85, 17);
            this.chbRendimiento.TabIndex = 3;
            this.chbRendimiento.Text = "Rendimiento";
            this.chbRendimiento.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(549, 280);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 16);
            this.lblUsuario.TabIndex = 13;
            this.lblUsuario.Text = "lblUsuario";
            // 
            // gbEquipos
            // 
            this.gbEquipos.Controls.Add(this.dgvAulasAdministrativas);
            this.gbEquipos.Location = new System.Drawing.Point(12, 12);
            this.gbEquipos.Name = "gbEquipos";
            this.gbEquipos.Size = new System.Drawing.Size(531, 311);
            this.gbEquipos.TabIndex = 12;
            this.gbEquipos.TabStop = false;
            this.gbEquipos.Text = "Equipos";
            // 
            // dgvAulasAdministrativas
            // 
            this.dgvAulasAdministrativas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAulasAdministrativas.Location = new System.Drawing.Point(6, 19);
            this.dgvAulasAdministrativas.Name = "dgvAulasAdministrativas";
            this.dgvAulasAdministrativas.Size = new System.Drawing.Size(519, 286);
            this.dgvAulasAdministrativas.TabIndex = 0;
            this.dgvAulasAdministrativas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAulasAdministrativas_CellContentClick);
            this.dgvAulasAdministrativas.CurrentCellChanged += new System.EventHandler(this.dgvAulasAdministrativas_CurrentCellChanged);
            // 
            // FormEquiposAdministrativos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 329);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaRevision);
            this.Controls.Add(this.tbObservaciones);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.gbAsistentes);
            this.Controls.Add(this.gbRevision);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.gbEquipos);
            this.Name = "FormEquiposAdministrativos";
            this.Text = "FormEquiposAdministrativos";
            this.Load += new System.EventHandler(this.FormEquiposAdministrativos_Load);
            this.gbAsistentes.ResumeLayout(false);
            this.gbRevision.ResumeLayout(false);
            this.gbRevision.PerformLayout();
            this.gbEquipos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulasAdministrativas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaRevision;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.GroupBox gbAsistentes;
        private System.Windows.Forms.ComboBox cbAsistente3;
        private System.Windows.Forms.ComboBox cbAsistente2;
        private System.Windows.Forms.ComboBox cbAsistente1;
        private System.Windows.Forms.GroupBox gbRevision;
        private System.Windows.Forms.CheckBox chbLimpieza;
        private System.Windows.Forms.CheckBox chbPerifericos;
        private System.Windows.Forms.CheckBox chbRendimiento;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox gbEquipos;
        private System.Windows.Forms.DataGridView dgvAulasAdministrativas;
    }
}