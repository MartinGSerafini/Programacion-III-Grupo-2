namespace TP1_Grupo_Nro_02
{
    partial class FormEjercicio2
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
            this.Gbxdatos = new System.Windows.Forms.GroupBox();
            this.Lblnombre = new System.Windows.Forms.Label();
            this.Lblapellido = new System.Windows.Forms.Label();
            this.Tbxnombre = new System.Windows.Forms.TextBox();
            this.Tbxapellido = new System.Windows.Forms.TextBox();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.Gbxdatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbxdatos
            // 
            this.Gbxdatos.Controls.Add(this.Btnagregar);
            this.Gbxdatos.Controls.Add(this.Tbxapellido);
            this.Gbxdatos.Controls.Add(this.Tbxnombre);
            this.Gbxdatos.Controls.Add(this.Lblapellido);
            this.Gbxdatos.Controls.Add(this.Lblnombre);
            this.Gbxdatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbxdatos.Location = new System.Drawing.Point(12, 12);
            this.Gbxdatos.Name = "Gbxdatos";
            this.Gbxdatos.Size = new System.Drawing.Size(776, 426);
            this.Gbxdatos.TabIndex = 1;
            this.Gbxdatos.TabStop = false;
            this.Gbxdatos.Text = "Ingreso de Datos";
            // 
            // Lblnombre
            // 
            this.Lblnombre.AutoSize = true;
            this.Lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblnombre.Location = new System.Drawing.Point(33, 140);
            this.Lblnombre.Name = "Lblnombre";
            this.Lblnombre.Size = new System.Drawing.Size(91, 24);
            this.Lblnombre.TabIndex = 0;
            this.Lblnombre.Text = "Nombre:";
            // 
            // Lblapellido
            // 
            this.Lblapellido.AutoSize = true;
            this.Lblapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblapellido.Location = new System.Drawing.Point(33, 187);
            this.Lblapellido.Name = "Lblapellido";
            this.Lblapellido.Size = new System.Drawing.Size(93, 24);
            this.Lblapellido.TabIndex = 1;
            this.Lblapellido.Text = "Apellido:";
            // 
            // Tbxnombre
            // 
            this.Tbxnombre.Location = new System.Drawing.Point(143, 140);
            this.Tbxnombre.Multiline = true;
            this.Tbxnombre.Name = "Tbxnombre";
            this.Tbxnombre.Size = new System.Drawing.Size(172, 24);
            this.Tbxnombre.TabIndex = 2;
            // 
            // Tbxapellido
            // 
            this.Tbxapellido.Location = new System.Drawing.Point(143, 187);
            this.Tbxapellido.Multiline = true;
            this.Tbxapellido.Name = "Tbxapellido";
            this.Tbxapellido.Size = new System.Drawing.Size(172, 24);
            this.Tbxapellido.TabIndex = 3;
            // 
            // Btnagregar
            // 
            this.Btnagregar.Location = new System.Drawing.Point(110, 234);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(133, 44);
            this.Btnagregar.TabIndex = 4;
            this.Btnagregar.Text = "Agregar";
            this.Btnagregar.UseVisualStyleBackColor = true;
            // 
            // FormEjercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gbxdatos);
            this.Name = "FormEjercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 2";
            this.Gbxdatos.ResumeLayout(false);
            this.Gbxdatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbxdatos;
        private System.Windows.Forms.Button Btnagregar;
        private System.Windows.Forms.TextBox Tbxapellido;
        private System.Windows.Forms.TextBox Tbxnombre;
        private System.Windows.Forms.Label Lblapellido;
        private System.Windows.Forms.Label Lblnombre;
    }
}