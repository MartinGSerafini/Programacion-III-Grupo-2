using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_Nro_XX
{
    public partial class Ejercicio2B : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Nombre;
            string Apellido;
            string Zona;
            string selectedItems = Session["SelectedItems"] as string;

            Nombre = Request["Txbnombre"].ToString();
            Apellido = Request["Txbapellido"].ToString();
            Zona = Request["Ddlzona"].ToString();

            

            lblNombre.Text = "Nombre: " + Nombre;
            lblApellido.Text = "Apellido: " + Apellido;
            lblZona.Text = "Zona: " + Zona;
            lblTemas.Text = "Temas seleccionados: " + "<br />" + selectedItems;
        }
    }
}