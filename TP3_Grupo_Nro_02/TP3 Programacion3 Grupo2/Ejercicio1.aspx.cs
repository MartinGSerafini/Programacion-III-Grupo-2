using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP3_Programacion3_Grupo2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "";
        }

        protected bool Locality_Repeat(string locality)
        {
            foreach (var item in ddlLocality.Items)
            {
                if(locality.ToLower() == item.ToString().ToLower())
                {
                    Txtboxlocalidad.Text = "";
                    return false;
                }
            }
            return true;
        }

        protected void btnGuardarLoc_Click(object sender, EventArgs e)
        {

            if (Locality_Repeat(Txtboxlocalidad.Text))
            {
                ddlLocality.Items.Add(Txtboxlocalidad.Text);
                Txtboxlocalidad.Text = "";
            }
        }

        protected void CvLocalidad_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Locality_Repeat(Txtboxlocalidad.Text))
                args.IsValid = true;
            else
                args.IsValid = false;
        }

        protected void Btninicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        protected void Btnguardarusuario_Click(object sender, EventArgs e)
        {
            lblBienvenido.Text = "Bienvenido " + TxbNombre.Text;
        }
    }
}