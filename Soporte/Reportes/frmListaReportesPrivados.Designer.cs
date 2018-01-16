namespace Soporte.Reportes
{
    partial class frmListaReportesPrivados
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
            this.dgvListaReportesPrivados = new System.Windows.Forms.DataGridView();
            this.gbReportesPrivados = new System.Windows.Forms.GroupBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaReportesPrivados)).BeginInit();
            this.gbReportesPrivados.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaReportesPrivados
            // 
            this.dgvListaReportesPrivados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaReportesPrivados.Location = new System.Drawing.Point(6, 19);
            this.dgvListaReportesPrivados.Name = "dgvListaReportesPrivados";
            this.dgvListaReportesPrivados.Size = new System.Drawing.Size(682, 252);
            this.dgvListaReportesPrivados.TabIndex = 0;
            this.dgvListaReportesPrivados.CurrentCellChanged += new System.EventHandler(this.dgvListaReportesPrivados_CurrentCellChanged);
            // 
            // gbReportesPrivados
            // 
            this.gbReportesPrivados.Controls.Add(this.dgvListaReportesPrivados);
            this.gbReportesPrivados.Location = new System.Drawing.Point(12, 23);
            this.gbReportesPrivados.Name = "gbReportesPrivados";
            this.gbReportesPrivados.Size = new System.Drawing.Size(694, 277);
            this.gbReportesPrivados.TabIndex = 1;
            this.gbReportesPrivados.TabStop = false;
            this.gbReportesPrivados.Text = "Reportes aulas privadas";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(581, 336);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(125, 49);
            this.btnGenerarReporte.TabIndex = 2;
            this.btnGenerarReporte.Text = "Generar reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // frmListaReportesPrivados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 397);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.gbReportesPrivados);
            this.Name = "frmListaReportesPrivados";
            this.Text = "frmListaReportesPrivados";
            this.Load += new System.EventHandler(this.frmListaReportesPrivados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaReportesPrivados)).EndInit();
            this.gbReportesPrivados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaReportesPrivados;
        private System.Windows.Forms.GroupBox gbReportesPrivados;
        private System.Windows.Forms.Button btnGenerarReporte;
    }
}