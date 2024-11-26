using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TurnosXmedicos
    {
        string DNI, ASISTENCIA, OBSERVACION;

        public string get_DNI_TURNO_X_MEDICO()
        {
            return DNI;
        }

        public void set_DNI_TURNO_X_MEDICO(string value)
        {
            DNI = value;
        }

        public string get_ASISTENCIA_TURNO_X_MEDICO()
        {
            return ASISTENCIA;
        }

        public void set_ASISTENCIA_TURNO_X_MEDICO(string value)
        {
            ASISTENCIA = value;
        }

        public string get_OBSERVACION_TURNO_X_MEDICO()
        {
            return OBSERVACION;
        }

        public void set_OBSERVACION_TURNO_X_MEDICO(string value)
        {
            OBSERVACION = value;
        }
    }
}
