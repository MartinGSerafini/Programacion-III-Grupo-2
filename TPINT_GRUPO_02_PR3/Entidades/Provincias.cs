using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincias
    {
        private int ID_PROVINCIA;
        private string NOMBRE_PRO;

        public Provincias() { }

        public int getID_Provincia() {return ID_PROVINCIA;}
        public void setID_Provincia(int id) {ID_PROVINCIA = id;}
        public string getNombre() {return NOMBRE_PRO; }
        public void setNombre(string nombre) { NOMBRE_PRO = nombre;}
    }
}
