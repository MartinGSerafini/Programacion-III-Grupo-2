using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using System.Data;

namespace TPINT_GRUPO_02_PR3
{
    public partial class Form_Admin_Listado_Pacientes : System.Web.UI.Page
    {
        LogicaPacientes log = new LogicaPacientes();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LblUsuario.Text = Session["NombreUsuario"] as string;
                DataTable tabla = log.getTabla();
                GrdPacientes.DataSource = tabla;
                GrdPacientes.DataBind();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string categoria = txtBuscador.Text, filtro = ddlFiltros.SelectedValue;

            DataTable tabla = log.getTablaFiltrada(categoria, filtro);
            GrdPacientes.DataSource = tabla;
            GrdPacientes.DataBind();
        }
    }
}