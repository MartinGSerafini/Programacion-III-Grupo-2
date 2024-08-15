namespace TP1_Grupo_Nro_02
{
    partial class FormEjercicio3
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
            this.Grbsexo = new System.Windows.Forms.GroupBox();
            this.Rabmasculino = new System.Windows.Forms.RadioButton();
            this.Rabfemenino = new System.Windows.Forms.RadioButton();
            this.Grbestadocivil = new System.Windows.Forms.GroupBox();
            this.Rabsoltero = new System.Windows.Forms.RadioButton();
            this.Rabcasado = new System.Windows.Forms.RadioButton();
            this.Clbox = new System.Windows.Forms.CheckedListBox();
            this.Btn = new System.Windows.Forms.Button();
            this.labelSeleccion = new System.Windows.Forms.Label();
            this.Grbsexo.SuspendLayout();
            this.Grbestadocivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grbsexo
            // 
            this.Grbsexo.Controls.Add(this.Rabmasculino);
            this.Grbsexo.Controls.Add(this.Rabfemenino);
            this.Grbsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grbsexo.Location = new System.Drawing.Point(19, 50);
            this.Grbsexo.Name = "Grbsexo";
            this.Grbsexo.Size = new System.Drawing.Size(189, 121);
            this.Grbsexo.TabIndex = 0;
            this.Grbsexo.TabStop = false;
            this.Grbsexo.Text = "Sexo";
            // 
            // Rabmasculino
            // 
            this.Rabmasculino.AutoSize = true;
            this.Rabmasculino.Location = new System.Drawing.Point(41, 81);
            this.Rabmasculino.Name = "Rabmasculino";
            this.Rabmasculino.Size = new System.Drawing.Size(98, 24);
            this.Rabmasculino.TabIndex = 1;
            this.Rabmasculino.TabStop = true;
            this.Rabmasculino.Text = "Masculino";
            this.Rabmasculino.UseVisualStyleBackColor = true;
            // 
            // Rabfemenino
            // 
            this.Rabfemenino.AutoSize = true;
            this.Rabfemenino.Checked = true;
            this.Rabfemenino.Location = new System.Drawing.Point(41, 42);
            this.Rabfemenino.Name = "Rabfemenino";
            this.Rabfemenino.Size = new System.Drawing.Size(98, 24);
            this.Rabfemenino.TabIndex = 0;
            this.Rabfemenino.TabStop = true;
            this.Rabfemenino.Text = "Femenino";
            this.Rabfemenino.UseVisualStyleBackColor = true;
            // 
            // Grbestadocivil
            // 
            this.Grbestadocivil.Controls.Add(this.Rabsoltero);
            this.Grbestadocivil.Controls.Add(this.Rabcasado);
            this.Grbestadocivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grbestadocivil.Location = new System.Drawing.Point(267, 50);
            this.Grbestadocivil.Name = "Grbestadocivil";
            this.Grbestadocivil.Size = new System.Drawing.Size(189, 121);
            this.Grbestadocivil.TabIndex = 1;
            this.Grbestadocivil.TabStop = false;
            this.Grbestadocivil.Text = "Estado Civil";
            // 
            // Rabsoltero
            // 
            this.Rabsoltero.AutoSize = true;
            this.Rabsoltero.Location = new System.Drawing.Point(41, 81);
            this.Rabsoltero.Name = "Rabsoltero";
            this.Rabsoltero.Size = new System.Drawing.Size(78, 24);
            this.Rabsoltero.TabIndex = 1;
            this.Rabsoltero.TabStop = true;
            this.Rabsoltero.Text = "Soltero";
            this.Rabsoltero.UseVisualStyleBackColor = true;
            // 
            // Rabcasado
            // 
            this.Rabcasado.AutoSize = true;
            this.Rabcasado.Checked = true;
            this.Rabcasado.Location = new System.Drawing.Point(41, 42);
            this.Rabcasado.Name = "Rabcasado";
            this.Rabcasado.Size = new System.Drawing.Size(82, 24);
            this.Rabcasado.TabIndex = 0;
            this.Rabcasado.TabStop = true;
            this.Rabcasado.Text = "Casado";
            this.Rabcasado.UseVisualStyleBackColor = false;
            // 
            // Clbox
            // 
            this.Clbox.CheckOnClick = true;
            this.Clbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clbox.FormattingEnabled = true;
            this.Clbox.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.Clbox.Location = new System.Drawing.Point(129, 188);
            this.Clbox.Name = "Clbox";
            this.Clbox.Size = new System.Drawing.Size(222, 130);
            this.Clbox.TabIndex = 2;
            // 
            // Btn
            // 
            this.Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn.Location = new System.Drawing.Point(129, 335);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(222, 33);
            this.Btn.TabIndex = 3;
            this.Btn.Text = "Monstrar lo que se selecciono";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // labelSeleccion
            // 
            this.labelSeleccion.AutoSize = true;
            this.labelSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeleccion.Location = new System.Drawing.Point(65, 384);
            this.labelSeleccion.Name = "labelSeleccion";
            this.labelSeleccion.Size = new System.Drawing.Size(355, 20);
            this.labelSeleccion.TabIndex = 4;
            this.labelSeleccion.Text = "Usted selecciono los siguientes elementos:";
            // 
            // FormEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 529);
            this.Controls.Add(this.labelSeleccion);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.Clbox);
            this.Controls.Add(this.Grbestadocivil);
            this.Controls.Add(this.Grbsexo);
            this.Name = "FormEjercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3";
            this.Grbsexo.ResumeLayout(false);
            this.Grbsexo.PerformLayout();
            this.Grbestadocivil.ResumeLayout(false);
            this.Grbestadocivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grbsexo;
        private System.Windows.Forms.RadioButton Rabmasculino;
        private System.Windows.Forms.RadioButton Rabfemenino;
        private System.Windows.Forms.GroupBox Grbestadocivil;
        private System.Windows.Forms.RadioButton Rabsoltero;
        private System.Windows.Forms.RadioButton Rabcasado;
        private System.Windows.Forms.CheckedListBox Clbox;
        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.Label labelSeleccion;
    }
}