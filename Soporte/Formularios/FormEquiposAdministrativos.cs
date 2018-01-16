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
    public partial class FormEquiposAdministrativos : Form
    {
        DataSet dsAsistente = new DataSet();
        DataSet dsAulasAdmin = new DataSet();
        int IDHardware;
        public FormEquiposAdministrativos()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            RevisionEquiposAdmin revision = new RevisionEquiposAdmin();

            DataTable respuesta = new DataTable();

            revision.IntIDHardware = IDHardware;
            revision.IntIDUsuario = Conexion.IDUsuario; 
            revision.StrObservaciones = tbObservaciones.Text;
            revision.DateFechaRegistro = dtpFechaRevision.Value;

            //corregir
            revision.DateFechaIngresoSistema = dtpFechaRevision.Value;
            revision.IntIDAsistente1 = int.Parse(cbAsistente1.SelectedValue.ToString());
            revision.IntIDAsistente2 = int.Parse(cbAsistente2.SelectedValue.ToString());
            revision.IntIDAsistente3 = int.Parse(cbAsistente3.SelectedValue.ToString());
            revision.BoolRendimiento = chbRendimiento.Checked;
            revision.BoolLimpieza = chbLimpieza.Checked;
            revision.BoolPerifericos = chbPerifericos.Checked;

            respuesta = RevisionEquiposAdmin.RevisionAulasInsertar(revision).Tables[0];
            int response = int.Parse(respuesta.Rows[0][0].ToString());
            if (response > 0)
            {
                MessageBox.Show("Registro dado de alta con éxito.");
                cbAsistente1.SelectedIndex = 0;
                cbAsistente2.SelectedIndex = 1;
                cbAsistente3.SelectedIndex = 3;
                chbLimpieza.Checked = false;
                chbPerifericos.Checked = false;
                chbRendimiento.Checked = false;
                tbObservaciones.Text = "";
            }
            else
            {
                MessageBox.Show(respuesta.Rows[0][1].ToString());
            }
        }

        private void dgvAulasAdministrativas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RevisionEquiposAdmin revision = new RevisionEquiposAdmin();

            revision.IntIDHardware = IDHardware;
            revision.IntIDUsuario = Conexion.IDUsuario;
            revision.StrObservaciones = tbObservaciones.Text;
            revision.DateFechaRegistro = dtpFechaRevision.Value;

            //corregir
            revision.DateFechaIngresoSistema = dtpFechaRevision.Value;
            revision.IntIDAsistente1 = int.Parse(cbAsistente1.SelectedValue.ToString());
            revision.IntIDAsistente2 = int.Parse(cbAsistente2.SelectedValue.ToString());
            revision.IntIDAsistente3 = int.Parse(cbAsistente3.SelectedValue.ToString());
            revision.BoolRendimiento = chbRendimiento.Checked;
            revision.BoolLimpieza = chbLimpieza.Checked;
            revision.BoolPerifericos = chbPerifericos.Checked;
        }

        private void FormEquiposAdministrativos_Load(object sender, EventArgs e)
        {
            dsAsistente = Usuarios.UsuarioSelect();
            

            cbAsistente1.DataSource = new DataView(dsAsistente.Tables[0]);
            cbAsistente1.ValueMember = "IDUsuario";
            cbAsistente1.DisplayMember = "strNombres";
            cbAsistente1.Text = "Seleccione...";

            cbAsistente2.DataSource = new DataView(dsAsistente.Tables[0]);
            cbAsistente2.ValueMember = "IDUsuario";
            cbAsistente2.DisplayMember = "strNombres";

            cbAsistente3.DataSource = new DataView(dsAsistente.Tables[0]);
            cbAsistente3.ValueMember = "IDUsuario";
            cbAsistente3.DisplayMember = "strNombres";

            dsAulasAdmin = HardwarePC.EquiposSelectDatos(2);
            dgvAulasAdministrativas.DataSource = dsAulasAdmin.Tables[0];
            dgvAulasAdministrativas.Columns[0].Width = -1;
            dgvAulasAdministrativas.Columns[1].Width = -1;

            lblUsuario.Text = Conexion.NombreUsuario;

        }

        private void dgvAulasAdministrativas_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvAulasAdministrativas.SelectedCells.Count > 0)
            {
                IDHardware = int.Parse(dgvAulasAdministrativas.CurrentRow.Cells[0].Value.ToString());
            }
        }
    }
}
