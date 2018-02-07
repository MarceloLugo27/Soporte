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

namespace Soporte.Formularios
{
    public partial class FormEquiposPrivados : Form
    {
        DataSet dsAulas = new DataSet();
        DataSet dsAsistente = new DataSet();
        int IDHardware;
        public FormEquiposPrivados()
        {
            InitializeComponent();
        }

        private void FormEquiposPrivados_Load(object sender, EventArgs e)
        {
            dsAulas = HardwarePC.EquiposSelectDatos(0);
            dgvAulasPrivadas.DataSource = dsAulas.Tables[0];
            
            dgvAulasPrivadas.Refresh();

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

            lblUsuario.Text = Conexion.NombreUsuario;

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            RevisionEquiposPrivados revision = new RevisionEquiposPrivados();

            DataTable respuesta = new DataTable();

            
            revision.IntIDUsuario = Conexion.IDUsuario;
            revision.IntIDHardware = IDHardware;
            revision.StrObservaciones = tbObservaciones.Text;
            revision.DateFechaRegistro = dtpFechaRevision.Value;
            
            revision.DateFechaIngresoSistema = dtpFechaRevision.Value;
            revision.IntIDAsistente1 = int.Parse(cbAsistente1.SelectedValue.ToString());
            revision.IntIDAsistente2 = int.Parse(cbAsistente2.SelectedValue.ToString());
            revision.IntIDAsistente3 = int.Parse(cbAsistente3.SelectedValue.ToString());
            revision.BoolRevisionCPU = chbCPU.Checked;
            revision.BoolRevisionMonitor = chbMonitor.Checked;
            revision.BoolRevisionMouse = chbMouse.Checked;
            revision.BoolRevisionTeclado = chbTeclado.Checked;
            revision.BoolRevisionCablesUSB = chbCableUSB.Checked;
            revision.BoolRevisionProyector = chbProyector.Checked;
            revision.BoolRevisionUpdates = chbUpdates.Checked;
            revision.BoolRevisionOptimizacion = chbOptimizacion.Checked;
            revision.BoolRevisionAntivirus = chbAntivirus.Checked;

            respuesta = RevisionEquiposPrivados.RevisionAulasInsertar(revision).Tables[0];
            int response = int.Parse(respuesta.Rows[0][0].ToString());
            if (response > 0)
            {
                MessageBox.Show("Registro dado de alta con éxito.");
                cbAsistente1.SelectedIndex = 0;
                cbAsistente2.SelectedIndex = 0;
                cbAsistente3.SelectedIndex = 0;
                chbAntivirus.Checked = false;
                chbCableUSB.Checked = false;
                chbCPU.Checked = false;
                chbMonitor.Checked = false;
                chbMouse.Checked = false;
                chbOptimizacion.Checked = false;
                chbProyector.Checked = false;
                chbTeclado.Checked = false;
                chbUpdates.Checked = false;
                tbObservaciones.Text = "";
            }
            else
            {
                MessageBox.Show(respuesta.Rows[0][1].ToString());
            }

        }

        private void dgvAulasPrivadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvAulasPrivadas_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvAulasPrivadas.SelectedCells.Count > 0)
            {
                IDHardware = int.Parse(dgvAulasPrivadas.CurrentRow.Cells[0].Value.ToString());
            }
        }
    }
}
