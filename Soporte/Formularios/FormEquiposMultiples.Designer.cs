namespace Soporte.Formularios
{
    partial class FormEquiposMultiples
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
            this.dgvAulasMultiples = new System.Windows.Forms.DataGridView();
            this.gbAulas = new System.Windows.Forms.GroupBox();
            this.lblAula = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.chbRendimiento = new System.Windows.Forms.CheckBox();
            this.gbRevision = new System.Windows.Forms.GroupBox();
            this.chbLimpieza = new System.Windows.Forms.CheckBox();
            this.chbPerifericos = new System.Windows.Forms.CheckBox();
            this.cbEquipo = new System.Windows.Forms.ComboBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.dtpFechaRevision = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.gbAsistentes = new System.Windows.Forms.GroupBox();
            this.cbAsistente3 = new System.Windows.Forms.ComboBox();
            this.cbAsistente2 = new System.Windows.Forms.ComboBox();
            this.cbAsistente1 = new System.Windows.Forms.ComboBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulasMultiples)).BeginInit();
            this.gbAulas.SuspendLayout();
            this.gbRevision.SuspendLayout();
            this.gbAsistentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAulasMultiples
            // 
            this.dgvAulasMultiples.AllowUserToAddRows = false;
            this.dgvAulasMultiples.AllowUserToDeleteRows = false;
            this.dgvAulasMultiples.AllowUserToOrderColumns = true;
            this.dgvAulasMultiples.AllowUserToResizeColumns = false;
            this.dgvAulasMultiples.AllowUserToResizeRows = false;
            this.dgvAulasMultiples.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvAulasMultiples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAulasMultiples.Location = new System.Drawing.Point(6, 19);
            this.dgvAulasMultiples.Name = "dgvAulasMultiples";
            this.dgvAulasMultiples.ReadOnly = true;
            this.dgvAulasMultiples.Size = new System.Drawing.Size(141, 286);
            this.dgvAulasMultiples.TabIndex = 0;
            this.dgvAulasMultiples.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAulasMultiples_CellContentClick_1);
            this.dgvAulasMultiples.CurrentCellChanged += new System.EventHandler(this.dgvAulasMultiples_CurrentCellChanged);
            // 
            // gbAulas
            // 
            this.gbAulas.Controls.Add(this.dgvAulasMultiples);
            this.gbAulas.Location = new System.Drawing.Point(12, 12);
            this.gbAulas.Name = "gbAulas";
            this.gbAulas.Size = new System.Drawing.Size(153, 311);
            this.gbAulas.TabIndex = 1;
            this.gbAulas.TabStop = false;
            this.gbAulas.Text = "Aulas";
            // 
            // lblAula
            // 
            this.lblAula.AutoSize = true;
            this.lblAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAula.Location = new System.Drawing.Point(171, 12);
            this.lblAula.Name = "lblAula";
            this.lblAula.Size = new System.Drawing.Size(56, 16);
            this.lblAula.TabIndex = 2;
            this.lblAula.Text = "lblAula";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(176, 289);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 16);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "lblUsuario";
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
            // gbRevision
            // 
            this.gbRevision.Controls.Add(this.chbLimpieza);
            this.gbRevision.Controls.Add(this.chbPerifericos);
            this.gbRevision.Controls.Add(this.chbRendimiento);
            this.gbRevision.Location = new System.Drawing.Point(174, 58);
            this.gbRevision.Name = "gbRevision";
            this.gbRevision.Size = new System.Drawing.Size(139, 104);
            this.gbRevision.TabIndex = 4;
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
            // cbEquipo
            // 
            this.cbEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEquipo.FormattingEnabled = true;
            this.cbEquipo.Location = new System.Drawing.Point(174, 31);
            this.cbEquipo.Name = "cbEquipo";
            this.cbEquipo.Size = new System.Drawing.Size(121, 21);
            this.cbEquipo.TabIndex = 5;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(174, 169);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 7;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Location = new System.Drawing.Point(174, 185);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(308, 55);
            this.tbObservaciones.TabIndex = 8;
            // 
            // dtpFechaRevision
            // 
            this.dtpFechaRevision.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaRevision.Location = new System.Drawing.Point(282, 245);
            this.dtpFechaRevision.Name = "dtpFechaRevision";
            this.dtpFechaRevision.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRevision.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha de la revisión:";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(361, 271);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(121, 52);
            this.btnAñadir.TabIndex = 11;
            this.btnAñadir.Text = "Añadir revisión";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // gbAsistentes
            // 
            this.gbAsistentes.Controls.Add(this.cbAsistente3);
            this.gbAsistentes.Controls.Add(this.cbAsistente2);
            this.gbAsistentes.Controls.Add(this.cbAsistente1);
            this.gbAsistentes.Location = new System.Drawing.Point(332, 58);
            this.gbAsistentes.Name = "gbAsistentes";
            this.gbAsistentes.Size = new System.Drawing.Size(150, 104);
            this.gbAsistentes.TabIndex = 18;
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
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(424, 12);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(60, 23);
            this.btnReiniciar.TabIndex = 19;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // FormEquiposMultiples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 335);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.gbAsistentes);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaRevision);
            this.Controls.Add(this.tbObservaciones);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.cbEquipo);
            this.Controls.Add(this.gbRevision);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblAula);
            this.Controls.Add(this.gbAulas);
            this.Name = "FormEquiposMultiples";
            this.Text = "FormEquiposMultiples";
            this.Load += new System.EventHandler(this.FormEquiposMultiples_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulasMultiples)).EndInit();
            this.gbAulas.ResumeLayout(false);
            this.gbRevision.ResumeLayout(false);
            this.gbRevision.PerformLayout();
            this.gbAsistentes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAulasMultiples;
        private System.Windows.Forms.GroupBox gbAulas;
        private System.Windows.Forms.Label lblAula;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.CheckBox chbRendimiento;
        private System.Windows.Forms.GroupBox gbRevision;
        private System.Windows.Forms.ComboBox cbEquipo;
        private System.Windows.Forms.CheckBox chbPerifericos;
        private System.Windows.Forms.CheckBox chbLimpieza;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.DateTimePicker dtpFechaRevision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.GroupBox gbAsistentes;
        private System.Windows.Forms.ComboBox cbAsistente3;
        private System.Windows.Forms.ComboBox cbAsistente2;
        private System.Windows.Forms.ComboBox cbAsistente1;
        private System.Windows.Forms.Button btnReiniciar;
    }
}