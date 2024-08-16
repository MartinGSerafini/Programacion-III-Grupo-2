namespace TP1_Grupo_Nro_02
{
    partial class FormPrincipal
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
            this.Btnejercicio1 = new System.Windows.Forms.Button();
            this.Btnejercicio2 = new System.Windows.Forms.Button();
            this.Btnejercicio3 = new System.Windows.Forms.Button();
            this.Lblintegrantes = new System.Windows.Forms.Label();
            this.Lblintegrantes2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btnejercicio1
            // 
            this.Btnejercicio1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btnejercicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnejercicio1.Location = new System.Drawing.Point(25, 51);
            this.Btnejercicio1.Name = "Btnejercicio1";
            this.Btnejercicio1.Size = new System.Drawing.Size(120, 42);
            this.Btnejercicio1.TabIndex = 0;
            this.Btnejercicio1.Text = "EJERCICIO 1";
            this.Btnejercicio1.UseVisualStyleBackColor = true;
            this.Btnejercicio1.Click += new System.EventHandler(this.Btnejercicio1_Click);
            // 
            // Btnejercicio2
            // 
            this.Btnejercicio2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btnejercicio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnejercicio2.Location = new System.Drawing.Point(151, 51);
            this.Btnejercicio2.MinimumSize = new System.Drawing.Size(20, 20);
            this.Btnejercicio2.Name = "Btnejercicio2";
            this.Btnejercicio2.Size = new System.Drawing.Size(120, 42);
            this.Btnejercicio2.TabIndex = 1;
            this.Btnejercicio2.Text = "EJERCICIO 2";
            this.Btnejercicio2.UseVisualStyleBackColor = true;
            this.Btnejercicio2.Click += new System.EventHandler(this.Btnejercicio2_Click);
            // 
            // Btnejercicio3
            // 
            this.Btnejercicio3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btnejercicio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnejercicio3.Location = new System.Drawing.Point(277, 51);
            this.Btnejercicio3.Name = "Btnejercicio3";
            this.Btnejercicio3.Size = new System.Drawing.Size(120, 42);
            this.Btnejercicio3.TabIndex = 2;
            this.Btnejercicio3.Text = "EJERCICIO 3";
            this.Btnejercicio3.UseVisualStyleBackColor = true;
            this.Btnejercicio3.Click += new System.EventHandler(this.Btnejercicio3_Click);
            // 
            // Lblintegrantes
            // 
            this.Lblintegrantes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Lblintegrantes.AutoSize = true;
            this.Lblintegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblintegrantes.Location = new System.Drawing.Point(27, 122);
            this.Lblintegrantes.Name = "Lblintegrantes";
            this.Lblintegrantes.Size = new System.Drawing.Size(99, 20);
            this.Lblintegrantes.TabIndex = 3;
            this.Lblintegrantes.Text = "Integrantes: ";
            // 
            // Lblintegrantes2
            // 
            this.Lblintegrantes2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Lblintegrantes2.AutoSize = true;
            this.Lblintegrantes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblintegrantes2.Location = new System.Drawing.Point(97, 148);
            this.Lblintegrantes2.Name = "Lblintegrantes2";
            this.Lblintegrantes2.Size = new System.Drawing.Size(246, 120);
            this.Lblintegrantes2.TabIndex = 4;
            this.Lblintegrantes2.Text = " - Martin Guillermo Serafini\r\n- Luciano Cogo\r\n- Fabrizio Alejandro De Rui Sartor\r" +
    "\n- Elen Ignacio Saucedo\r\n- Juan Martin Monte\r\n- Sofia Pilar Vitalevi";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 317);
            this.Controls.Add(this.Lblintegrantes2);
            this.Controls.Add(this.Lblintegrantes);
            this.Controls.Add(this.Btnejercicio3);
            this.Controls.Add(this.Btnejercicio2);
            this.Controls.Add(this.Btnejercicio1);
            this.MinimumSize = new System.Drawing.Size(433, 356);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnejercicio1;
        private System.Windows.Forms.Button Btnejercicio2;
        private System.Windows.Forms.Button Btnejercicio3;
        private System.Windows.Forms.Label Lblintegrantes;
        private System.Windows.Forms.Label Lblintegrantes2;
    }
}

