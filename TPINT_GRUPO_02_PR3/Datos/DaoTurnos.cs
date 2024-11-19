using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DaoTurnos
    {
        AccesoDatos ds = new AccesoDatos();
        public bool agregarTurno(Turnos turno)//INSERTA EL TURNO DEJANDO "OBSERVACION" EN NULL
        {
            string sql = "INSERT INTO TURNOS(FK_ID_MEDICO_TUR, FK_ID_PACIENTE_TUR, FK_ID_ESPECIALIDAD_TUR, FECHA_TUR, HORA_TUR, ESTADO_TUR) " +
                         "SELECT @IDMEDICO, @IDPACIENTE, @IDESPECIALIDAD, @FECHA, @HORA, @ESTADO";

            SqlCommand cmd = new SqlCommand(sql);

            cmd.Parameters.AddWithValue("@IDMEDICO", turno.getIdMedico()); 
            cmd.Parameters.AddWithValue("@IDPACIENTE", turno.getIdPaciente()); 
            cmd.Parameters.AddWithValue("@IDESPECIALIDAD", turno.getEspecialidad());
            SqlParameter paramFecha = new SqlParameter("@FECHA", SqlDbType.Date);
            paramFecha.Value = turno.getFecha();
            cmd.Parameters.Add(paramFecha);
            cmd.Parameters.AddWithValue("@HORA", turno.getHora());
            cmd.Parameters.AddWithValue("@ESTADO", turno.getEstado());
            try
            {
                int filas = ds.EjecutarComando(cmd);
                return filas > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable buscarIdMedico(string dni)
        {
            DataTable tabla = ds.ObtenerTabla("MEDICO", "SELECT ID_MEDICO_MED AS IdMedico FROM MEDICOS WHERE FK_DNI_MED = '" + dni + "'");
            return tabla;
        }

        public DataTable buscarIdPaciente(string dni)
        {
            DataTable tabla = ds.ObtenerTabla("PACIENTES", "SELECT ID_PACIENTE_PAS AS IdPaciente FROM PACIENTES WHERE DNI_PAS = '" + dni + "'");
            return tabla;
        }


    }
}
