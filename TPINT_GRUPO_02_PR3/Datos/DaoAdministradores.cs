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
    public class DaoAdministradores
    {
        AccesoDatos ds = new AccesoDatos();

        public string GetNombreYApellidoAdministrador(string dniAdministrador)
        {
            string consulta = "SELECT NOMBRE_DES , APELLIDO_DES  FROM Administrador WHERE FK_DNI_DES = '" + dniAdministrador + "'";
            DataTable tabla = ds.ObtenerTabla("Administradores", consulta);

            if (tabla.Rows.Count > 0)
            {
                string nombreAdmin = tabla.Rows[0]["NOMBRE_DES"].ToString();
                string apellidoAdmin = tabla.Rows[0]["APELLIDO_DES"].ToString();
                return nombreAdmin + " " + apellidoAdmin;
            }
            return string.Empty;
        }
    }
}
