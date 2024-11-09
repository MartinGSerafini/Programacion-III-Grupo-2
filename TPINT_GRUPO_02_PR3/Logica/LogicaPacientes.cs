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
    }
}
