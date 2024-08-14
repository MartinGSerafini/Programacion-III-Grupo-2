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

        private void NombreValido() ///Valida que el nombre ingresado sea valido
        {
            bool repetido = false;

            for (int i = 0; i < ListBox1.Items.Count; i++){
                string nombreaux = TextBox1.Text.ToUpper(); ///crea una cadena auxiliar igual al txtbox pero en mayusculas
                if (nombreaux == ListBox1.Items[i].ToString().ToUpper()) ///compara todas las cadenas de la lstbox pasandolas a mayusculas
                    repetido = true;    ///si se repite alguno, el bool repetido pasa a true
            }
            for (int i = 0; i < ListBox2.Items.Count; i++)
            {
                string nombreaux = TextBox1.Text.ToUpper(); ///crea una cadena auxiliar igual al txtbox pero en mayusculas
                if (nombreaux == ListBox2.Items[i].ToString().ToUpper()) ///compara todas las cadenas de la lstbox2 pasandolas a mayusculas
                    repetido = true;    ///si se repite alguno, el bool repetido pasa a true
            }
            if (!string.IsNullOrWhiteSpace(TextBox1.Text) && repetido == false){    ///IsNullOrWhiteSpace controla que no haya solo un espacio en blanco.
                ListBox1.Items.Add(TextBox1.Text.Trim()); ///Copia lo del txtbox1 a la listbox
                TextBox1.Clear();
            }
            else
                MessageBox.Show("El nombre ingresado es repetido o el campo está vacío", "Nombre no válido", MessageBoxButtons.OK, MessageBoxIcon.Error); //Muestra un cartel de error cuando el campo de nombre esta vacio o repetido
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            if(ListBox1.SelectedItems.Count < 1)    ///ListBox1.SelectedItems.Count devuelve una coleccion de  objetos de la lista
                MessageBox.Show("Debe seleccionar por lo menos 1 nombre de la lista.", "Error al pasar nombres", MessageBoxButtons.OK, MessageBoxIcon.Error);

            for (int i = ListBox1.SelectedItems.Count - 1; i>=0; i--) ///ListBox1.SelectedItems devuelve una coleccion de objetos de la lista que esten seleccionados
            {
                string Aux = ListBox1.SelectedItems[i].ToString(); // Obtener el elemento seleccionado
                ListBox2.Items.Add(Aux);   // Agregar el elemento a ListBox2
                ListBox1.Items.Remove(Aux);    // Eliminar el elemento de ListBox1
            }
        }

        private void Btnaddall_Click(object sender, EventArgs e)
        {
            if (ListBox1.Items.Count < 1)   ///ListBox1.SelectedItems.Count DEVUELVE LA CANTIDAD DE NOMBRES EN LA LISTA
                MessageBox.Show("No hay nombres cargados para pasar de una lista a la otra.", "Error al pasar nombres", MessageBoxButtons.OK, MessageBoxIcon.Error);

            foreach (string item in ListBox1.Items) ///RECORRE LA LISTA
                ListBox2.Items.Add(item);    ///AGREGA LOS NOMBRES DE LA LISTA RECORRIDA A LA LISTA 2

            ListBox1.Items.Clear(); ///BORRA LA LISTA 1

        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            NombreValido(); ///llama a la funcion que se encarga de validar el nombre
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ') ///Controla si la tecla presionada es una letra, es un espacio o es la de retroceso
                e.Handled = true;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
