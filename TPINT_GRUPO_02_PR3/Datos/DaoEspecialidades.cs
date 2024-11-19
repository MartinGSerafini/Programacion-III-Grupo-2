using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class DaoEspecialidades
    {
        private AccesoDatos accesoDatos = new AccesoDatos();
        public DataTable GetTablaEspecialidades()
        {
            string query = "SELECT ID_ESPECIALIDAD_ESP AS IDEspecialidad, NOMBRE_ESP AS Nombre FROM ESPECIALIDADES";
            return accesoDatos.ObtenerTabla("ESPECIALIDADES", query);
        }
    }
}
