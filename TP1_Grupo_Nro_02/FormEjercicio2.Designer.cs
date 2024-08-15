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
            this.Btnagregar = new System.Windows.Forms.Button();
            this.Tbxapellido = new System.Windows.Forms.TextBox();
            this.Tbxnombre = new System.Windows.Forms.TextBox();
            this.Lblapellido = new System.Windows.Forms.Label();
            this.Lblnombre = new System.Windows.Forms.Label();
            this.Btnborrar = new System.Windows.Forms.Button();
            this.Gbxelementos = new System.Windows.Forms.GroupBox();
            this.Lstbox = new System.Windows.Forms.ListBox();
            this.Gbxdatos.SuspendLayout();
            this.Gbxelementos.SuspendLayout();
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
            this.Gbxdatos.Size = new System.Drawing.Size(305, 426);
            this.Gbxdatos.TabIndex = 1;
            this.Gbxdatos.TabStop = false;
            this.Gbxdatos.Text = "Ingreso de Datos";
            // 
            // Btnagregar
            // 
            this.Btnagregar.Location = new System.Drawing.Point(73, 250);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(152, 61);
            this.Btnagregar.TabIndex = 4;
            this.Btnagregar.Text = "Agregar";
            this.Btnagregar.UseVisualStyleBackColor = true;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // Tbxapellido
            // 
            this.Tbxapellido.Location = new System.Drawing.Point(110, 187);
            this.Tbxapellido.Multiline = true;
            this.Tbxapellido.Name = "Tbxapellido";
            this.Tbxapellido.Size = new System.Drawing.Size(172, 24);
            this.Tbxapellido.TabIndex = 3;
            this.Tbxapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbxapellido_KeyPress);
            // 
            // Tbxnombre
            // 
            this.Tbxnombre.Location = new System.Drawing.Point(110, 140);
            this.Tbxnombre.Multiline = true;
            this.Tbxnombre.Name = "Tbxnombre";
            this.Tbxnombre.Size = new System.Drawing.Size(172, 24);
            this.Tbxnombre.TabIndex = 2;
            this.Tbxnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbxnombre_KeyPress);
            // 
            // Lblapellido
            // 
            this.Lblapellido.AutoSize = true;
            this.Lblapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblapellido.Location = new System.Drawing.Point(13, 187);
            this.Lblapellido.Name = "Lblapellido";
            this.Lblapellido.Size = new System.Drawing.Size(93, 24);
            this.Lblapellido.TabIndex = 1;
            this.Lblapellido.Text = "Apellido:";
            // 
            // Lblnombre
            // 
            this.Lblnombre.AutoSize = true;
            this.Lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblnombre.Location = new System.Drawing.Point(13, 140);
            this.Lblnombre.Name = "Lblnombre";
            this.Lblnombre.Size = new System.Drawing.Size(91, 24);
            this.Lblnombre.TabIndex = 0;
            this.Lblnombre.Text = "Nombre:";
            // 
            // Btnborrar
            // 
            this.Btnborrar.Location = new System.Drawing.Point(79, 355);
            this.Btnborrar.Name = "Btnborrar";
            this.Btnborrar.Size = new System.Drawing.Size(152, 61);
            this.Btnborrar.TabIndex = 4;
            this.Btnborrar.Text = "Borrar";
            this.Btnborrar.UseVisualStyleBackColor = true;
            this.Btnborrar.Click += new System.EventHandler(this.Btnborrar_Click);
            // 
            // Gbxelementos
            // 
            this.Gbxelementos.Controls.Add(this.Btnborrar);
            this.Gbxelementos.Controls.Add(this.Lstbox);
            this.Gbxelementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbxelementos.Location = new System.Drawing.Point(323, 12);
            this.Gbxelementos.Name = "Gbxelementos";
            this.Gbxelementos.Size = new System.Drawing.Size(305, 426);
            this.Gbxelementos.TabIndex = 2;
            this.Gbxelementos.TabStop = false;
            this.Gbxelementos.Text = "Elementos";
            // 
            // Lstbox
            // 
            this.Lstbox.FormattingEnabled = true;
            this.Lstbox.ItemHeight = 20;
            this.Lstbox.Location = new System.Drawing.Point(18, 45);
            this.Lstbox.Name = "Lstbox";
            this.Lstbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Lstbox.Size = new System.Drawing.Size(266, 304);
            this.Lstbox.Sorted = true;
            this.Lstbox.TabIndex = 5;
            this.Lstbox.SelectedIndexChanged += new System.EventHandler(this.Lstbox_SelectedIndexChanged);
            // 
            // FormEjercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.Gbxelementos);
            this.Controls.Add(this.Gbxdatos);
            this.Name = "FormEjercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 2";
            this.Gbxdatos.ResumeLayout(false);
            this.Gbxdatos.PerformLayout();
            this.Gbxelementos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbxdatos;
        private System.Windows.Forms.Button Btnborrar;
        private System.Windows.Forms.TextBox Tbxapellido;
        private System.Windows.Forms.TextBox Tbxnombre;
        private System.Windows.Forms.Label Lblapellido;
        private System.Windows.Forms.Label Lblnombre;
        private System.Windows.Forms.Button Btnagregar;
        private System.Windows.Forms.GroupBox Gbxelementos;
        private System.Windows.Forms.ListBox Lstbox;
    }
}