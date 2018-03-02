namespace Soporte.Formularios
{
    partial class frmAgregarEquipo
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbAulas = new System.Windows.Forms.ComboBox();
            this.gbDatosEquipo = new System.Windows.Forms.GroupBox();
            this.cbActivo = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNumeroSerie = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFabricante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProcesador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDominio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSistemaOperativo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUsuarioPC = new System.Windows.Forms.TextBox();
            this.tbTAG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.gbListaEquipos = new System.Windows.Forms.GroupBox();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.cbModoEdición = new System.Windows.Forms.CheckBox();
            this.gbDatosEquipo.SuspendLayout();
            this.gbListaEquipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(758, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aula:";
            // 
            // cbAulas
            // 
            this.cbAulas.FormattingEnabled = true;
            this.cbAulas.Location = new System.Drawing.Point(795, 52);
            this.cbAulas.Name = "cbAulas";
            this.cbAulas.Size = new System.Drawing.Size(159, 21);
            this.cbAulas.TabIndex = 1;
            // 
            // gbDatosEquipo
            // 
            this.gbDatosEquipo.Controls.Add(this.cbActivo);
            this.gbDatosEquipo.Controls.Add(this.label8);
            this.gbDatosEquipo.Controls.Add(this.tbNumeroSerie);
            this.gbDatosEquipo.Controls.Add(this.label7);
            this.gbDatosEquipo.Controls.Add(this.tbFabricante);
            this.gbDatosEquipo.Controls.Add(this.label6);
            this.gbDatosEquipo.Controls.Add(this.tbProcesador);
            this.gbDatosEquipo.Controls.Add(this.label5);
            this.gbDatosEquipo.Controls.Add(this.tbDominio);
            this.gbDatosEquipo.Controls.Add(this.label4);
            this.gbDatosEquipo.Controls.Add(this.tbSistemaOperativo);
            this.gbDatosEquipo.Controls.Add(this.label3);
            this.gbDatosEquipo.Controls.Add(this.tbUsuarioPC);
            this.gbDatosEquipo.Controls.Add(this.tbTAG);
            this.gbDatosEquipo.Controls.Add(this.label2);
            this.gbDatosEquipo.Location = new System.Drawing.Point(752, 83);
            this.gbDatosEquipo.Name = "gbDatosEquipo";
            this.gbDatosEquipo.Size = new System.Drawing.Size(224, 255);
            this.gbDatosEquipo.TabIndex = 2;
            this.gbDatosEquipo.TabStop = false;
            this.gbDatosEquipo.Text = "Datos del equipo";
            // 
            // cbActivo
            // 
            this.cbActivo.AutoSize = true;
            this.cbActivo.Location = new System.Drawing.Point(9, 227);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(91, 17);
            this.cbActivo.TabIndex = 14;
            this.cbActivo.Text = "Equipo activo";
            this.cbActivo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Número de serie:";
            // 
            // tbNumeroSerie
            // 
            this.tbNumeroSerie.Location = new System.Drawing.Point(111, 32);
            this.tbNumeroSerie.Name = "tbNumeroSerie";
            this.tbNumeroSerie.Size = new System.Drawing.Size(100, 20);
            this.tbNumeroSerie.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Marca/Fabricante:";
            // 
            // tbFabricante
            // 
            this.tbFabricante.Location = new System.Drawing.Point(111, 188);
            this.tbFabricante.Name = "tbFabricante";
            this.tbFabricante.Size = new System.Drawing.Size(100, 20);
            this.tbFabricante.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Procesador:";
            // 
            // tbProcesador
            // 
            this.tbProcesador.Location = new System.Drawing.Point(111, 162);
            this.tbProcesador.Name = "tbProcesador";
            this.tbProcesador.Size = new System.Drawing.Size(100, 20);
            this.tbProcesador.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dominio:";
            // 
            // tbDominio
            // 
            this.tbDominio.Location = new System.Drawing.Point(111, 136);
            this.tbDominio.Name = "tbDominio";
            this.tbDominio.Size = new System.Drawing.Size(100, 20);
            this.tbDominio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sistema operativo:";
            // 
            // tbSistemaOperativo
            // 
            this.tbSistemaOperativo.Location = new System.Drawing.Point(111, 110);
            this.tbSistemaOperativo.Name = "tbSistemaOperativo";
            this.tbSistemaOperativo.Size = new System.Drawing.Size(100, 20);
            this.tbSistemaOperativo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre del equipo:";
            // 
            // tbUsuarioPC
            // 
            this.tbUsuarioPC.Location = new System.Drawing.Point(111, 84);
            this.tbUsuarioPC.Name = "tbUsuarioPC";
            this.tbUsuarioPC.Size = new System.Drawing.Size(100, 20);
            this.tbUsuarioPC.TabIndex = 2;
            // 
            // tbTAG
            // 
            this.tbTAG.Location = new System.Drawing.Point(111, 58);
            this.tbTAG.Name = "tbTAG";
            this.tbTAG.Size = new System.Drawing.Size(100, 20);
            this.tbTAG.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "TAG:";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(819, 405);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(157, 58);
            this.btnEjecutar.TabIndex = 3;
            this.btnEjecutar.Text = "Ejecutar acción";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // gbListaEquipos
            // 
            this.gbListaEquipos.Controls.Add(this.dgvEquipos);
            this.gbListaEquipos.Location = new System.Drawing.Point(12, 12);
            this.gbListaEquipos.Name = "gbListaEquipos";
            this.gbListaEquipos.Size = new System.Drawing.Size(734, 451);
            this.gbListaEquipos.TabIndex = 4;
            this.gbListaEquipos.TabStop = false;
            this.gbListaEquipos.Text = "Lista de equipos";
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Location = new System.Drawing.Point(6, 17);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.Size = new System.Drawing.Size(722, 428);
            this.dgvEquipos.TabIndex = 0;
            this.dgvEquipos.CurrentCellChanged += new System.EventHandler(this.dgvEquipos_CurrentCellChanged);
            // 
            // cbModoEdición
            // 
            this.cbModoEdición.AutoSize = true;
            this.cbModoEdición.Location = new System.Drawing.Point(761, 29);
            this.cbModoEdición.Name = "cbModoEdición";
            this.cbModoEdición.Size = new System.Drawing.Size(90, 17);
            this.cbModoEdición.TabIndex = 5;
            this.cbModoEdición.Text = "Modo edición";
            this.cbModoEdición.UseVisualStyleBackColor = true;
            this.cbModoEdición.CheckedChanged += new System.EventHandler(this.cbModoEdición_CheckedChanged);
            // 
            // frmAgregarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 475);
            this.Controls.Add(this.cbModoEdición);
            this.Controls.Add(this.gbListaEquipos);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.gbDatosEquipo);
            this.Controls.Add(this.cbAulas);
            this.Controls.Add(this.label1);
            this.Name = "frmAgregarEquipo";
            this.Text = "frmAgregarEquipo";
            this.Load += new System.EventHandler(this.frmAgregarEquipo_Load);
            this.gbDatosEquipo.ResumeLayout(false);
            this.gbDatosEquipo.PerformLayout();
            this.gbListaEquipos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAulas;
        private System.Windows.Forms.GroupBox gbDatosEquipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNumeroSerie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFabricante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbProcesador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDominio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSistemaOperativo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUsuarioPC;
        private System.Windows.Forms.TextBox tbTAG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.GroupBox gbListaEquipos;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.CheckBox cbActivo;
        private System.Windows.Forms.CheckBox cbModoEdición;
    }
}