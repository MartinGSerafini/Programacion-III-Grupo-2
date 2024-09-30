using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_Grupo_Nro_02
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                cargarTabla();
            }
        }

        public void cargarTabla()
        {
            GestionProductos gproductos = new GestionProductos();
            GrdProductos.DataSource = gproductos.ObtenerTodosLosProductos();
            GrdProductos.DataBind();
        }

        protected void GrdProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GrdProductos.PageIndex = e.NewPageIndex;
            cargarTabla();
        }
        protected void GrdProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GrdProductos.EditIndex = e.NewEditIndex;
            cargarTabla();
        }

        protected void GrdProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

    }
}