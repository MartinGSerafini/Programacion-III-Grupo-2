using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DaoTurnos
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaTurnos()
        {
            DataTable tabla = ds.ObtenerTabla("TURNOS", "SELECT P.DNI_PAS AS DNI_PACIENTE, P.NOMBRE_PAS + ' ' + P.APELLIDO_PAS AS NOMBRE_PACIENTE, M.NOMBRE_MED + ' ' + M.APELLIDO_MED AS NOMBRE_MEDICO, E.NOMBRE_ESP, T.FECHA_TUR, T.HORA_TUR " +
                "FROM TURNOS T INNER JOIN MEDICOS M ON M.FK_DNI_MED = T.FK_DNI_MEDICO_TUR " +
                "INNER JOIN PACIENTES P ON P.ID_PACIENTE_PAS = T.FK_ID_PACIENTE_TUR " +
                "INNER JOIN ESPECIALIDADES E ON E.ID_ESPECIALIDAD_ESP = T.FK_ID_ESPECIALIDAD_TUR " +
                "WHERE T.ESTADO_TUR = ''");
            return tabla;
        }
        public DataTable getTablaTurnosFiltrada(string filtro, string dato)
        {
            string cons = "SELECT P.DNI_PAS AS DNI_PACIENTE, P.NOMBRE_PAS + ' ' + P.APELLIDO_PAS AS NOMBRE_PACIENTE, M.NOMBRE_MED + ' ' + M.APELLIDO_MED AS NOMBRE_MEDICO, E.NOMBRE_ESP, T.FECHA_TUR, T.HORA_TUR " +
                "FROM TURNOS T INNER JOIN MEDICOS M ON M.FK_DNI_MED = T.FK_DNI_MEDICO_TUR " +
                "INNER JOIN PACIENTES P ON P.ID_PACIENTE_PAS = T.FK_ID_PACIENTE_TUR " +
                "INNER JOIN ESPECIALIDADES E ON E.ID_ESPECIALIDAD_ESP = T.FK_ID_ESPECIALIDAD_TUR " +
                "WHERE " + filtro + " LIKE '%" + dato + "%' AND T.ESTADO_TUR = ''";
            return ds.ObtenerTabla("TURNOS", cons);
        }
        public void ArmarParametrosTurnosBajaLogica(ref SqlCommand Comando, int IDTurno)
        {
            SqlParameter sqlParametros = new SqlParameter();
            sqlParametros = Comando.Parameters.Add("@IDTURNO", SqlDbType.Char);
            sqlParametros.Value = IDTurno;
        }
        public int bajaLogicaTurno(int IDTurno)
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosTurnosBajaLogica(ref Comando, IDTurno);
            return ds.EjecutarProcedimientoAlmacenado(Comando, "spBajaLogicaTurno");
        }
        public void ArmarParametrosPacientesModificacion(ref SqlCommand Comando, Turnos turno)
        {
            SqlParameter sqlParametros = new SqlParameter();
            sqlParametros = Comando.Parameters.Add("@ID_TURNO_TUR", SqlDbType.Char);
            sqlParametros.Value = turno.GetID_TURNO_TUR();
            sqlParametros = Comando.Parameters.Add("@FK_DNI_MEDICO_TUR", SqlDbType.Int);
            sqlParametros.Value = turno.GetFK_DNI_MEDICO_TUR();
            sqlParametros = Comando.Parameters.Add("@FK_ID_PACIENTE_TUR", SqlDbType.Int);
            sqlParametros.Value = turno.GetID_PACIENTE_TUR();
            sqlParametros = Comando.Parameters.Add("@FK_ID_ESPECIALIDAD_TUR", SqlDbType.Char);
            sqlParametros.Value = turno.GetID_ESPECIALIDAD_TUR();
            sqlParametros = Comando.Parameters.Add("@FECHA_TUR", SqlDbType.Char);
            sqlParametros.Value = turno.GetFECHA_TUR();
            sqlParametros = Comando.Parameters.Add("@HORA_TUR", SqlDbType.Char);
            sqlParametros.Value = turno.GetHORA_TUR();
            sqlParametros = Comando.Parameters.Add("@ESTADO_TUR", SqlDbType.Char);
            sqlParametros.Value = turno.GetESTADO_TUR();
            sqlParametros = Comando.Parameters.Add("@OBSERVACION_TUR", SqlDbType.Date);
            sqlParametros.Value = turno.GetOBSERVACION_TUR();
        }
        public int ActualizarTurno(Turnos turno)
        {
            SqlCommand Comando = new SqlCommand();
            return ds.EjecutarProcedimientoAlmacenado(Comando, "spModificarTurno");
        }
        public List<TimeSpan> ObtenerHorariosOcupados(string dniMedico, DateTime fecha)
        {
            string fechaSql = fecha.ToString("yyyy-MM-dd");

            string sql = $"SELECT HORA_TUR FROM TURNOS WHERE FK_DNI_MEDICO_TUR = '{dniMedico}' AND FECHA_TUR = '{fechaSql}'";

            DataTable tabla = ds.ObtenerTabla("TURNOS", sql);

            List<TimeSpan> horariosOcupados = new List<TimeSpan>();
            foreach (DataRow row in tabla.Rows)
            {
                TimeSpan hora = TimeSpan.Parse(row["HORA_TUR"].ToString());
                horariosOcupados.Add(hora);
            }

            return horariosOcupados;
        }
        public bool InsertarTurno(Turnos turno)
        {
            string sql = "INSERT INTO TURNOS (FK_DNI_MEDICO_TUR, FK_ID_PACIENTE_TUR, FK_ID_ESPECIALIDAD_TUR, " +
                         "FECHA_TUR, HORA_TUR, ESTADO_TUR, OBSERVACION_TUR) " +
                         "VALUES (@DNI_MEDICO, @ID_PACIENTE, @ID_ESPECIALIDAD, @FECHA, @HORA, @ESTADO, @OBSERVACION)";

            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@DNI_MEDICO", turno.GetFK_DNI_MEDICO_TUR());
            cmd.Parameters.AddWithValue("@ID_PACIENTE", turno.GetID_PACIENTE_TUR());
            cmd.Parameters.AddWithValue("@ID_ESPECIALIDAD", turno.GetID_ESPECIALIDAD_TUR());
            cmd.Parameters.AddWithValue("@FECHA", turno.GetFECHA_TUR());
            var horaParam = new SqlParameter("@HORA", SqlDbType.Time);
            horaParam.Value = turno.GetHORA_TUR();
            cmd.Parameters.Add(horaParam);
            cmd.Parameters.AddWithValue("@ESTADO", turno.GetESTADO_TUR());;
            cmd.Parameters.AddWithValue("@OBSERVACION", turno.GetOBSERVACION_TUR());
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                int filasAfectadas = accesoDatos.EjecutarComando(cmd);
                return filasAfectadas > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
