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
            String idProducto = ((Label)GrdProductos.Rows[e.RowIndex].FindControl("Lbl_idproducto")).Text;

            Producto producto = new Producto();
            producto.idproducto = Convert.ToInt32(idProducto);

            GestionProductos gProductos = new GestionProductos();
            gProductos.EliminarProducto(producto);

            cargarTabla();
        }

        protected void GrdProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GrdProductos.EditIndex = -1;
            cargarTabla();
        }
    }
}