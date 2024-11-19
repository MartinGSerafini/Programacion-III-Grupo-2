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
    public class LogicaPacientes
    {
        DaoPacientes dao = new DaoPacientes();
        public DataTable getTabla()
        {
            return dao.getTablaPacientes();
        }

        public DataTable getTablaFiltrada(string dato, string filtro)
        {
            return dao.getTablaPacientesFiltrada(filtro, dato);
        }

        public bool EliminarPaciente(string DNI)
        {
            Pacientes paciente = new Pacientes();
            paciente.setDNI(DNI);
            int op = dao.bajaLogicaPaciente(paciente);
            if(op == 1)
            {
                return true;
            }
            else { return false; }
        }
        public bool ActualizarPaciente(Pacientes paciente)
        {
            int op = dao.ActualizarPaciente(paciente);
            if (op == 1)
            {
                return true;
            }
            else { return false; }
        }
        public bool VerificarExistenciaDePaciente(string DNI)
        {
            return dao.ExistePacienteConDNI(DNI);
        }
        public bool AgregarPaciente(Pacientes paciente)
        {
            return dao.InsertarPaciente(paciente);
        }
        public int ObtenerPacientePorDNI(string dni)
        {
            return dao.ObtenerIdPaciente(dni);
        }
    }
}
