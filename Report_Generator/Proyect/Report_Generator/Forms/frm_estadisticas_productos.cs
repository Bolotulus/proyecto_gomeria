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
    public partial class frm_estadisticas_productos : Form
    {
        public frm_estadisticas_productos(DataTable tabla_libro,DataTable tabla_conceptos)
        {
            InitializeComponent();
            dt_libro = tabla_libro;
            dt_conceptos = tabla_conceptos;
        }

        DataTable dt_libro,dt_conceptos;

        private void btn_cerrar_concepto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private DataTable Fill_products_table(DataTable tabla_libro, DataTable tabla_conceptos)
        {
            Concepto _concepto = new Concepto();
            DataTable dt_productos = new DataTable();
            dt_productos.Columns.Add("Indice");
            dt_productos.Columns.Add("Id Concepto");
            dt_productos.Columns.Add("Cantidad en Pesos ($)");
            dt_productos.Columns.Add("Cantidad en Unidades (u)");
            dt_productos.Columns.Add("Promedio");
            
            int i = 0;Decimal promedio = 0;
            foreach (DataRow fila in tabla_conceptos.Rows)
            {
                _concepto = Find_product_values(fila[0].ToString(),tabla_libro);
                promedio = _concepto.precio / _concepto.cantidad;
                dt_productos.Rows.Add(i,_concepto.concepto,_concepto.precio, _concepto.cantidad,(promedio));
                i++;
            }
            return dt_productos;

        }
        private Concepto Find_product_values(string Id_product,DataTable tabla_libro)
        {
            Concepto _concepto = new Concepto();

            int acum_cant = 0; int acum_monto = 0;

            foreach (DataRow fila in tabla_libro.Rows)
            {
                if(fila[1].ToString() == Id_product)
                {
                    acum_cant += int.Parse(fila[2].ToString());
                    acum_monto += int.Parse(fila[3].ToString());
                }
            }
            _concepto.concepto = Id_product;
            _concepto.cantidad = acum_cant;
            _concepto.precio = acum_monto;
            return _concepto;

        }
        private void calcular_valores(DataTable tabla)
        {
            int acum_cantidad = 0; int acum_promedio = 0; int acum_precio = 0;
            foreach (DataRow fila in tabla.Rows)
            {
                acum_cantidad += int.Parse(fila[2].ToString()); acum_precio += int.Parse(fila[3].ToString()); acum_promedio += int.Parse(fila[4].ToString());
            }
            lbl_cantidad.Text = acum_cantidad.ToString();
            lbl_precio.Text = acum_precio.ToString();
            lbl_promedio.Text = acum_promedio.ToString();
        }
        private void frm_estadisticas_productos_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Fill_products_table(dt_libro, dt_conceptos);
            calcular_valores(dt);

            dgv_conceptos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_conceptos.DataSource = dt;
        }
    }
}
