using Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP8_Grupo_Nro_02
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIdSucursal.Text);
            LogicaSucursal log = new LogicaSucursal();
            bool fila =  log.eliminarSucursal(ID);

            if (fila == true)
            {
                lblValidacion.Text = "La sucursal se ha eliminado con éxito.";
                txtIdSucursal.Text = "";
            }
            else
            {
                lblValidacion.Text = "La sucursal ingresada no existe o ya ha sido eliminada.";
                txtIdSucursal.Text = "";
            }
        }
    }
}