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

namespace Soporte.Reportes
{
    public partial class frmListaReportesPrivados : Form
    {
        //DataSet dsAulas = new DataSet();
        //public frmlistaReportesPrivados()
        //{
        //    InitializeComponent();
        //}

        //private void dgvAulasPrivadas_CurrentCellChanged(object sender, EventArgs e)
        //{
        //    if (dgvAulasPrivadas.SelectedCells.Count > 0)
        //    {
        //        Conexion.IDReporte = int.Parse(dgvAulasPrivadas.CurrentRow.Cells[0].Value.ToString());
        //        Conexion.parametro1.Name = "IDReporte";
        //        Conexion.parametro1.Values.Add(Conexion.IDReporte.ToString());
        //    }
        //}

        //private void frmListaReportesPrivados_Load(object sender, EventArgs e)
        //{
        //    dsAulas = RevisionEquiposPrivados.ListaReportesAulasPrivadas();
        //    dgvAulasPrivadas.DataSource = dsAulas.Tables[0];
        //}

        //private void btnGenerarReporte_Click(object sender, EventArgs e)
        //{
        //    //Reportes.frmReportePrivado frmReportePrivado = new Reportes.frmReportePrivado();
        //    //frmReportePrivado.ShowDialog();
        //}

        //private void frmListaReportesPrivados_Load_1(object sender, EventArgs e)
        //{
        //    dsAulas = RevisionEquiposPrivados.ListaReportesAulasPrivadas();
        //    dgvAulasPrivadas.DataSource = dsAulas.Tables[0];
        //}

        DataSet dsAulasPrivadas = new DataSet();
        public frmListaReportesPrivados()
        {
            InitializeComponent();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            Reportes.frmReportePrivado formReportePrivado = new Reportes.frmReportePrivado();
            formReportePrivado.ShowDialog();
        }

        private void dgvListaReportesPrivados_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvListaReportesPrivados.SelectedCells.Count > 0)
            {
                Conexion.IDReporte = int.Parse(dgvListaReportesPrivados.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void frmListaReportesPrivados_Load(object sender, EventArgs e)
        {
            dsAulasPrivadas = RevisionEquiposPrivados.ListaReportesAulasPrivadas();
            dgvListaReportesPrivados.DataSource = dsAulasPrivadas.Tables[0];
        }
    }
}
