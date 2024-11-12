using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DaoMedicos
    {
        AccesoDatos ds = new AccesoDatos();

        public string GetNombreYApellidoMedico(string dniMedico)
        {
            string consulta = "SELECT NOMBRE_MED, APELLIDO_MED FROM Medicos WHERE FK_DNI_MED = '" + dniMedico + "'";
            DataTable tabla = ds.ObtenerTabla("Medicos", consulta);

            if (tabla.Rows.Count > 0)
            {
                string nombreMedico = tabla.Rows[0]["NOMBRE_MED"].ToString();
                string apellidoMedico = tabla.Rows[0]["APELLIDO_MED"].ToString();
                return nombreMedico + " " + apellidoMedico;
            }
            return string.Empty;
        }

        public int agregarMedico(string dni, int IDLocalidad, int IDEspecialidad, int legajo, string nombre, string apellido, char sexo,
                                string nacionalidad, string nacimiento, string direccion, string email, string telefono)
        {
            try
            {
                int filas = ds.ejecutarConsulta("INSERT INTO MEDICOS(FK_DNI_MED, FK_ID_LOCALIDAD_MED, FK_ID_ESPECIALIDAD_MED, LEGAJO_MED, " +
                                    "NOMBRE_MED, APELLIDO_MED, SEXO_MED, NACIONALIDAD_MED, NACIMIENTO_MED, DIRECCION_MED, EMAIL_MED, TELEFONO_MED) " +
                                    "SELECT '" + dni + "', " + IDLocalidad + ", " + IDEspecialidad + ", " + legajo + ", '" + nombre + "', '" +
                                    "" + apellido + "', '" + sexo + "', '" + nacionalidad + "', '" + nacimiento + "', '" + direccion + "', " +
                                    "'" + email + "', '" + telefono + "'");
                return filas;
            }
            catch
            {
                return -1;
            }
        }

        public void agregarHorario(string dia, string horaIni, string horaFin, string dni)
        {
            ds.ejecutarConsulta("INSERT INTO HORARIO_ATENCION (FK_ID_MEDICO_HDA, DIA_HDA, HORA_INICIO_HDA, HORA_FIN_HDA) " +
                "SELECT (SELECT ID_MEDICO_MED FROM MEDICOS WHERE FK_DNI_MED = '" + dni + "'), '" + dia + "', '" + horaIni + "', '" + horaFin + "'");
        }

        public DataTable getTablaEspecialidades()
        {
            DataTable tabla = ds.ObtenerTabla("ESPECIALIDADES", "SELECT ID_ESPECIALIDAD_ESP AS IDEspecialidad, NOMBRE_ESP AS Nombre FROM ESPECIALIDADES");
            return tabla;
        }
    }

}
