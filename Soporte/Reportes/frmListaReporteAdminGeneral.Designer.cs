namespace Soporte.Reportes
{
    partial class frmListaReporteAdminGeneral
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
            this.cbPeriodoTiempo = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Periodo:";
            // 
            // cbPeriodoTiempo
            // 
            this.cbPeriodoTiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriodoTiempo.FormattingEnabled = true;
            this.cbPeriodoTiempo.Location = new System.Drawing.Point(64, 28);
            this.cbPeriodoTiempo.Name = "cbPeriodoTiempo";
            this.cbPeriodoTiempo.Size = new System.Drawing.Size(196, 21);
            this.cbPeriodoTiempo.TabIndex = 7;
            this.cbPeriodoTiempo.SelectionChangeCommitted += new System.EventHandler(this.cbPeriodoTiempo_SelectionChangeCommitted);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(142, 62);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(118, 48);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "Generar reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // frmListaReporteAdminGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 122);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPeriodoTiempo);
            this.Name = "frmListaReporteAdminGeneral";
            this.Text = "frmListaReporteAdminGeneral";
            this.Load += new System.EventHandler(this.frmListaReporteAdminGeneral_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPeriodoTiempo;
        private System.Windows.Forms.Button btnGenerar;
    }
}