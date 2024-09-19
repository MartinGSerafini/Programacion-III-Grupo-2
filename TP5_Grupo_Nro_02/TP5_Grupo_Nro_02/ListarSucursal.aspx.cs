using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data;

namespace TP5_Grupo_Nro_02
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                string consulta = "SELECT Id_Sucursal,NombreSucursal AS Nombre,DescripcionSucursal " +
                                  "AS Descripcion,DescripcionProvincia AS Provincia,DireccionSucursal " +
                                  "AS Direccion FROM Sucursal " +
                                  "INNER JOIN Provincia ON Sucursal.Id_ProvinciaSucursal = Provincia.Id_Provincia";
                ConexionSQL Sucursal = new ConexionSQL();
                Sucursal.consultaGrd(consulta, GrdSucursales);
            }
        }

        protected void Mostrar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT Id_Sucursal,NombreSucursal AS Nombre,DescripcionSucursal AS Descripcion,DescripcionProvincia " +
                              "AS Provincia,DireccionSucursal AS Direccion FROM Sucursal " +
                              "INNER JOIN Provincia ON Sucursal.Id_ProvinciaSucursal = Provincia.Id_Provincia";
            ConexionSQL Sucursal = new ConexionSQL();
            Sucursal.consultaGrd(consulta, GrdSucursales);
        }

        protected void filtro_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(TxtID.Text);

            string consulta = $"SELECT S.Id_Sucursal, S.NombreSucursal AS Nombre, S.DescripcionSucursal AS Descripcion, " + "P.DescripcionProvincia AS Provincia, S.DireccionSucursal AS Direccion " +
                              $"FROM Sucursal S INNER JOIN Provincia " + "P ON S.Id_ProvinciaSucursal = P.Id_Provincia " +
                              $"WHERE S.Id_Sucursal = {ID}";

            new ConexionSQL().consultaGrd(consulta, GrdSucursales);
        }
    }
}