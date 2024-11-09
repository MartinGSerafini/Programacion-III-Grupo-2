using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Localidades
    {
        private int ID_LOCALIDAD;
        private int ID_PROVINCIA;
        private string NOMBRE;

        public Localidades() { }

        public int getID_Localidad() {return ID_LOCALIDAD;}
        public void setID_Localidad(int id) {ID_LOCALIDAD = id;}
        public int getID_Provincia() {return ID_PROVINCIA;}
        public void setID_Provincia(int id) {ID_PROVINCIA = id;}
        public string getNombre() {return NOMBRE;}
        public void setNombre(string nombre) {NOMBRE = nombre;}

    }
}
