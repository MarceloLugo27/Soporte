namespace Soporte.Reportes
{
    partial class frmListaReportesMultiples
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
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.gbReportesMultiples = new System.Windows.Forms.GroupBox();
            this.dgvListaReportesMultiples = new System.Windows.Forms.DataGridView();
            this.cbPeriodoTiempo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbReportesMultiples.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaReportesMultiples)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(581, 336);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(125, 49);
            this.btnGenerarReporte.TabIndex = 4;
            this.btnGenerarReporte.Text = "Generar reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // gbReportesMultiples
            // 
            this.gbReportesMultiples.Controls.Add(this.dgvListaReportesMultiples);
            this.gbReportesMultiples.Location = new System.Drawing.Point(12, 53);
            this.gbReportesMultiples.Name = "gbReportesMultiples";
            this.gbReportesMultiples.Size = new System.Drawing.Size(694, 277);
            this.gbReportesMultiples.TabIndex = 3;
            this.gbReportesMultiples.TabStop = false;
            this.gbReportesMultiples.Text = "Reportes aulas de usos múltiples";
            // 
            // dgvListaReportesMultiples
            // 
            this.dgvListaReportesMultiples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaReportesMultiples.Location = new System.Drawing.Point(6, 19);
            this.dgvListaReportesMultiples.Name = "dgvListaReportesMultiples";
            this.dgvListaReportesMultiples.Size = new System.Drawing.Size(682, 252);
            this.dgvListaReportesMultiples.TabIndex = 0;
            this.dgvListaReportesMultiples.CurrentCellChanged += new System.EventHandler(this.dgvListaReportesMultiples_CurrentCellChanged);
            // 
            // cbPeriodoTiempo
            // 
            this.cbPeriodoTiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriodoTiempo.FormattingEnabled = true;
            this.cbPeriodoTiempo.Location = new System.Drawing.Point(67, 26);
            this.cbPeriodoTiempo.Name = "cbPeriodoTiempo";
            this.cbPeriodoTiempo.Size = new System.Drawing.Size(196, 21);
            this.cbPeriodoTiempo.TabIndex = 5;
            this.cbPeriodoTiempo.SelectionChangeCommitted += new System.EventHandler(this.cbPeriodoTiempo_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Periodo:";
            // 
            // frmListaReportesMultiples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPeriodoTiempo);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.gbReportesMultiples);
            this.Name = "frmListaReportesMultiples";
            this.Text = "frmListaReportesMultiples";
            this.Load += new System.EventHandler(this.frmListaReportesMultiples_Load);
            this.gbReportesMultiples.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaReportesMultiples)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.GroupBox gbReportesMultiples;
        private System.Windows.Forms.DataGridView dgvListaReportesMultiples;
        private System.Windows.Forms.ComboBox cbPeriodoTiempo;
        private System.Windows.Forms.Label label1;
    }
}