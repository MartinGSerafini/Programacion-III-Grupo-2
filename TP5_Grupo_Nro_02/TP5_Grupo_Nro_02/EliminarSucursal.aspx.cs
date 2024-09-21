using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP5_Grupo_Nro_02
{
    public partial class WebForm3 : System.Web.UI.Page
    {
<<<<<<< HEAD
<<<<<<< HEAD
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            int IDaux;
            int.TryParse(TxbID.Text, out IDaux);
            string consultaEliminar = "DELETE FROM Sucursal WHERE Id_Sucursal = @IdSucursal";
            SqlConnection conexion = new SqlConnection("Data Source=localhost\\sqlexpress; Initial Catalog=BDSucursales; Integrated Security=True;");
            SqlCommand comando = new SqlCommand(consultaEliminar, conexion);
            comando.Parameters.AddWithValue("@IdSucursal", IDaux);
            conexion.Open();
            TxbID.Text = "";
=======

>>>>>>> parent of 3fb1319 (Add files via upload)
=======
        protected void Page_Load(object sender, EventArgs e)
        {

>>>>>>> parent of beb2b44 (.)
=======
        protected void Page_Load(object sender, EventArgs e)
        {

>>>>>>> parent of beb2b44 (.)
        }
    }
}