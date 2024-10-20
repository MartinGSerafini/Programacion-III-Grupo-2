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
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDSucursal.Text);
            string consulta = $"DELETE FROM Sucursal WHERE Id_Sucursal = {ID}";

            ConexionSQL conexionsql = new ConexionSQL();
            int fila = conexionsql.ejecutarConsulta(consulta);

            if (fila > 0)
            {
                lblMensaje.Text = "La sucursal se ha eliminado con éxito.";
                txtIDSucursal.Text = "";
            }
            else
            {
                lblMensaje.Text = "La sucursal ingresada no existe o ya ha sido eliminada.";
            }
        }
    }
}