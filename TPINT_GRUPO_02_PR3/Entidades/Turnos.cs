using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Entidades
{
    public class Turnos
    {
        private int ID_TURNO_TUR;
        private string FK_DNI_MEDICO_TUR;
        private int ID_PACIENTE_TUR;
        private int ID_ESPECIALIDAD_TUR;
        private DateTime FECHA_TUR;
        private TimeSpan HORA_TUR;
        private string OBSERVACION_TUR;
        private string ESTADO_TUR;
        public int GetID_TURNO_TUR()
        {
            return ID_TURNO_TUR;
        }

        public void SetID_TURNO_TUR(int value)
        {
            ID_TURNO_TUR = value;
        }

        public string GetFK_DNI_MEDICO_TUR()
        {
            return FK_DNI_MEDICO_TUR;
        }

        public void SetFK_DNI_MEDICO_TUR(string value)
        {
            FK_DNI_MEDICO_TUR = value;
        }

        public int GetID_PACIENTE_TUR()
        {
            return ID_PACIENTE_TUR;
        }

        public void SetID_PACIENTE_TUR(int value)
        {
            ID_PACIENTE_TUR = value;
        }

        public int GetID_ESPECIALIDAD_TUR()
        {
            return ID_ESPECIALIDAD_TUR;
        }

        public void SetID_ESPECIALIDAD_TUR(int value)
        {
            ID_ESPECIALIDAD_TUR = value;
        }

        public DateTime GetFECHA_TUR()
        {
            return FECHA_TUR;
        }

        public void SetFECHA_TUR(DateTime value)
        {
            FECHA_TUR = value;
        }

        public TimeSpan GetHORA_TUR()
        {
            return HORA_TUR;
        }

        public void SetHORA_TUR(TimeSpan value)
        {
            HORA_TUR = value;
        }

        public string GetOBSERVACION_TUR()
        {
            return OBSERVACION_TUR;
        }

        public void SetOBSERVACION_TUR(string value)
        {
            OBSERVACION_TUR = value;
        }

        public string GetESTADO_TUR()
        {
            return ESTADO_TUR;
        }

        public void SetESTADO_TUR(string value)
        {
            ESTADO_TUR = value;
        }
    }

}
