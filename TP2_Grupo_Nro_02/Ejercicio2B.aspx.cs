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
            if (Session["SelectedItems"] == null || Request["Txbnombre"] == null || Request["Txbapellido"] == null || Request["Ddlzona"] == null)
            {
                Response.Redirect("Ejercicio2A.aspx");
                return;
            }
            string Nombre = Request["Txbnombre"].ToString();
            string Apellido = Request["Txbapellido"].ToString();
            string Zona = Request["Ddlzona"].ToString();
            string selectedItems = Session["SelectedItems"] as string;

            lblNombre.Text = "Nombre: ";
            lblNombreNegrita.Text = Nombre;
            lblApellido.Text = "Apellido: ";
            lblApellidoNegrita.Text = Apellido;
            lblZona.Text = "Zona: ";
            lblZonaNegrita.Text = Zona;
            lblTemas.Text = "Los temas elegidos son: ";
            lblTemasNegrita.Text = "<br />" + selectedItems;

        }
    }
}