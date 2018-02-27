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
    public partial class frmAgregarEquipo : Form
    {
        public frmAgregarEquipo()
        {
            InitializeComponent();
        }

        private void frmAgregarEquipo_Load(object sender, EventArgs e)
        {
            gbListaEquipos.Enabled = false;
            DataSet dsAulas = new DataSet();
            dsAulas = Aulas.AulasSelect();
            cbAulas.DataSource = dsAulas.Tables[0];
            cbAulas.ValueMember = "IDAula";
            cbAulas.DisplayMember = "strDescripcionAula";

            DataSet dsEquipos = new DataSet();
            dsEquipos = HardwarePC.EquiposSelectDatos(99);
            dgvEquipos.DataSource = dsEquipos.Tables[0];
            gbListaEquipos.Enabled = false;
            
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (btnEjecutar.Text == "Añadir equipo")
            {
            HardwarePC equipoNuevo = new HardwarePC();
            equipoNuevo.IntIDAula = int.Parse(cbAulas.SelectedValue.ToString());
            equipoNuevo.StrNumeroSerie = tbNumeroSerie.Text;
            equipoNuevo.IntTAG = tbTAG.Text;
            equipoNuevo.StrUsuarioPC = tbUsuarioPC.Text;
            equipoNuevo.StrSistemaOperativo = tbSistemaOperativo.Text;
            equipoNuevo.StrDominio = tbDominio.Text;
            equipoNuevo.StrNombreProcesador = tbProcesador.Text;
            equipoNuevo.StrFabricante = tbFabricante.Text;

            HardwarePC.EquipoInsertar(equipoNuevo);
            }

            if (btnEjecutar.Text == "Editar datos")
            {

            }
        }

        private void cbModoEdición_CheckedChanged(object sender, EventArgs e)
        {
            if (cbModoEdición.Checked == true)
            {
            gbListaEquipos.Enabled = true;
            btnEjecutar.Text = "Editar datos";
            }
            if (cbModoEdición.Checked == false)
            {
                gbListaEquipos.Enabled = false;
                btnEjecutar.Text = "Añadir equipo";
                gbListaEquipos.Enabled = false;
                tbNumeroSerie.Text = "";
                tbTAG.Text = "";
                tbUsuarioPC.Text = "";
                tbSistemaOperativo.Text = "";
                tbDominio.Text = "";
                tbProcesador.Text = "";
                tbFabricante.Text = "";
            }
        }
    }
}
