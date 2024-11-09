using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class LogicaProvincias
    {
        public DataTable getTabla()
        {
            DaoProvincias dao = new DaoProvincias();
            return dao.getTablaProvincias();
        }
    }
}
