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

        protected void btnGuardarLoc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txtboxlocalidad.Text))
            {
                DropDownList1.Items.Add(Txtboxlocalidad.Text);
                Txtboxlocalidad.Text = "";
            }

            else
                Lblerrorlocalidad.Text = "Por favor, ingresa una localidad.";
                Lblerrorlocalidad.ForeColor = System.Drawing.Color.Red;
        }
    }
}