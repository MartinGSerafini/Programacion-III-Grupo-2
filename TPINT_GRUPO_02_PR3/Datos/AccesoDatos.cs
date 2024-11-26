using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Datos
{
    public class AccesoDatos
    {
        String ruta = "Data Source=localhost\\sqlexpress;Initial Catalog=MedicalStudio;Integrated Security=True";
        public AccesoDatos()
        {
        }
        public int ejecutarConsulta(string consulta)
        {
            SqlConnection conexion = new SqlConnection(ruta);
            conexion.Open();

            SqlCommand cmd = new SqlCommand(consulta, conexion);
            int filas = cmd.ExecuteNonQuery();

            return filas;
        }

        private SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(ruta);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
                return null;
            }
        }

        private SqlDataAdapter ObtenerAdaptador(String consultaSql, SqlConnection cn)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, cn);
                return adaptador;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ObtenerTabla(String NombreTabla, String Sql)
        {
            DataSet ds = new DataSet();
            SqlConnection Conexion = ObtenerConexion();
            SqlDataAdapter adp = ObtenerAdaptador(Sql, Conexion);
            adp.Fill(ds, NombreTabla);
            Conexion.Close();
            return ds.Tables[NombreTabla];
        }

        public Boolean existe(String consulta)
        {
            Boolean estado = false;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand(consulta, Conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            if (datos.Read())
            {
                estado = true;
            }
            return estado;
        }

        public int BuscarTipoUsuario(String consulta)
        {
            int ID_Tipo_Usuario = 0;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand(consulta, Conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            if (datos.Read())
            {
                ID_Tipo_Usuario = datos.GetInt32(0);
            }
            return ID_Tipo_Usuario;
        }

        public int EjecutarProcedimientoAlmacenado(SqlCommand Comando, String nombreSP)
        {
            int FilasCambiadas;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = Comando;
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            FilasCambiadas = cmd.ExecuteNonQuery();
            Conexion.Close();
            return FilasCambiadas;
        }

        public int EjecutarComando(SqlCommand comando)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                if (conexion == null)
                {
                    Console.WriteLine("No se pudo establecer la conexión.");
                    return 0;
                }

                try
                {
                    comando.Connection = conexion;
                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        public int ejecutarContadorDeEstadoTurnos(string consulta)
        {
            SqlConnection conexion = ObtenerConexion();
            SqlCommand command = new SqlCommand(consulta, conexion);
            object result = command.ExecuteScalar();
            int resultado = (int)command.ExecuteScalar();
            resultado = result != null ? Convert.ToInt32(result) : 0;
            return resultado;
        }

        public DataTable obtenerCantidadEspecialidadesXturnos(string consulta)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = ObtenerConexion();
            SqlCommand command = new SqlCommand(consulta, conexion);
            SqlDataAdapter adapter = ObtenerAdaptador(consulta, conexion);

            adapter.Fill(dt);
            return dt;
        }

        public string obtenerEspecialidadReporte(string consulta)
        {
            SqlConnection conexion = ObtenerConexion();
            SqlCommand command = new SqlCommand(consulta, conexion);
            object result = command.ExecuteScalar();
            string resultado = result.ToString();
            return resultado;
        }
    }
}

