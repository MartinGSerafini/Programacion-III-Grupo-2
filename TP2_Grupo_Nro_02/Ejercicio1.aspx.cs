using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_Nro_XX
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btntabla_Click(object sender, EventArgs e) ///Genera la tabla con los productos y el total
        {
            if (!string.IsNullOrWhiteSpace(Txbcant1.Text) && !string.IsNullOrWhiteSpace(Txbcant2.Text) && !string.IsNullOrWhiteSpace(Txbnombre1.Text) && !string.IsNullOrWhiteSpace(Txbnombre2.Text))
            {

                LabelError.Text = "";
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
            }
            else
            {
                LabelError.Text = "Complete todos los campos en blanco";
            }
        }
    }
}
