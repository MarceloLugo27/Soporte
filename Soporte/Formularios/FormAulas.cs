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
    public partial class FormAulas : Form
    {
        Aulas aulas = new Aulas();
        DataSet ds = new DataSet();
        int IDTipoAula;
        public FormAulas()
        {
            InitializeComponent();
        }

        private void FormAulas_Load(object sender, EventArgs e)
        {
            aulas.IntTipoAula = 0;
            rdbAulaPrivada.Checked = true;
            ds = Aulas.AulasSelect();
            dgvAulas.DataSource = ds.Tables[0];
            dgvAulas.Refresh();
            dgvAulas.Columns["IDAula"].Width = 0;
            dgvAulas.Columns["intTipoAula"].Width = 0;
            dgvAulas.Columns["dateFechaRegistro"].Visible = false;
            dgvAulas.Columns["bitactivo"].Visible = false;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            aulas.StrDescripcionAula = tbNombreAula.Text;
            aulas.IntTipoAula = IDTipoAula;
            Aulas.AulasInsert(aulas);
            ds = Aulas.AulasSelect();
            dgvAulas.DataSource = ds.Tables[0];
            dgvAulas.Refresh();
        }

        private void chbUsosMultiples_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbAulaPrivada_CheckedChanged(object sender, EventArgs e)
        {
           if (rdbAulaPrivada.Checked == true)
            {
                IDTipoAula = 0;
            }
        }

        private void rdbAulaMultiple_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAulaMultiple.Checked == true)
            {
                IDTipoAula = 1;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                IDTipoAula = 3;
            }
        }
    }
}
