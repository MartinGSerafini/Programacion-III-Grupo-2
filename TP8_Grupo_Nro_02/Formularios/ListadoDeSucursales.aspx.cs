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
                Gvsucursales.DataSource = tablaSucursal;
                Gvsucursales.DataBind();
            }
        }

        protected void btnfiltrar_Click(object sender, EventArgs e)
        {
            LblSucursal.Visible = false;

            int ID = int.Parse(txtid_sucursal.Text);

            LogicaSucursal log = new LogicaSucursal();

            DataTable sucursalData = log.getTableId(ID);

            if (log.validacionIDenTabla(ID) == false)
            {
                LblSucursal.Visible = true;
                txtid_sucursal.Text = "";
            }

            Gvsucursales.DataSource = sucursalData;
            Gvsucursales.DataBind();
            txtid_sucursal.Text = "";
        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            DataTable tablaSucursal = log.getTabla();
            Gvsucursales.DataSource = tablaSucursal;
            Gvsucursales.DataBind();

            txtid_sucursal.Text = "";
            LblSucursal.Text = "";
        }
    }
}