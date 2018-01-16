using Soporte.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soporte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FormAulas formAulas = new Formularios.FormAulas();
            formAulas.ShowDialog();
        }

        private void aulasPrivadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FormEquiposPrivados formEquiposPrivados = new Formularios.FormEquiposPrivados();
            formEquiposPrivados.Show();
        }

        private void usosMúltiplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FormEquiposMultiples formAulas = new Formularios.FormEquiposMultiples();
            formAulas.ShowDialog();
        }

        private void administrativosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FormEquiposAdministrativos formAdmin = new Formularios.FormEquiposAdministrativos();
            formAdmin.ShowDialog();
        }

        private void aulasPrivadasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes.frmListaReportesPrivados formListaReportes = new Reportes.frmListaReportesPrivados();
            formListaReportes.ShowDialog();
        }

        private void aulasUsosMúltiplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmListaReportesMultiples formListaReportesMultiples = new Reportes.frmListaReportesMultiples();
            formListaReportesMultiples.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void administrativosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes.ArchivosRDLC.frmListaReportesAdmin frmListaAdmin = new Reportes.ArchivosRDLC.frmListaReportesAdmin();
            frmListaAdmin.ShowDialog();
        }

        private void aulastoolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Conexion.IDUsuario == 1 || Conexion.IDUsuario == 2)
            {
                sistemaToolStripMenuItem.Visible = true;
            }
        }

        private void agregarEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmAgregarEquipo frmAgregarEquipo = new Formularios.frmAgregarEquipo();
            frmAgregarEquipo.ShowDialog();
        }

        private void añadirAulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FormAulas formAulas = new Formularios.FormAulas();
            formAulas.ShowDialog();
        }

        private void plazosDeTiempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FormPlazosTiempo formPlazosTiempo = new Formularios.FormPlazosTiempo();
            formPlazosTiempo.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
