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
    public class LogicaLocalidades
    {
        DaoLocalidades dao = new DaoLocalidades();
        public DataTable getTablaLocalidades(int idProvincia)
        {
            return dao.getTablaLocalidades(idProvincia);
        }
        public Localidades getLocalidad(int id)
        {
            DaoLocalidades dao = new DaoLocalidades();
            Localidades localidad = dao.getLocalidad(id);
            return localidad;
        }
    }
}
