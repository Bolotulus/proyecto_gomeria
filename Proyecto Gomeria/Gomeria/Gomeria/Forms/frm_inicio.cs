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

namespace Gomeria
{
    public partial class frm_inicio : Form
    {
        public frm_inicio(int id_user, string user, string password, frm_login _login)
        {
            InitializeComponent();
            id_usuario = id_user;
            usuario = user;
            clave = password;
            login = _login;
            
        }
        int id_usuario;
        string usuario, clave;
        frm_login login;
        


        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void frm_inicio_Load(object sender, EventArgs e)
        {
            cargarPanelInformativo(id_usuario, usuario, clave);
        }

        private void btn_prueba_Click(object sender, EventArgs e)
        {
            frm_login form = new frm_login();
            form.Show();
        }

        private void cargarPanelInformativo(int id_usuario, string usuario, string clave)
        {
            lbl_cargo.Text = id_usuario.ToString();
            lbl_fecha.Text = DateTime.Today.ToString();
            lbl_usuario.Text = usuario;
        }
    }
}
