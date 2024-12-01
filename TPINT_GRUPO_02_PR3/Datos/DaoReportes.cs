using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DaoReportes
    {
        AccesoDatos ds = new AccesoDatos();
        public int ContarTurnos(DateTime fechaInicio, DateTime fechaFin)
        {
            int cantturnos = 0;
            string consulta = $"SELECT COUNT(*) FROM TURNOS WHERE FECHA_TUR BETWEEN '{fechaInicio:yyyy-MM-dd}' AND '{fechaFin:yyyy-MM-dd}'";

            DataTable dt = ds.ObtenerTabla("TURNOS", consulta);

            if (dt.Rows.Count > 0)
            {
                cantturnos = Convert.ToInt32(dt.Rows[0][0]);
            }

            return cantturnos;
        }
        public int ContarTurnosPresentes(DateTime fechaInicio, DateTime fechaFin)
        {
            int cantpresentes = 0;
            string consulta = $"SELECT COUNT(*) FROM TURNOS WHERE FECHA_TUR BETWEEN '{fechaInicio:yyyy-MM-dd}' AND '{fechaFin:yyyy-MM-dd}' AND ESTADO_TUR = 'Presente'";

            DataTable dt = ds.ObtenerTabla("TURNOS", consulta);

            if (dt.Rows.Count > 0)
            {
                cantpresentes = Convert.ToInt32(dt.Rows[0][0]);
            }

            return cantpresentes;
        }
        public int ContarTurnosAusentes(DateTime fechaInicio, DateTime fechaFin)
        {
            int cantausentes = 0;
            string consulta = $"SELECT COUNT(*) FROM TURNOS WHERE FECHA_TUR BETWEEN '{fechaInicio:yyyy-MM-dd}' AND '{fechaFin:yyyy-MM-dd}' AND ESTADO_TUR = 'Ausente'";

            DataTable dt = ds.ObtenerTabla("TURNOS", consulta);

            if (dt.Rows.Count > 0)
            {
                cantausentes = Convert.ToInt32(dt.Rows[0][0]);
            }

            return cantausentes;
        }
        public DataTable ObtenerNombrePacientesAusentes(DateTime fechaInicio, DateTime fechaFin)
        {
            string consulta = $"SELECT P.NOMBRE_PAS + ' ' + P.APELLIDO_PAS AS Nombre FROM TURNOS T INNER JOIN PACIENTES P ON T.FK_ID_PACIENTE_TUR = P.ID_PACIENTE_PAS WHERE T.FECHA_TUR BETWEEN '{fechaInicio:yyyy-MM-dd}' AND '{fechaFin:yyyy-MM-dd}' AND T.ESTADO_TUR = 'Ausente'";
            return ds.ObtenerTabla("TURNOS", consulta);
        }
        public DataTable ObtenerNombrePacientesPresentes(DateTime fechaInicio, DateTime fechaFin)
        {
            string consulta = $"SELECT P.NOMBRE_PAS + ' ' + P.APELLIDO_PAS AS Nombre FROM TURNOS T INNER JOIN PACIENTES P ON T.FK_ID_PACIENTE_TUR = P.ID_PACIENTE_PAS WHERE T.FECHA_TUR BETWEEN '{fechaInicio:yyyy-MM-dd}' AND '{fechaFin:yyyy-MM-dd}' AND T.ESTADO_TUR = 'Presente'";
            return ds.ObtenerTabla("TURNOS", consulta);
        }
        public DataTable ObtenerTurnosPorHora(DateTime FechaInicio, DateTime FechaFinal, int TotalTurnos)
        {
            string consulta = $@"
            SELECT 
                CONVERT(VARCHAR(5), HORA_TUR, 108) AS Hora, -- Extrae solo la hora y los minutos (HH:MM)
                COUNT(*) AS CantidadTurnos, 
                (COUNT(*) * 100.0 / {TotalTurnos}) AS Porcentaje -- Calcula el porcentaje
            FROM TURNOS
            WHERE FECHA_TUR BETWEEN '{FechaInicio:yyyy-MM-dd}' AND '{FechaFinal:yyyy-MM-dd}'
            GROUP BY CONVERT(VARCHAR(5), HORA_TUR, 108)
            ORDER BY Hora";


            return ds.ObtenerTabla("TURNOS", consulta);
        }
    }
}
