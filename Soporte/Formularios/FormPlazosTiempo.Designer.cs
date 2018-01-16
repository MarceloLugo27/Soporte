namespace Soporte.Formularios
{
    partial class FormPlazosTiempo
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
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIntermedia = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescripcionPeriodo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chbTipoPeriodo = new System.Windows.Forms.CheckBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(142, 63);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 0;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // dtpFechaIntermedia
            // 
            this.dtpFechaIntermedia.Location = new System.Drawing.Point(142, 88);
            this.dtpFechaIntermedia.Name = "dtpFechaIntermedia";
            this.dtpFechaIntermedia.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIntermedia.TabIndex = 1;
            this.dtpFechaIntermedia.ValueChanged += new System.EventHandler(this.dtpFechaIntermedia_ValueChanged);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(142, 114);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del periodo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha media del periodo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha final del periodo:";
            // 
            // tbDescripcionPeriodo
            // 
            this.tbDescripcionPeriodo.Location = new System.Drawing.Point(142, 24);
            this.tbDescripcionPeriodo.Name = "tbDescripcionPeriodo";
            this.tbDescripcionPeriodo.Size = new System.Drawing.Size(200, 20);
            this.tbDescripcionPeriodo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha inicial del periodo:";
            // 
            // chbTipoPeriodo
            // 
            this.chbTipoPeriodo.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbTipoPeriodo.AutoSize = true;
            this.chbTipoPeriodo.Location = new System.Drawing.Point(15, 146);
            this.chbTipoPeriodo.Name = "chbTipoPeriodo";
            this.chbTipoPeriodo.Size = new System.Drawing.Size(100, 23);
            this.chbTipoPeriodo.TabIndex = 7;
            this.chbTipoPeriodo.Text = "Periodo semestral";
            this.chbTipoPeriodo.UseVisualStyleBackColor = true;
            this.chbTipoPeriodo.CheckedChanged += new System.EventHandler(this.chbTipoPeriodo_CheckedChanged);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(251, 168);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(99, 35);
            this.btnAñadir.TabIndex = 8;
            this.btnAñadir.Text = "Añadir periodo";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // FormPlazosTiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 215);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.chbTipoPeriodo);
            this.Controls.Add(this.tbDescripcionPeriodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.dtpFechaIntermedia);
            this.Controls.Add(this.dtpFechaInicio);
            this.Name = "FormPlazosTiempo";
            this.Text = "FormPlazosTiempo";
            this.Load += new System.EventHandler(this.FormPlazosTiempo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaIntermedia;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDescripcionPeriodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbTipoPeriodo;
        private System.Windows.Forms.Button btnAñadir;
    }
}