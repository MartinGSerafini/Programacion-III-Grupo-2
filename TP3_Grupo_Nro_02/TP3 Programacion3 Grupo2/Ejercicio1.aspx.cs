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

        }

        protected bool Locality_Repeat(string locality)
        {
            foreach(var item in ddlLocality.Items)
            {
                if(locality.ToLower() == item.ToString().ToLower())
                {
                    return false;
                }
            }
            return true;
        }

        protected void btnGuardarLoc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txtboxlocalidad.Text))
            {
                if (Locality_Repeat(Txtboxlocalidad.Text))
                {
                    ddlLocality.Items.Add(Txtboxlocalidad.Text);
                    Txtboxlocalidad.Text = "";
                }
                else
                {
                    Lblerrorlocalidad.Text = "Localidad repetida.";
                    Lblerrorlocalidad.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                Lblerrorlocalidad.Text = "Por favor, ingresa una localidad.";
                Lblerrorlocalidad.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}