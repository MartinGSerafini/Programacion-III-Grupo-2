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
    public partial class FormEjercicio3 : Form
    {
        public FormEjercicio3()
        {
            InitializeComponent();
        }

        private string Sexo()
        {
            if (Rabmasculino.Checked)
            {
                return "Masculino";
            }
            else
            {
                return "Femenino";
            }
        }

        private string EstadoCivil()
        {
            if (Rabcasado.Checked)
            {
                return "Casado";
            }
            else
            {
                return "Soltero";
            }
        }

        private string Oficio()
        {
            string job="";
            foreach(string strngOficio in Clbox.CheckedItems)
            {
                job += "- " + strngOficio + "\r\n";
            }
            return job;
        }
        

        private void Btn_Click(object sender, EventArgs e)
        {
            labelSeleccion.Text += "\r\n" + "Sexo: " + Sexo();
            labelSeleccion.Text += "\r\n" + "Estado Civil: " + EstadoCivil();
            labelSeleccion.Text += "\r\n" + "Oficio: " + "\r\n" + Oficio();
        }
    }
}
