using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Data;

namespace TP5_Grupo_Nro_02
{
    public class ConexionSQL
    {
        private string ruta = "Data Source = localhost\\sqlexpress; Initial Catalog = BDSucursales; Integrated Security=True";

        public int ejecutarConsulta(string consulta)
        {
            SqlConnection conexion = new SqlConnection(ruta);
            conexion.Open();

            SqlCommand cmd = new SqlCommand(consulta, conexion);
            int filas = cmd.ExecuteNonQuery();

            return filas;
        }

        public void consultaParaDdl(string consulta, DropDownList ddl, string item1, string item2)
        {
            SqlConnection conexion = new SqlConnection(ruta);
            conexion.Open();

            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataReader dr = cmd.ExecuteReader();

            ddl.Items.Add("--Seleccionar provincia--");
            while (dr.Read())
            {
                ddl.Items.Add(dr[$"{item1}"] + "-" + dr[$"{item2}"]);
            }

            conexion.Close();
        }
        public void consultaGrd(string consulta, GridView grd)
        {
            SqlConnection conexion = new SqlConnection(ruta);
            conexion.Open();
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataReader dr = cmd.ExecuteReader();
            grd.DataSource = dr;
            grd.DataBind();
            conexion.Close();
        }
    }
}