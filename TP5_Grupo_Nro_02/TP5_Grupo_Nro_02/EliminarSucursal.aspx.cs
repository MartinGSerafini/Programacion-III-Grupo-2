using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP5_Grupo_Nro_02
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            int IDaux;
            int.TryParse(txtIDSucursal.Text, out IDaux);
            string consultaEliminar = "DELETE FROM Sucursal WHERE Id_Sucursal = @IdSucursal";
            SqlConnection conexion = new SqlConnection("Data Source=localhost\\sqlexpress; Initial Catalog=BDSucursales; Integrated Security=True;");
            SqlCommand comando = new SqlCommand(consultaEliminar, conexion);
            comando.Parameters.AddWithValue("@IdSucursal", IDaux);
            conexion.Open();
            txtIDSucursal.Text = "";
        }
    }
}