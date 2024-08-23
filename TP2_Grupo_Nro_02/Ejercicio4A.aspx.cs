using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_Nro_XX
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnvalidar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(Txbnombre.Text) && !string.IsNullOrWhiteSpace(TxbClave.Text))
            {
                if(Txbnombre.Text == "claudio" &&  TxbClave.Text == "casas")
                {
                    Server.Transfer("Ejercicio4B.aspx");
                }
                else
                {
                    Server.Transfer("Ejercicio4c.aspx");
                }
            }
            else
            {
                string Msgerror = "alert('Debe completar todos los campos');";
                ClientScript.RegisterStartupScript(this.GetType(), "Ingreso Incorrecto", Msgerror, true);
            }
        }
    }
}