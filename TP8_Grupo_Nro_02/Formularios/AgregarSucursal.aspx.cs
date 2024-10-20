using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

namespace TP8_Grupo_Nro_02
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarDdlProvincias();
            }
        }

        private void LlenarDdlProvincias()
        {
            LogicaProvincia logica = new LogicaProvincia(); // Crear instancia de LogicaProvincia
            DataTable tablaProvincias = logica.getTabla(); // Obtener la tabla de provincias

            if (tablaProvincias != null && tablaProvincias.Rows.Count > 0)
            {
                ddlProvincia.DataSource = tablaProvincias;
                ddlProvincia.DataTextField = "DescripcionProvincia";
                ddlProvincia.DataValueField = "Id_Provincia";
                ddlProvincia.DataBind();

                ddlProvincia.Items.Insert(0, new ListItem("--Seleccione una provincia--", "0"));
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string consulta = "INSERT INTO Sucursal(NombreSucursal,DescripcionSucursal,Id_ProvinciaSucursal,DireccionSucursal) " +
                               "VALUES ('" + txtNombreSucursal.Text + "' , '" + txtDescripcion.Text + "' , '" + ddlProvincia.SelectedIndex + 
                               "' , '" + txtDireccion.Text + "')";

            LogicaSucursal ls = new LogicaSucursal();
            int fila = ls.ConexionSQL(consulta);

            lblconfirmacion.Visible = false;
            if (fila > 0)
            {
                lblconfirmacion.Text = "Sucursal agregada correctamente";
                lblconfirmacion.Visible = true;
                borrarcampos();
            }
            else
            {
                lblconfirmacion.Text = "No se pudo agregar la sucursal";
                lblconfirmacion.Visible = true;
            }
        }

        private void borrarcampos()
        {
            txtNombreSucursal.Text = "";
            txtDescripcion.Text = "";
            txtDireccion.Text = "";
        }
    }
}