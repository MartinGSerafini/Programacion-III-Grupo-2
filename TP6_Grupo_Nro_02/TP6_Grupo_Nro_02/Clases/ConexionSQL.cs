using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_Grupo_Nro_02
{
    public class ConexionSQL
    {
        private string ruta = "Data Source=localhost\\sqlexpress; Initial Catalog=Neptuno; Integrated Security=True"; // RUTA


        public SqlConnection ObtenerConexion() //DEVUELVE UN SQL CONEXION
        {
            SqlConnection cn = new SqlConnection(ruta);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public SqlDataAdapter ObtenerAdaptador(string consultaSql) //DEVUELVE EL ADAPTADOR
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, ObtenerConexion());
                return adaptador;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int EjecutarProcedimietnoAlmacenado(SqlCommand comando, string NombreSP)
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