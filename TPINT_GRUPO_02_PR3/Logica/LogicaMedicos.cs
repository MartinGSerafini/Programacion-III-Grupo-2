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
            DaoMedicos daoMedico = new DaoMedicos();
            return daoMedico.GetNombreYApellidoMedico(dniMedico);
        }
    }
}
