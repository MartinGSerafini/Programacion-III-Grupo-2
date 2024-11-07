using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        private int ID_USUARIO;
        private int ID_TIPO_USUARIO;
        private string DNI;
        private string CONTRA;
        private DateTime FECHA_CREACION;
        
        public Usuarios() { }

        public int getId_Usuario() { return ID_USUARIO; }
        public void setId_Usuario(int ID_Usuario) { ID_USUARIO = ID_Usuario; }
        public int getIDTipoUsuario() { return ID_TIPO_USUARIO; }
        public void setIDTipoUsuario(int IDTipoUsuario) { ID_TIPO_USUARIO = IDTipoUsuario; }
        public string getDNIusuario() { return DNI; }
        public void setDNIusuario(string DNI_Usuario) { DNI = DNI_Usuario; }
        public string getContraseniaUsuario() { return CONTRA; }
        public void setContraseniaUsuario(string Contrasenia) { CONTRA = Contrasenia; }
        public DateTime getFECHA_CREACION() { return FECHA_CREACION; }
        public void setFECHA_CREACION(DateTime fecha) {  FECHA_CREACION = fecha; }
    }
}
