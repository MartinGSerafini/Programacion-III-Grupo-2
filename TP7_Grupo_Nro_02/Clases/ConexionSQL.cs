using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP7_Grupo_Nro_02
{
    public class ConexionSQL
    {
        private string ruta = "Data Source=localhost\\sqlexpress; Initial Catalog=BDSucursales; Integrated Security=True"; // RUTA

        public SqlConnection ObtenerConexion() //DEVUELVE UN SQL CONEXION
        {
            SqlConnection cn = new SqlConnection(ruta);
            cn.Open();
            return cn;
        }

        public SqlDataAdapter ObtenerAdaptador(string consultaSql) //DEVUELVE EL ADAPTADOR
        {
            SqlDataAdapter adaptador;
            adaptador = new SqlDataAdapter(consultaSql, ObtenerConexion());
            return adaptador;
        }

        public int EjecutarProcedimientoAlmacenado(SqlCommand comando, string NombreSP)
        {
            int FilasCambiadas;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = comando;
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSP;
            FilasCambiadas = cmd.ExecuteNonQuery();
            Conexion.Close();
            return FilasCambiadas;

        }
    }
}