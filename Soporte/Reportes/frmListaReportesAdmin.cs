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

namespace Soporte.Reportes.ArchivosRDLC
{
    public partial class frmListaReportesAdmin : Form
    {
        DataSet dsAulasAdmin = new DataSet();
        public frmListaReportesAdmin()
        {
            InitializeComponent();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            Reportes.frmReporteAdmin formReporteAdmin = new frmReporteAdmin();
            formReporteAdmin.ShowDialog();
        }

        private void frmListaReportesAdmin_Load(object sender, EventArgs e)
        {
            dsAulasAdmin = RevisionEquiposAdmin.ListaReportesAdmin();
            dgvListaReportesAdmin.DataSource = dsAulasAdmin.Tables[0];
        }

        private void dgvListaReportesAdmin_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvListaReportesAdmin.SelectedCells.Count > 0)
            {
                Conexion.IDReporte = int.Parse(dgvListaReportesAdmin.CurrentRow.Cells[0].Value.ToString());
            }
        }
    }
}
