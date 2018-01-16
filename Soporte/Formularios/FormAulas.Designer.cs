namespace Soporte.Formularios
{
    partial class FormAulas
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
            this.tbNombreAula = new System.Windows.Forms.TextBox();
            this.dgvAulas = new System.Windows.Forms.DataGridView();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.chbUsosMultiples = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbAulaPrivada = new System.Windows.Forms.RadioButton();
            this.rdbAulaMultiple = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del aula:";
            // 
            // tbNombreAula
            // 
            this.tbNombreAula.Location = new System.Drawing.Point(102, 20);
            this.tbNombreAula.Name = "tbNombreAula";
            this.tbNombreAula.Size = new System.Drawing.Size(100, 20);
            this.tbNombreAula.TabIndex = 1;
            // 
            // dgvAulas
            // 
            this.dgvAulas.AllowUserToAddRows = false;
            this.dgvAulas.AllowUserToDeleteRows = false;
            this.dgvAulas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvAulas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAulas.Location = new System.Drawing.Point(12, 143);
            this.dgvAulas.Name = "dgvAulas";
            this.dgvAulas.ReadOnly = true;
            this.dgvAulas.Size = new System.Drawing.Size(307, 150);
            this.dgvAulas.TabIndex = 2;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(244, 117);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 20);
            this.btnAñadir.TabIndex = 3;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // chbUsosMultiples
            // 
            this.chbUsosMultiples.AutoSize = true;
            this.chbUsosMultiples.Location = new System.Drawing.Point(12, 46);
            this.chbUsosMultiples.Name = "chbUsosMultiples";
            this.chbUsosMultiples.Size = new System.Drawing.Size(115, 17);
            this.chbUsosMultiples.TabIndex = 2;
            this.chbUsosMultiples.Text = "Aula usos múltiples";
            this.chbUsosMultiples.UseVisualStyleBackColor = true;
            this.chbUsosMultiples.CheckedChanged += new System.EventHandler(this.chbUsosMultiples_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.rdbAulaMultiple);
            this.groupBox1.Controls.Add(this.rdbAulaPrivada);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 91);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de aula";
            // 
            // rdbAulaPrivada
            // 
            this.rdbAulaPrivada.AutoSize = true;
            this.rdbAulaPrivada.Location = new System.Drawing.Point(7, 20);
            this.rdbAulaPrivada.Name = "rdbAulaPrivada";
            this.rdbAulaPrivada.Size = new System.Drawing.Size(84, 17);
            this.rdbAulaPrivada.TabIndex = 0;
            this.rdbAulaPrivada.TabStop = true;
            this.rdbAulaPrivada.Text = "Aula privada";
            this.rdbAulaPrivada.UseVisualStyleBackColor = true;
            this.rdbAulaPrivada.CheckedChanged += new System.EventHandler(this.rdbAulaPrivada_CheckedChanged);
            // 
            // rdbAulaMultiple
            // 
            this.rdbAulaMultiple.AutoSize = true;
            this.rdbAulaMultiple.Location = new System.Drawing.Point(7, 44);
            this.rdbAulaMultiple.Name = "rdbAulaMultiple";
            this.rdbAulaMultiple.Size = new System.Drawing.Size(84, 17);
            this.rdbAulaMultiple.TabIndex = 1;
            this.rdbAulaMultiple.TabStop = true;
            this.rdbAulaMultiple.Text = "Aula múltiple";
            this.rdbAulaMultiple.UseVisualStyleBackColor = true;
            this.rdbAulaMultiple.CheckedChanged += new System.EventHandler(this.rdbAulaMultiple_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(113, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Aula administrativa";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // FormAulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 309);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chbUsosMultiples);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.dgvAulas);
            this.Controls.Add(this.tbNombreAula);
            this.Controls.Add(this.label1);
            this.Name = "FormAulas";
            this.Text = "FormAulas";
            this.Load += new System.EventHandler(this.FormAulas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombreAula;
        private System.Windows.Forms.DataGridView dgvAulas;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.CheckBox chbUsosMultiples;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rdbAulaMultiple;
        private System.Windows.Forms.RadioButton rdbAulaPrivada;
    }
}