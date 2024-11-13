using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using System.Data;
using Entidades;
using System.Net;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace TPINT_GRUPO_02_PR3
{
    public partial class Form_Admin_Listado_Pacientes : System.Web.UI.Page
    {
        LogicaPacientes log = new LogicaPacientes();
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
            GrdPacientes.DataSource = tabla;
            GrdPacientes.DataBind();
            dt = tabla; 
        }

        protected void CargarGrilla()
        {
            DataTable tabla = dt ?? log.getTabla();
            GrdPacientes.DataSource = tabla;
            GrdPacientes.DataBind();
        }

        protected void GrdPacientes_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && GrdPacientes.EditIndex == e.Row.RowIndex)
            {
                DropDownList ddlProvincias = (DropDownList)e.Row.FindControl("ddlProvincias");
                DropDownList ddlLocalidades = (DropDownList)e.Row.FindControl("ddlLocalidades");

                DataRowView rowView = (DataRowView)e.Row.DataItem;
                int provinciaId = Convert.ToInt32(rowView["FK_ID_PROVINCIA_PAS"]);
                int localidadId = Convert.ToInt32(rowView["FK_ID_LOCALIDAD_PAS"]);

                ddlProvincias.SelectedValue = provinciaId.ToString();

                SqlDataSource2.SelectParameters["ID_PROVINCIA_PRO"].DefaultValue = provinciaId.ToString();
                ddlLocalidades.DataBind();

                ddlLocalidades.SelectedValue = localidadId.ToString();
            }
        }
        protected void GrdPacientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GrdPacientes.EditIndex = e.NewEditIndex;
            CargarGrilla();

            DropDownList ddlProvincias = (DropDownList)GrdPacientes.Rows[GrdPacientes.EditIndex].FindControl("ddlProvincias");
            DropDownList ddlLocalidades = (DropDownList)GrdPacientes.Rows[GrdPacientes.EditIndex].FindControl("ddlLocalidades");

            if (ddlProvincias != null && ddlLocalidades != null)
            {
                Label lblProvincia = (Label)GrdPacientes.Rows[e.NewEditIndex].FindControl("lbl_it_Provincia");
                Label lblLocalidad = (Label)GrdPacientes.Rows[e.NewEditIndex].FindControl("lbl_it_Localidad");

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
        protected void GrdPacientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string MensajeError = "";
            string DNI = ((Label)GrdPacientes.Rows[e.RowIndex].FindControl("lblDNI")).Text;
            string Nombre = ((TextBox)GrdPacientes.Rows[e.RowIndex].FindControl("txtNombre")).Text;
            if (string.IsNullOrWhiteSpace(Nombre) || !System.Text.RegularExpressions.Regex.IsMatch(Nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {

                MensajeError += "El Nombre no debe contener números ni estar vacío.\n";
                e.Cancel = true;
            }
            string Apellido = ((TextBox)GrdPacientes.Rows[e.RowIndex].FindControl("txtApellido")).Text;
            if (string.IsNullOrWhiteSpace(Apellido) || !System.Text.RegularExpressions.Regex.IsMatch(Apellido, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                MensajeError += "El Apellido no debe contener números ni estar vacío.\n";
                e.Cancel = true;
            }
            string Sexo = ((DropDownList)GrdPacientes.Rows[e.RowIndex].FindControl("ddlSexo")).SelectedValue;
            string Nacionalidad = ((TextBox)GrdPacientes.Rows[e.RowIndex].FindControl("txtNacionalidad")).Text;
            if (string.IsNullOrWhiteSpace(Nacionalidad) || !System.Text.RegularExpressions.Regex.IsMatch(Nacionalidad, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                MensajeError += "La Nacionalidad no debe contener números ni estar vacía.\n";
                e.Cancel = true;
            }
            DateTime Nacimiento;
            if (!DateTime.TryParseExact(
                ((TextBox)GrdPacientes.Rows[e.RowIndex].FindControl("txtNacimiento")).Text,"yyyy-MM-dd",null,System.Globalization.DateTimeStyles.None,out Nacimiento))
            {
                MensajeError += "La fecha debe tener un formato yyyy-MM-dd y no estar vacía.\n";
                e.Cancel = true;
            }
            else if (Nacimiento > DateTime.Today)
            {
                MensajeError += "La fecha de nacimiento no puede ser posterior a la fecha actual.\n";
                e.Cancel = true;
            }
            if (Nacimiento > DateTime.Today)
            {
                MensajeError += "La fecha de nacimiento no puede ser posterior a la fecha actual.\n";
                e.Cancel = true;
            }
            string Direccion = ((TextBox)GrdPacientes.Rows[e.RowIndex].FindControl("txtDireccion")).Text;
            if (string.IsNullOrWhiteSpace(Direccion) || !Regex.IsMatch(Direccion, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ0-9\s]+$"))
            {
                MensajeError += "Ingresa una dirección válida (solo letras, números, espacios y guiones).\n";
                e.Cancel = true;
            }
            DropDownList ddlProvincias = (DropDownList)GrdPacientes.Rows[e.RowIndex].FindControl("ddlProvincias");
            if (ddlProvincias == null || ddlProvincias.SelectedIndex <= 0)
            {
                MensajeError += "Seleccione una Provincia.\n";
                e.Cancel = true;
            }
            int Provincia = Convert.ToInt32(((DropDownList)GrdPacientes.Rows[e.RowIndex].FindControl("ddlProvincias")).SelectedValue);
            DropDownList ddlLocalidades = (DropDownList)GrdPacientes.Rows[e.RowIndex].FindControl("ddlLocalidades");
            if (ddlLocalidades == null || ddlLocalidades.SelectedIndex <= -1)
            {
                MensajeError += "Seleccione una Localidad.\n";
                e.Cancel = true;
            }
            int Localidad = Convert.ToInt32(((DropDownList)GrdPacientes.Rows[e.RowIndex].FindControl("ddlLocalidades")).SelectedValue);
            string Email = ((TextBox)GrdPacientes.Rows[e.RowIndex].FindControl("txtEmail")).Text;
            if (!Regex.IsMatch(Email, @"^[\w\.\-]+@[\w\-]+\.[a-zA-Z]{2,}$"))
            {
                MensajeError += "Introduce un correo electrónico válido.\n";
                e.Cancel = true;
            }
            string Telefono = ((TextBox)GrdPacientes.Rows[e.RowIndex].FindControl("txtTelefono")).Text;
            if (!Regex.IsMatch(Telefono, @"^\d+$"))
            {
                MensajeError += "El teléfono debe contener solo números y no estár vacío.\n";
                e.Cancel = true;
            }

            if (!string.IsNullOrEmpty(MensajeError))
            {
                // Cancela la operación de edición
                e.Cancel = true;

                string scriptvalidacion = $"alert('{MensajeError.Replace("\n", "\\n")}');";
                ClientScript.RegisterStartupScript(this.GetType(), "MensajeError", scriptvalidacion, true);
                return;
            }

            Pacientes Pac = new Pacientes();
            {
                Pac.setDNI(DNI);
                Pac.setNombre(Nombre);
                Pac.setApellido(Apellido);
                Pac.setSexo(Sexo);
                Pac.setLocalidad(Localidad);
                Pac.setProvincia(Provincia);
                Pac.setNacionalidad(Nacionalidad);
                Pac.setNacimiento(Nacimiento);
                Pac.setDireccion(Direccion);
                Pac.setEmail(Email);
                Pac.setTelefono(Telefono);
                Pac.setEstado("Activo");
            };

            log.ActualizarPaciente(Pac);

            GrdPacientes.EditIndex = -1;
            CargarGrilla();

            string script = "alert('El Registro fue Modificado con Exito.');";
            ClientScript.RegisterStartupScript(this.GetType(), "mensajeExito", script, true);
        }

        protected void GrdPacientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string s_DNIPaciente = ((Label)GrdPacientes.Rows[e.RowIndex].FindControl("lbl_it_DNI")).Text;

            if (log.EliminarPaciente(s_DNIPaciente))
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

        protected void GrdPacientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GrdPacientes.EditIndex = -1;
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

                if (ddlLocalidades.Items.FindByValue("-1") == null)
                {
                    ddlLocalidades.Items.Insert(0, new ListItem("Seleccione una localidad", "-1"));
                }
            }
            else
            {
                ddlLocalidades.Items.Clear();
                ddlLocalidades.Items.Add(new ListItem("Seleccione una localidad", "-1"));
            }
        }
    }
}
