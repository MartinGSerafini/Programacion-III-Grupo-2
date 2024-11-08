using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador
    {
        private int ID_ADMINISTRADOR;
        private string DNI;
        private string NOMBRE;
        private string APELLIDO;
        private string EMAIL;
        private string TELEFONO;
        public Administrador() { }
        public int GetID_ADMINISTRADOR() { return ID_ADMINISTRADOR; }
        public void SetID_ADMINISTRADOR(int idAdministrador) { ID_ADMINISTRADOR = idAdministrador; }
        public string GetDNI() { return DNI; }
        public void SetDNI(string dni) { DNI = dni; }
        public string GetNOMBRE() { return NOMBRE; }
        public void SetNOMBRE(string nombre) { NOMBRE = nombre; }
        public string GetAPELLIDO() { return APELLIDO; }
        public void SetAPELLIDO(string apellido) { APELLIDO = apellido; }
        public string GetEMAIL() { return EMAIL; }
        public void SetEMAIL(string email) { EMAIL = email; }
        public string GetTELEFONO() { return TELEFONO; }
        public void SetTELEFONO(string telefono) { TELEFONO = telefono; }
    }
}

