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
    public class LogicaMedicos
    {
        private DaoMedicos dao = new DaoMedicos();

        public bool AgregarMedico(Medico medico)
        {
            return dao.agregarMedico(medico);
        }
        public bool EliminarMedico(string DNI)
        {
            Medico medico = new Medico();
            medico.setDni(DNI);
            int op = dao.bajaLogicaMedico(medico);
            if (op == 1)
            {
                return true;
            }
            else { return false; }
        }
        public bool ActualizarMedico(Medico medico)
        {
            int op = dao.ActualizarMedico(medico);
            if (op == 1)
            {
                return true;
            }
            else { return false; }
        }
        public string ObtenerNombreYApellidoMedico(string dniMedico)
        {
            return dao.GetNombreYApellidoMedico(dniMedico);
        }
        public DataTable getTablaFiltrada(string dato, string filtro)
        {
            return dao.getTablaMedicosFiltrada(dato, filtro);
        }
        public DataTable getTablaMedicosPorEspecialidad(int idEspecialidad)
        {
            return dao.GetMedicosPorEspecialidad(idEspecialidad);
        }
        public bool VerificarExistenciaDeMedico(string columna, string dato)
        {
            DaoMedicos dao = new DaoMedicos();
            return dao.ExisteMedico(columna, dato);
        }
        public DataTable GetTablaMedicos()
        {
            return dao.getTablaMedicos();
        }
    }
}
