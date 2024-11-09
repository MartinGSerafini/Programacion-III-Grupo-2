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
        public DataTable getTabla()
        {
            DaoPacientes dao = new DaoPacientes();
            return dao.getTablaPacientes();
        }

        public DataTable getTablaFiltrada(string dato, string filtro)
        {
            DaoPacientes dao = new DaoPacientes();
            return dao.getTablaPacientesFiltrada(filtro, dato);
        }

        public bool EliminarPaciente(string DNI)
        {
            DaoPacientes Dao = new DaoPacientes();
            Pacientes paciente = new Pacientes();
            paciente.setDNI(DNI);
            int op = Dao.bajaLogicaPaciente(paciente);
            if(op == 1)
            {
                return true;
            }
            else { return false; }
        }

        public bool ModificarPaciente(string DNI)
        {
            DaoPacientes Dao = new DaoPacientes();
            Pacientes paciente = new Pacientes();
            paciente.setDNI(DNI);
            int op = Dao.ModificaiónPaciente(paciente);
            if (op == 1)
            {
                return true;
            }
            else { return false; }
        }
    }
}
