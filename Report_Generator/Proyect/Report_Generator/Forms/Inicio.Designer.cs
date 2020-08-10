namespace Report_Generator
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ver_libro = new System.Windows.Forms.Button();
            this.txt_ubicacion_libro = new System.Windows.Forms.TextBox();
            this.btn_examinar_libro = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_prueba = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ver_subcategorias = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_examinar_subcategorias = new System.Windows.Forms.Button();
            this.txt_ubicacion_subcategorias = new System.Windows.Forms.TextBox();
            this.btn_ver_conceptos = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_examinar_conceptos = new System.Windows.Forms.Button();
            this.txt_ubicacion_conceptos = new System.Windows.Forms.TextBox();
            this.pUbicacion_libro = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_columna_3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_columna_5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_columna_2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_columna_4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_columna_1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.chk_columnas_default = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.pUbicacion_libro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ver_libro
            // 
            this.btn_ver_libro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ver_libro.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ver_libro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_libro.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_libro.Location = new System.Drawing.Point(920, 150);
            this.btn_ver_libro.Name = "btn_ver_libro";
            this.btn_ver_libro.Size = new System.Drawing.Size(103, 34);
            this.btn_ver_libro.TabIndex = 0;
            this.btn_ver_libro.Text = "Previsualizar";
            this.btn_ver_libro.UseVisualStyleBackColor = false;
            this.btn_ver_libro.Click += new System.EventHandler(this.btn_ver_conceptos_Click);
            // 
            // txt_ubicacion_libro
            // 
            this.txt_ubicacion_libro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ubicacion_libro.Location = new System.Drawing.Point(14, 156);
            this.txt_ubicacion_libro.Name = "txt_ubicacion_libro";
            this.txt_ubicacion_libro.Size = new System.Drawing.Size(791, 23);
            this.txt_ubicacion_libro.TabIndex = 10;
            this.txt_ubicacion_libro.Text = "C:\\Users\\florencia\\Desktop\\Proyectos Visual Studio\\Report_Generator\\EXCELS Report" +
    " Generator\\BD gomeria NUEVO.xlsx";
            this.txt_ubicacion_libro.TextChanged += new System.EventHandler(this.txt_ubicacion_dominio_TextChanged);
            // 
            // btn_examinar_libro
            // 
            this.btn_examinar_libro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_examinar_libro.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_examinar_libro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_examinar_libro.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_examinar_libro.Location = new System.Drawing.Point(811, 150);
            this.btn_examinar_libro.Name = "btn_examinar_libro";
            this.btn_examinar_libro.Size = new System.Drawing.Size(103, 34);
            this.btn_examinar_libro.TabIndex = 1;
            this.btn_examinar_libro.Text = "Examinar";
            this.btn_examinar_libro.UseVisualStyleBackColor = false;
            this.btn_examinar_libro.Click += new System.EventHandler(this.btn_examinar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ruta del Archivo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btn_prueba
            // 
            this.btn_prueba.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_prueba.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_prueba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prueba.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prueba.Location = new System.Drawing.Point(811, 244);
            this.btn_prueba.Name = "btn_prueba";
            this.btn_prueba.Size = new System.Drawing.Size(212, 35);
            this.btn_prueba.TabIndex = 18;
            this.btn_prueba.Text = "Cargar Archivo";
            this.btn_prueba.UseVisualStyleBackColor = false;
            this.btn_prueba.Click += new System.EventHandler(this.btn_prueba_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ver_subcategorias);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.btn_examinar_subcategorias);
            this.groupBox2.Controls.Add(this.txt_ubicacion_subcategorias);
            this.groupBox2.Controls.Add(this.btn_ver_conceptos);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.btn_examinar_conceptos);
            this.groupBox2.Controls.Add(this.txt_ubicacion_conceptos);
            this.groupBox2.Controls.Add(this.pUbicacion_libro);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.btn_prueba);
            this.groupBox2.Controls.Add(this.btn_ver_libro);
            this.groupBox2.Controls.Add(this.chk_columnas_default);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btn_examinar_libro);
            this.groupBox2.Controls.Add(this.txt_ubicacion_libro);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1036, 293);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Archivo";
            // 
            // btn_ver_subcategorias
            // 
            this.btn_ver_subcategorias.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ver_subcategorias.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ver_subcategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_subcategorias.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_subcategorias.Location = new System.Drawing.Point(920, 93);
            this.btn_ver_subcategorias.Name = "btn_ver_subcategorias";
            this.btn_ver_subcategorias.Size = new System.Drawing.Size(103, 34);
            this.btn_ver_subcategorias.TabIndex = 35;
            this.btn_ver_subcategorias.Text = "Previsualizar";
            this.btn_ver_subcategorias.UseVisualStyleBackColor = false;
            this.btn_ver_subcategorias.Click += new System.EventHandler(this.btn_ver_subcategorias_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(11, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(346, 17);
            this.label20.TabIndex = 38;
            this.label20.Text = "Ruta del Archivo de Texto (.txt) de Subcategorias";
            // 
            // btn_examinar_subcategorias
            // 
            this.btn_examinar_subcategorias.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_examinar_subcategorias.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_examinar_subcategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_examinar_subcategorias.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_examinar_subcategorias.Location = new System.Drawing.Point(811, 93);
            this.btn_examinar_subcategorias.Name = "btn_examinar_subcategorias";
            this.btn_examinar_subcategorias.Size = new System.Drawing.Size(103, 34);
            this.btn_examinar_subcategorias.TabIndex = 36;
            this.btn_examinar_subcategorias.Text = "Examinar";
            this.btn_examinar_subcategorias.UseVisualStyleBackColor = false;
            this.btn_examinar_subcategorias.Click += new System.EventHandler(this.btn_examinar_subcategorias_Click);
            // 
            // txt_ubicacion_subcategorias
            // 
            this.txt_ubicacion_subcategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ubicacion_subcategorias.Location = new System.Drawing.Point(14, 99);
            this.txt_ubicacion_subcategorias.Name = "txt_ubicacion_subcategorias";
            this.txt_ubicacion_subcategorias.Size = new System.Drawing.Size(791, 23);
            this.txt_ubicacion_subcategorias.TabIndex = 37;
            this.txt_ubicacion_subcategorias.Text = "C:\\Users\\florencia\\Desktop\\Proyectos Visual Studio\\Report_Generator\\subconceptos." +
    "txt";
            // 
            // btn_ver_conceptos
            // 
            this.btn_ver_conceptos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ver_conceptos.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ver_conceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_conceptos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_conceptos.Location = new System.Drawing.Point(920, 39);
            this.btn_ver_conceptos.Name = "btn_ver_conceptos";
            this.btn_ver_conceptos.Size = new System.Drawing.Size(103, 34);
            this.btn_ver_conceptos.TabIndex = 31;
            this.btn_ver_conceptos.Text = "Previsualizar";
            this.btn_ver_conceptos.UseVisualStyleBackColor = false;
            this.btn_ver_conceptos.Click += new System.EventHandler(this.btn_ver_conceptos_Click_1);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(11, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(324, 17);
            this.label19.TabIndex = 34;
            this.label19.Text = "Ruta del Archivo de Texto (.txt) de Conceptos";
            // 
            // btn_examinar_conceptos
            // 
            this.btn_examinar_conceptos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_examinar_conceptos.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_examinar_conceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_examinar_conceptos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_examinar_conceptos.Location = new System.Drawing.Point(811, 39);
            this.btn_examinar_conceptos.Name = "btn_examinar_conceptos";
            this.btn_examinar_conceptos.Size = new System.Drawing.Size(103, 34);
            this.btn_examinar_conceptos.TabIndex = 32;
            this.btn_examinar_conceptos.Text = "Examinar";
            this.btn_examinar_conceptos.UseVisualStyleBackColor = false;
            this.btn_examinar_conceptos.Click += new System.EventHandler(this.btn_examinar_conceptos_Click);
            // 
            // txt_ubicacion_conceptos
            // 
            this.txt_ubicacion_conceptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ubicacion_conceptos.Location = new System.Drawing.Point(14, 45);
            this.txt_ubicacion_conceptos.Name = "txt_ubicacion_conceptos";
            this.txt_ubicacion_conceptos.Size = new System.Drawing.Size(791, 23);
            this.txt_ubicacion_conceptos.TabIndex = 33;
            this.txt_ubicacion_conceptos.Text = "C:\\Users\\florencia\\Desktop\\Proyectos Visual Studio\\Report_Generator\\CONCEPTOS.txt" +
    "";
            // 
            // pUbicacion_libro
            // 
            this.pUbicacion_libro.BackColor = System.Drawing.SystemColors.Control;
            this.pUbicacion_libro.Controls.Add(this.textBox1);
            this.pUbicacion_libro.Controls.Add(this.label9);
            this.pUbicacion_libro.Controls.Add(this.txt_columna_3);
            this.pUbicacion_libro.Controls.Add(this.label14);
            this.pUbicacion_libro.Controls.Add(this.txt_columna_5);
            this.pUbicacion_libro.Controls.Add(this.label12);
            this.pUbicacion_libro.Controls.Add(this.txt_columna_2);
            this.pUbicacion_libro.Controls.Add(this.label13);
            this.pUbicacion_libro.Controls.Add(this.txt_columna_4);
            this.pUbicacion_libro.Controls.Add(this.label11);
            this.pUbicacion_libro.Controls.Add(this.txt_columna_1);
            this.pUbicacion_libro.Controls.Add(this.label10);
            this.pUbicacion_libro.Controls.Add(this.label18);
            this.pUbicacion_libro.Enabled = false;
            this.pUbicacion_libro.Location = new System.Drawing.Point(14, 211);
            this.pUbicacion_libro.Name = "pUbicacion_libro";
            this.pUbicacion_libro.Size = new System.Drawing.Size(791, 67);
            this.pUbicacion_libro.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(76, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 23);
            this.textBox1.TabIndex = 30;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Fila Inicio";
            // 
            // txt_columna_3
            // 
            this.txt_columna_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_columna_3.Location = new System.Drawing.Point(466, 33);
            this.txt_columna_3.Name = "txt_columna_3";
            this.txt_columna_3.Size = new System.Drawing.Size(43, 23);
            this.txt_columna_3.TabIndex = 28;
            this.txt_columna_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(394, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "Columna 3";
            // 
            // txt_columna_5
            // 
            this.txt_columna_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_columna_5.Location = new System.Drawing.Point(726, 33);
            this.txt_columna_5.Name = "txt_columna_5";
            this.txt_columna_5.Size = new System.Drawing.Size(43, 23);
            this.txt_columna_5.TabIndex = 26;
            this.txt_columna_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(654, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Columna 5";
            // 
            // txt_columna_2
            // 
            this.txt_columna_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_columna_2.Location = new System.Drawing.Point(336, 33);
            this.txt_columna_2.Name = "txt_columna_2";
            this.txt_columna_2.Size = new System.Drawing.Size(43, 23);
            this.txt_columna_2.TabIndex = 24;
            this.txt_columna_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(264, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "Columna 2";
            // 
            // txt_columna_4
            // 
            this.txt_columna_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_columna_4.Location = new System.Drawing.Point(596, 33);
            this.txt_columna_4.Name = "txt_columna_4";
            this.txt_columna_4.Size = new System.Drawing.Size(43, 23);
            this.txt_columna_4.TabIndex = 22;
            this.txt_columna_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(524, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Columna 4";
            // 
            // txt_columna_1
            // 
            this.txt_columna_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_columna_1.Location = new System.Drawing.Point(206, 33);
            this.txt_columna_1.Name = "txt_columna_1";
            this.txt_columna_1.Size = new System.Drawing.Size(43, 23);
            this.txt_columna_1.TabIndex = 20;
            this.txt_columna_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(134, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Columna 1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label18.Location = new System.Drawing.Point(5, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(497, 15);
            this.label18.TabIndex = 12;
            this.label18.Text = "Ubicacion de la Fila y Columnas del Dominio Estadisitico (Fila->Numero, Columna->" +
    "Letras)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label17.Location = new System.Drawing.Point(814, 226);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(208, 15);
            this.label17.TabIndex = 29;
            this.label17.Text = "Presiona Aquí para Cargar el Archivo";
            // 
            // chk_columnas_default
            // 
            this.chk_columnas_default.AutoSize = true;
            this.chk_columnas_default.Checked = true;
            this.chk_columnas_default.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_columnas_default.Location = new System.Drawing.Point(14, 185);
            this.chk_columnas_default.Name = "chk_columnas_default";
            this.chk_columnas_default.Size = new System.Drawing.Size(177, 19);
            this.chk_columnas_default.TabIndex = 13;
            this.chk_columnas_default.Text = "Fila y Columnas por defecto";
            this.chk_columnas_default.UseVisualStyleBackColor = true;
            this.chk_columnas_default.CheckedChanged += new System.EventHandler(this.chk_columnas_default_CheckedChanged);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1061, 312);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics Generator";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pUbicacion_libro.ResumeLayout(false);
            this.pUbicacion_libro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ver_libro;
        private System.Windows.Forms.TextBox txt_ubicacion_libro;
        private System.Windows.Forms.Button btn_examinar_libro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_prueba;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_columnas_default;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel pUbicacion_libro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_columna_3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_columna_5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_columna_2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_columna_4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_columna_1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_ver_conceptos;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_examinar_conceptos;
        private System.Windows.Forms.TextBox txt_ubicacion_conceptos;
        private System.Windows.Forms.Button btn_ver_subcategorias;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btn_examinar_subcategorias;
        private System.Windows.Forms.TextBox txt_ubicacion_subcategorias;
    }
}

