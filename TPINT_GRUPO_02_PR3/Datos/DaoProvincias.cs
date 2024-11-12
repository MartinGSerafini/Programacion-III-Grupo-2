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
        public Provincias getProvincia(int id)
        {
            DataTable tabla = ds.ObtenerTabla("PROVINCIAS", "SELECT ID_PROVINCIA_PRO AS IDProvincia, " +
                "NOMBRE_PRO AS NombreProvincia FROM PROVINCIAS WHERE ID_PROVINCIA_PRO = '" + id + "'");
            Provincias provincia = new Provincias();
            provincia.setID_Provincia(Convert.ToInt32(tabla.Rows[0][0].ToString()));
            provincia.setNombre(tabla.Rows[0][1].ToString());

            return provincia;
        }
    }
}
