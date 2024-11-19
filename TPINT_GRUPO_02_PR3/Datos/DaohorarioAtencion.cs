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
    public class DaohorarioAtencion
    {
        AccesoDatos ds = new AccesoDatos();
        public void agregarHorario(string dia, string horaIni, string horaFin, string dni)
        {
            ds.ejecutarConsulta("INSERT INTO HORARIO_ATENCION (FK_DNI_MEDICO_HDA, DIA_HDA, HORA_INICIO_HDA, HORA_FIN_HDA) " +
                "SELECT '" + dni + "', '" + dia + "', '" + horaIni + "', '" + horaFin + "'");
        }
        public DataTable ObtenerDiasLaborales(string dniMedico)
        {
            string consulta = $"SELECT DIA_HDA FROM HORARIO_ATENCION WHERE FK_DNI_MEDICO_HDA = " +dniMedico;

            return ds.ObtenerTabla("DiasLaborales", consulta);
        }
        public DateTime ObtenerHoraInicio(string dniMedico)
        {
            string sql = "SELECT HORA_INICIO_HDA FROM HORARIO_ATENCION WHERE FK_DNI_MEDICO_HDA = '" + dniMedico + "'";
            DataTable tabla = ds.ObtenerTabla("HORARIO_ATENCION", sql);

            if (tabla.Rows.Count > 0)
            {
                TimeSpan horaInicio = (TimeSpan)tabla.Rows[0]["HORA_INICIO_HDA"];

                DateTime fechaActual = DateTime.Now.Date; 
                DateTime horaIniciocompleta = fechaActual.Add(horaInicio);

                return horaIniciocompleta;
            }
            else
            {
                throw new Exception("Error: No se encontró la hora de inicio");
            }
        }
        public DateTime ObtenerHoraFin(string dniMedico)
        {
            string sql = "SELECT HORA_FIN_HDA FROM HORARIO_ATENCION WHERE FK_DNI_MEDICO_HDA = '" + dniMedico + "'";
            DataTable tabla = ds.ObtenerTabla("HORARIO_ATENCION", sql);

            if (tabla.Rows.Count > 0)
            {
                TimeSpan horaFin = (TimeSpan)tabla.Rows[0]["HORA_FIN_HDA"];

                DateTime fechaActual = DateTime.Now.Date;
                DateTime horafinalcompleta = fechaActual.Add(horaFin);

                return horafinalcompleta;
            }
            else
            {
                throw new Exception("Error: No se encontró la hora de fin");
            }
        }
    }
}
