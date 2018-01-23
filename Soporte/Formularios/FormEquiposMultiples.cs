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
    public partial class FormEquiposMultiples : Form
    {
        DataSet dsAulas = new DataSet();
        DataSet dsAsistente = new DataSet();

        int IDAula;
        String strNombreAula;
        public FormEquiposMultiples()
        {
            InitializeComponent();
        }     

        private void FormEquiposMultiples_Load(object sender, EventArgs e)
        {
            lblAula.Text = "";
            lblUsuario.Text = Conexion.NombreUsuario;

            dsAsistente = Usuarios.UsuarioSelect();

            cbAsistente1.DataSource = new DataView(dsAsistente.Tables[0]);
            cbAsistente1.ValueMember = "IDUsuario";
            cbAsistente1.DisplayMember = "strNombres";

            cbAsistente2.DataSource = new DataView(dsAsistente.Tables[0]);
            cbAsistente2.ValueMember = "IDUsuario";
            cbAsistente2.DisplayMember = "strNombres";

            cbAsistente3.DataSource = new DataView(dsAsistente.Tables[0]);
            cbAsistente3.ValueMember = "IDUsuario";
            cbAsistente3.DisplayMember = "strNombres";

            dsAulas = Aulas.AulasTiposSelect(1);
            dgvAulasMultiples.DataSource = dsAulas.Tables[0];
            //dgvAulasMultiples.Columns[0].Visible = false;

            lblUsuario.Text = Conexion.NombreUsuario;

        }

        private void dgvAulasMultiples_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvAulasMultiples.SelectedCells.Count > 0)
            {
                IDAula = int.Parse(dgvAulasMultiples.CurrentRow.Cells[0].Value.ToString());
                strNombreAula = dgvAulasMultiples.CurrentRow.Cells[1].Value.ToString();
                lblAula.Text = strNombreAula;
                DataSet dsEquipos = new DataSet();
                dsEquipos = HardwarePC.EquiposPorAulaSelect(IDAula);
                if (dsEquipos.Tables[0].Rows.Count > 0)
                {
                    cbEquipo.DataSource = dsEquipos.Tables[0];
                    cbEquipo.ValueMember = "IDHardware";
                    cbEquipo.DisplayMember = "strUsuarioPC";
                    dgvAulasMultiples.Enabled = false;
                    gbAulas.Enabled = false;
                }
            }
        }

        private void dgvAulasMultiples_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            RevisionEquiposMultiples revision = new RevisionEquiposMultiples();

            DataTable respuesta = new DataTable();

            revision.IntIDUsuario = Conexion.IDUsuario;
            revision.StrObservaciones = tbObservaciones.Text;
            revision.DateFechaRegistro = dtpFechaRevision.Value;
            revision.IntIDHardware = int.Parse(cbEquipo.SelectedValue.ToString());

            //corregir
            revision.DateFechaIngresoSistema = dtpFechaRevision.Value;
            revision.IntIDAsistente1 = int.Parse(cbAsistente1.SelectedValue.ToString());
            revision.IntIDAsistente2 = int.Parse(cbAsistente2.SelectedValue.ToString());
            revision.IntIDAsistente3 = int.Parse(cbAsistente3.SelectedValue.ToString());
            revision.BoolRendimiento = chbRendimiento.Checked;
            revision.BoolLimpieza = chbLimpieza.Checked;
            revision.BoolPerifericos = chbPerifericos.Checked;

            respuesta = RevisionEquiposMultiples.RevisionAulasInsertar(revision).Tables[0];
            int response = int.Parse(respuesta.Rows[0][0].ToString());
            if (response > 0)
            {
                MessageBox.Show("Registro dado de alta con éxito.");
                cbAsistente1.SelectedIndex = 0;
                cbAsistente2.SelectedIndex = 1;
                cbAsistente3.SelectedIndex = 3;
                //chbLimpieza.Checked = false;
                //chbPerifericos.Checked = false;
                //chbRendimiento.Checked = false;
                if (cbEquipo.SelectedIndex < cbEquipo.Items.Count)
                {
                cbEquipo.SelectedIndex = cbEquipo.SelectedIndex + 1;
                }
                else
                {
                    MessageBox.Show("Se han terminado de dar de registrar todos los equipos del aula.");
                }
                tbObservaciones.Text = "";
            }
            else
            {
                MessageBox.Show(respuesta.Rows[0][1].ToString());
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dgvAulasMultiples.Enabled = true;
            gbAulas.Enabled = true;
        }

        private void dgvAulasMultiples_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
