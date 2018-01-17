using Soporte.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soporte.Reportes
{
    public partial class frmListaReporteAdminGeneral : Form
    {
        DataSet dsFechas = new DataSet();
        DataTable dtFechasInicializar = new DataTable();
        public frmListaReporteAdminGeneral()
        {
            InitializeComponent();
        }

        private void frmListaReporteAdminGeneral_Load(object sender, EventArgs e)
        {
            dsFechas = Conexion.FechaRevisionesSelect(0);

            cbPeriodoTiempo.DataSource = new DataView(dsFechas.Tables[0]);
            cbPeriodoTiempo.ValueMember = "IDFecha";
            cbPeriodoTiempo.DisplayMember = "strDescripcionFecha";

            Debug.Print(Conexion.FechaInicio.ToString());
        }

        private void cbPeriodoTiempo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtFechasInicializar = Conexion.FechaRevisionesSelect(0, int.Parse(cbPeriodoTiempo.SelectedValue.ToString())).Tables[0];
            Conexion.FechaInicio = DateTime.Parse(dtFechasInicializar.Rows[0][2].ToString());
            Conexion.FechaFinal = DateTime.Parse(dtFechasInicializar.Rows[0][4].ToString());
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Reportes.frmReporteAdminGeneral reporteGeneral = new frmReporteAdminGeneral();
            reporteGeneral.Show();
            this.Close();
        }
    }
}
