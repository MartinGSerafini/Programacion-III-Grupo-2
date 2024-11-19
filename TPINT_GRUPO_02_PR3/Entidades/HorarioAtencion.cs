using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class HorarioAtencion
    {
        private int ID_HORARIO_HDA;
        private int FK_DNI_MEDICO_HDA;
        private DateTime DIA_HDA;
        private TimeSpan HORA_INICIO_HDA;
        private TimeSpan HORA_FINAL_HDA;
        public HorarioAtencion() { }

        public int getID_HORARIO_HDA() { return ID_HORARIO_HDA; }
        public void setID_HORARIO_HDA(int ID) { ID_HORARIO_HDA = ID; }
        public int getFK_DNI_MEDICO_HDA() { return FK_DNI_MEDICO_HDA; }
        public void setFK_DNI_MEDICO_HDA(int ID) { FK_DNI_MEDICO_HDA = ID; }
        public DateTime getDIA_HDA() { return DIA_HDA; }
        public void setDIA_HDA(DateTime dia) { DIA_HDA = dia; }
        public TimeSpan getHORA_INICIO_HDA() { return HORA_INICIO_HDA; }
        public void setHORA_INICIO_HDA(TimeSpan horainicio) { HORA_INICIO_HDA = horainicio; }
        public TimeSpan getHORA_FINAL_HDA() { return HORA_FINAL_HDA; }
        public void setHORA_FINAL_HDA(TimeSpan horafinal) { HORA_FINAL_HDA = horafinal; }
    }
}
