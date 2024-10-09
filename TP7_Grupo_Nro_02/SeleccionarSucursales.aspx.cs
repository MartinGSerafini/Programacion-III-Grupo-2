using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
            string S_IdSucursal;
            string S_Nombre;
            string S_Descripcion;

            if (Session["tabla"] == null)
            {
                Session["tabla"] = crearTabla();
            }
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string nombre = txtSucursal.Text;
            ConexionSQL cn = new ConexionSQL();
            SqlDataAdapter adapter = cn.ObtenerAdaptador("SELECT [NombreSucursal], [DescripcionSucursal], [URL_Imagen_Sucursal] " +
                                                                        "FROM [Sucursal] WHERE [NombreSucursal] = @NombreSucursal");
            adapter.SelectCommand.Parameters.AddWithValue("@NombreSucursal", nombre);
            
            adapter.Fill(ds, "Sucursal");
            lvSucursales.DataSourceID = null;
            lvSucursales.DataSource = ds.Tables["Sucursal"];
            lvSucursales.DataBind();
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
    }
}