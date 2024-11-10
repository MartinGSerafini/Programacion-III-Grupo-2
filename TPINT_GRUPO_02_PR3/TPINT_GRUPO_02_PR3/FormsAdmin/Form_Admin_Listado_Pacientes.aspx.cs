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
            DataTable tabla = Session["TablaFiltrada"] as DataTable ?? log.getTabla();
            GrdPacientes.DataSource = tabla;
            GrdPacientes.DataBind();

            // Obtener los valores actuales de Provincia y Localidad del paciente
            int idProvincia = Convert.ToInt32(((Label)GrdPacientes.Rows[e.NewEditIndex].FindControl("lbl_it_Provincia")).Text);
            int idLocalidad = Convert.ToInt32(((Label)GrdPacientes.Rows[e.NewEditIndex].FindControl("lbl_it_Localidad")).Text);

            // Llenar el DropDownList de Provincias
            DropDownList ddlProvincias = (DropDownList)GrdPacientes.Rows[e.NewEditIndex].FindControl("ddlProvincias");
            LogicaProvincias logProvincias = new LogicaProvincias();
            ddlProvincias.DataSource = logProvincias.getTabla();
            ddlProvincias.DataTextField = "NOMBRE_PRO";
            ddlProvincias.DataValueField = "ID_PROVINCIA_PRO";
            ddlProvincias.DataBind();

            // Seleccionar la provincia actual
            if (ddlProvincias.Items.FindByValue(idProvincia.ToString()) != null)
            {
                ddlProvincias.SelectedValue = idProvincia.ToString();
            }
            else
            {
                // Si no se encuentra, selecciona el primer elemento o maneja como desees
                ddlProvincias.SelectedIndex = 0;
            }

            // Llenar el DropDownList de Localidades
            DropDownList ddlLocalidades = (DropDownList)GrdPacientes.Rows[e.NewEditIndex].FindControl("ddlLocalidades");
            LogicaLocalidades logLocalidades = new LogicaLocalidades();
            ddlLocalidades.DataSource = logLocalidades.getTablaLocalidades(idProvincia);
            ddlLocalidades.DataTextField = "NOMBRE_LOC";
            ddlLocalidades.DataValueField = "ID_LOCALIDAD_LOC";
            ddlLocalidades.DataBind();

            // Seleccionar la localidad actual
            if (ddlLocalidades.Items.FindByValue(idLocalidad.ToString()) != null)
            {
                ddlLocalidades.SelectedValue = idLocalidad.ToString();
            }
            else
            {
                // Si la localidad no se encuentra, selecciona el primer ítem o maneja de la forma que prefieras
                ddlLocalidades.SelectedIndex = 0;
            }
        }




        protected void GrdPacientes_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowState.HasFlag(DataControlRowState.Edit))
            {
                DropDownList ddlProvincias = (DropDownList)e.Row.FindControl("ddlProvincias");
                DropDownList ddlLocalidades = (DropDownList)e.Row.FindControl("ddlLocalidades");

                if (ddlProvincias != null && ddlLocalidades != null)
                {
                    LogicaProvincias logicaProvincias = new LogicaProvincias();
                    LogicaLocalidades logicaLocalidades = new LogicaLocalidades();

                    DataTable provincias = logicaProvincias.getTabla();
                    ddlProvincias.DataSource = provincias;
                    ddlProvincias.DataTextField = "NOMBRE_PRO";
                    ddlProvincias.DataValueField = "ID_PROVINCIA_PRO";
                    ddlProvincias.DataBind();
                    ddlProvincias.Items.Insert(0, new ListItem("Selecciona una provincia", "0"));

                    int provinciaId = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "ID_PROVINCIA_PRO"));
                    ddlProvincias.SelectedValue = provinciaId.ToString();

                    DataTable localidades = logicaLocalidades.getTablaLocalidades(provinciaId);
                    ddlLocalidades.DataSource = localidades;
                    ddlLocalidades.DataTextField = "NOMBRE_LOC";
                    ddlLocalidades.DataValueField = "ID_LOCALIDAD_LOC";
                    ddlLocalidades.DataBind();
                    ddlLocalidades.Items.Insert(0, new ListItem("Selecciona una localidad", "0"));

                    int localidadId = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "IDLocalidad"));
                    ddlLocalidades.SelectedValue = localidadId.ToString();
                }
            }
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