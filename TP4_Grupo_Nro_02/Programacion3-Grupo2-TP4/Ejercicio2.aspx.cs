using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.ModelBinding;

namespace Programacion3_Grupo2_TP4
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TxbProducto.Attributes["type"] = "number";
            TxbCategoria.Attributes["type"] = "number";

            if (IsPostBack == false)
            {
                using (SqlConnection bdNeptuno = new SqlConnection("Data Source = localhost\\sqlexpress; Initial Catalog = Neptuno; Integrated Security = True"))
                {
                    bdNeptuno.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Productos", bdNeptuno);
                    SqlDataReader dr = cmd.ExecuteReader();
                    grdProductos.DataSource = dr;
                    grdProductos.DataBind();
                }
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxbProducto.Text) && string.IsNullOrEmpty(TxbCategoria.Text))
            {
                LblIDVacio.Visible = true;
                return;
            }

            using (SqlConnection bdNeptuno = new SqlConnection("Data Source = localhost\\sqlexpress; Initial Catalog = Neptuno; Integrated Security = True"))
            {
                bdNeptuno.Open();
                if (TxbProducto.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Productos WHERE idProducto" + DdlProducto.SelectedValue + TxbProducto.Text, bdNeptuno);
                    SqlDataReader dr = cmd.ExecuteReader();
                    grdProductos.DataSource = dr;
                    grdProductos.DataBind();
                    LblIDVacio.Visible = false;
                }
                else if (TxbCategoria.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Productos WHERE IdCategoría" + DdlCategoria.SelectedValue + TxbCategoria.Text, bdNeptuno);
                    SqlDataReader dr = cmd.ExecuteReader();
                    grdProductos.DataSource = dr;
                    grdProductos.DataBind();
                    LblIDVacio.Visible = false;
                }
            }
        }

        protected void btnQuitar_Click(object sender, EventArgs e)
        {

            TxbProducto.Text = "";
            TxbCategoria.Text = "";

            using (SqlConnection bdNeptuno = new SqlConnection("Data Source = localhost\\sqlexpress; Initial Catalog = Neptuno; Integrated Security = True"))
            {
                bdNeptuno.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Productos", bdNeptuno);
                SqlDataReader dr = cmd.ExecuteReader();
                grdProductos.DataSource = dr;
                grdProductos.DataBind();
                LblIDVacio.Visible = false;
            }
        }
    }
}