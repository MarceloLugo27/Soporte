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

        public static Nullable<DateTime> FechaInicio;
        public static Nullable<DateTime> FechaIntermedia;
        public static Nullable<DateTime> FechaFinal;

        public static Nullable<DateTime> FechaInicio1;
        public static Nullable<DateTime> FechaIntermedia1;
        public static Nullable<DateTime> FechaFinal1;

        DataSet dsPeriodoSemestral = new DataSet();
        DataSet dsPeriodoAnual = new DataSet();

        DataSet dsFechasSem = new DataSet();
        DataSet dsFechasAn = new DataSet();

        DataTable dtFechaSemestral = new DataTable();
        DataTable dtFechaAnual = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void RevisarEquipos()
         {
            int ValorSem;
            dsPeriodoSemestral = Conexion.MonitorRevisiones(0);
            dgvEquiposSemestrales.DataSource = dsPeriodoSemestral.Tables[0];


            dsFechasSem = Conexion.FechaRevisionesSelect(0);

            cbPeriodoSemestral.DataSource = new DataView(dsFechasSem.Tables[0]);
            cbPeriodoSemestral.ValueMember = "IDFecha";
            cbPeriodoSemestral.DisplayMember = "strDescripcionFecha";

            dtFechaSemestral = Conexion.FechaRevisionesSelect(0, int.Parse(cbPeriodoSemestral.SelectedValue.ToString())).Tables[0];
            FechaInicio = DateTime.Parse(dtFechaSemestral.Rows[0][2].ToString());
            FechaIntermedia = DateTime.Parse(dtFechaSemestral.Rows[0][3].ToString());
            FechaFinal = DateTime.Parse(dtFechaSemestral.Rows[0][4].ToString());

            for (int i = 0; i < dgvEquiposSemestrales.Rows.Count; i++)
            {
                ValorSem = int.Parse(dgvEquiposSemestrales.Rows[i].Cells[3].Value.ToString());
                if (ValorSem == 0)
                {
                    dgvEquiposSemestrales.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    dgvEquiposSemestrales.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //RevisarEquipos();

            if (Conexion.IDUsuario == 1 || Conexion.IDUsuario == 2)
            {
                sistemaToolStripMenuItem.Visible = true;
            }

        }

        #region Menus

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

        private void administrativosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes.ArchivosRDLC.frmListaReportesAdmin frmListaAdmin = new Reportes.ArchivosRDLC.frmListaReportesAdmin();
            frmListaAdmin.ShowDialog();
        }

        private void aulastoolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

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

        private void administrativosgeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmListaReporteAdminGeneral listaGeneral = new Reportes.frmListaReporteAdminGeneral();
            listaGeneral.Show();
        }
        #endregion

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            RevisarEquipos();
        }
    }
}
