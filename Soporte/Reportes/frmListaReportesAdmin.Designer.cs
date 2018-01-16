namespace Soporte.Reportes.ArchivosRDLC
{
    partial class frmListaReportesAdmin
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
            this.gbReportesAdmin = new System.Windows.Forms.GroupBox();
            this.dgvListaReportesAdmin = new System.Windows.Forms.DataGridView();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.gbReportesAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaReportesAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // gbReportesAdmin
            // 
            this.gbReportesAdmin.Controls.Add(this.dgvListaReportesAdmin);
            this.gbReportesAdmin.Location = new System.Drawing.Point(12, 26);
            this.gbReportesAdmin.Name = "gbReportesAdmin";
            this.gbReportesAdmin.Size = new System.Drawing.Size(694, 277);
            this.gbReportesAdmin.TabIndex = 4;
            this.gbReportesAdmin.TabStop = false;
            this.gbReportesAdmin.Text = "Reportes de equipos administrativos";
            // 
            // dgvListaReportesAdmin
            // 
            this.dgvListaReportesAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaReportesAdmin.Location = new System.Drawing.Point(6, 19);
            this.dgvListaReportesAdmin.Name = "dgvListaReportesAdmin";
            this.dgvListaReportesAdmin.Size = new System.Drawing.Size(682, 252);
            this.dgvListaReportesAdmin.TabIndex = 0;
            this.dgvListaReportesAdmin.CurrentCellChanged += new System.EventHandler(this.dgvListaReportesAdmin_CurrentCellChanged);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(581, 336);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(125, 49);
            this.btnGenerarReporte.TabIndex = 5;
            this.btnGenerarReporte.Text = "Generar reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // frmListaReportesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 397);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.gbReportesAdmin);
            this.Name = "frmListaReportesAdmin";
            this.Text = "frmListaReportesAdmin";
            this.Load += new System.EventHandler(this.frmListaReportesAdmin_Load);
            this.gbReportesAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaReportesAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReportesAdmin;
        private System.Windows.Forms.DataGridView dgvListaReportesAdmin;
        private System.Windows.Forms.Button btnGenerarReporte;
    }
}