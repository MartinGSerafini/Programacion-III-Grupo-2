using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP5_Grupo_Nro_02
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string ruta = "Data Source=localhost\\sqlexpress; Initial Catalog=BDSucursales; Integrated Security=True;";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                CargarProvincias();
            }
            

        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            string consulta = "insert into Sucursal(NombreSucursal,DescripcionSucursal,Id_ProvinciaSucursal,DireccionSucursal) values ('"+txtNombreSuc.Text+"' , '"+txtDescripcionSuc.Text+"' , '"+DdlProvincias.Text+"' , '"+txtDireccionSuc.Text+"')";

            ConexionSQL conexionsql = new ConexionSQL();
            int fila = conexionsql.ejecutarConsulta(consulta);

            if (fila > 0)
            {
                lblMensaje.Text = "Sucursal agregada correctamente";
                limpiarAgregarSucursal();
            }
            else
            {
                lblMensaje.Text = "No se pudo agregar la sucursal";
            }
        }

        protected void CargarProvincias()
        {
            SqlConnection BDSucursales = new SqlConnection(ruta);
            BDSucursales.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Provincia", BDSucursales);
            SqlDataReader dr = cmd.ExecuteReader();
            DdlProvincias.DataSource = dr;
            DdlProvincias.DataTextField = "DescripcionProvincia";
            DdlProvincias.DataValueField = "Id_Provincia";
            DdlProvincias.DataBind();
            DdlProvincias.Items.Insert(0, new ListItem("Seleccione una provincia", ""));
            BDSucursales.Close();
        }

        protected void limpiarAgregarSucursal()
        {
            txtNombreSuc.Text = "";
            txtDescripcionSuc.Text = "";
            DdlProvincias.SelectedIndex = 0;
            txtDireccionSuc.Text = "";
        }

    }
}