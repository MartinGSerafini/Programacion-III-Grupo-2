using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DaoProvincias
    {
        AccesoDatos ds = new AccesoDatos();
        public DataTable getTablaProvincias()
        {
            DataTable tabla = ds.ObtenerTabla("PROVINCIAS", "SELECT ID_PROVINCIA_PRO AS IDProvincia, NOMBRE_PRO AS NombreProvincia FROM PROVINCIAS");
            return tabla;
        }
    }
}
