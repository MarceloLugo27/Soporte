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
            DataSet dsAulas = new DataSet();
            dsAulas = Aulas.AulasSelect();
            cbAulas.DataSource = dsAulas.Tables[0];
            cbAulas.ValueMember = "IDAula";
            cbAulas.DisplayMember = "strDescripcionAula";
            
        }

        private void btnAñadir_Click(object sender, EventArgs e)
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
    }
}
