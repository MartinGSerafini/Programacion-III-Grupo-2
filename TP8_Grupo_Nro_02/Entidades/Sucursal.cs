using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        private int Id_Sucursal;
        private string NombreSucursal;
        private string DescripcionSucursal;
        private int Id_HorarioSucursal;
        private int Id_ProvinciaSucursal;
        private string DireccionSucursal;

        public Sucursal() { }

        public int getId_Sucursal() {return Id_Sucursal;}
        public void setId_Sucursal(int id) { Id_Sucursal = id;}
        public string getNombreSucursal() { return NombreSucursal;}
        public void setNombreSucursal(string nombre) { NombreSucursal = nombre;}
        public string getDescripcionSucursal() { return DescripcionSucursal;}
        public void setDescripcionSucursal(string descripcion) { DescripcionSucursal = descripcion;}
        public int getId_HorarioSucursal() { return Id_HorarioSucursal; }
        public void setId_HorarioSucursal(int horaio) { Id_HorarioSucursal = horaio;}
        public int getId_ProvinciaSucursal() { return Id_ProvinciaSucursal; }
        public void setId_ProvinciaSucursal(int provincia) { Id_ProvinciaSucursal = provincia;}
        public string getDireccionSucursal() { return DireccionSucursal; }
        public void setDireccionSucursal(string direccion) { DireccionSucursal = direccion;}
    }
}
