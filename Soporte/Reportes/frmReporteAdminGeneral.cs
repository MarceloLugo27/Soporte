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
    public partial class frmReporteAdminGeneral : Form
    {
        public frmReporteAdminGeneral()
        {
            InitializeComponent();
        }

        private void frmReporteAdminGeneral_Load(object sender, EventArgs e)
        {
            string FechaInicial, FechaFinal;
            FechaInicial = Conexion.FechaInicio.ToString("yyyy-MM-dd");
            FechaFinal = Conexion.FechaFinal.ToString("yyyy-MM-dd");

            try
            {
                DataTable dtReporte = new DataTable();
                dtReporte = RevisionEquiposAdmin.ReportesAulasAdminGeneral(DateTime.Parse(FechaInicial), DateTime.Parse(FechaFinal)).Tables[0];
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = dtReporte;

                ReportParameter rpFechaInicio = new ReportParameter();
                rpFechaInicio.Name = "pDateFechaInicio";
                rpFechaInicio.Values.Add(FechaInicial);

                ReportParameter rpFechaFinal = new ReportParameter();
                rpFechaFinal.Name = "pDateFechaFinal";
                rpFechaFinal.Values.Add(FechaFinal);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rpFechaInicio, rpFechaFinal });
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                ex.ToString();
                throw ex;
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
