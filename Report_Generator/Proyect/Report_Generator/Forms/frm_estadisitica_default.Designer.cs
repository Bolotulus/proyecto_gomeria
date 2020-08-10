namespace Report_Generator
{
    partial class frm_previsualizar_conceptos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar_concepto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Totales segun ...";
            // 
            // btn_cerrar_concepto
            // 
            this.btn_cerrar_concepto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_concepto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cerrar_concepto.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cerrar_concepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_concepto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_concepto.Location = new System.Drawing.Point(253, 115);
            this.btn_cerrar_concepto.Name = "btn_cerrar_concepto";
            this.btn_cerrar_concepto.Size = new System.Drawing.Size(118, 27);
            this.btn_cerrar_concepto.TabIndex = 11;
            this.btn_cerrar_concepto.Text = "Cerrar";
            this.btn_cerrar_concepto.UseVisualStyleBackColor = false;
            this.btn_cerrar_concepto.Click += new System.EventHandler(this.btn_cerrar_concepto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Precio ($)";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.BackColor = System.Drawing.Color.White;
            this.lbl_cantidad.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(100, 47);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(122, 22);
            this.lbl_cantidad.TabIndex = 18;
            this.lbl_cantidad.Text = "Cantidad";
            this.lbl_cantidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_precio
            // 
            this.lbl_precio.BackColor = System.Drawing.Color.White;
            this.lbl_precio.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.Location = new System.Drawing.Point(100, 83);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(122, 22);
            this.lbl_precio.TabIndex = 19;
            this.lbl_precio.Text = "Precio";
            this.lbl_precio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_previsualizar_conceptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 154);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cerrar_concepto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_previsualizar_conceptos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadísticas Default";
            this.Load += new System.EventHandler(this.frm_previsualizar_archivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cerrar_concepto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_precio;
    }
}