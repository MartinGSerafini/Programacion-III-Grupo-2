using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPINT_GRUPO_02_PR3.FormAdmin
{
    public partial class ListadoMedicos : System.Web.UI.Page
    {
        LogicaMedicos log = new LogicaMedicos();
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

            DataTable tabla = log.getTablaFiltrada(categoria, filtro);
            grdListadoMedicos.DataSource = tabla;
            grdListadoMedicos.DataBind();
            dt = tabla;
        }

        protected void CargarGrilla()
        {
            DataTable tabla = dt ?? log.GetTablaMedicos();
            grdListadoMedicos.DataSource = tabla;
            grdListadoMedicos.DataBind();
        }

        protected void grdListadoMedicos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdListadoMedicos.EditIndex = e.NewEditIndex;
            CargarGrilla();

            DropDownList ddlProvincias = (DropDownList)grdListadoMedicos.Rows[grdListadoMedicos.EditIndex].FindControl("ddlProvincias");
            DropDownList ddlLocalidades = (DropDownList)grdListadoMedicos.Rows[grdListadoMedicos.EditIndex].FindControl("ddlLocalidades");

            if (ddlProvincias != null && ddlLocalidades != null)
            {
                Label lblProvincia = (Label)grdListadoMedicos.Rows[e.NewEditIndex].FindControl("lbl_it_Provincia");
                Label lblLocalidad = (Label)grdListadoMedicos.Rows[e.NewEditIndex].FindControl("lbl_it_Localidad");

                if (lblProvincia != null && lblLocalidad != null)
                {
                    string idProvincia = lblProvincia.Text;
                    if (!string.IsNullOrEmpty(idProvincia))
                    {
                        ddlProvincias.SelectedValue = idProvincia;

                        SqlDataSource2.SelectParameters["ID_PROVINCIA_PRO"].DefaultValue = idProvincia;
                        ddlLocalidades.DataBind();

                        string idLocalidad = lblLocalidad.Text;
                        if (!string.IsNullOrEmpty(idLocalidad))
                        {
                            ddlLocalidades.SelectedValue = idLocalidad;
                        }
                    }
                }
            }
        }

        protected void grdListadoMedicos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string DNI = ((Label)grdListadoMedicos.Rows[e.RowIndex].FindControl("lblDNI")).Text;
            string Nombre = ((TextBox)grdListadoMedicos.Rows[e.RowIndex].FindControl("txtNombre")).Text;
            string Apellido = ((TextBox)grdListadoMedicos.Rows[e.RowIndex].FindControl("txtApellido")).Text;
            string Sexo = ((DropDownList)grdListadoMedicos.Rows[e.RowIndex].FindControl("ddlSexo")).SelectedValue;
            string Nacionalidad = ((TextBox)grdListadoMedicos.Rows[e.RowIndex].FindControl("txtNacionalidad")).Text;
            DateTime Nacimiento;
            if (DateTime.TryParseExact(((TextBox)grdListadoMedicos.Rows[e.RowIndex].FindControl("txtNacimiento")).Text, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out Nacimiento))
            {
            }
            string Direccion = ((TextBox)grdListadoMedicos.Rows[e.RowIndex].FindControl("txtDireccion")).Text;
            int Localidad = Convert.ToInt32(((DropDownList)grdListadoMedicos.Rows[e.RowIndex].FindControl("ddlLocalidades")).SelectedValue);
            int Provincia = Convert.ToInt32(((DropDownList)grdListadoMedicos.Rows[e.RowIndex].FindControl("ddlProvincias")).SelectedValue);
            string Email = ((TextBox)grdListadoMedicos.Rows[e.RowIndex].FindControl("txtEmail")).Text;
            string Telefono = ((TextBox)grdListadoMedicos.Rows[e.RowIndex].FindControl("txtTelefono")).Text;
            int Especialidad = Convert.ToInt32(((DropDownList)grdListadoMedicos.Rows[e.RowIndex].FindControl("ddlEspecialidades")).SelectedValue);
            string Dias = ((TextBox)grdListadoMedicos.Rows[e.RowIndex].FindControl("txtDias")).Text;
            string Horario = ((TextBox)grdListadoMedicos.Rows[e.RowIndex].FindControl("txtHorarios")).Text;

            Medico Med = new Medico();
            {
                Med.setDni(DNI);
                Med.setNombre(Nombre);
                Med.setApellido(Apellido);
                Med.setSexo(Sexo);
                Med.setLocalidad(Localidad);
                Med.setProvincia(Provincia);
                Med.setNacionalidad(Nacionalidad);
                Med.setNacimiento(Nacimiento);
                Med.setDireccion(Direccion);
                Med.setEmail(Email);
                Med.setTelefono(Telefono);
                Med.setEspecialidad(Especialidad);
                Med.setDias(Dias);
                Med.setHorario(Horario);
                Med.setEstado("Activo");
            };

            log.ActualizarMedico(Med);

            grdListadoMedicos.EditIndex = -1;
            CargarGrilla();

            string script = "alert('El Registro fue Modificado con Exito.');";
            ClientScript.RegisterStartupScript(this.GetType(), "mensajeExito", script, true);
        }

        protected void grdListadoMedicos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string s_DNIMedico = ((Label)grdListadoMedicos.Rows[e.RowIndex].FindControl("lbl_it_DNI")).Text;

            if (log.EliminarMedico(s_DNIMedico))
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

        protected void grdListadoMedicos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdListadoMedicos.EditIndex = -1;
            CargarGrilla();
        }

        protected void ddlProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlProvincias = (DropDownList)sender;
            GridViewRow row = (GridViewRow)ddlProvincias.NamingContainer;
            int provinciaSeleccionada = Convert.ToInt32(ddlProvincias.SelectedValue);
            DropDownList ddlLocalidades = (DropDownList)row.FindControl("ddlLocalidades");

            if (provinciaSeleccionada != -1)
            {
                SqlDataSource2.SelectParameters["ID_PROVINCIA_PRO"].DefaultValue = provinciaSeleccionada.ToString();
                ddlLocalidades.DataBind();
                ddlLocalidades.Items.Insert(0, new ListItem("Seleccione una localidad", "-1"));
                ddlLocalidades.SelectedValue = "-1";
            }
            else
            {
                ddlLocalidades.Items.Clear();
                ddlLocalidades.Items.Add(new ListItem("Seleccione una localidad", "-1"));
                ddlLocalidades.SelectedValue = "-1";
            }
        }
    }
}