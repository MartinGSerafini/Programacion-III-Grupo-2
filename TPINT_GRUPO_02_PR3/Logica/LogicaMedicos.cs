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
        public string ObtenerNombreYApellidoMedico(string dniMedico)
        {
            DaoMedicos dao = new DaoMedicos();
            return dao.GetNombreYApellidoMedico(dniMedico);
        }

        public bool AgregarMedico(Medico medico)
        {
            DaoMedicos dao = new DaoMedicos();
            return dao.agregarMedico(medico);
        }

        public void AgregarHorario(List<string> listaDias, string horaIni, string horaFin, string dni)
        {
            DaoMedicos dao = new DaoMedicos();
            string dias = string.Join(",", listaDias);
            dao.agregarHorario(dias, horaIni, horaFin, dni);
        }

        public bool EliminarMedico(string DNI)
        {
            DaoMedicos Dao = new DaoMedicos();
            Medico medico = new Medico();
            medico.setDni(DNI);
            int op = Dao.bajaLogicaMedico(medico);
            if (op == 1)
            {
                return true;
            }
            else { return false; }
        }

        public bool ActualizarMedico(Medico medico)
        {
            DaoMedicos Dao = new DaoMedicos();
            int op = Dao.ActualizarMedico(medico);
            if (op == 1)
            {
                return true;
            }
            else { return false; }
        }

        public DataTable GetTablaMedicos()
        {
            DaoMedicos dao = new DaoMedicos();
            return dao.getTablaMedicos();
        }

        public DataTable getTablaFiltrada(string dato, string filtro)
        {
            DaoMedicos dao = new DaoMedicos();
            return dao.getTablaMedicosFiltrada(dato, filtro);
        }

        public DataTable getTabla()
        {
            DaoMedicos dao = new DaoMedicos();
            return dao.getTablaEspecialidades();
        }

        public bool VerificarExistenciaDeMedico(string DNI)
        {
            DaoMedicos dao = new DaoMedicos();
            return dao.ExisteMedicoConDNI(DNI);
        }
    }
}
