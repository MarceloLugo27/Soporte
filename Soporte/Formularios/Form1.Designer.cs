namespace Soporte
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.revisiónDeEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aulasPrivadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usosMúltiplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aulasPrivadasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aulasUsosMúltiplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativosgeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aulastoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirAulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plazosDeTiempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvEquiposSemestrales = new System.Windows.Forms.DataGridView();
            this.gbPeriodoSemestral = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPeriodoSemestral = new System.Windows.Forms.ComboBox();
            this.gbPeriodoAnual = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPeriodoAnual = new System.Windows.Forms.ComboBox();
            this.dgvEquiposAnuales = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposSemestrales)).BeginInit();
            this.gbPeriodoSemestral.SuspendLayout();
            this.gbPeriodoAnual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposAnuales)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revisiónDeEquiposToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1304, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "MenuPrincipal";
            // 
            // revisiónDeEquiposToolStripMenuItem
            // 
            this.revisiónDeEquiposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aulasPrivadasToolStripMenuItem,
            this.usosMúltiplesToolStripMenuItem,
            this.administrativosToolStripMenuItem});
            this.revisiónDeEquiposToolStripMenuItem.Name = "revisiónDeEquiposToolStripMenuItem";
            this.revisiónDeEquiposToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.revisiónDeEquiposToolStripMenuItem.Text = "Revisión de equipos";
            // 
            // aulasPrivadasToolStripMenuItem
            // 
            this.aulasPrivadasToolStripMenuItem.Name = "aulasPrivadasToolStripMenuItem";
            this.aulasPrivadasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.aulasPrivadasToolStripMenuItem.Text = "Aulas privadas";
            this.aulasPrivadasToolStripMenuItem.Click += new System.EventHandler(this.aulasPrivadasToolStripMenuItem_Click);
            // 
            // usosMúltiplesToolStripMenuItem
            // 
            this.usosMúltiplesToolStripMenuItem.Name = "usosMúltiplesToolStripMenuItem";
            this.usosMúltiplesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.usosMúltiplesToolStripMenuItem.Text = "Aulas usos múltiples";
            this.usosMúltiplesToolStripMenuItem.Click += new System.EventHandler(this.usosMúltiplesToolStripMenuItem_Click);
            // 
            // administrativosToolStripMenuItem
            // 
            this.administrativosToolStripMenuItem.Name = "administrativosToolStripMenuItem";
            this.administrativosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.administrativosToolStripMenuItem.Text = "Administrativos";
            this.administrativosToolStripMenuItem.Click += new System.EventHandler(this.administrativosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aulasPrivadasToolStripMenuItem1,
            this.aulasUsosMúltiplesToolStripMenuItem,
            this.administrativosToolStripMenuItem1,
            this.administrativosgeneralToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // aulasPrivadasToolStripMenuItem1
            // 
            this.aulasPrivadasToolStripMenuItem1.Name = "aulasPrivadasToolStripMenuItem1";
            this.aulasPrivadasToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.aulasPrivadasToolStripMenuItem1.Text = "Aulas privadas";
            this.aulasPrivadasToolStripMenuItem1.Click += new System.EventHandler(this.aulasPrivadasToolStripMenuItem1_Click);
            // 
            // aulasUsosMúltiplesToolStripMenuItem
            // 
            this.aulasUsosMúltiplesToolStripMenuItem.Name = "aulasUsosMúltiplesToolStripMenuItem";
            this.aulasUsosMúltiplesToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.aulasUsosMúltiplesToolStripMenuItem.Text = "Aulas usos múltiples";
            this.aulasUsosMúltiplesToolStripMenuItem.Click += new System.EventHandler(this.aulasUsosMúltiplesToolStripMenuItem_Click);
            // 
            // administrativosToolStripMenuItem1
            // 
            this.administrativosToolStripMenuItem1.Name = "administrativosToolStripMenuItem1";
            this.administrativosToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.administrativosToolStripMenuItem1.Text = "Administrativos";
            this.administrativosToolStripMenuItem1.Visible = false;
            this.administrativosToolStripMenuItem1.Click += new System.EventHandler(this.administrativosToolStripMenuItem1_Click);
            // 
            // administrativosgeneralToolStripMenuItem
            // 
            this.administrativosgeneralToolStripMenuItem.Name = "administrativosgeneralToolStripMenuItem";
            this.administrativosgeneralToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.administrativosgeneralToolStripMenuItem.Text = "Administrativos (general)";
            this.administrativosgeneralToolStripMenuItem.Click += new System.EventHandler(this.administrativosgeneralToolStripMenuItem_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.equiposToolStripMenuItem,
            this.aulastoolStripMenuItem1,
            this.plazosDeTiempoToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.ShowShortcutKeys = false;
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            this.sistemaToolStripMenuItem.Visible = false;
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEquiposToolStripMenuItem,
            this.editarEquiposToolStripMenuItem});
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.equiposToolStripMenuItem.Text = "Equipos";
            // 
            // agregarEquiposToolStripMenuItem
            // 
            this.agregarEquiposToolStripMenuItem.Name = "agregarEquiposToolStripMenuItem";
            this.agregarEquiposToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.agregarEquiposToolStripMenuItem.Text = "Agregar equipos";
            this.agregarEquiposToolStripMenuItem.Click += new System.EventHandler(this.agregarEquiposToolStripMenuItem_Click);
            // 
            // editarEquiposToolStripMenuItem
            // 
            this.editarEquiposToolStripMenuItem.Name = "editarEquiposToolStripMenuItem";
            this.editarEquiposToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.editarEquiposToolStripMenuItem.Text = "Editar equipos";
            // 
            // aulastoolStripMenuItem1
            // 
            this.aulastoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirAulasToolStripMenuItem});
            this.aulastoolStripMenuItem1.Name = "aulastoolStripMenuItem1";
            this.aulastoolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.aulastoolStripMenuItem1.Text = "Aulas";
            this.aulastoolStripMenuItem1.Click += new System.EventHandler(this.aulastoolStripMenuItem1_Click);
            // 
            // añadirAulasToolStripMenuItem
            // 
            this.añadirAulasToolStripMenuItem.Name = "añadirAulasToolStripMenuItem";
            this.añadirAulasToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.añadirAulasToolStripMenuItem.Text = "Añadir aulas";
            this.añadirAulasToolStripMenuItem.Click += new System.EventHandler(this.añadirAulasToolStripMenuItem_Click);
            // 
            // plazosDeTiempoToolStripMenuItem
            // 
            this.plazosDeTiempoToolStripMenuItem.Name = "plazosDeTiempoToolStripMenuItem";
            this.plazosDeTiempoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.plazosDeTiempoToolStripMenuItem.Text = "Plazos de tiempo";
            this.plazosDeTiempoToolStripMenuItem.Click += new System.EventHandler(this.plazosDeTiempoToolStripMenuItem_Click);
            // 
            // dgvEquiposSemestrales
            // 
            this.dgvEquiposSemestrales.AllowUserToAddRows = false;
            this.dgvEquiposSemestrales.AllowUserToDeleteRows = false;
            this.dgvEquiposSemestrales.AllowUserToResizeColumns = false;
            this.dgvEquiposSemestrales.AllowUserToResizeRows = false;
            this.dgvEquiposSemestrales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquiposSemestrales.Location = new System.Drawing.Point(6, 73);
            this.dgvEquiposSemestrales.MultiSelect = false;
            this.dgvEquiposSemestrales.Name = "dgvEquiposSemestrales";
            this.dgvEquiposSemestrales.ReadOnly = true;
            this.dgvEquiposSemestrales.RowHeadersVisible = false;
            this.dgvEquiposSemestrales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquiposSemestrales.Size = new System.Drawing.Size(553, 516);
            this.dgvEquiposSemestrales.TabIndex = 2;
            // 
            // gbPeriodoSemestral
            // 
            this.gbPeriodoSemestral.Controls.Add(this.label1);
            this.gbPeriodoSemestral.Controls.Add(this.cbPeriodoSemestral);
            this.gbPeriodoSemestral.Controls.Add(this.dgvEquiposSemestrales);
            this.gbPeriodoSemestral.Location = new System.Drawing.Point(12, 82);
            this.gbPeriodoSemestral.Name = "gbPeriodoSemestral";
            this.gbPeriodoSemestral.Size = new System.Drawing.Size(565, 595);
            this.gbPeriodoSemestral.TabIndex = 3;
            this.gbPeriodoSemestral.TabStop = false;
            this.gbPeriodoSemestral.Text = "Periodo semestral";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Periodo:";
            // 
            // cbPeriodoSemestral
            // 
            this.cbPeriodoSemestral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriodoSemestral.FormattingEnabled = true;
            this.cbPeriodoSemestral.Location = new System.Drawing.Point(58, 33);
            this.cbPeriodoSemestral.Name = "cbPeriodoSemestral";
            this.cbPeriodoSemestral.Size = new System.Drawing.Size(286, 21);
            this.cbPeriodoSemestral.TabIndex = 3;
            this.cbPeriodoSemestral.SelectedIndexChanged += new System.EventHandler(this.cbPeriodoSemestral_SelectedIndexChanged);
            this.cbPeriodoSemestral.SelectionChangeCommitted += new System.EventHandler(this.cbPeriodoSemestral_SelectionChangeCommitted);
            // 
            // gbPeriodoAnual
            // 
            this.gbPeriodoAnual.Controls.Add(this.label2);
            this.gbPeriodoAnual.Controls.Add(this.cbPeriodoAnual);
            this.gbPeriodoAnual.Controls.Add(this.dgvEquiposAnuales);
            this.gbPeriodoAnual.Location = new System.Drawing.Point(727, 82);
            this.gbPeriodoAnual.Name = "gbPeriodoAnual";
            this.gbPeriodoAnual.Size = new System.Drawing.Size(565, 595);
            this.gbPeriodoAnual.TabIndex = 5;
            this.gbPeriodoAnual.TabStop = false;
            this.gbPeriodoAnual.Text = "Periodo anual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Periodo:";
            // 
            // cbPeriodoAnual
            // 
            this.cbPeriodoAnual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriodoAnual.FormattingEnabled = true;
            this.cbPeriodoAnual.Location = new System.Drawing.Point(58, 33);
            this.cbPeriodoAnual.Name = "cbPeriodoAnual";
            this.cbPeriodoAnual.Size = new System.Drawing.Size(286, 21);
            this.cbPeriodoAnual.TabIndex = 3;
            this.cbPeriodoAnual.SelectedIndexChanged += new System.EventHandler(this.cbPeriodoAnual_SelectedIndexChanged);
            this.cbPeriodoAnual.SelectionChangeCommitted += new System.EventHandler(this.cbPeriodoAnual_SelectionChangeCommitted);
            // 
            // dgvEquiposAnuales
            // 
            this.dgvEquiposAnuales.AllowUserToAddRows = false;
            this.dgvEquiposAnuales.AllowUserToDeleteRows = false;
            this.dgvEquiposAnuales.AllowUserToResizeColumns = false;
            this.dgvEquiposAnuales.AllowUserToResizeRows = false;
            this.dgvEquiposAnuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquiposAnuales.Location = new System.Drawing.Point(6, 73);
            this.dgvEquiposAnuales.Name = "dgvEquiposAnuales";
            this.dgvEquiposAnuales.ReadOnly = true;
            this.dgvEquiposAnuales.RowHeadersVisible = false;
            this.dgvEquiposAnuales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquiposAnuales.Size = new System.Drawing.Size(553, 516);
            this.dgvEquiposAnuales.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 689);
            this.Controls.Add(this.gbPeriodoAnual);
            this.Controls.Add(this.gbPeriodoSemestral);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposSemestrales)).EndInit();
            this.gbPeriodoSemestral.ResumeLayout(false);
            this.gbPeriodoSemestral.PerformLayout();
            this.gbPeriodoAnual.ResumeLayout(false);
            this.gbPeriodoAnual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposAnuales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem revisiónDeEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aulasPrivadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usosMúltiplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrativosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plazosDeTiempoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aulasPrivadasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aulasUsosMúltiplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrativosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aulastoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirAulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrativosgeneralToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvEquiposSemestrales;
        private System.Windows.Forms.GroupBox gbPeriodoSemestral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPeriodoSemestral;
        private System.Windows.Forms.GroupBox gbPeriodoAnual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPeriodoAnual;
        private System.Windows.Forms.DataGridView dgvEquiposAnuales;
    }
}

