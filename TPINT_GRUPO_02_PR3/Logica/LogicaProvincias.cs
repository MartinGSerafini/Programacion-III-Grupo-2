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
    public class LogicaProvincias
    {
        public DataTable getTabla()
        {
            DaoProvincias dao = new DaoProvincias();
            return dao.getTablaProvincias();
        }
        public Provincias getProvincia(int id)
        {
            DaoProvincias dao = new DaoProvincias();
            Provincias provincia = dao.getProvincia(id);
            return provincia;
        }
    }
}
