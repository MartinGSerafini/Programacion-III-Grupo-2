using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Entidades
{
    public class Pacientes
    {
        private int ID_PACIENTE;
        private int FK_ID_LOCALIDAD_PAS;
        private int FK_ID_PROVINCIA_PAS;
        private string DNI_PAS;
        private string NOMBRE_PAS;
        private string APELLIDO_PAS;
        private string SEXO_PAS;
        private string NACIONALIDAD_PAS;
        private DateTime NACIMIENTO_PAS;
        private string DIRECCION_PAS;
        private string EMAIL_PAS;
        private string TELEFONO_PAS;
        private string ESTADO_PAS;

        public Pacientes() { }

        public int getId_Paciente() { return ID_PACIENTE; }
        public void setId_Paciente(int ID) { ID_PACIENTE = ID; }
        public int getLocalidad() { return FK_ID_LOCALIDAD_PAS; }
        public void setLocalidad(int ID) { FK_ID_LOCALIDAD_PAS = ID; }
        public int getProvincia() { return FK_ID_PROVINCIA_PAS; }
        public void setProvincia(int ID) { FK_ID_PROVINCIA_PAS = ID; }
        public string getDNI() { return DNI_PAS; }
        public void setDNI(string DNI) { DNI_PAS = DNI; }
        public string getNombre() { return NOMBRE_PAS; }
        public void setNombre(string nombre) {  NOMBRE_PAS = nombre;}
        public string getApellido() { return APELLIDO_PAS; }
        public void setApellido(string apellido) {APELLIDO_PAS = apellido;}
        public string getSexo() { return SEXO_PAS; }
        public void setSexo(string sexo) { SEXO_PAS = sexo; }
        public string getNacionalidad() {return NACIONALIDAD_PAS; }
        public void setNacionalidad(string nacionalidad) { NACIONALIDAD_PAS = nacionalidad; }
        public DateTime getNacimiento() { return NACIMIENTO_PAS; }
        public void setNacimiento(DateTime fecha) {NACIMIENTO_PAS = fecha; }
        public string getDireccion() { return DIRECCION_PAS; }
        public void setDireccion(string direccion) { DIRECCION_PAS = direccion; }
        public string getEmail() { return EMAIL_PAS; }
        public void setEmail(string email) { EMAIL_PAS = email; }
        public string getTelefono() { return TELEFONO_PAS; }
        public void setTelefono(string telefono) { TELEFONO_PAS = telefono; }
        public string getEstado() {return ESTADO_PAS; }
        public void setEstado(string estado) {ESTADO_PAS = estado; }
    }
}
