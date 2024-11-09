using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DaoPacientes
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaPacientes()
        {
            DataTable tabla = ds.ObtenerTabla("PACIENTES", "SELECT P.DNI_PAS, P.NOMBRE_PAS, P.APELLIDO_PAS, P.SEXO_PAS, " +
                "P.NACIONALIDAD_PAS, P.NACIMIENTO_PAS, P.DIRECCION_PAS, L.NOMBRE_LOC, PRO.NOMBRE_PRO, P.EMAIL_PAS, P.TELEFONO_PAS " +
                "FROM PACIENTES P INNER JOIN LOCALIDADES L ON P.FK_ID_LOCALIDAD_PAS = L.ID_LOCALIDAD_LOC " +
                "INNER JOIN PROVINCIAS PRO ON P.FK_ID_PROVINCIA_PAS = PRO.ID_PROVINCIA_PRO");
            return tabla;
        }

        public DataTable getTablaPacientesFiltrada(string filtro, string dato)
        {
            DataTable tabla = ds.ObtenerTabla("PACIENTES", "SELECT P.DNI_PAS, P.NOMBRE_PAS, P.APELLIDO_PAS, P.SEXO_PAS, " +
                "P.NACIONALIDAD_PAS, P.NACIMIENTO_PAS, P.DIRECCION_PAS, L.NOMBRE_LOC, PRO.NOMBRE_PRO, P.EMAIL_PAS, P.TELEFONO_PAS " +
                "FROM PACIENTES P INNER JOIN LOCALIDADES L ON P.FK_ID_LOCALIDAD_PAS = L.ID_LOCALIDAD_LOC " +
                "INNER JOIN PROVINCIAS PRO ON P.FK_ID_PROVINCIA_PAS = PRO.ID_PROVINCIA_PRO " +
                "WHERE " + filtro + " = '" + dato + "'");
            return tabla;
        }
    }
}
