using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Generator.Forms
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }
        General_Task _general_Task = new General_Task();

        

        private void frm_principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_cargar_bd_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();
            abrir_frm_en_panel(form);
        }
        public void abrir_frm_en_panel(Form f)
        {
            f.TopLevel = false;
            this.p_padre.Controls.Add(f);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
    }
}
