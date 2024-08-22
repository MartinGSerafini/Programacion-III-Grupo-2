using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_Nro_XX
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected bool CamposVacios(TextBox Txbcant1, TextBox Txbnombre1, TextBox Txbcant2, TextBox Txbnombre2)
        {
            if (string.IsNullOrWhiteSpace(Txbcant1.Text) || string.IsNullOrWhiteSpace(Txbcant2.Text) ||
                string.IsNullOrWhiteSpace(Txbnombre1.Text) || string.IsNullOrWhiteSpace(Txbnombre2.Text))  ///Solo muestra la tabla si todos los Txtbox estan completos
            {

                string Msgerror = "alert('Debe completar todos los campos vacios');"; ///Genera una string  y usa "älert" para poder mostrarla en una ventana emergente
                ClientScript.RegisterStartupScript(this.GetType(), "completar campos", Msgerror, true); ///ClientScript registra y ejecuta scripts de Javascrips en al pagina
                                                                                                        ///RegisterStartupScript registra el script y lo ejecuta cuando la pagina termina de cargar
                return true;                                                                            ///this.GetType() devuelve el tipo de pagina
                                                                                                        ///true se encarga de que el mensaje aparezca al final de la pagina y no en el encabezado
            }
            return false;
        }

        protected bool NumeroEnCantidad(TextBox Txbcant1, TextBox Txbcant2)
         {
             bool a = Char.IsNumber(Txbcant1.Text, 0);
             bool b = Char.IsNumber(Txbcant2.Text, 0);
             if (!a || !b)
             {
                 string Msgerror = "alert('Debe ingresar sólalmente números en las secciones de cantidad');"; 
                 ClientScript.RegisterStartupScript(this.GetType(), "Ingreso Incorrecto", Msgerror, true); 
                 return true;                                                                            
            }
            return false;
        }

        protected void Btntabla_Click(object sender, EventArgs e) ///Genera la tabla con los productos y el total
        {
            if (CamposVacios(Txbcant1, Txbnombre1, Txbcant2, Txbnombre2))  ///Si algun Txtbox esta vacio, no muestra la tabla
                return;
            if (NumeroEnCantidad(Txbcant1, Txbcant2))
                return;

            int numero1 = int.Parse(Txbcant1.Text);
            int numero2 = int.Parse(Txbcant2.Text);
                
            int suma = numero1 + numero2;
            string tabla = "<table border = '1'>";
            tabla += "<tr>";
            tabla += "<td>" + "Producto" + "</td>";
            tabla += "<td>" + "Cantidad" + "</td>";
            tabla += "</tr>";
            tabla += "<tr>";
            tabla += "<td>" + Txbnombre1.Text + "</td>";
            tabla += "<td>" + Txbcant1.Text + "</td>";
            tabla += "</tr>";
            tabla += "<tr>";
            tabla += "<td>" + Txbnombre2.Text + "</td>";
            tabla += "<td>" + Txbcant2.Text + "</td>";
            tabla += "</tr>";
            tabla += "<tr>";
            tabla += "<td>" + "TOTAL" + "</td>";
            tabla += "<td>" + suma + "</td>";
            tabla += "</tr>";
            tabla += "</table>";
            Lbltabla.Text = tabla; ///Asigna la tabla al Lbltabla

            Txbnombre1.Text = "";
            Txbnombre2.Text = "";
            Txbcant1.Text = "";
            Txbcant2.Text = "";
        }
    }
}
