using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soporte.Clases;
using System.Diagnostics;

namespace Soporte.Reportes
{
    public partial class frmListaReportesMultiples : Form
    {
        DataSet dsAulaMultiple = new DataSet();
        DataSet dsFechas = new DataSet();
        DataTable dtFechasInicializar = new DataTable();
        //int intIDFecha;

        public frmListaReportesMultiples()
        {
            InitializeComponent();
        }

        private void frmListaReportesMultiples_Load(object sender, EventArgs e)
        {
            //dsAulaMultiple = RevisionEquiposMultiples.ListaReportesAulasMultiples();
            dsFechas = Conexion.FechaRevisionesSelect(0);

            

            cbPeriodoTiempo.DataSource = new DataView(dsFechas.Tables[0]);
            cbPeriodoTiempo.ValueMember = "IDFecha";
            cbPeriodoTiempo.DisplayMember = "strDescripcionFecha";

            Debug.Print(Conexion.FechaInicio.ToString());
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            Reportes.frmReporteMultiple frmReporteMultiple = new frmReporteMultiple();
            frmReporteMultiple.ShowDialog();
        }

        private void dgvListaReportesMultiples_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvListaReportesMultiples.SelectedCells.Count > 0)
            {
                Conexion.IDReporte = int.Parse(dgvListaReportesMultiples.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void cbPeriodoTiempo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtFechasInicializar = Conexion.FechaRevisionesSelect(0, int.Parse(cbPeriodoTiempo.SelectedValue.ToString())).Tables[0];
            Conexion.FechaInicio = DateTime.Parse(dtFechasInicializar.Rows[0][2].ToString());
            Conexion.FechaFinal = DateTime.Parse(dtFechasInicializar.Rows[0][4].ToString());

            dsFechas = RevisionEquiposMultiples.ListaReportesAulasMultiples(Conexion.FechaInicio, Conexion.FechaFinal);
            dgvListaReportesMultiples.DataSource = dsFechas.Tables[0];

        }
    }
}
