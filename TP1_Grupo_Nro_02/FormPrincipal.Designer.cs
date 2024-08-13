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
            this.btnejercicio1 = new System.Windows.Forms.Button();
            this.btnejercicio2 = new System.Windows.Forms.Button();
            this.btnejercicio3 = new System.Windows.Forms.Button();
            this.lblintegrantes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnejercicio1
            // 
            this.btnejercicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnejercicio1.Location = new System.Drawing.Point(25, 51);
            this.btnejercicio1.Name = "btnejercicio1";
            this.btnejercicio1.Size = new System.Drawing.Size(120, 42);
            this.btnejercicio1.TabIndex = 0;
            this.btnejercicio1.Text = "EJERCICIO 1";
            this.btnejercicio1.UseVisualStyleBackColor = true;
            this.btnejercicio1.Click += new System.EventHandler(this.btnejercicio1_Click);
            // 
            // btnejercicio2
            // 
            this.btnejercicio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnejercicio2.Location = new System.Drawing.Point(151, 51);
            this.btnejercicio2.Name = "btnejercicio2";
            this.btnejercicio2.Size = new System.Drawing.Size(120, 42);
            this.btnejercicio2.TabIndex = 1;
            this.btnejercicio2.Text = "EJERCICIO 2";
            this.btnejercicio2.UseVisualStyleBackColor = true;
            this.btnejercicio2.Click += new System.EventHandler(this.btnejercicio2_Click);
            // 
            // btnejercicio3
            // 
            this.btnejercicio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnejercicio3.Location = new System.Drawing.Point(277, 51);
            this.btnejercicio3.Name = "btnejercicio3";
            this.btnejercicio3.Size = new System.Drawing.Size(120, 42);
            this.btnejercicio3.TabIndex = 2;
            this.btnejercicio3.Text = "EJERCICIO 3";
            this.btnejercicio3.UseVisualStyleBackColor = true;
            this.btnejercicio3.Click += new System.EventHandler(this.btnejercicio3_Click);
            // 
            // lblintegrantes
            // 
            this.lblintegrantes.AutoSize = true;
            this.lblintegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblintegrantes.Location = new System.Drawing.Point(27, 122);
            this.lblintegrantes.Name = "lblintegrantes";
            this.lblintegrantes.Size = new System.Drawing.Size(99, 20);
            this.lblintegrantes.TabIndex = 3;
            this.lblintegrantes.Text = "Integrantes: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 120);
            this.label2.TabIndex = 4;
            this.label2.Text = " - Martin Guillermo Serafini\r\n- Luciano Cogo\r\n- Fabrizio Alejandro De Rui Sartor\r" +
    "\n- Elen Ignacio Saucedo\r\n- Juan Martin Monte\r\n- Sofia Pilar Vitalevi";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblintegrantes);
            this.Controls.Add(this.btnejercicio3);
            this.Controls.Add(this.btnejercicio2);
            this.Controls.Add(this.btnejercicio1);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnejercicio1;
        private System.Windows.Forms.Button btnejercicio2;
        private System.Windows.Forms.Button btnejercicio3;
        private System.Windows.Forms.Label lblintegrantes;
        private System.Windows.Forms.Label label2;
    }
}

