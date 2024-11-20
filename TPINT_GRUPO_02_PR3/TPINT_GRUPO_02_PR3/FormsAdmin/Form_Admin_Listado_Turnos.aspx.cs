using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

namespace TPINT_GRUPO_02_PR3.FormsAdmin
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        LogicaPacientes logpac = new LogicaPacientes();
        LogicaMedicos logmed = new LogicaMedicos();
        LogicaHorarioAtencion loghor = new LogicaHorarioAtencion();
        LogicaTurnos logtur = new LogicaTurnos();
        DataTable dt = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LblUsuario.Text = Session["NombreUsuario"] as string;
                CargarGrilla();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string categoria = txtBuscador.Text;
            string filtro = ddlFiltros.SelectedValue;
            if (filtro == "-1")
            {
                string script = "alert('Por favor, seleccione una categoría válida.');";
                ClientScript.RegisterStartupScript(this.GetType(), "mensajeExito", script, true);
                return;
            }
            DataTable tabla = logtur.getTablaFiltrada(categoria, filtro);
            GrdTurnos.DataSource = tabla;
            GrdTurnos.DataBind();
            dt = tabla;
        }

        protected void CargarGrilla()
        {
            DataTable tabla = dt ?? logtur.getTabla();
            GrdTurnos.DataSource = tabla;
            GrdTurnos.DataBind();
        }

        protected void GrdTurnos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int s_IDTurno = Convert.ToInt32(((Label)GrdTurnos.Rows[e.RowIndex].FindControl("lbl_it_ID")).Text);

            if (logtur.EliminarTurno(s_IDTurno))
            {
                string script = "alert('El Registro fue Eliminiado con Exito.');";
                ClientScript.RegisterStartupScript(this.GetType(), "mensajeExito", script, true);
            }
            else
            {
                string script = "alert('El Registro no se puedo Eliminar.');";
                ClientScript.RegisterStartupScript(this.GetType(), "mensajeExito", script, true);
            }

            CargarGrilla();
        }
    }
}