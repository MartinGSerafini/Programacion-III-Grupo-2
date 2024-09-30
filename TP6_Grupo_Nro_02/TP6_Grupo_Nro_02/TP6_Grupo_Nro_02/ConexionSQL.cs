using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_Grupo_Nro_02
{
    public class ConexionSQL
    {
        private string ruta = "Data Source=localhost\\sqlexpress; Initial Catalog=Neptuno; Integrated Security=True";

        public void consultaGrd(string consulta, GridView grd)
        {
            SqlConnection conexion = new SqlConnection(ruta);
            conexion.Open();
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader dr = comando.ExecuteReader();
            grd.DataSource = dr;
            grd.DataBind();
            conexion.Close();
        }
    }
}