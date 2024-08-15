using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP1_Grupo_Nro_02
{
    public partial class FormEjercicio2 : Form
    {
        public FormEjercicio2()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }
=======
        private void NombreValido() //Funcion para validar que el nombre y apellido sean validos y no esten repetidos
        {
            for (int i = 0; i < Lstbox.Items.Count; i++) ///recorre los elementos de la list box
            {
                string nombreyapellido = Tbxnombre.Text.ToUpper() + " " + Tbxapellido.Text.ToUpper(); ///crea una cadena auxiliar igual al txtbox pero en mayusculas
                if (nombreyapellido == Lstbox.Items[i].ToString().ToUpper())    ///compara todas las cadenas de la lstbox pasandolas a mayusculas
                {
                    ///si se repite alguno, muestra un mensaje de error y detiene el buclem
                    MessageBox.Show("El nombre ya se encuentra en la Lista", "Informacion ingresada no válida", MessageBoxButtons.OK, MessageBoxIcon.Error); //Muestra un cartel de error cuando el campo de nombre esta vacio o repetido
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(Tbxnombre.Text) && !string.IsNullOrWhiteSpace(Tbxapellido.Text)) ///Controla que los campos no esten vacios.
            {
                Lstbox.Items.Add(Tbxnombre.Text.Trim() + " " + Tbxapellido.Text.Trim()); ///Copia lo del Tbxnombre a la Lstbox
                Tbxnombre.Clear();
                Tbxapellido.Clear();
            }
            else
                MessageBox.Show("Complete los campos vacios", "Informacion ingresada no válida", MessageBoxButtons.OK, MessageBoxIcon.Error); //Muestra un cartel de error cuando el campo de nombre esta vacio o repetido
        }

        private void TeclaValida(KeyPressEventArgs e)   ///Funcion para validar que tecla se presiono
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ') ///Controla si la tecla presionada es una letra, es un espacio o es la de retroceso
                e.Handled = true;
        }

        private void Tbxnombre_KeyPress(object sender, KeyPressEventArgs e) ///metodo para la txtbox del nombre
        {
            TeclaValida(e); ///llama a la funcion para validar la tecla presionada
        }

        private void Tbxapellido_KeyPress(object sender, KeyPressEventArgs e) ///metodo para la txtbox del apellido
        {
            TeclaValida(e); ///llama a la funcion para validar la tecla presionada
        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            NombreValido();
        }

        private void Btnborrar_Click(object sender, EventArgs e)
        {

            if (Lstbox.SelectedItems.Count > 0)
            {
                for (int i = Lstbox.SelectedItems.Count - 1; i >= 0; i--) ///Lstbox.SelectedItems devuelve una coleccion de objetos de la lista que esten seleccionados
                {
                    string Aux = Lstbox.SelectedItems[i].ToString(); // Obtiene el elemento seleccionado
                    Lstbox.Items.Remove(Aux);    // Eliminar el elemento de Lstbox
                }
            }

            else
                MessageBox.Show("Debe seleccionar 1 o mas elementos", "Seleccion no valida", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                //Muestra un cartel de error cuando el campo de nombre esta vacio o repetido
        }

>>>>>>> 49f3d0347ee37673df08166126abb3fb7039eb98
    }
}