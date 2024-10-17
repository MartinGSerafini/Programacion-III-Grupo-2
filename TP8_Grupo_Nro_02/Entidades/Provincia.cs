using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincia
    {
        private int Id_Provincia;
        private string DescripcionProvincia;

        public Provincia() { }

        public int getId_Provincia() {return Id_Provincia;}
        public void setId_Provincia(int IdProvincia) { Id_Provincia = IdProvincia;}
        public string getDescripcionProvincia() { return DescripcionProvincia;}
        public void setDescripcionCategoria(string Descripcion) { DescripcionProvincia = Descripcion;}
    }
}
