using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPINT_GRUPO_02_PR3.FormsMedico
{
    public partial class Form_Medico_Listado_Turnos : System.Web.UI.Page
    {
        LogicaTurnos logtur = new LogicaTurnos();
        LogicaMedicos logmed = new LogicaMedicos();
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
            string texto = txtBuscador.Text;
            string filtro = ddlFiltros.SelectedValue;
            if (texto == "")
            {
                CargarGrilla();
                ddlFiltros.SelectedValue = "-1";
                return;
            }
            int idmedico = logmed.GetIdMedicoPorNombreApellido(LblUsuario.Text);
            DataTable tabla = logtur.getTablaFiltrada2(texto, filtro, idmedico);
            GrdTurnos.DataSource = tabla;
            GrdTurnos.DataBind();
            dt = tabla;
        }
        protected void CargarGrilla()
        {
            int idmedico = logmed.GetIdMedicoPorNombreApellido(LblUsuario.Text);
            DataTable tabla = dt ?? logtur.getTabla2(idmedico);
            GrdTurnos.DataSource = tabla;
            GrdTurnos.DataBind();
        }
        protected void GrdTurnos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowState.HasFlag(DataControlRowState.Edit))
            {
                TextBox txtObservacion = (TextBox)e.Row.FindControl("txtObservacion");
                DropDownList ddlEstado = (DropDownList)e.Row.FindControl("ddlEstado");

                ddlEstado.Enabled = !string.IsNullOrWhiteSpace(txtObservacion.Text);

                txtObservacion.Attributes["onkeyup"] = "habilitarEstado(this);";
            }
        }
        protected void GrdTurnos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int idTurno = Convert.ToInt32(GrdTurnos.DataKeys[e.RowIndex].Value);

            GridViewRow row = GrdTurnos.Rows[e.RowIndex];
            TextBox txtObservacion = (TextBox)row.FindControl("txtObservacion");
            DropDownList ddlEstado = (DropDownList)row.FindControl("ddlEstado");
            if (ddlEstado.SelectedValue == "1")
            {
                txtObservacion.Text = "";
            }

            Turnos turno = new Turnos();
            {
                turno.SetID_TURNO_TUR(idTurno);
                turno.SetOBSERVACION_TUR(txtObservacion.Text);
                turno.SetESTADO_TUR(ddlEstado.SelectedItem.Text);
            }
            if (logtur.ActualizarTurno(turno))
            {
                string script = "alert('El turno fue modificado con éxito.');";
                ClientScript.RegisterStartupScript(this.GetType(), "mensajeExito", script, true);
            }
            else
            {
                string script = "alert('Error al modificar el turno.');";
                ClientScript.RegisterStartupScript(this.GetType(), "mensajeError", script, true);
            }
            GrdTurnos.EditIndex = -1;
            CargarGrilla();
        }
        protected void GrdTurnos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GrdTurnos.EditIndex = e.NewEditIndex;
            CargarGrilla();
        }
        protected void GrdTurnos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GrdTurnos.EditIndex = -1;
            CargarGrilla();
        }

        protected void GrdTurnos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GrdTurnos.PageIndex = e.NewPageIndex;

            CargarGrilla();
        }
    }
}