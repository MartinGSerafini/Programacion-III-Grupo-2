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
            string consulta = "insert into Sucursal(NombreSucursal,DescripcionSucursal,Id_ProvinciaSucursal,DireccionSucursal) values ('"+txtNombreSuc.Text+"' , '"+txtDescripcionSuc.Text+"' , '"+DdlProvincias.SelectedIndex+"' , '"+txtDireccionSuc.Text+"')";

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
            String consulta = "SELECT * FROM Provincia";
            String item1 = "id_provincia";
            String item2 = "DescripcionProvincia";
            ConexionSQL conexion = new ConexionSQL();
            conexion.consultaParaDdl(consulta, DdlProvincias, item1, item2);
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