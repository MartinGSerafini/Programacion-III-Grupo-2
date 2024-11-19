using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turnos
    {
        private int IDMEDICO;
        private int IDPACIENTE;
        private int IDESPECIALIDAD;
        private DateTime FECHA;
        private string HORA;
        private string ESTADO;
        private string OBSERVACION;

        public int getIdMedico() { return IDMEDICO; }
        public void setIdMedico(int idmedico) { IDMEDICO = idmedico; }
        public int getIdPaciente() { return IDPACIENTE; }
        public void setIdPaciente(int idPaciente) { IDPACIENTE = idPaciente; }
        public int getEspecialidad() { return IDESPECIALIDAD; }
        public void setEspecialidad(int especialidad) { IDESPECIALIDAD = especialidad; }
        public DateTime getFecha() { return FECHA; }
        public void setFecha(DateTime fecha) { FECHA = fecha; }
        public string getHora() { return HORA; }
        public void setHora(string hora) { HORA = hora; }
        public string getEstado() { return ESTADO; }
        public void setEstado(string estado) { ESTADO = estado; }
        public string getObservacion() { return OBSERVACION; }
        public void setObservacion(string observacion) { OBSERVACION = observacion; }
    }
}
