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
    public class LogicaProvincia
    {
        public DataTable getTabla()
        {
            DaoProvincia dao = new DaoProvincia();
            return dao.getTablaProvincia();
        }

        public Provincia getProvincia(int id)
        {
            DaoProvincia dao = new DaoProvincia();
            Provincia prov = new Provincia();
            prov.setId_Provincia(id);
            return dao.getProvincia(prov);
        }
    }
}
