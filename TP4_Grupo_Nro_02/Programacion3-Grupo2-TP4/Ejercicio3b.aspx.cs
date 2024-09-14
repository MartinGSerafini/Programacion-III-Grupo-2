using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Remoting.Messaging;

namespace Programacion3_Grupo2_TP4
{
    public partial class Ejercicio3b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string TemaSeleccionado = Request.QueryString["TemaId"];
                if (TemaSeleccionado != null)
                {
                    using (SqlConnection bdLibreria = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Libreria;Integrated Security=True"))
                    {
                        bdLibreria.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Libros WHERE IdTema = @IdTema", bdLibreria);
                        cmd.Parameters.AddWithValue("@IdTema", TemaSeleccionado);
                        SqlDataReader dr = cmd.ExecuteReader();
                        grdLibros.DataSource = dr;
                        grdLibros.DataBind();
                    }
                }
            }
        }

        protected void lbtnConsultar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio3a.aspx?TemaId=");
        }
    }
}