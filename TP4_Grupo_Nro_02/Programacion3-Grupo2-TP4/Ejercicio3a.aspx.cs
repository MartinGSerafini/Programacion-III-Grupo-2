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
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                using (SqlConnection bdLibreria = new SqlConnection("Data Source=PILY\\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True"))
                {
                    bdLibreria.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Temas", bdLibreria);
                    SqlDataReader reader = cmd.ExecuteReader();

                    ddlTemas.DataSource = reader;
                    ddlTemas.DataTextField = "Tema";
                    ddlTemas.DataValueField = "idTema";
                    ddlTemas.DataBind();

                    ddlTemas.Items.Insert(0, new ListItem("Seleccione un tema", ""));
                }
            }
        }
    }
}