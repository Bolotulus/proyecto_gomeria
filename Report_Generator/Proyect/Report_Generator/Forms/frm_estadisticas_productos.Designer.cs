namespace Report_Generator
{
    partial class frm_estadisticas_productos
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
            this.dgv_conceptos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar_concepto = new System.Windows.Forms.Button();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_promedio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_conceptos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_conceptos
            // 
            this.dgv_conceptos.AllowUserToAddRows = false;
            this.dgv_conceptos.AllowUserToDeleteRows = false;
            this.dgv_conceptos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_conceptos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_conceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_conceptos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_conceptos.Location = new System.Drawing.Point(12, 33);
            this.dgv_conceptos.Name = "dgv_conceptos";
            this.dgv_conceptos.ReadOnly = true;
            this.dgv_conceptos.RowHeadersWidth = 5;
            this.dgv_conceptos.Size = new System.Drawing.Size(534, 773);
            this.dgv_conceptos.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Productos invididuales";
            // 
            // btn_cerrar_concepto
            // 
            this.btn_cerrar_concepto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_concepto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cerrar_concepto.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cerrar_concepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_concepto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_concepto.Location = new System.Drawing.Point(670, 710);
            this.btn_cerrar_concepto.Name = "btn_cerrar_concepto";
            this.btn_cerrar_concepto.Size = new System.Drawing.Size(118, 27);
            this.btn_cerrar_concepto.TabIndex = 23;
            this.btn_cerrar_concepto.Text = "Cerrar";
            this.btn_cerrar_concepto.UseVisualStyleBackColor = false;
            this.btn_cerrar_concepto.Click += new System.EventHandler(this.btn_cerrar_concepto_Click);
            // 
            // lbl_precio
            // 
            this.lbl_precio.BackColor = System.Drawing.Color.White;
            this.lbl_precio.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.Location = new System.Drawing.Point(663, 127);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(122, 22);
            this.lbl_precio.TabIndex = 28;
            this.lbl_precio.Text = "Monto";
            this.lbl_precio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.BackColor = System.Drawing.Color.White;
            this.lbl_cantidad.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(663, 76);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(122, 22);
            this.lbl_cantidad.TabIndex = 27;
            this.lbl_cantidad.Text = "Cantidad";
            this.lbl_cantidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(556, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 46);
            this.label5.TabIndex = 26;
            this.label5.Text = "Monto en Pesos($)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(556, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 46);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cantidad en Unidades (u)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(552, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Totales segun ...";
            // 
            // lbl_promedio
            // 
            this.lbl_promedio.BackColor = System.Drawing.Color.White;
            this.lbl_promedio.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_promedio.Location = new System.Drawing.Point(663, 178);
            this.lbl_promedio.Name = "lbl_promedio";
            this.lbl_promedio.Size = new System.Drawing.Size(122, 22);
            this.lbl_promedio.TabIndex = 32;
            this.lbl_promedio.Text = "Promedio";
            this.lbl_promedio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(556, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 46);
            this.label7.TabIndex = 30;
            this.label7.Text = "Promedio ($/u)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_estadisticas_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.lbl_promedio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cerrar_concepto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_conceptos);
            this.Name = "frm_estadisticas_productos";
            this.Text = "Estadisticas: Por Producto";
            this.Load += new System.EventHandler(this.frm_estadisticas_productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_conceptos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_conceptos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cerrar_concepto;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_promedio;
        private System.Windows.Forms.Label label7;
    }
}