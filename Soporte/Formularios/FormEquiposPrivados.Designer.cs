namespace Soporte.Formularios
{
    partial class FormEquiposPrivados
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
            this.gbEquiposPrivados = new System.Windows.Forms.GroupBox();
            this.dgvAulasPrivadas = new System.Windows.Forms.DataGridView();
            this.gbRevision = new System.Windows.Forms.GroupBox();
            this.chbAntivirus = new System.Windows.Forms.CheckBox();
            this.chbOptimizacion = new System.Windows.Forms.CheckBox();
            this.chbUpdates = new System.Windows.Forms.CheckBox();
            this.chbProyector = new System.Windows.Forms.CheckBox();
            this.chbCableUSB = new System.Windows.Forms.CheckBox();
            this.chbMouse = new System.Windows.Forms.CheckBox();
            this.chbTeclado = new System.Windows.Forms.CheckBox();
            this.chbMonitor = new System.Windows.Forms.CheckBox();
            this.chbCPU = new System.Windows.Forms.CheckBox();
            this.gbAsistentes = new System.Windows.Forms.GroupBox();
            this.cbAsistente3 = new System.Windows.Forms.ComboBox();
            this.cbAsistente2 = new System.Windows.Forms.ComboBox();
            this.cbAsistente1 = new System.Windows.Forms.ComboBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaRevision = new System.Windows.Forms.DateTimePicker();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gbEquiposPrivados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulasPrivadas)).BeginInit();
            this.gbRevision.SuspendLayout();
            this.gbAsistentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEquiposPrivados
            // 
            this.gbEquiposPrivados.Controls.Add(this.dgvAulasPrivadas);
            this.gbEquiposPrivados.Location = new System.Drawing.Point(12, 12);
            this.gbEquiposPrivados.Name = "gbEquiposPrivados";
            this.gbEquiposPrivados.Size = new System.Drawing.Size(153, 343);
            this.gbEquiposPrivados.TabIndex = 2;
            this.gbEquiposPrivados.TabStop = false;
            this.gbEquiposPrivados.Text = "Equipos privados";
            // 
            // dgvAulasPrivadas
            // 
            this.dgvAulasPrivadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAulasPrivadas.Location = new System.Drawing.Point(6, 19);
            this.dgvAulasPrivadas.Name = "dgvAulasPrivadas";
            this.dgvAulasPrivadas.Size = new System.Drawing.Size(141, 318);
            this.dgvAulasPrivadas.TabIndex = 0;
            this.dgvAulasPrivadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAulasPrivadas_CellContentClick);
            this.dgvAulasPrivadas.CurrentCellChanged += new System.EventHandler(this.dgvAulasPrivadas_CurrentCellChanged);
            // 
            // gbRevision
            // 
            this.gbRevision.Controls.Add(this.chbAntivirus);
            this.gbRevision.Controls.Add(this.chbOptimizacion);
            this.gbRevision.Controls.Add(this.chbUpdates);
            this.gbRevision.Controls.Add(this.chbProyector);
            this.gbRevision.Controls.Add(this.chbCableUSB);
            this.gbRevision.Controls.Add(this.chbMouse);
            this.gbRevision.Controls.Add(this.chbTeclado);
            this.gbRevision.Controls.Add(this.chbMonitor);
            this.gbRevision.Controls.Add(this.chbCPU);
            this.gbRevision.Location = new System.Drawing.Point(174, 31);
            this.gbRevision.Name = "gbRevision";
            this.gbRevision.Size = new System.Drawing.Size(221, 148);
            this.gbRevision.TabIndex = 5;
            this.gbRevision.TabStop = false;
            this.gbRevision.Text = "Revisiones";
            // 
            // chbAntivirus
            // 
            this.chbAntivirus.AutoSize = true;
            this.chbAntivirus.Location = new System.Drawing.Point(115, 92);
            this.chbAntivirus.Name = "chbAntivirus";
            this.chbAntivirus.Size = new System.Drawing.Size(66, 17);
            this.chbAntivirus.TabIndex = 3;
            this.chbAntivirus.Text = "Antivirus";
            this.chbAntivirus.UseVisualStyleBackColor = true;
            // 
            // chbOptimizacion
            // 
            this.chbOptimizacion.AutoSize = true;
            this.chbOptimizacion.Location = new System.Drawing.Point(115, 69);
            this.chbOptimizacion.Name = "chbOptimizacion";
            this.chbOptimizacion.Size = new System.Drawing.Size(86, 17);
            this.chbOptimizacion.TabIndex = 3;
            this.chbOptimizacion.Text = "Optimización";
            this.chbOptimizacion.UseVisualStyleBackColor = true;
            // 
            // chbUpdates
            // 
            this.chbUpdates.AutoSize = true;
            this.chbUpdates.Location = new System.Drawing.Point(115, 46);
            this.chbUpdates.Name = "chbUpdates";
            this.chbUpdates.Size = new System.Drawing.Size(100, 17);
            this.chbUpdates.TabIndex = 3;
            this.chbUpdates.Text = "Actualizaciones";
            this.chbUpdates.UseVisualStyleBackColor = true;
            // 
            // chbProyector
            // 
            this.chbProyector.AutoSize = true;
            this.chbProyector.Location = new System.Drawing.Point(115, 23);
            this.chbProyector.Name = "chbProyector";
            this.chbProyector.Size = new System.Drawing.Size(71, 17);
            this.chbProyector.TabIndex = 3;
            this.chbProyector.Text = "Proyector";
            this.chbProyector.UseVisualStyleBackColor = true;
            // 
            // chbCableUSB
            // 
            this.chbCableUSB.AutoSize = true;
            this.chbCableUSB.Location = new System.Drawing.Point(26, 115);
            this.chbCableUSB.Name = "chbCableUSB";
            this.chbCableUSB.Size = new System.Drawing.Size(78, 17);
            this.chbCableUSB.TabIndex = 3;
            this.chbCableUSB.Text = "Cable USB";
            this.chbCableUSB.UseVisualStyleBackColor = true;
            // 
            // chbMouse
            // 
            this.chbMouse.AutoSize = true;
            this.chbMouse.Location = new System.Drawing.Point(26, 69);
            this.chbMouse.Name = "chbMouse";
            this.chbMouse.Size = new System.Drawing.Size(58, 17);
            this.chbMouse.TabIndex = 3;
            this.chbMouse.Text = "Mouse";
            this.chbMouse.UseVisualStyleBackColor = true;
            // 
            // chbTeclado
            // 
            this.chbTeclado.AutoSize = true;
            this.chbTeclado.Location = new System.Drawing.Point(26, 92);
            this.chbTeclado.Name = "chbTeclado";
            this.chbTeclado.Size = new System.Drawing.Size(65, 17);
            this.chbTeclado.TabIndex = 3;
            this.chbTeclado.Text = "Teclado";
            this.chbTeclado.UseVisualStyleBackColor = true;
            // 
            // chbMonitor
            // 
            this.chbMonitor.AutoSize = true;
            this.chbMonitor.Location = new System.Drawing.Point(26, 46);
            this.chbMonitor.Name = "chbMonitor";
            this.chbMonitor.Size = new System.Drawing.Size(61, 17);
            this.chbMonitor.TabIndex = 3;
            this.chbMonitor.Text = "Monitor";
            this.chbMonitor.UseVisualStyleBackColor = true;
            // 
            // chbCPU
            // 
            this.chbCPU.AutoSize = true;
            this.chbCPU.Location = new System.Drawing.Point(26, 23);
            this.chbCPU.Name = "chbCPU";
            this.chbCPU.Size = new System.Drawing.Size(48, 17);
            this.chbCPU.TabIndex = 3;
            this.chbCPU.Text = "CPU";
            this.chbCPU.UseVisualStyleBackColor = true;
            // 
            // gbAsistentes
            // 
            this.gbAsistentes.Controls.Add(this.cbAsistente3);
            this.gbAsistentes.Controls.Add(this.cbAsistente2);
            this.gbAsistentes.Controls.Add(this.cbAsistente1);
            this.gbAsistentes.Location = new System.Drawing.Point(403, 31);
            this.gbAsistentes.Name = "gbAsistentes";
            this.gbAsistentes.Size = new System.Drawing.Size(150, 148);
            this.gbAsistentes.TabIndex = 7;
            this.gbAsistentes.TabStop = false;
            this.gbAsistentes.Text = "Asistentes";
            // 
            // cbAsistente3
            // 
            this.cbAsistente3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsistente3.FormattingEnabled = true;
            this.cbAsistente3.Location = new System.Drawing.Point(14, 92);
            this.cbAsistente3.Name = "cbAsistente3";
            this.cbAsistente3.Size = new System.Drawing.Size(121, 21);
            this.cbAsistente3.TabIndex = 5;
            // 
            // cbAsistente2
            // 
            this.cbAsistente2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsistente2.FormattingEnabled = true;
            this.cbAsistente2.Location = new System.Drawing.Point(14, 65);
            this.cbAsistente2.Name = "cbAsistente2";
            this.cbAsistente2.Size = new System.Drawing.Size(121, 21);
            this.cbAsistente2.TabIndex = 5;
            // 
            // cbAsistente1
            // 
            this.cbAsistente1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsistente1.FormattingEnabled = true;
            this.cbAsistente1.Location = new System.Drawing.Point(14, 38);
            this.cbAsistente1.Name = "cbAsistente1";
            this.cbAsistente1.Size = new System.Drawing.Size(121, 21);
            this.cbAsistente1.TabIndex = 5;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(432, 297);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(121, 52);
            this.btnAñadir.TabIndex = 17;
            this.btnAñadir.Text = "Añadir revisión";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fecha de la revisión:";
            // 
            // dtpFechaRevision
            // 
            this.dtpFechaRevision.Location = new System.Drawing.Point(279, 259);
            this.dtpFechaRevision.Name = "dtpFechaRevision";
            this.dtpFechaRevision.Size = new System.Drawing.Size(274, 20);
            this.dtpFechaRevision.TabIndex = 15;
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Location = new System.Drawing.Point(174, 198);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(379, 55);
            this.tbObservaciones.TabIndex = 14;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(171, 182);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 13;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(171, 315);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 16);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "lblUsuario";
            // 
            // FormEquiposPrivados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 367);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaRevision);
            this.Controls.Add(this.tbObservaciones);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.gbAsistentes);
            this.Controls.Add(this.gbRevision);
            this.Controls.Add(this.gbEquiposPrivados);
            this.Name = "FormEquiposPrivados";
            this.Text = "FormEquiposPrivados";
            this.Load += new System.EventHandler(this.FormEquiposPrivados_Load);
            this.gbEquiposPrivados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulasPrivadas)).EndInit();
            this.gbRevision.ResumeLayout(false);
            this.gbRevision.PerformLayout();
            this.gbAsistentes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEquiposPrivados;
        private System.Windows.Forms.DataGridView dgvAulasPrivadas;
        private System.Windows.Forms.GroupBox gbRevision;
        private System.Windows.Forms.CheckBox chbAntivirus;
        private System.Windows.Forms.CheckBox chbOptimizacion;
        private System.Windows.Forms.CheckBox chbUpdates;
        private System.Windows.Forms.CheckBox chbProyector;
        private System.Windows.Forms.CheckBox chbCableUSB;
        private System.Windows.Forms.CheckBox chbTeclado;
        private System.Windows.Forms.CheckBox chbMonitor;
        private System.Windows.Forms.CheckBox chbCPU;
        private System.Windows.Forms.GroupBox gbAsistentes;
        private System.Windows.Forms.ComboBox cbAsistente3;
        private System.Windows.Forms.ComboBox cbAsistente2;
        private System.Windows.Forms.ComboBox cbAsistente1;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaRevision;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.CheckBox chbMouse;
    }
}