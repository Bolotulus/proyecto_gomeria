using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;
using SpreadsheetLight;
using Report_Generator.Objetos;
using System.Globalization;

using System.IO;
using LinqToExcel.Extensions;

namespace Report_Generator
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

        }
        General_Task _general_Task = new General_Task();
        DataTable dt_libro = new DataTable(); DataTable dt_conceptos = new DataTable(); DataTable dt_reporte = new DataTable();
        DataTable dt_ordenamiento = new DataTable();
        private void txt_ubicacion_dominio_TextChanged(object sender, EventArgs e)
        {
            if (txt_ubicacion_libro.Text != string.Empty)
                btn_ver_libro.Enabled = true;
            else
                btn_ver_libro.Enabled = false;
        }



        private DataTable tomar_archivo(string path)
        {
            SLDocument sl = new SLDocument(path);
            SLWorksheetStatistics propiedades = sl.GetWorksheetStatistics();
            int ultimaFila = propiedades.EndRowIndex;

            DataTable tabla = new DataTable();
            tabla.Columns.Add(sl.GetCellValueAsString("A" + 1));
            tabla.Columns.Add(sl.GetCellValueAsString("B" + 1));

            for (int x = 2; x <= ultimaFila; x++)
            {
                string concepto = sl.GetCellValueAsString("A" + x);
                int precio = sl.GetCellValueAsInt32("B" + x);
                tabla.Rows.Add(concepto, precio);
            }
            return tabla;
        }
        private DataTable Get_products(string path)
        {
            SLDocument sl = new SLDocument(path);
            int iRow = 2;
            List<Concepto> lstConceptos = new List<Concepto>();


            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
            {
                Concepto _concepto = new Concepto();
                _concepto.concepto = sl.GetCellValueAsString(iRow, 1);
                _concepto.precio = sl.GetCellValueAsInt32(iRow, 2);
                lstConceptos.Add(_concepto);

                iRow++;
            }


            DataTable dt = new DataTable();
            dt.Columns.Add("Concepto"); dt.Columns.Add("Precio");
            foreach (var item in lstConceptos)
            {
                DataRow row = dt.NewRow();
                row["Concepto"] = item.concepto;
                row["Precio"] = item.precio;
                dt.Rows.Add(row);
            }
            return dt;
        }
        private DataTable Get_transactions(string path)
        {
            SLDocument sl1 = new SLDocument(path);
            int iRow = 2;
            List<Transaccion> lstTransaccion = new List<Transaccion>();
            while (!string.IsNullOrEmpty(sl1.GetCellValueAsString(iRow, 1)))
            {
                Transaccion _transaccion = new Transaccion();
                _transaccion.fecha = sl1.GetCellValueAsDateTime(iRow, 1);
                _transaccion.concepto = sl1.GetCellValueAsString(iRow, 2);
                _transaccion.cantidad = sl1.GetCellValueAsInt32(iRow, 3);
                _transaccion.monto = sl1.GetCellValueAsInt32(iRow, 4);
                _transaccion.observacion = sl1.GetCellValueAsString(iRow, 2);
                lstTransaccion.Add(_transaccion);
                iRow++;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("Fecha"); dt.Columns.Add("Concepto"); dt.Columns.Add("Cantidad"); dt.Columns.Add("Monto"); dt.Columns.Add("Observacion");
            foreach (var item in lstTransaccion)
            {
                DataRow row = dt.NewRow();
                row["Fecha"] = item.fecha;
                row["Concepto"] = item.concepto;
                row["Cantidad"] = item.cantidad;
                row["Monto"] = item.monto;
                row["Observacion"] = item.observacion;
                dt.Rows.Add(row);
            }
            return dt;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            Auto_Fill_Columns();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ver_conceptos_Click(object sender, EventArgs e)
        {
            try
            {

                frm_previsualizar_libro previsualizar_Libro = new frm_previsualizar_libro(Make_daily_book());
                previsualizar_Libro.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Error", "¡Ocurrio un Error!");
            }
        }


        private void btn_examinar_Click(object sender, EventArgs e)
        {
            txt_ubicacion_libro.Text = _general_Task.Get_file_path();
        }


        #region FUNCIONES GENERALES 

        private void clean_datatables()
        {
            if (dt_libro.Rows.Count != 0)
            {
                dt_libro.Clear();
            }


        }
        #endregion

        private void btn_limpiar_concepto_Click(object sender, EventArgs e)
        {
            txt_ubicacion_libro.Text = string.Empty;
        }


        private void btn_prueba_Click(object sender, EventArgs e)
        {
            dt_libro = Make_daily_book();
            dt_conceptos = find_conceptos(dt_libro);
            dt_ordenamiento = Make_subcategory_values(Make_concepts_table());
            frm_previsualizar_libro frm = new frm_previsualizar_libro(Fix_database(dt_libro, dt_ordenamiento));
            frm.Show();

        }
        private DataTable find_conceptos(DataTable libro)
        {

            List<string> miListaConceptos = new List<string>();

            DataTable tabla_conceptos = new DataTable();

            tabla_conceptos.Columns.Add("Nombre de Concepto");

            foreach (DataRow fila in libro.Rows)
            {
                string valor = fila[1].ToString();
                if (!Find_in_list(miListaConceptos, valor))
                {
                    miListaConceptos.Add(valor);
                }
            }
            miListaConceptos.Sort();
            foreach (string item in miListaConceptos)
            {
                tabla_conceptos.Rows.Add(item);
            }
            return tabla_conceptos;

        }
        private bool Find_in_list(List<string> lista, string elemento)
        {
            foreach (string item in lista)
            {
                if (item == elemento)
                {
                    return true;
                }
            }
            return false;
        }

        private string[] Array_owner(string h1, string h2, string h3, string h4, string h5)
        {

            string[] headers;
            headers = new string[5] { h1, h2, h3, h4, h5 };
            return headers;

        }
        private DataTable Get_transaccion_values(string[] headers, string path, string[] columns)
        {
            DataTable tabla = new DataTable();
            SLDocument sl = new SLDocument(path);
            SLWorksheetStatistics propiedades = sl.GetWorksheetStatistics();
            int ultimaFila = propiedades.EndRowIndex;

            foreach (string h in headers)
            {
                tabla.Columns.Add(h);
            }
            for (int x = 2; x <= ultimaFila; x++)
            {
                DateTime fecha = sl.GetCellValueAsDateTime(columns[0] + x);
                string concepto = sl.GetCellValueAsString(columns[1] + x);
                int cantidad = sl.GetCellValueAsInt32(columns[2] + x);
                int monto = sl.GetCellValueAsInt32(columns[3] + x);
                string observacion = sl.GetCellValueAsString(columns[4] + x);

                if (concepto != string.Empty)
                {
                    tabla.Rows.Add(fecha.Day.ToString() + "-" + fecha.Month.ToString() + "-" + fecha.Year.ToString(), concepto, cantidad, monto, observacion);
                }
                else
                {
                    break;
                }
            }
            return tabla;
        }
        private void chk_columnas_default_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_columnas_default.Checked)
            {
                pUbicacion_libro.Enabled = false;
                Auto_Fill_Columns();
            }
            else
            {
                pUbicacion_libro.Enabled = true;
                Auto_Clear_Columns();
            }
        }
        private void Auto_Fill_Columns()
        {
            txt_columna_1.Text = "A";
            txt_columna_2.Text = "B";
            txt_columna_3.Text = "C";
            txt_columna_4.Text = "D";
            txt_columna_5.Text = "E";
        }
        private void Auto_Clear_Columns()
        {
            txt_columna_1.Text =
            txt_columna_2.Text =
            txt_columna_3.Text =
            txt_columna_4.Text =
            txt_columna_5.Text = "";
        }
        private DataTable Make_daily_book()
        {
            DataTable dt = new DataTable();

            try
            {
                string h1, h2, h3, h4, h5, c1, c2, c3, c4, c5;
                h1 = "Fecha";
                h2 = "Concepto";
                h3 = "Cantidad";
                h4 = "Monto";
                h5 = "Observacion";

                c1 = txt_columna_1.Text;
                c2 = txt_columna_2.Text;
                c3 = txt_columna_3.Text;
                c4 = txt_columna_4.Text;
                c5 = txt_columna_5.Text;

                return Get_transaccion_values(Array_owner(h1, h2, h3, h4, h5), txt_ubicacion_libro.Text, Array_owner(c1, c2, c3, c4, c5));

            }
            catch (Exception)
            {

                MessageBox.Show("Error al construir el libro.", "¡Ocurrio un Error!");
            }
            return dt;
        }
        private void Find_book_results(DataTable tabla_libro)
        {
            foreach (DataRow fila in tabla_libro.Rows)
            {

            }
        }

        private DataTable Table_corrector(DataTable dt_Incorrecta)
        {
            DataTable dt_correcta = new DataTable();
            Transaccion _transaccion_incorrecta = new Transaccion();
            Transaccion_Completa _transaccion_completa = new Transaccion_Completa();
            List<Transaccion_Completa> lstConceptos = new List<Transaccion_Completa>();

            foreach (DataRow fila in dt_Incorrecta.Rows)
            {
                string valor = fila[1].ToString();

            }

            return dt_correcta;
        }
        private int Recognize_category(string concepto)
        {
            int categoria = 0; int posicion = 0;
            //1  - GOMAS USADAS
            //2  - GOMAS NUEVAS
            //3  - LLANTAS CHAPA
            //4  - LLANTAS ALEACION
            //5  - SERVICIOS           
            foreach (char caracter in concepto)
            {
                if (caracter == 'N' && posicion == 0)
                {
                    return 2;
                }
                posicion++;
            }
            return categoria;
        }
        private string Fix_concept(string concept, int category)
        {
            string fixed_concept = "";
            switch (category)
            {
                case 2:

                    foreach (char c in concept)
                    {
                        if (c == ' ' || c == 'N')
                        {
                            continue;
                        }
                        fixed_concept += c;
                    }
                    break;
            }
            return fixed_concept;
        }

      
        private DataTable Make_concepts_table()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = Get_concepts_values(txt_ubicacion_conceptos.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al construir los conceptos.", "¡Ocurrio un Error!");
            }
            return dt;
        }
        private DataTable Get_concepts_values(string path)
        {
            DataTable tabla = new DataTable();

            string texto_completo;
            StreamReader leer = new StreamReader(path);

            tabla.Columns.Add("Nombre Concepto");
            tabla.Columns.Add("Categoria");
            //tabla.Columns.Add("Subcategoria");

            int categoria = 0;
            while (!leer.EndOfStream)
            {
                texto_completo = leer.ReadLine();
                bool flag = false;

                foreach (char c in texto_completo)
                {
                    if (c == '%')
                    {
                        flag = true;
                        continue;
                    }
                    if (flag)
                    {
                        categoria = int.Parse(c.ToString());
                        break;
                    }
                }
                if (!flag)
                {
                    tabla.Rows.Add(texto_completo, categoria);
                }
            }
            return tabla;
        }
        private DataTable Make_subcategory_values(DataTable tabla_categorias)
        {
            tabla_categorias.Columns.Add("Subcategoria");
            foreach (DataRow fila in tabla_categorias.Rows)
            {
                int categoria = int.Parse(fila[1].ToString());
                if (categoria == 1 || categoria == 5)
                {
                    StringBuilder res = new StringBuilder();
                    string concepto = fila[0].ToString();
                    int largo = concepto.Length;
                    if (concepto[largo - 3].ToString().ToLower() != "x" && concepto[largo - 3].ToString() != "-")
                    {
                        res.Append(concepto.ToString());
                        fila[2] = res.ToString();
                    }
                    else
                    {
                        res.Append(concepto[largo - 2].ToString() + concepto[largo - 1].ToString());

                        fila[2] = int.Parse(res.ToString());
                    }
                }

            }
            return tabla_categorias;
        }
        private void btn_ver_conceptos_Click_1(object sender, EventArgs e)
        {
            try
            {
                frm_previsualizar_libro previsualizar_Libro = new frm_previsualizar_libro(Make_concepts_table());
                previsualizar_Libro.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Error 34", "¡Ocurrio un Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_examinar_conceptos_Click(object sender, EventArgs e)
        {
            txt_ubicacion_conceptos.Text = _general_Task.Get_file_path();
        }

        private void btn_examinar_subcategorias_Click(object sender, EventArgs e)
        {
            txt_ubicacion_subcategorias.Text = _general_Task.Get_file_path();
        }

        private void btn_ver_subcategorias_Click(object sender, EventArgs e)
        {
            try
            {
                frm_previsualizar_libro previsualizar_Libro = new frm_previsualizar_libro(Make_subcategory_values(Make_concepts_table()));
                previsualizar_Libro.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Error 44", "¡Ocurrio un Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataTable Fix_database(DataTable dt_broken, DataTable dt_fixer)
        {
            DataTable dt_repaired = new DataTable();

            dt_repaired.Columns.Add("Fecha");
            dt_repaired.Columns.Add("Concepto");
            dt_repaired.Columns.Add("Categoria");
            dt_repaired.Columns.Add("SubCategoria");
            dt_repaired.Columns.Add("Cantidad");
            dt_repaired.Columns.Add("Precio Unitario");
            dt_repaired.Columns.Add("Observacion");

            foreach (DataRow f_libro in dt_broken.Rows)
            {
                DateTime fecha = DateTime.Parse(f_libro[0].ToString());
                string concepto = f_libro[1].ToString();
                int cantidad = int.Parse(f_libro[2].ToString());
                double precio = int.Parse(f_libro[3].ToString()) / cantidad;
                string observacion = f_libro[4].ToString();
                List<string> tipos = get_category(concepto, dt_fixer);

                string categoria = tipos[0].ToString();
                string subcategoria = tipos[1].ToString();

                dt_repaired.Rows.Add(fecha, concepto, categoria, subcategoria, cantidad, precio, observacion);
            }
            return dt_repaired;
        }
        private List<string> get_category(string concepto, DataTable tabla)
        {
            List<string> lista = new List<string>();
            foreach (DataRow fila in tabla.Rows)
            {
                if (fila[0].ToString().ToLower() == concepto.ToString().ToLower())
                {
                    int categoria = int.Parse(fila[1].ToString());
                    lista.Add(categoria.ToString());
                    if (categoria == 1 || categoria == 5)
                    {
                        lista.Add(fila[2].ToString());
                        return lista;

                    }
                    else
                    {
                        lista.Add("Null");
                        return lista;
                    }
                }
            }
            lista.Add("Undefined");
            lista.Add("Undefined");
            return lista;


        }
    }
}