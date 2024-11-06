using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace TP6_Grupo_Nro_02
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string fechaSeleccionada = txtFecha.Text;
            if (!string.IsNullOrEmpty(fechaSeleccionada))
            {
                lblMensaje.Text = "Fecha seleccionada: " + fechaSeleccionada;
            }
            else
            {
                lblMensaje.Text = "Por favor, selecciona una fecha válida.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}