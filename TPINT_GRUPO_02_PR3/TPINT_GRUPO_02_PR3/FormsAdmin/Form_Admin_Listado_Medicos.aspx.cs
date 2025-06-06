﻿using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        LogicaUsuarios logusu = new LogicaUsuarios();
        DataTable dt = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LblUsuario.Text = Session["NombreUsuario"] as string;
                grdListadoMedicos.DataBind();
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
        protected void grdListadoMedicos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && grdListadoMedicos.EditIndex == e.Row.RowIndex)
            {
                DropDownList ddlProvincias = (DropDownList)e.Row.FindControl("ddlProvincias");
                DropDownList ddlLocalidades = (DropDownList)e.Row.FindControl("ddlLocalidades");
                DropDownList ddlEspecialidades = (DropDownList)e.Row.FindControl("ddlEspecialidades");
                CheckBoxList cblDias = (CheckBoxList)e.Row.FindControl("cblDias");
                DropDownList ddlHoraInicio = (DropDownList)e.Row.FindControl("ddlHoraInicio");
                DropDownList ddlHoraFinal = (DropDownList)e.Row.FindControl("ddlHoraFinal");
                TextBox txtContraseña = (TextBox)e.Row.FindControl("txtContraseña");

                DataRowView rowView = (DataRowView)e.Row.DataItem;
                int provinciaId = Convert.ToInt32(rowView["FK_ID_PROVINCIA_MED"]);
                int localidadId = Convert.ToInt32(rowView["FK_ID_LOCALIDAD_MED"]);
                int especialidadId = Convert.ToInt32(rowView["FK_ID_ESPECIALIDAD_MED"]);
                string dias = rowView["DIA_HDA"].ToString();
                string horarios = rowView["Horarios"].ToString();
                string contraseña = rowView["Contraseña"].ToString();

                ddlProvincias.SelectedValue = provinciaId.ToString();
                SqlDataSource2.SelectParameters["ID_PROVINCIA_PRO"].DefaultValue = provinciaId.ToString();
                ddlLocalidades.DataBind();
                ddlLocalidades.SelectedValue = localidadId.ToString();
                ddlEspecialidades.SelectedValue = especialidadId.ToString();

                if (!string.IsNullOrEmpty(dias))
                {
                    string[] diasSeleccionados = dias.Split(',');
                    foreach (var dia in diasSeleccionados)
                    {
                        ListItem item = cblDias.Items.FindByValue(dia.Trim());
                        if (item != null)
                        {
                            item.Selected = true;
                        }
                    }
                }

                if (!string.IsNullOrEmpty(horarios))
                {
                    string[] horas = horarios.Split('-');
                    if (horas.Length == 2)
                    {
                        ddlHoraInicio.SelectedValue = ddlHoraInicio.Items.FindByText(horas[0].Trim()).Value;
                        ddlHoraFinal.SelectedValue = ddlHoraFinal.Items.FindByText(horas[1].Trim()).Value; 
                    }
                }
            }
        }
        protected void grdListadoMedicos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdListadoMedicos.EditIndex = e.NewEditIndex;
            CargarGrilla();

            DropDownList ddlEspecialidades = (DropDownList)grdListadoMedicos.Rows[grdListadoMedicos.EditIndex].FindControl("ddlEspecialidades");

            if (ddlEspecialidades != null)
            {
                Label lblEspecialidad = (Label)grdListadoMedicos.Rows[e.NewEditIndex].FindControl("lbl_it_Especialidad");

                if (lblEspecialidad != null)
                {
                    string idEspecialidad = lblEspecialidad.Text;
                    if (!string.IsNullOrEmpty(idEspecialidad))
                    {
                        ddlEspecialidades.SelectedValue = idEspecialidad;
                    }
                }
            }
        }
        protected void grdListadoMedicos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string MensajeError = "";
            string DNI = ((Label)grdListadoMedicos.Rows[e.RowIndex].FindControl("lblDNI")).Text;
            string Legajo = ((Label)grdListadoMedicos.Rows[e.RowIndex].FindControl("lblLegajo")).Text;
            string Nombre = ((TextBox)grdListadoMedicos.Rows[e.RowIndex].FindControl("txtNombre")).Text;

            if (string.IsNullOrWhiteSpace(Nombre) || !System.Text.RegularExpressions.Regex.IsMatch(Nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                MensajeError += "El Nombre no debe contener números ni estar vacío.\n";
                e.Cancel = true;
            }

            string Apellido = ((TextBox)grdListadoMedicos.Rows[e.RowIndex].FindControl("txtApellido")).Text;
            if (string.IsNullOrWhiteSpace(Apellido) || !System.Text.RegularExpressions.Regex.IsMatch(Apellido, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                MensajeError += "El Apellido no debe contener números ni estar vacío.\n";
                e.Cancel = true;
            }

            string Sexo = ((DropDownList)grdListadoMedicos.Rows[e.RowIndex].FindControl("ddlSexo")).SelectedValue;

            string Nacionalidad = ((TextBox)grdListadoMedicos.Rows[e.RowIndex].FindControl("txtNacionalidad")).Text;
            if (string.IsNullOrWhiteSpace(Nacionalidad) || !System.Text.RegularExpressions.Regex.IsMatch(Nacionalidad, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                MensajeError += "La Nacionalidad no debe contener números ni estar vacía.\n";
                e.Cancel = true;
            }

            DateTime Nacimiento;
            if (!DateTime.TryParseExact(
                ((TextBox)grdListadoMedicos.Rows[e.RowIndex].FindControl("txtNacimiento")).Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out Nacimiento))
            {
                MensajeError += "La fecha debe tener un formato yyyy-MM-dd y no estar vacía.\n";
                e.Cancel = true;
            }
            else if (Nacimiento > DateTime.Today)
            {
                MensajeError += "La fecha de nacimiento no puede ser posterior a la fecha actual.\n";
                e.Cancel = true;
            }

            string Direccion = ((TextBox)grdListadoMedicos.Rows[e.RowIndex].FindControl("txtDireccion")).Text;
            if (string.IsNullOrWhiteSpace(Direccion) || !System.Text.RegularExpressions.Regex.IsMatch(Direccion, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ0-9\s]+$"))
            {
                MensajeError += "Ingresa una dirección válida (solo letras, números, espacios y guiones).\n";
                e.Cancel = true;
            }

            DropDownList ddlProvincias = (DropDownList)grdListadoMedicos.Rows[e.RowIndex].FindControl("ddlProvincias");
            if (ddlProvincias == null || ddlProvincias.SelectedIndex <= 0)
            {
                MensajeError += "Seleccione una Provincia.\n";
                e.Cancel = true;
            }
            int Provincia = Convert.ToInt32(((DropDownList)grdListadoMedicos.Rows[e.RowIndex].FindControl("ddlProvincias")).SelectedValue);


            DropDownList ddlLocalidades = (DropDownList)grdListadoMedicos.Rows[e.RowIndex].FindControl("ddlLocalidades");
            if (ddlLocalidades == null || ddlLocalidades.SelectedIndex <= -1)
            {
                MensajeError += "Seleccione una Localidad.\n";
                e.Cancel = true;
            }
            int Localidad = Convert.ToInt32(((DropDownList)grdListadoMedicos.Rows[e.RowIndex].FindControl("ddlLocalidades")).SelectedValue);

            string Email = ((TextBox)grdListadoMedicos.Rows[e.RowIndex].FindControl("txtEmail")).Text;
            if (!System.Text.RegularExpressions.Regex.IsMatch(Email, @"^[\w\.\-]+@[\w\-]+\.[a-zA-Z]{2,}$"))
            {
                MensajeError += "Introduce un correo electrónico válido.\n";
                e.Cancel = true;
            }

            string Telefono = ((TextBox)grdListadoMedicos.Rows[e.RowIndex].FindControl("txtTelefono")).Text;
            if (!System.Text.RegularExpressions.Regex.IsMatch(Telefono, @"^\d+$"))
            {
                MensajeError += "El teléfono debe contener solo números y no estar vacío.\n";
                e.Cancel = true;
            }

            DropDownList ddlEspecialidades = (DropDownList)grdListadoMedicos.Rows[e.RowIndex].FindControl("ddlEspecialidades");
            if (ddlEspecialidades == null || ddlEspecialidades.SelectedIndex <= 0)
            {
                MensajeError += "Seleccione una Especialidad.\n";
                e.Cancel = true;
            }
            int Especialidad = Convert.ToInt32(ddlEspecialidades.SelectedValue);

            CheckBoxList cblDias = (CheckBoxList)grdListadoMedicos.Rows[e.RowIndex].FindControl("cblDias");
            string Dias = string.Join(",", cblDias.Items.Cast<ListItem>()
                .Where(i => i.Selected)
                .Select(i => i.Value));
            if (string.IsNullOrEmpty(Dias))
            {
                MensajeError += "Debe seleccionar al menos un día.\n";
                e.Cancel = true;
            }

            DropDownList ddlHoraInicio = (DropDownList)grdListadoMedicos.Rows[e.RowIndex].FindControl("ddlHoraInicio");
            DropDownList ddlHoraFinal = (DropDownList)grdListadoMedicos.Rows[e.RowIndex].FindControl("ddlHoraFinal");

            string horaInicioText = ddlHoraInicio.SelectedItem.Text;
            string horaFinalText = ddlHoraFinal.SelectedItem.Text;

            string horaInicioValue = ddlHoraInicio.SelectedValue;
            string horaFinalValue = ddlHoraFinal.SelectedValue;

            if (horaInicioValue != "-1" && horaFinalValue != "-1")
            {
                int horaInicioInt = Convert.ToInt32(horaInicioValue); 
                int horaFinalInt = Convert.ToInt32(horaFinalValue); 

                if (horaInicioInt >= horaFinalInt)
                {
                    MensajeError += "La hora de inicio no puede ser mayor o igual a la hora de salida.\n";
                    e.Cancel = true;
                }
            }
            else
            {
                MensajeError += "Debe seleccionar una hora de inicio y una de salida.\n";
                e.Cancel = true;
            }
            string horaInicio = ddlHoraInicio.SelectedItem.Text;
            string horaFinal = ddlHoraFinal.SelectedItem.Text;
            string Horario = $"{horaInicio} - {horaFinal}";

            TextBox txtContraseña = (TextBox)grdListadoMedicos.Rows[e.RowIndex].FindControl("txtContraseña");
            string nuevaContraseña = txtContraseña.Text;
            if (string.IsNullOrWhiteSpace(nuevaContraseña))
            {
                MensajeError += "La contraseña no debe estar vacía.";
                e.Cancel = true;
            }

            if (!string.IsNullOrEmpty(MensajeError))
            {
                e.Cancel = true;

                string scriptvalidacion = $"alert('{MensajeError.Replace("\n", "\\n")}');";
                ClientScript.RegisterStartupScript(this.GetType(), "MensajeError", scriptvalidacion, true);
                return;
            }

            Medico Med = new Medico();
            {
                Med.setDni(DNI);
                Med.setLegajo(Legajo);
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
            logusu.ActualizarContraseña(DNI, nuevaContraseña);

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
            DropDownList ddlLocalidades = (DropDownList)ddlProvincias.NamingContainer.FindControl("ddlLocalidades");

            SqlDataSource2.SelectParameters["ID_PROVINCIA_PRO"].DefaultValue = ddlProvincias.SelectedValue;

            ddlLocalidades.DataBind();
        }

        protected void grdListadoMedicos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdListadoMedicos.PageIndex = e.NewPageIndex;

            CargarGrilla();
        }
    }
}