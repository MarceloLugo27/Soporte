using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Reflection;
using System.IO;
using Soporte.Clases;

namespace Soporte.Reportes
{
    public partial class frmReportePrivado : Form
    {
        public frmReportePrivado()
        {
            InitializeComponent();
        }

        private void frmReportePrivado_Load(object sender, EventArgs e)
        {
            DataTable dtReporte = new DataTable();
            dtReporte = RevisionEquiposPrivados.ReportesAulasPrivadas(Conexion.IDReporte).Tables[0];
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
    }
}
