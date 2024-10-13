using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace TP7_Grupo_Nro_02
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSeleccionar_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "eventoSeleccionar")
            {
                string[] datosSucursal = (e.CommandArgument.ToString()).Split('|');
                string IdSucursal = datosSucursal[0];
                string Nombre = datosSucursal[1];
                string Descripcion = datosSucursal[2];
                if (Session["tabla"] == null)
                    Session["tabla"] = crearTabla();

                if (validarRepeticiones(IdSucursal))
                    agregarFila((DataTable)Session["tabla"], IdSucursal, Nombre, Descripcion);
            }
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            Session["provinciaseleccionada"] = null;
            DataSet ds = new DataSet();
            string nombre = txtSucursal.Text;
            ConexionSQL cn = new ConexionSQL();

            if (string.IsNullOrEmpty(nombre))
            {
                Response.Redirect("SeleccionarSucursales.aspx");
            }
            else
            {
                SqlDataAdapter adapter = cn.ObtenerAdaptador("SELECT [Id_Sucursal], [NombreSucursal], [DescripcionSucursal], [URL_Imagen_Sucursal] " +
                                                            "FROM [Sucursal] WHERE [NombreSucursal] LIKE '%' + @NombreSucursal + '%'");
                adapter.SelectCommand.Parameters.AddWithValue("@NombreSucursal", nombre);
                adapter.Fill(ds, "Sucursal");
                lvSucursales.DataSourceID = null;
                lvSucursales.DataSource = ds.Tables["Sucursal"];
                lvSucursales.DataBind();
            }
        }

        public DataTable crearTabla()
        {
            DataTable dt = new DataTable();
            DataColumn col = new DataColumn("ID_SUCURSAL", System.Type.GetType("System.String"));
            dt.Columns.Add(col);

            col = new DataColumn("NOMBRE", System.Type.GetType("System.String"));
            dt.Columns.Add(col);

            col = new DataColumn("DESCRIPCION", System.Type.GetType("System.String"));
            dt.Columns.Add(col);

            return dt;
        }

        public void agregarFila(DataTable tabla, string IdSucursal, string Nombre, string Descripcion)
        {
            DataRow dataRow = tabla.NewRow();

            dataRow["ID_SUCURSAL"] = IdSucursal;
            dataRow["NOMBRE"] = Nombre;
            dataRow["DESCRIPCION"] = Descripcion;

            tabla.Rows.Add(dataRow);
        }

        public bool validarRepeticiones(string IdSucursal)
        {
            DataTable tabla = Session["tabla"] as DataTable;
            if (tabla == null)
            {
                return true;
            }
            int filas = tabla.Rows.Count;
            string id;
            for (int i = 0; i < filas; i++)
            {
                id = tabla.Rows[i]["ID_SUCURSAL"].ToString();
                if (id == IdSucursal)
                {
                    return false;
                }
            }
            return true;
        }

        protected void btnProvincias_Command(object sender, CommandEventArgs e)
        {
            if(e.CommandName == "ComandoBoton")
            {
                Session["provinciaseleccionada"] = e.CommandArgument.ToString();
                CargarListview(e.CommandArgument.ToString());
            }
        }
        protected void lvSucursales_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            DataPager pager = lvSucursales.FindControl("DataPager1") as DataPager;
            pager.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            string provincia = Session["ProvinciaSeleccionada"] as string;
            CargarListview(provincia);
        }
        private void CargarListview(string provincia)
        {
            if (!string.IsNullOrEmpty(provincia))
            {
                ConexionSQL cn = new ConexionSQL();
                SqlDataAdapter adapter = cn.ObtenerAdaptador(
                    "SELECT s.[Id_Sucursal], s.[NombreSucursal], s.[DescripcionSucursal], s.[URL_Imagen_Sucursal] " +
                    "FROM [Sucursal] s JOIN [Provincia] p ON s.Id_ProvinciaSucursal = p.Id_Provincia " +
                    "WHERE p.DescripcionProvincia = @NombreProvincia");

                adapter.SelectCommand.Parameters.AddWithValue("@NombreProvincia", provincia);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "Sucursal");

                lvSucursales.DataSourceID = null;
                lvSucursales.DataSource = ds.Tables["Sucursal"];
                lvSucursales.DataBind();
            }
        }
    }
}