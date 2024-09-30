using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_Grupo_Nro_02
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT IdProducto AS [Id Producto], NombreProducto AS [Nombre Producto], CantidadPorUnidad AS [Cantidad Por Unidad], PrecioUnidad AS [Precio Unidad] FROM Productos";
            ConexionSQL conexion = new ConexionSQL();
            conexion.consultaGrd(consulta,GrdProductos);
        }
    }
}