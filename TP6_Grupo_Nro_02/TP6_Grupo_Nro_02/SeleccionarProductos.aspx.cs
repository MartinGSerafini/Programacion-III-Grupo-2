using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_Grupo_Nro_02
{
    public partial class Ejercicio_2B : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                cargarTabla();
            }
        }

        public void cargarTabla()
        {
            GestionProductos gproductos = new GestionProductos();
            grdProductos.DataSource = gproductos.ObtenerTodosLosProductos();
            grdProductos.DataBind();
        }
    } 
}