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
            this.label2 = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.jobsLabel = new System.Windows.Forms.Label();
            this.SelecteItems = new System.Windows.Forms.GroupBox();
            this.Grbsexo.SuspendLayout();
            this.Grbestadocivil.SuspendLayout();
            this.SelecteItems.SuspendLayout();
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sexo:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(57, 31);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(0, 13);
            this.genderLabel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado civil:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Oficio:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(83, 54);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(0, 13);
            this.stateLabel.TabIndex = 9;
            // 
            // jobsLabel
            // 
            this.jobsLabel.AutoSize = true;
            this.jobsLabel.Location = new System.Drawing.Point(34, 90);
            this.jobsLabel.Name = "jobsLabel";
            this.jobsLabel.Size = new System.Drawing.Size(0, 13);
            this.jobsLabel.TabIndex = 10;
            // 
            // SelecteItems
            // 
            this.SelecteItems.Controls.Add(this.genderLabel);
            this.SelecteItems.Controls.Add(this.jobsLabel);
            this.SelecteItems.Controls.Add(this.label2);
            this.SelecteItems.Controls.Add(this.label5);
            this.SelecteItems.Controls.Add(this.stateLabel);
            this.SelecteItems.Controls.Add(this.label4);
            this.SelecteItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelecteItems.Location = new System.Drawing.Point(60, 374);
            this.SelecteItems.Name = "SelecteItems";
            this.SelecteItems.Size = new System.Drawing.Size(351, 151);
            this.SelecteItems.TabIndex = 11;
            this.SelecteItems.TabStop = false;
            this.SelecteItems.Text = "Usted selecciono los siguiente elementos";
            this.SelecteItems.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FormEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 529);
            this.Controls.Add(this.SelecteItems);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.Clbox);
            this.Controls.Add(this.Grbestadocivil);
            this.Controls.Add(this.Grbsexo);
            this.Name = "FormEjercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3";
            this.Load += new System.EventHandler(this.FormEjercicio3_Load);
            this.Grbsexo.ResumeLayout(false);
            this.Grbsexo.PerformLayout();
            this.Grbestadocivil.ResumeLayout(false);
            this.Grbestadocivil.PerformLayout();
            this.SelecteItems.ResumeLayout(false);
            this.SelecteItems.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label jobsLabel;
        private System.Windows.Forms.GroupBox SelecteItems;
    }
}