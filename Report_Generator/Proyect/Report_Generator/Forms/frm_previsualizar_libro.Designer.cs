namespace Report_Generator
{
    partial class frm_previsualizar_libro
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
            this.dgv_libro = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar_concepto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_libro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_libro
            // 
            this.dgv_libro.AllowUserToAddRows = false;
            this.dgv_libro.AllowUserToDeleteRows = false;
            this.dgv_libro.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_libro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_libro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_libro.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_libro.Location = new System.Drawing.Point(12, 30);
            this.dgv_libro.Name = "dgv_libro";
            this.dgv_libro.ReadOnly = true;
            this.dgv_libro.RowHeadersWidth = 5;
            this.dgv_libro.Size = new System.Drawing.Size(756, 446);
            this.dgv_libro.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Transacciones";
            // 
            // btn_cerrar_concepto
            // 
            this.btn_cerrar_concepto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cerrar_concepto.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cerrar_concepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_concepto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_concepto.Location = new System.Drawing.Point(666, 820);
            this.btn_cerrar_concepto.Name = "btn_cerrar_concepto";
            this.btn_cerrar_concepto.Size = new System.Drawing.Size(103, 25);
            this.btn_cerrar_concepto.TabIndex = 12;
            this.btn_cerrar_concepto.Text = "Cerrar";
            this.btn_cerrar_concepto.UseVisualStyleBackColor = false;
            this.btn_cerrar_concepto.Click += new System.EventHandler(this.btn_cerrar_concepto_Click);
            // 
            // frm_previsualizar_libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(781, 485);
            this.Controls.Add(this.btn_cerrar_concepto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_libro);
            this.Name = "frm_previsualizar_libro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Previsualizacion";
            this.Load += new System.EventHandler(this.frm_previsualizar_libro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_libro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_libro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cerrar_concepto;
    }
}