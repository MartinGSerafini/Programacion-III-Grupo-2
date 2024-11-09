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
    }
}