namespace Report_Generator.Forms
{
    partial class frm_principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_columna_1_c = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_cargar_bd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p_padre = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_eliminar_bd = new System.Windows.Forms.Button();
            this.btn_modificar_bd = new System.Windows.Forms.Button();
            this.txt_columna_1_c.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_columna_1_c
            // 
            this.txt_columna_1_c.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_columna_1_c.Controls.Add(this.panel15);
            this.txt_columna_1_c.Controls.Add(this.label6);
            this.txt_columna_1_c.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_columna_1_c.Location = new System.Drawing.Point(0, 0);
            this.txt_columna_1_c.Name = "txt_columna_1_c";
            this.txt_columna_1_c.Size = new System.Drawing.Size(1072, 93);
            this.txt_columna_1_c.TabIndex = 24;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Location = new System.Drawing.Point(0, 83);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1072, 10);
            this.panel15.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(-6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(987, 82);
            this.label6.TabIndex = 0;
            this.label6.Text = "Neumaticos Usados Cordoba";
            // 
            // btn_cargar_bd
            // 
            this.btn_cargar_bd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cargar_bd.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cargar_bd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargar_bd.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar_bd.Location = new System.Drawing.Point(21, 15);
            this.btn_cargar_bd.Name = "btn_cargar_bd";
            this.btn_cargar_bd.Size = new System.Drawing.Size(160, 47);
            this.btn_cargar_bd.TabIndex = 36;
            this.btn_cargar_bd.Text = "Cargar base de datos";
            this.btn_cargar_bd.UseVisualStyleBackColor = false;
            this.btn_cargar_bd.Click += new System.EventHandler(this.btn_cargar_bd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_modificar_bd);
            this.panel1.Controls.Add(this.btn_eliminar_bd);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_cargar_bd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 652);
            this.panel1.TabIndex = 37;
            // 
            // p_padre
            // 
            this.p_padre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_padre.Location = new System.Drawing.Point(200, 93);
            this.p_padre.Name = "p_padre";
            this.p_padre.Size = new System.Drawing.Size(872, 652);
            this.p_padre.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 47);
            this.button1.TabIndex = 37;
            this.button1.Text = "Examinar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar_bd
            // 
            this.btn_eliminar_bd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_eliminar_bd.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminar_bd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_bd.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_bd.Location = new System.Drawing.Point(21, 146);
            this.btn_eliminar_bd.Name = "btn_eliminar_bd";
            this.btn_eliminar_bd.Size = new System.Drawing.Size(160, 47);
            this.btn_eliminar_bd.TabIndex = 38;
            this.btn_eliminar_bd.Text = "Eliminar base de datos";
            this.btn_eliminar_bd.UseVisualStyleBackColor = false;
            // 
            // btn_modificar_bd
            // 
            this.btn_modificar_bd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_modificar_bd.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_modificar_bd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar_bd.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar_bd.Location = new System.Drawing.Point(20, 80);
            this.btn_modificar_bd.Name = "btn_modificar_bd";
            this.btn_modificar_bd.Size = new System.Drawing.Size(160, 47);
            this.btn_modificar_bd.TabIndex = 39;
            this.btn_modificar_bd.Text = "Modificar base de datos";
            this.btn_modificar_bd.UseVisualStyleBackColor = false;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 745);
            this.Controls.Add(this.p_padre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_columna_1_c);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neumaticos Usados Cordoba";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.txt_columna_1_c.ResumeLayout(false);
            this.txt_columna_1_c.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel txt_columna_1_c;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_cargar_bd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel p_padre;
        private System.Windows.Forms.Button btn_modificar_bd;
        private System.Windows.Forms.Button btn_eliminar_bd;
        private System.Windows.Forms.Button button1;
    }
}