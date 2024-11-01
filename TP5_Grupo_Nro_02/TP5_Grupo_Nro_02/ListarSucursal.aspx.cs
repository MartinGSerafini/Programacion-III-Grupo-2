using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP5_Grupo_Nro_02
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDatos();
            }
        }

        protected void CargarDatos()
        {
            string consulta = "SELECT Id_Sucursal, NombreSucursal AS Nombre, DescripcionSucursal AS Descripcion, " +
                              "DescripcionProvincia AS Provincia, DireccionSucursal AS Direccion FROM Sucursal " +
                              "INNER JOIN Provincia ON Sucursal.Id_ProvinciaSucursal = Provincia.Id_Provincia";
            ConexionSQL sucursal = new ConexionSQL();
            sucursal.consultaGrd(consulta, GrdSucursales);
        }

        protected void Mostrar_Click(object sender, EventArgs e)
        {
            CargarDatos();
            TxtID.Text = "";
        }

        protected void filtro_Click(object sender, EventArgs e)
        {
            int ID;
            if (int.TryParse(TxtID.Text, out ID))
            {
                string consulta = $"SELECT S.Id_Sucursal, S.NombreSucursal AS Nombre, S.DescripcionSucursal AS Descripcion, " +
                                  "P.DescripcionProvincia AS Provincia, S.DireccionSucursal AS Direccion " +
                                  "FROM Sucursal S INNER JOIN Provincia P ON S.Id_ProvinciaSucursal = P.Id_Provincia " +
                                  $"WHERE S.Id_Sucursal = {ID}";

                ConexionSQL sucursal = new ConexionSQL();
                sucursal.consultaGrd(consulta, GrdSucursales);
            }

            TxtID.Text = "";
        }

        protected void GrdSucursales_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                string id = e.CommandArgument.ToString();
                Response.Redirect($"~/EditarSucursal.aspx?ID={id}");
            }
            else if (e.CommandName == "Eliminar")
            {
                string id = e.CommandArgument.ToString();
                string consulta = $"DELETE FROM Sucursal WHERE Id_Sucursal = {id}";
                ConexionSQL sucursal = new ConexionSQL();
                sucursal.ejecutarConsulta(consulta);
                CargarDatos();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            // Obtener el LinkButton que fue clickeado
            LinkButton btn = (LinkButton)sender;

            // Obtener la fila del GridView donde se hizo clic
            GridViewRow row = (GridViewRow)btn.NamingContainer;

            // Obtener el Panel de acciones dentro de la fila
            Panel pnlAcciones = (Panel)row.FindControl("pnlAcciones");

            // Alternar la visibilidad del panel de acciones
            pnlAcciones.Visible = !pnlAcciones.Visible;
        }

    }
}
