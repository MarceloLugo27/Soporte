using Microsoft.Reporting.WinForms;
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
    public partial class frmReporteAdmin : Form
    {
        public frmReporteAdmin()
        {
            InitializeComponent();
        }

        private void frmReporteAdmin_Load(object sender, EventArgs e)
        {
            try
            {
            DataTable dtReporte = new DataTable();
            dtReporte = RevisionEquiposAdmin.ReportesAulasAdmin(Conexion.IDReporte).Tables[0];
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dtReporte;

            ReportParameter rpIDReporte = new ReportParameter();
            rpIDReporte.Name = "IDReporte";
            rpIDReporte.Values.Add(Conexion.IDReporte.ToString());

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rpIDReporte });
            reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
