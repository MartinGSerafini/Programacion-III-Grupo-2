using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_Grupo_Nro_02
{
    public partial class MostrarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["tabla"] != null)
                {
                    DataTable tablaProductos = (DataTable)Session["tabla"];
                    GrdMostrarProductos.DataSource = tablaProductos;
                    GrdMostrarProductos.DataBind();
                }
            }
        }
    }
}