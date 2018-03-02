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
    public partial class FormUsuarios : Form
    {
        Boolean esNuevoUsuario = false;
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            gbUsuarios.Enabled = false;
            tbNombres.Text = "";
            tbApellidoPaterno.Text = "";
            tbApellidoMaterno.Text = "";
            tbUsername.Text = "";
            tbContraseña.Text = "";
            chbActivo.Checked = false;
            btnEjecutarAccion.Text = "Añadir";
            esNuevoUsuario = true;
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.PrepararDGV();
        }

        private void btnEjecutarAccion_Click(object sender, EventArgs e)
        {

        }
    }
}
