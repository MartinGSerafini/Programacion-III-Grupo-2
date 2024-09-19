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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            string consulta = "insert into Sucursal(NombreSucursal,DescripcionSucursal,Id_ProvinciaSucursal,DireccionSucursal) values ('"+txtNombreSuc.Text+"' , '"+txtDescripcionSuc.Text+"' , '"+DdlProvincias.Text+"' , '"+txtDireccionSuc.Text+"')";

            ConexionSQL conexionsql = new ConexionSQL();
            int fila = conexionsql.ejecutarConsulta(consulta);

            if (fila > 0)
            {
                lblMensaje.Text = "Sucursal agregada correctamente";
            }
            else
            {
                lblMensaje.Text = "No se pudo agregar la sucursal";
            }
        }
    }
}