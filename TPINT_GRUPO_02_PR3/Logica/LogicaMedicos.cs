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

        public int AgregarMedico(string dni, int IDLocalidad, int IDEspecialidad, int legajo, string nombre, string apellido, char sexo,
                                string nacionalidad, string nacimiento, string direccion, string email, string telefono)
        {
            DaoMedicos dao = new DaoMedicos();
            return dao.agregarMedico(dni, IDLocalidad, IDEspecialidad, legajo, nombre, apellido, sexo, nacionalidad, nacimiento,
                                    direccion, email, telefono);
        }

        public void AgregarHorario(List<string> listaDias, string horaIni, string horaFin, string dni)
        {
            DaoMedicos dao = new DaoMedicos();
            string dias = string.Join(",", listaDias);
            dao.agregarHorario(dias, horaIni, horaFin, dni);
        }

        public DataTable getTabla()
        {
            DaoMedicos dao = new DaoMedicos();
            return dao.getTablaEspecialidades();
        }
    }
}
