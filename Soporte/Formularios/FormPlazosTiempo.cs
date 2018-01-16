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

namespace Soporte.Formularios
{
    public partial class FormPlazosTiempo : Form
    {
        int intTipoPeriodo = 0;
        public FormPlazosTiempo()
        {
            InitializeComponent();
        }

        private void chbTipoPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTipoPeriodo.Checked == true)
            {
                chbTipoPeriodo.Text = "Periodo anual";
                intTipoPeriodo = 1;
            }
            if (chbTipoPeriodo.Checked == false)
            {
                chbTipoPeriodo.Text = "Periodo semestral";
                intTipoPeriodo = 0;
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            DataTable dsrespuesta = new DataTable();

            dsrespuesta = Conexion.FechasRevisionesInsert(tbDescripcionPeriodo.Text, dtpFechaInicio.Value, dtpFechaIntermedia.Value, dtpFechaFinal.Value, intTipoPeriodo).Tables[0];
            int response = int.Parse(dsrespuesta.Rows[0][0].ToString());
            if (response > 0)
            {
                MessageBox.Show("Registro dado de alta con éxito.");
                tbDescripcionPeriodo.Text = "";
                chbTipoPeriodo.Checked = false;
            }
            else
            {
                MessageBox.Show(dsrespuesta.Rows[0][1].ToString());
            }
        }

        private void FormPlazosTiempo_Load(object sender, EventArgs e)
        {
            dtpFechaIntermedia.MinDate = dtpFechaInicio.Value;
            dtpFechaFinal.MinDate = dtpFechaIntermedia.Value;
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaIntermedia.MinDate = dtpFechaInicio.Value;
            if (dtpFechaIntermedia.Value > dtpFechaIntermedia.MinDate)
            {
                dtpFechaIntermedia.Value = dtpFechaIntermedia.MinDate;
            }
            dtpFechaFinal.MinDate = dtpFechaIntermedia.Value;
            if (dtpFechaFinal.Value > dtpFechaFinal.MinDate)
            {
                dtpFechaFinal.Value = dtpFechaFinal.MinDate;
            }
        }

        private void dtpFechaIntermedia_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
