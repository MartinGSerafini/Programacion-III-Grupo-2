using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_Grupo_Nro_02
{
    public partial class Ejercicio_2B : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                cargarTabla();
            }
        }

        public void cargarTabla()
        {
            GestionProductos gproductos = new GestionProductos();
            grdProductos.DataSource = gproductos.ObtenerTodosLosProductos();
            grdProductos.DataBind();
        }

        protected void grdProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdProductos.PageIndex = e.NewPageIndex;
            cargarTabla();
        }

        protected void grdProductos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            string S_IdProducto = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_IdProducto")).Text;
            string S_NombreProducto = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_NombreProducto")).Text;
            string S_IdProveedor = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_IdProveedor")).Text;
            string S_PrecioUnitario = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_PrecioUnitario")).Text;

            lblSeleccionProductos.Text = "Producto Agregado: " + S_IdProducto + " " + S_NombreProducto + " " + S_IdProveedor + " " + S_PrecioUnitario;

            if (Session["tabla"] == null)
            {
                Session["tabla"] = crearTabla();
            }

            if (validarRepeticiones(S_IdProducto))
            {
                agregarFila((DataTable)Session["tabla"], S_IdProducto, S_NombreProducto, S_IdProveedor, S_PrecioUnitario);
            }
        }

        public DataTable crearTabla()
        {
            DataTable dt = new DataTable();
            DataColumn col = new DataColumn("Id Producto", System.Type.GetType("System.String"));
            dt.Columns.Add(col);

            col = new DataColumn("Nombre Producto", System.Type.GetType("System.String"));
            dt.Columns.Add(col);

            col = new DataColumn("Id Proveedor", System.Type.GetType("System.String"));
            dt.Columns.Add(col);

            col = new DataColumn("Precio Unitario", System.Type.GetType("System.String"));
            dt.Columns.Add(col);

            return dt;
        }

        public void agregarFila(DataTable tabla, string IdProducto, string NombreProducto, string IdProveedor, string PrecioUnitario)
        {
            DataRow dataRow = tabla.NewRow();

            dataRow["Id Producto"] = IdProducto;
            dataRow["Nombre Producto"] = NombreProducto;
            dataRow["Id Proveedor"] = IdProveedor;
            dataRow["Precio Unitario"] = PrecioUnitario;

            tabla.Rows.Add(dataRow);
        }

        public bool validarRepeticiones(string IdProducto)
        {
            DataTable tabla = Session["tabla"] as DataTable;
            if(tabla == null)
            {
                return true;
            }
            int filas = tabla.Rows.Count;
            string id;
            for (int i=0; i<filas; i++)
            {
                id = tabla.Rows[i]["Id Producto"].ToString();
                if (id == IdProducto)
                {
                    return false;
                }
            }
            return true;
        }
    } 
}