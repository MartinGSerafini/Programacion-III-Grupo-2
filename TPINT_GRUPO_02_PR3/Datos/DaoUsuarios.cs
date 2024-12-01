using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class DaoUsuarios
    {
        AccesoDatos ds = new AccesoDatos();
        public Usuarios getUsuario(Usuarios usu)
        {
            DataTable tabla = ds.ObtenerTabla("USUARIOS", "SELECT * FROM USUARIOS WHERE FK_DNI_USU = " + usu.getDNIusuario());
            usu.setId_Usuario(Convert.ToInt32(tabla.Rows[0][0].ToString()));
            usu.setIDTipoUsuario(Convert.ToInt32(tabla.Rows[0][1].ToString()));
            usu.setDNIusuario(tabla.Rows[0][2].ToString());
            usu.setContraseniaUsuario(tabla.Rows[0][3].ToString());
            usu.setFECHA_CREACION(Convert.ToDateTime(tabla.Rows[0][4].ToString()));
            return usu;
        }
        public Boolean existeUsuario(Usuarios usu)
        {
            string consulta = "SELECT * FROM USUARIOS WHERE FK_DNI_USU = '" + usu.getDNIusuario() + "'";
            return ds.existe(consulta);
        }
        public int TipoDeUsuario(Usuarios usu)
        {
            string consulta = "SELECT FK_ID_TIPO_USUARIO_USU FROM USUARIOS WHERE FK_DNI_USU = '" + usu.getDNIusuario() + "'";
            return ds.BuscarTipoUsuario(consulta);
        }
        public string GetNombreUsuario(Usuarios usu)
        {
            string consulta = "";

            if (usu.getIDTipoUsuario() == 1)
            {
                consulta = "SELECT NombreAdministrador FROM Administradores WHERE FK_DNI_ADMIN = '" + usu.getDNIusuario() + "'";
            }
            else if (usu.getIDTipoUsuario() == 2)
            {
                consulta = "SELECT NombreMedico FROM Medicos WHERE FK_DNI_MEDICO = '" + usu.getDNIusuario() + "'";
            }
            DataTable tabla = ds.ObtenerTabla("USUARIOS", consulta);

            if (tabla.Rows.Count > 0)
            {
                if (usu.getIDTipoUsuario() == 1)
                {
                    return tabla.Rows[0]["NombreAdministrador"].ToString();
                }
                else if (usu.getIDTipoUsuario() == 2)
                {
                    return tabla.Rows[0]["NombreMedico"].ToString();
                }
            }

            return string.Empty;
        }
        public int agregarUsuario(int tipo, string dni, string contra)
        {
            int filas = ds.ejecutarConsulta("INSERT INTO USUARIOS(FK_ID_TIPO_USUARIO_USU,FK_DNI_USU,CONTRA_USU,FECHA_CREACION_USU)" +
                                            "SELECT " + tipo + ", '" + dni + "', '" + contra + "', GETDATE();");
            return filas;
        }
        public int ActualizarContraseña(string dni, string nuevaContraseña)
        {
            SqlCommand comando = new SqlCommand();
            comando.Parameters.AddWithValue("@DNI_USU", dni);
            comando.Parameters.AddWithValue("@CONTRA_USU", nuevaContraseña);

            return ds.EjecutarProcedimientoAlmacenado(comando, "spActualizarContraseñaUsuario");
        }
        public bool ExisteDni(string dni)
        {
            string sql = "SELECT COUNT(*) FROM USUARIOS WHERE FK_DNI_USU = '" + dni + "'";

            DataTable tabla = ds.ObtenerTabla("USUARIOS", sql);

            if (tabla.Rows.Count > 0)
            {
                return Convert.ToInt32(tabla.Rows[0][0]) > 0;
            }
            return false;
        }
    }
}
