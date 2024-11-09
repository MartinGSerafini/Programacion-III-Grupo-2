using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using System.Data;
using System.Data.SqlClient;

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

        protected void GrdPacientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GrdPacientes.EditIndex = e.NewEditIndex;
            DataTable tabla = log.getTabla();
            GrdPacientes.DataSource = tabla;
            GrdPacientes.DataBind();
        }

        protected void GrdPacientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string s_DNIPaciente = ((Label)GrdPacientes.Rows[e.RowIndex].FindControl("lbl_it_DNI")).Text;
            LogicaPacientes logica = new LogicaPacientes();


            if (logica.EliminarPaciente(s_DNIPaciente))
            {
                lblMensaje.Text = "El paciente con DNI " + s_DNIPaciente + " fué eliminado con éxito";
            }
            else
            {
                lblMensaje.Text = "El paciente con DNI " + s_DNIPaciente + " no se pudo eliminar";
            }

            DataTable tabla = log.getTabla();
            GrdPacientes.DataSource = tabla;
            GrdPacientes.DataBind();
        }

    }
}