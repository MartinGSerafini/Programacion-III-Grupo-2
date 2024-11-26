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
        public DataTable GetTablaTurnosXMedicos(string dni)
        {
            return dao.getTablaTurnosXMedicos(dni);
        }
        public DataTable GetTablaTurnosXMedicosFiltrada(string dni, string dato, string filtro)
        {
            return dao.getTablaTurnosXMedicosFiltrada(dni, filtro, dato);
        }
        public bool ActualizarTurnoXmedico(TurnosXmedicos Turno)
        {
            int op = dao.actualizarTurnoXmedico(Turno);
            if(op == 1)
            {
                return true;
            }
            else { return false; }
        }

        public int cantidadTurnosEstado(string estado)
        {
            DaoTurnos dao = new DaoTurnos();
            int cantidad = dao.contarTurnosPresentes(estado);
            return cantidad;
        }

        public DataTable EspecialidadesXturnosReportes()
        {
            DaoTurnos dao = new DaoTurnos();
            DataTable dt = dao.obtenerEspecialidadesXturnos();
            return dt;
        }

        public string devolverEspecialidadMax()
        {
            DaoTurnos dao = new DaoTurnos();
            string espe = dao.obtenerEspecialidadMaxReporte();
            return espe;
        }

        public string devolverEspecialidadMin()
        {
            DaoTurnos dao = new DaoTurnos();
            string espe = dao.obtenerEspecialidadMinReporte();
            return espe;
        }
    }
}
