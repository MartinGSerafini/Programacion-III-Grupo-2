using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using System.Data;

namespace TPINT_GRUPO_02_PR3
{
    public partial class Form_Agregar_Pacientes : System.Web.UI.Page
    {
        LogicaProvincias logicaProvincias = new LogicaProvincias();
        LogicaLocalidades logicaLocalidades = new LogicaLocalidades();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblUsuario.Text = Session["NombreUsuario"] as string;
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
                ddlLocalidad.Items.Insert(0, new ListItem("Seleccionar Localidad", "0"));
            }
        }
        private void CargarProvincias()
        {
            DataTable dtProvincias = logicaProvincias.getTabla();
            ddlProvincia.DataSource = dtProvincias;
            ddlProvincia.DataTextField = "NombreProvincia";
            ddlProvincia.DataValueField = "IdProvincia";
            ddlProvincia.DataBind();

            ddlProvincia.Items.Insert(0, new ListItem("Seleccionar Provincia", "0"));
        }
        private void CargarLocalidades(int idProvincia)
        {
            DataTable dtLocalidades = logicaLocalidades.getTablaLocalidades(idProvincia);
            ddlLocalidad.DataSource = dtLocalidades;
            ddlLocalidad.DataTextField = "Nombre";
            ddlLocalidad.DataValueField = "IDLocalidad";
            ddlLocalidad.DataBind();

            ddlLocalidad.Items.Insert(0, new ListItem("Seleccionar Localidad", "0"));
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
    }
}
