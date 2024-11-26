using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Logica
{
    public class LogicaReportes
    {
        private DaoReportes dao = new DaoReportes();
        public int ObtenerTotalTurnos(DateTime fechaInicio, DateTime fechaFin)
        {
            return dao.CortarTurnos(fechaInicio, fechaFin);
        }
        public int ObtenerTotalTurnosPresentes(DateTime fechaInicio, DateTime fechaFin)
        {
            return dao.ContarTurnosPresentes(fechaInicio, fechaFin);
        }
        public int ObtenerTotalTurnosAusentes(DateTime fechaInicio, DateTime fechaFin)
        {
            return dao.ContarTurnosAusentes(fechaInicio, fechaFin);
        }
        public DataTable ObtenerNombrePacientesAusentes(DateTime fechaInicio, DateTime fechaFin)
        {
            return dao.ObtenerNombrePacientesAusentes(fechaInicio, fechaFin);
        }
        public DataTable ObtenerNombrePacientesPresentes(DateTime fechaInicio, DateTime fechaFin)
        {
            return dao.ObtenerNombrePacientesPresentes(fechaInicio, fechaFin);
        }
        public DataTable ObtenerTurnosPorHoras(DateTime FechaInicio, DateTime FechaFinal, int TotalTurnos)
        {
            return dao.ObtenerTurnosPorHora(FechaInicio, FechaFinal, TotalTurnos);
        }
    }
}
