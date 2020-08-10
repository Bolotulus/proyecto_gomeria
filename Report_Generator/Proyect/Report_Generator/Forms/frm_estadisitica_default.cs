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
    public partial class frm_previsualizar_conceptos : Form
    {
        public frm_previsualizar_conceptos(DataTable tabla_conceptos)
        {
            InitializeComponent();
            dt_conceptos = tabla_conceptos;
            
        }
        DataTable dt_conceptos;

        public void btn_cerrar_concepto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_previsualizar_archivo_Load(object sender, EventArgs e)
        {
            
            
            calcular_valores(dt_conceptos);
        }
        private void calcular_valores(DataTable tabla)
        {
            int acum_cantidad = 0;
            int acum_precio = 0;
            foreach (DataRow fila in tabla.Rows)
            {
                acum_cantidad+= int.Parse(fila[2].ToString()); acum_precio+= int.Parse(fila[3].ToString());
            }
            lbl_cantidad.Text = acum_cantidad.ToString();
            lbl_precio.Text = acum_precio.ToString();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
