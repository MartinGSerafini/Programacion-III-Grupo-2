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
    public class LogicaHorarioAtencion
    {
        DaohorarioAtencion dao = new DaohorarioAtencion();
        public void AgregarHorario(List<string> listaDias, string horaIni, string horaFin, string dni)
        {
            string dias = string.Join(",", listaDias);
            dao.agregarHorario(dias, horaIni, horaFin, dni);
        }
        public string ObtenerDiasLaborales(string dniMedico)
        {
            DataTable tabla = dao.ObtenerDiasLaborales(dniMedico);

            if (tabla.Rows.Count > 0)
            {
                return tabla.Rows[0]["DIA_HDA"].ToString();
            }
            return string.Empty;
        }
        public int[] ObtenerDiasLaboralesComoNumeros(string dniMedico)
        {
            string diasLaborales = ObtenerDiasLaborales(dniMedico);
            if (!string.IsNullOrEmpty(diasLaborales))
            {
                var mapaDias = new Dictionary<string, int>
                {
                    { "domingo", 0 },
                    { "lunes", 1 },
                    { "martes", 2 },
                    { "miércoles", 3 },
                    { "jueves", 4 },
                    { "viernes", 5 },
                    { "sábado", 6 }
                };

                return diasLaborales
                    .Split(',')
                    .Select(dia => mapaDias[dia.ToLower().Trim()])
                    .ToArray();
            }
            return new int[] { };
        }
        public DateTime ObtenerHoraInicio(string dniMedico)
        {
            return dao.ObtenerHoraInicio(dniMedico);
        }
        public DateTime ObtenerHoraFin(string dniMedico)
        {
            return dao.ObtenerHoraFin(dniMedico);
        }
        public bool EsHorarioValido(string dniMedico, DateTime horaSolicitada)
        {
            try
            {
                DateTime horaInicio = ObtenerHoraInicio(dniMedico);
                DateTime horaFin = ObtenerHoraFin(dniMedico);

                return horaSolicitada >= horaInicio && horaSolicitada <= horaFin;
            }
            catch (Exception)
            {
                throw new Exception("Error");
            }
        }
    }
}
