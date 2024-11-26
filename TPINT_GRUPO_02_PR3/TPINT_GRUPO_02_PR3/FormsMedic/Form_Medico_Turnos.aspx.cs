using Logica;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace TPINT_GRUPO_02_PR3
{
    public partial class Form_Medico_Turnos : System.Web.UI.Page
    {
        LogicaTurnos log = new LogicaTurnos();
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
            DataTable tabla = log.GetTablaTurnosXMedicosFiltrada(Session["DniUsuario"] as string, categoria, filtro);
            grdListadoTurnos.DataSource = tabla;
            grdListadoTurnos.DataBind();
            dt = tabla;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Button btnGuardar = (Button)sender;
            GridViewRow row = (GridViewRow)btnGuardar.NamingContainer;

            string dni = ((Label)row.FindControl("lbl_it_dni")).Text;
            string asistencia = ((DropDownList)row.FindControl("ddl_it_Asistencias")).SelectedValue;
            string observacion = ((TextBox)row.FindControl("txt_it_Observaciones")).Text;

            TurnosXmedicos TurXmed = new TurnosXmedicos();
            {
                TurXmed.set_DNI_TURNO_X_MEDICO(dni);
                TurXmed.set_ASISTENCIA_TURNO_X_MEDICO(asistencia);
                TurXmed.set_OBSERVACION_TURNO_X_MEDICO(observacion);
            };
            log.ActualizarTurnoXmedico(TurXmed);

            grdListadoTurnos.EditIndex = -1;
            CargarGrilla();

            string script = "alert('El Registro fue Guardado con Exito.');";
            ClientScript.RegisterStartupScript(this.GetType(), "mensajeExito", script, true);
        }

        protected void CargarGrilla()
        {
            DataTable tabla = dt ?? log.GetTablaTurnosXMedicos(Session["DniUsuario"] as string);
            grdListadoTurnos.DataSource = tabla;
            grdListadoTurnos.DataBind();
        }
    }
}