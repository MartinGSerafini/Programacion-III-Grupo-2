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
    public class LogicaEspecialidades
    {
        public DataTable ObtenerTabla()
        {
            DaoEspecialidades dao = new DaoEspecialidades();
            return dao.GetTablaEspecialidades();
        }

        public DataTable ObtenerMedicosPorEspecialidad(int idEspecialidad)
        {
            DaoMedicos dao = new DaoMedicos();
            return dao.GetMedicosPorEspecialidad(idEspecialidad);
        }
    }
}
