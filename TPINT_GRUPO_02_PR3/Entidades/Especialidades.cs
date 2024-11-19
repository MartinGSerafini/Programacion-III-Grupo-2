using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Especialidades
    {
        public int ID_ESPECIALIDAD_ESP;
        public string NOMBRE_ESP;

        public int GetID_ESPECIALIDAD_ESP()
        {
            return ID_ESPECIALIDAD_ESP;
        }
        public void SetID_ESPECIALIDAD_ESP(int value)
        {
            ID_ESPECIALIDAD_ESP = value;
        }
        public string GetNOMBRE_ESP()
        {
            return NOMBRE_ESP;
        }

        public void SetNOMBRE_ESP(string value)
        {
            NOMBRE_ESP = value;
        }
    }
}
