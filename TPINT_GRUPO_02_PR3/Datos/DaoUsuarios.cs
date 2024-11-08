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
    }
}
