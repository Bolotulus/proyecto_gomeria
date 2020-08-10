using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Generator
{
    public partial class frm_previsualizar_libro : Form
    {
        public frm_previsualizar_libro(DataTable tabla_libro)
        {
            InitializeComponent();
            dt_libro = tabla_libro;

        }
        DataTable dt_libro;

        private void frm_previsualizar_libro_Load(object sender, EventArgs e)
        {
            dgv_libro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_libro.DataSource = dt_libro;
        }

        private void btn_cerrar_concepto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
