using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

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
    }
}