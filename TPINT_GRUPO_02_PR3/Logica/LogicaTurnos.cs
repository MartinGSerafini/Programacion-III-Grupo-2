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
    public class LogicaTurnos
    {
        DaoTurnos dao = new DaoTurnos();
        public DataTable getTabla()
        {
            return dao.getTablaTurnos();
        }
        public DataTable getTablaFiltrada(string dato, string filtro)
        {
            return dao.getTablaTurnosFiltrada(filtro, dato);
        }
        public DataTable getTabla2(int idmedico)
        {
            return dao.getTablaTurnos2(idmedico);
        }
        public DataTable getTablaFiltrada2(string dato, string filtro, int idmedico)
        {
            return dao.getTablaTurnosFiltrada2(filtro, dato, idmedico);
        }
        public bool EliminarTurno(int IdTurno)
        {
            int op = dao.bajaLogicaTurno(IdTurno);
            if (op == 1)
            {
                return true;
            }
            else { return false; }
        }
        public bool ActualizarTurno(Turnos Turno)
        {
            int op = dao.ActualizarTurno(Turno);
            if (op == 1)
            {
                return true;
            }
            else { return false; }
        }
        public List<TimeSpan> HorariosOcupados(string dniMedico, DateTime fecha)
        {
            return dao.ObtenerHorariosOcupados(dniMedico, fecha);
        }
        public bool AgregarTurno(Turnos Turno)
        {
            return dao.InsertarTurno(Turno);
        }
    }
}
