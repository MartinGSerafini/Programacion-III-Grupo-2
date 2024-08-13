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
    public partial class FormEjercicio1 : Form
    {
        public FormEjercicio1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ') ///Controla si la tecla presionada es una letra, es un espacio o es la de retroceso
                e.Handled = true;
        }

        private bool NombreValido() ///Valida que el nombre ingresado sea valido
        {
            bool repetido = false;

            for (int i = 0; i < ListBox1.Items.Count; i++)
            {
                string nombreaux = TextBox1.Text.ToUpper(); ///crea una cadena auxiliar igual al txtbox pero en mayusculas
                if (nombreaux == ListBox1.Items[i].ToString().ToUpper()) ///compara todas las cadenas de la lstbox pasandolas a mayusculas
                    repetido = true;    ///si se repite alguno, el bool repetido pasa a true
            }
            if (!string.IsNullOrWhiteSpace(TextBox1.Text) && repetido == false)
            {    ///IsNullOrWhiteSpace controla que no haya solo un espacio en blanco y repetido, que el nombre no se encuentre ya en uso
                ListBox1.Items.Add(TextBox1.Text.Trim()); ///Copia lo del txtbox1 a la listbox
                TextBox1.Clear();
            }
            return repetido;

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (NombreValido()) MessageBox.Show("Nombre repetido, porfavo eliga otro", "error"); ///llama a la funcion que se encarga de validar el nombre
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor eliga un elemento", "Error");
            }
        }
    }
}
