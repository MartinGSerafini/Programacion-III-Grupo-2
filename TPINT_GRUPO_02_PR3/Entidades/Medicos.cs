using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico
    {
        private int ID_MEDICO;
        private string DNI;
        private string LOCALIDAD;
        private string ESPECIALIDAD;
        private string LEGAJO;
        private string NOMBRE;
        private string APELLIDO;
        private string SEXO;
        private string NACIONALIDAD;
        private DateTime NACIMIENTO;
        private string DIRECCION;
        private string EMAIL;
        private string TELEFONO;

        public Medico() { }
        public int getIdMedico() { return ID_MEDICO; }
        public void setIdMedico(int idMedico) { ID_MEDICO = idMedico; }
        public string getDni() { return DNI; }
        public void setDni(string dni) { DNI = dni; }
        public string getLocalidad() { return LOCALIDAD; }
        public void setLocalidad(string localidad) { LOCALIDAD = localidad; }
        public string getEspecialidad() { return ESPECIALIDAD; }
        public void setEspecialidad(string especialidad) { ESPECIALIDAD = especialidad; }
        public string getLegajo() { return LEGAJO; }
        public void setLegajo(string legajo) { LEGAJO = legajo; }
        public string getNombre() { return NOMBRE; }
        public void setNombre(string nombre) { NOMBRE = nombre; }
        public string getApellido() { return APELLIDO; }
        public void setApellido(string apellido) { APELLIDO = apellido; }
        public string getSexo() { return SEXO; }
        public void setSexo(string sexo) { SEXO = sexo; }
        public string getNacionalidad() { return NACIONALIDAD; }
        public void setNacionalidad(string nacionalidad) { NACIONALIDAD = nacionalidad; }
        public DateTime getNacimiento() { return NACIMIENTO; }
        public void setNacimiento(DateTime nacimiento) { NACIMIENTO = nacimiento; }
        public string getDireccion() { return DIRECCION; }
        public void setDireccion(string direccion) { DIRECCION = direccion; }
        public string getEmail() { return EMAIL; }
        public void setEmail(string email) { EMAIL = email; }
    }

}
