using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Grupo_Nro_02
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnejercicio1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEjercicio1 formEjercicio1 = new FormEjercicio1();
            formEjercicio1.Show();
        }

        private void btnejercicio2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEjercicio2 formEjercicio2 = new FormEjercicio2();
            formEjercicio2.Show();
        }

        private void btnejercicio3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEjercicio3 formEjercicio3 = new FormEjercicio3();
            formEjercicio3.Show();
        }
    }
}
