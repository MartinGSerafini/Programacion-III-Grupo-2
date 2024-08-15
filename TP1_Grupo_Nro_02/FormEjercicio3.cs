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
            if (Rabfemenino.Checked == true)
                return "Femenino";


            else
                return "Masculino";
        }

        private string EstCivil()
        {
            if (Rabcasado.Checked == true)
                return "Casado";

            else
                return "Soltero";
        }

        private void Oficios()
        {
            for (int i = Clbox.CheckedItems.Count - 1; i >= 0; i--) ///Clbox.SelectedItems devuelve una coleccion de objetos de la lista que esten seleccionados
            {
                string Aux = Clbox.CheckedItems[i].ToString(); // Obtiene el elemento seleccionado
                Label1.Text += "\r\n" + "   -" + Aux;  //Lo muestra 
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label1.Text += "Usted selecciono los siguientes elementos:";
            Label1.Text += "\r\n" + "Sexo: " + Sexo();
            Label1.Text += "\r\n" + "Estado Civil: " + EstCivil();
            Label1.Text += "\r\n" + "Oficios: ";
            Oficios();
        }
    }
}
