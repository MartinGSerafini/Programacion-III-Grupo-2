using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using System.Data;

namespace TP8_Grupo_Nro_02
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        LogicaSucursal log = new LogicaSucursal();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable tablaSucursal = log.getTabla();
                Grid.DataSource = tablaSucursal;
                Grid.DataBind();
            }
        }

        protected void btnfiltrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}