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
    public partial class frmLogin : Form
    {
        DataSet ds = new DataSet();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Conexion.Username = tbUsuario.Text;
            Conexion.UserPassword = tbPassword.Text;
            ds = Conexion.Login();

            if (ds.Tables[0].Rows.Count > 0)
            {
                Conexion.IDUsuario = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                Conexion.NombreUsuario = ds.Tables[0].Rows[0][2].ToString();
                Form1 form = new Form1();
                form.Show();
                this.Visible = false;
            }
        }
    }
}
