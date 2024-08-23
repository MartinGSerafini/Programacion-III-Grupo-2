using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_Nro_XX
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Origen"] == null)
            {
                Response.Redirect("Ejercicio4A.aspx");
                return;
            }

            LblBienvenida.Width = Unit.Pixel(2000);
            LblBienvenida.Height = Unit.Pixel(50);
            LblBienvenida.Font.Size = FontUnit.Point(40);
            LblBienvenida.Style["text-align"] = "center";
        }
    }
}