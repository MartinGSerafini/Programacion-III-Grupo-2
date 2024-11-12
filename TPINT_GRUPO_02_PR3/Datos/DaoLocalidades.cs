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
    public class DaoLocalidades
    {
        AccesoDatos ds = new AccesoDatos();
        public DataTable getTablaLocalidades(int idProvincia)
        {
            DataTable tabla = ds.ObtenerTabla("LOCALIDADES", "SELECT ID_LOCALIDAD_LOC AS IDLocalidad, FK_ID_PROVINCIA_LOC AS IDProvincia, NOMBRE_LOC AS Nombre FROM lOCALIDADES WHERE FK_ID_PROVINCIA_LOC = " + idProvincia);
            return tabla;
        }
        public Localidades getLocalidad(int id)
        {
            DataTable tabla = ds.ObtenerTabla("LOCALIDADES", "SELECT ID_LOCALIDAD_LOC AS IDLocalidad, FK_ID_PROVINCIA_LOC AS IDProvincia, NOMBRE_LOC AS NombreLocalidad FROM lOCALIDADES WHERE ID_LOCALIDAD_LOC = '" + id + "'");
            Localidades localidad = new Localidades();
            localidad.setID_Localidad(Convert.ToInt32(tabla.Rows[0][0].ToString()));
            localidad.setID_Provincia(Convert.ToInt32(tabla.Rows[0][1].ToString()));
            localidad.setNombre(tabla.Rows[0][2].ToString());

            return localidad;
        }
    }
}