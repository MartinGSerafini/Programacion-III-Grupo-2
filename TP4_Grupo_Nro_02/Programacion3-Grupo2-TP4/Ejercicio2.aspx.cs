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
    public partial class WebForm2 : System.Web.UI.Page
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
    }
}