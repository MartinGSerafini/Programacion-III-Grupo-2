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

        protected void GrdPacientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            // Establece el índice de edición
            GrdPacientes.EditIndex = e.NewEditIndex;
            CargarGrilla();

            // Encuentra los controles DropDownList
            DropDownList ddlProvincias = (DropDownList)GrdPacientes.Rows[GrdPacientes.EditIndex].FindControl("ddlProvincias");
            DropDownList ddlLocalidades = (DropDownList)GrdPacientes.Rows[GrdPacientes.EditIndex].FindControl("ddlLocalidades");

            if (ddlProvincias != null && ddlLocalidades != null)
            {
                ddlProvincias.DataBind();

                if (ddlProvincias.SelectedValue != "-1" && !string.IsNullOrEmpty(ddlProvincias.SelectedValue))
                {
                    int idProvincia = Convert.ToInt32(ddlProvincias.SelectedValue);
                    ddlLocalidades.DataBind();
                    string selectedValueLocalidad = ddlLocalidades.SelectedValue;
                    if (!string.IsNullOrEmpty(selectedValueLocalidad) && selectedValueLocalidad != "-1")
                    {
                        int idLocalidadSeleccionada = Convert.ToInt32(selectedValueLocalidad);
                        ddlLocalidades.SelectedValue = idLocalidadSeleccionada.ToString();
                    }
                    else
                    {
                    }
                }
                else
                {
                }
            }
        }


        protected void GrdPacientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string DNI = ((Label)GrdPacientes.Rows[e.RowIndex].FindControl("lblDNI")).Text;
            string Nombre = ((TextBox)GrdPacientes.Rows[e.RowIndex].FindControl("txtNombre")).Text;
            string Apellido = ((TextBox)GrdPacientes.Rows[e.RowIndex].FindControl("txtApellido")).Text;
            string Sexo = ((DropDownList)GrdPacientes.Rows[e.RowIndex].FindControl("ddlSexo")).SelectedValue;
            string Nacionalidad = ((TextBox)GrdPacientes.Rows[e.RowIndex].FindControl("txtNacionalidad")).Text;
            DateTime Nacimiento;
            if (DateTime.TryParseExact(((TextBox)GrdPacientes.Rows[e.RowIndex].FindControl("txtNacimiento")).Text, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None ,out Nacimiento))
            {
                lblMensaje.Text = "La fecha de nacimiento no es válida.";
                return;
            }
            string Direccion = ((TextBox)GrdPacientes.Rows[e.RowIndex].FindControl("txtDireccion")).Text;
            int Provincia = Convert.ToInt32(((DropDownList)GrdPacientes.Rows[e.RowIndex].FindControl("ddlProvincias")).SelectedValue);
            int Localidad = Convert.ToInt32(((DropDownList)GrdPacientes.Rows[e.RowIndex].FindControl("ddlLocalidades")).SelectedValue);
            string Email = ((TextBox)GrdPacientes.Rows[e.RowIndex].FindControl("txtEmail")).Text;
            string Telefono = ((TextBox)GrdPacientes.Rows[e.RowIndex].FindControl("txtTelefono")).Text;

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

            lblMensaje.Text = "Paciente actualizado correctamente.";
        }

        protected void GrdPacientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string s_DNIPaciente = ((Label)GrdPacientes.Rows[e.RowIndex].FindControl("lbl_it_DNI")).Text;

            if (log.EliminarPaciente(s_DNIPaciente))
            {
                lblMensaje.Text = $"El paciente con DNI {s_DNIPaciente} fue eliminado con éxito.";
            }
            else
            {
                lblMensaje.Text = $"El paciente con DNI {s_DNIPaciente} no se pudo eliminar.";
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
                ddlLocalidades.Items.Insert(0, new ListItem("Seleccione una localidad", "-1"));
                ddlLocalidades.SelectedValue = "-1"; // Asegurarse de que no haya una localidad seleccionada por defecto
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
