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
        public bool VerificarExistenciaDeMedico2(string legajo)
        {
            DaoMedicos dao = new DaoMedicos();
            return dao.ExisteMedicoConDNI(legajo);
        }
        public (int provinciaId, int localidadId) ObtenerProvinciaYLocalidadPorDni(string dni)
        {
            DaoMedicos dao = new DaoMedicos();
            int provinciaId = dao.ObtenerProvinciaPorDni(dni);
            int localidadId = dao.ObtenerLocalidadPorDni(dni);

            return (provinciaId, localidadId);
        }
        public int ObtenerEspecialidadPorDni(string dni)
        {
            DaoMedicos dao = new DaoMedicos();
            int especialidadId = dao.ObtenerEspecialidadPorDni(dni);
            return (especialidadId);
        }

        public DataTable GetTablaMedicosXidEsp(int id)
        {
            DaoMedicos dao = new DaoMedicos();
            return dao.getTablaMedicosXidEsp(id);
        }

        public string GetDiasMedico(string DNI)
        {
            DaoMedicos dao = new DaoMedicos();
            DataTable tabla = dao.getDiasMedico(DNI);

            if (tabla != null && tabla.Rows.Count > 0)
            {
                return tabla.Rows[0]["Dias"].ToString();
            }
            return "0";
        }

        public string GetHorarioMedico(string DNI, string hora)
        {
            DaoMedicos dao = new DaoMedicos();
            DataTable tabla = dao.getDiasMedico(DNI);

            if (tabla != null && tabla.Rows.Count > 0)
            {
                return tabla.Rows[0][hora].ToString();
            }
            return "0";
        }
    }
}
