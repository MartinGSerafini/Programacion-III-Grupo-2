using Logica;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPINT_GRUPO_02_PR3.FormAdmin
{
    public partial class Agregar_Medico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblDias.Visible = false;
                LblUsuario.Text = Session["NombreUsuario"] as string;
                CargarProvincias();
                CargarEspecialidades();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cblDias.SelectedItem == null)
            {
                lblDias.Visible = true;
                return;
            }

            string dni = txtDNI.Text.Trim();

            LogicaMedicos logicaMed = new LogicaMedicos();
            LogicaUsuarios logicaUsu = new LogicaUsuarios();
            List<string> dias = new List<string>();

            foreach (ListItem item in cblDias.Items)
            {
                if (item.Selected)
                {
                    dias.Add(item.Text);
                }
            }
            if (!logicaMed.VerificarExistenciaDeMedico(dni))
            {
                Medico Med = new Medico();
                {
                    Med.setLegajo(txtLegajo.Text);
                    Med.setDni(txtDNI.Text);
                    Med.setNombre(txtNombre.Text);
                    Med.setApellido(txtApellido.Text);
                    Med.setSexo(ddlSexo.SelectedItem.Text);
                    Med.setLocalidad(Convert.ToInt32(ddlLocalidad.SelectedValue));
                    Med.setProvincia(Convert.ToInt32(ddlProvincia.SelectedValue));
                    Med.setNacionalidad(txtnacionalidad.Text);
                    Med.setNacimiento(DateTime.Parse(txtNacimiento.Text));
                    Med.setDireccion(txtDireccion.Text);
                    Med.setEmail(txtCorreo.Text);
                    Med.setTelefono(txtTelefono.Text);
                    Med.setEspecialidad(Convert.ToInt32(ddlEspecialidad.SelectedValue));
                    Med.setEstado("Activo");
                };


                bool validMedico = logicaMed.AgregarMedico(Med);
                if (validMedico)
                {
                    logicaUsu.AgregarUsuario(2, dni, txtContraseña.Text);
                    logicaMed.AgregarHorario(dias, txtHoraInicio.Text, txtHoraFinal.Text, dni);
                    string script = "alert('El Medico fue Ingresado al Sistema.');";
                    ClientScript.RegisterStartupScript(this.GetType(), "mensajeExito", script, true);
                    limpiarCampos();
                }
                else
                {
                    string script = "alert('Hubo un problema al Ingresar al Medico al sistema.');";
                    ClientScript.RegisterStartupScript(this.GetType(), "mensajeError", script, true);
                }
            }
            else
            {
                string script = "alert('El DNI ya está registrado. No se puede agregar el paciente.');";
                ClientScript.RegisterStartupScript(this.GetType(), "mensajeError", script, true);
                return;
            }
        }

        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idProvincia = Convert.ToInt32(ddlProvincia.SelectedValue);

            if (idProvincia > 0)
            {
                CargarLocalidades(idProvincia);
            }
            else
            {
                ddlLocalidad.Items.Clear();
                ddlLocalidad.Items.Insert(0, new ListItem("Seleccionar Localidad", "0"));
            }
        }

        private void CargarProvincias()
        {
            LogicaProvincias logica = new LogicaProvincias();
            DataTable tablaProvincias = logica.getTabla();

            if (tablaProvincias != null && tablaProvincias.Rows.Count > 0)
            {
                ddlProvincia.DataSource = tablaProvincias;
                ddlProvincia.DataTextField = "NombreProvincia";
                ddlProvincia.DataValueField = "IDProvincia";
                ddlProvincia.DataBind();

                ddlProvincia.Items.Insert(0, new ListItem("--Seleccione la provincia--", "0"));
            }
        }

        private void CargarLocalidades(int idProvincia)
        {
            LogicaLocalidades logica = new LogicaLocalidades();
            DataTable dtLocalidades = logica.getTablaLocalidades(idProvincia);
            ddlLocalidad.DataSource = dtLocalidades;
            ddlLocalidad.DataTextField = "Nombre";
            ddlLocalidad.DataValueField = "IDLocalidad";
            ddlLocalidad.DataBind();

            ddlLocalidad.Items.Insert(0, new ListItem("--Seleccione la localidad--", "0"));
        }

        private void CargarEspecialidades()
        {
            LogicaMedicos logica = new LogicaMedicos();
            DataTable dtEspecialidades = logica.getTabla();
            ddlEspecialidad.DataSource = dtEspecialidades;
            ddlEspecialidad.DataTextField = "Nombre";
            ddlEspecialidad.DataValueField = "IDEspecialidad";
            ddlEspecialidad.DataBind();

            ddlEspecialidad.Items.Insert(0, new ListItem("--Seleccione la especialidad--", "0"));
        }

        private void limpiarCampos()
        {
            txtLegajo.Text = "";
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNacimiento.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtHoraInicio.Text = "";
            txtHoraFinal.Text = "";
            txtContraseña.Text = "";
            txtRepetirContraseña.Text = "";
            ddlSexo.SelectedIndex = 0;
            txtnacionalidad.Text = "";
            ddlProvincia.SelectedIndex = 0;
            ddlLocalidad.SelectedIndex = 0;
            ddlEspecialidad.SelectedIndex = 0;
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("Form_Menu_Administrador.aspx");
        }
    }
}