namespace TP1_Grupo_Nro_02
{
    partial class FormEjercicio1
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
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.ListBox2 = new System.Windows.Forms.ListBox();
            this.Btnadd = new System.Windows.Forms.Button();
            this.Btnaddall = new System.Windows.Forms.Button();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.Lblnombre = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListBox1
            // 
            this.ListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 20;
            this.ListBox1.Location = new System.Drawing.Point(12, 95);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ListBox1.Size = new System.Drawing.Size(258, 324);
            this.ListBox1.TabIndex = 0;
            this.ListBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // ListBox2
            // 
            this.ListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox2.FormattingEnabled = true;
            this.ListBox2.ItemHeight = 20;
            this.ListBox2.Location = new System.Drawing.Point(378, 95);
            this.ListBox2.Name = "ListBox2";
            this.ListBox2.Size = new System.Drawing.Size(258, 324);
            this.ListBox2.TabIndex = 1;
            // 
            // Btnadd
            // 
            this.Btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnadd.Location = new System.Drawing.Point(290, 190);
            this.Btnadd.Name = "Btnadd";
            this.Btnadd.Size = new System.Drawing.Size(67, 34);
            this.Btnadd.TabIndex = 2;
            this.Btnadd.Text = ">";
            this.Btnadd.UseVisualStyleBackColor = true;
            this.Btnadd.Click += new System.EventHandler(this.Btnadd_Click);
            // 
            // Btnaddall
            // 
            this.Btnaddall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnaddall.Location = new System.Drawing.Point(290, 257);
            this.Btnaddall.Name = "Btnaddall";
            this.Btnaddall.Size = new System.Drawing.Size(67, 34);
            this.Btnaddall.TabIndex = 3;
            this.Btnaddall.Text = ">>";
            this.Btnaddall.UseVisualStyleBackColor = true;
            this.Btnaddall.Click += new System.EventHandler(this.Btnaddall_Click);
            // 
            // Btnagregar
            // 
            this.Btnagregar.Location = new System.Drawing.Point(533, 37);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(103, 24);
            this.Btnagregar.TabIndex = 4;
            this.Btnagregar.Text = "Agregar";
            this.Btnagregar.UseVisualStyleBackColor = true;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // Lblnombre
            // 
            this.Lblnombre.AutoSize = true;
            this.Lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblnombre.Location = new System.Drawing.Point(12, 37);
            this.Lblnombre.Name = "Lblnombre";
            this.Lblnombre.Size = new System.Drawing.Size(179, 24);
            this.Lblnombre.TabIndex = 5;
            this.Lblnombre.Text = "Ingrese un Nombre:";
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(190, 37);
            this.TextBox1.MaxLength = 30;
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(337, 24);
            this.TextBox1.TabIndex = 6;
            this.TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // FormEjercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 436);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Lblnombre);
            this.Controls.Add(this.Btnagregar);
            this.Controls.Add(this.Btnaddall);
            this.Controls.Add(this.Btnadd);
            this.Controls.Add(this.ListBox2);
            this.Controls.Add(this.ListBox1);
            this.Name = "FormEjercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.ListBox ListBox2;
        private System.Windows.Forms.Button Btnadd;
        private System.Windows.Forms.Button Btnaddall;
        private System.Windows.Forms.Button Btnagregar;
        private System.Windows.Forms.Label Lblnombre;
        private System.Windows.Forms.TextBox TextBox1;
    }
}