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
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aulastoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirAulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plazosDeTiempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(472, 24);
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
            this.administrativosToolStripMenuItem1});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // aulasPrivadasToolStripMenuItem1
            // 
            this.aulasPrivadasToolStripMenuItem1.Name = "aulasPrivadasToolStripMenuItem1";
            this.aulasPrivadasToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.aulasPrivadasToolStripMenuItem1.Text = "Aulas privadas";
            this.aulasPrivadasToolStripMenuItem1.Click += new System.EventHandler(this.aulasPrivadasToolStripMenuItem1_Click);
            // 
            // aulasUsosMúltiplesToolStripMenuItem
            // 
            this.aulasUsosMúltiplesToolStripMenuItem.Name = "aulasUsosMúltiplesToolStripMenuItem";
            this.aulasUsosMúltiplesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.aulasUsosMúltiplesToolStripMenuItem.Text = "Aulas usos múltiples";
            this.aulasUsosMúltiplesToolStripMenuItem.Click += new System.EventHandler(this.aulasUsosMúltiplesToolStripMenuItem_Click);
            // 
            // administrativosToolStripMenuItem1
            // 
            this.administrativosToolStripMenuItem1.Name = "administrativosToolStripMenuItem1";
            this.administrativosToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.administrativosToolStripMenuItem1.Text = "Administrativos";
            this.administrativosToolStripMenuItem1.Click += new System.EventHandler(this.administrativosToolStripMenuItem1_Click);
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
            this.añadirAulasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 321);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

