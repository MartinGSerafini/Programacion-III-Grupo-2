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
    public class LogicaAdministradores
    {
        public string ObtenerNombreYApellidoAdministrador(string dniAdministrador)
        {
            DaoAdministradores daoAdministrador = new DaoAdministradores();
            return daoAdministrador.GetNombreYApellidoAdministrador(dniAdministrador); // Llamamos al DAO para obtener el nombre y apellido del administrador
        }
    }

}
