using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace TPINT_GRUPO_02_PR3
{
    public partial class Form_Agregar_Pacientes : System.Web.UI.Page
    {
        LogicaPacientes logpas = new LogicaPacientes();
        LogicaUsuarios logUsu = new LogicaUsuarios();
        LogicaProvincias logPro = new LogicaProvincias();
        LogicaLocalidades logLoc = new LogicaLocalidades();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LblUsuario.Text = Session["NombreUsuario"] as string;
                CargarProvincias();
                CargarSexos();
                CargarFechaMax();
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
                ddlLocalidad.Items.Insert(0, new ListItem("Seleccionar Localidad", "-1"));
            }
        }
        private void CargarProvincias()
        {
            DataTable dtProvincias = logPro.getTabla();
            ddlProvincia.DataSource = dtProvincias;
            ddlProvincia.DataTextField = "NombreProvincia";
            ddlProvincia.DataValueField = "IdProvincia";
            ddlProvincia.DataBind();

            ddlProvincia.Items.Insert(0, new ListItem("--Seleccione una Provincia--", "0"));
        }
        private void CargarLocalidades(int idProvincia)
        {
            DataTable dtLocalidades = logLoc.getTablaLocalidades(idProvincia);
            ddlLocalidad.DataSource = dtLocalidades;
            ddlLocalidad.DataTextField = "Nombre";
            ddlLocalidad.DataValueField = "IDLocalidad";
            ddlLocalidad.DataBind();

            ddlLocalidad.Items.Insert(0, new ListItem("Seleccionar Localidad", "-1"));
        }
        private void CargarSexos()
        {
            ddlSexo.Items.Clear();
            ddlSexo.Items.Add(new ListItem("--Seleccione una opción--", "-1"));
            ddlSexo.Items.Add(new ListItem("F", "0"));
            ddlSexo.Items.Add(new ListItem("M", "1"));
        }
        private void CargarFechaMax()
        {
            txtNacimiento.Attributes["max"] = DateTime.Today.ToString("yyyy-MM-dd");
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("Form_Menu_Administrador.aspx");
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();
            if (logUsu.VerificarExistenciaDeDni(dni) || logpas.VerificarExistenciaDePaciente(dni))
            {
                string script = "alert('El DNI ya está registrado en la Base de Datos. No se puede agregar el paciente.');";
                ClientScript.RegisterStartupScript(this.GetType(), "mensajeError", script, true);
                return; 
            }
            else
            {
                Pacientes Pac = new Pacientes();
                {
                    Pac.setDNI(txtDNI.Text);
                    Pac.setNombre(txtNombre.Text);
                    Pac.setApellido(txtApellido.Text);
                    Pac.setSexo(ddlSexo.SelectedItem.Text);
                    Pac.setLocalidad(int.Parse(ddlLocalidad.SelectedValue.ToString()));
                    Pac.setProvincia(int.Parse(ddlProvincia.SelectedValue.ToString()));
                    Pac.setNacionalidad(TxbNacionalidad.Text);
                    Pac.setNacimiento(DateTime.Parse(txtNacimiento.Text));
                    Pac.setDireccion(txtDirección.Text);
                    Pac.setEmail (txtCorreo.Text);
                    Pac.setTelefono(txtTelefono.Text);
                    Pac.setEstado("Activo");
                };
                bool resultado = logpas.AgregarPaciente(Pac);
                if (resultado)
                {
                    string script = "alert('El paciente fue Ingresado al Sistema.');";
                    ClientScript.RegisterStartupScript(this.GetType(), "mensajeExito", script, true);
                    limpiarCampos();
                }
                else
                {
                    string script = "alert('Hubo un problema al Ingresar al paciente al sistema.');";
                    ClientScript.RegisterStartupScript(this.GetType(), "mensajeError", script, true);
                }
            }
        }
        private void limpiarCampos()
        {
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            ddlSexo.SelectedIndex = -1;
            ddlLocalidad.SelectedIndex = -1;
            ddlProvincia.SelectedIndex = -1;
            TxbNacionalidad.Text = "";
            txtNacimiento.Text = "";
            txtDirección.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
        }
    }
}
