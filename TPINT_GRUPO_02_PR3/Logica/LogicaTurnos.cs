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
        public bool AgregarTurno(Turnos turno)
        {
            DaoTurnos dao = new DaoTurnos();
            return dao.agregarTurno(turno);
        }

        public int BuscarIdMedico(string dni)//TOMA EL ID MEDICO CON EL DNI
        {
            DaoTurnos dao = new DaoTurnos();
            DataTable tabla = dao.buscarIdMedico(dni);

            if (tabla != null && tabla.Rows.Count > 0)
            {
                return Convert.ToInt32(tabla.Rows[0]["IdMedico"]);
            }
            return 0;
        }

        public int BuscarIdPaciente(string dni)//TOMA EL ID PACIENTE CON EL DNI
        {
            DaoTurnos dao = new DaoTurnos();
            DataTable tabla = dao.buscarIdPaciente(dni);

            if (tabla != null && tabla.Rows.Count > 0)
            {
                return Convert.ToInt32(tabla.Rows[0]["IdPaciente"]);
            }
            return 0;
        }

    }
}
