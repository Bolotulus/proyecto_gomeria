using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gomeria.Forms;

namespace Gomeria.Forms
{
    public partial class frm_login : Form
    {
        int id = 0;
        string user = "ale";
        string password = "123";

        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {

            if (txt_user.Text == this.user && txt_password.Text == this.password)
            {

                frm_inicio frm_inicio = new frm_inicio(id, user, password, this);
                frm_inicio.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
