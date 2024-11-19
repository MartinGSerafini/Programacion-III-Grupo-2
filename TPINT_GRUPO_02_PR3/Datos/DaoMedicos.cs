using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

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
        public bool agregarMedico(Medico medico)
        {
            string sql = "INSERT INTO MEDICOS(FK_DNI_MED, FK_ID_LOCALIDAD_MED, FK_ID_PROVINCIA_MED, FK_ID_ESPECIALIDAD_MED, " +
                         "LEGAJO_MED, NOMBRE_MED, APELLIDO_MED, SEXO_MED, NACIONALIDAD_MED, NACIMIENTO_MED, DIRECCION_MED, EMAIL_MED, " +
                         "TELEFONO_MED, ESTADO_MED) " +
                         "SELECT @DNI, @LocalidadId, @ProvinciaId, @EpecialidadId, @Legajo, @Nombre, @Apellido, @Sexo, @Nacionalidad, " +
                         "@Nacimiento, @Direccion, @Email, @Telefono, @Estado";
            SqlCommand cmd = new SqlCommand(sql);

            cmd.Parameters.AddWithValue("@Legajo", medico.getLegajo());
            cmd.Parameters.AddWithValue("@DNI", medico.getDni());
            cmd.Parameters.AddWithValue("@Nombre", medico.getNombre());
            cmd.Parameters.AddWithValue("@Apellido", medico.getApellido());
            cmd.Parameters.AddWithValue("@Sexo", medico.getSexo());
            cmd.Parameters.AddWithValue("@LocalidadId", medico.getLocalidad());
            cmd.Parameters.AddWithValue("@ProvinciaId", medico.getProvincia());
            cmd.Parameters.AddWithValue("@Nacionalidad", medico.getNacionalidad());
            SqlParameter paramNacimiento = new SqlParameter("@Nacimiento", SqlDbType.Date);
            paramNacimiento.Value = medico.getNacimiento();
            cmd.Parameters.Add(paramNacimiento);
            cmd.Parameters.AddWithValue("@Direccion", medico.getDireccion());
            cmd.Parameters.AddWithValue("@Email", medico.getEmail());
            cmd.Parameters.AddWithValue("@Telefono", medico.getTelefono());
            cmd.Parameters.AddWithValue("@EpecialidadId", medico.getEspecialidad());
            cmd.Parameters.AddWithValue("@Estado", medico.getEstado());
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
        public DataTable getTablaMedicos()
        {
            DataTable tabla = ds.ObtenerTabla("MEDICOS", "SELECT M.LEGAJO_MED, M.FK_DNI_MED, M.NOMBRE_MED, M.APELLIDO_MED, M.SEXO_MED, " +
                                            "M.NACIONALIDAD_MED, M.NACIMIENTO_MED, M.DIRECCION_MED, L.NOMBRE_LOC, PRO.NOMBRE_PRO, EMAIL_MED, " +
                                            "TELEFONO_MED, E.NOMBRE_ESP, H.DIA_HDA, M.FK_ID_PROVINCIA_MED, M.FK_ID_LOCALIDAD_MED, E.NOMBRE_ESP, M.FK_ID_ESPECIALIDAD_MED, " +
                                            "CAST(H.HORA_INICIO_HDA AS CHAR(5)) + ' - ' + CAST(H.HORA_FIN_HDA AS CHAR(5)) AS Horarios " +
                                            "FROM MEDICOS M INNER JOIN LOCALIDADES L ON M.FK_ID_LOCALIDAD_MED = L.ID_LOCALIDAD_LOC " +
                                            "INNER JOIN PROVINCIAS PRO ON M.FK_ID_PROVINCIA_MED = PRO.ID_PROVINCIA_PRO " +
                                            "INNER JOIN ESPECIALIDADES E ON M.FK_ID_ESPECIALIDAD_MED = E.ID_ESPECIALIDAD_ESP " +
                                            "INNER JOIN HORARIO_ATENCION H ON M.FK_DNI_MED = H.FK_DNI_MEDICO_HDA " +
                                            "WHERE M.ESTADO_MED = 'Activo'");
            return tabla;
        }
        public DataTable getTablaMedicosFiltrada(string dato, string filtro)
        {
            DataTable tabla = ds.ObtenerTabla("MEDICOS", "SELECT M.LEGAJO_MED, M.FK_DNI_MED, M.NOMBRE_MED, M.APELLIDO_MED, M.SEXO_MED, " +
                                            "M.NACIONALIDAD_MED, M.NACIMIENTO_MED, M.DIRECCION_MED, L.NOMBRE_LOC, PRO.NOMBRE_PRO, M.EMAIL_MED, " +
                                            "M.TELEFONO_MED, E.NOMBRE_ESP, H.DIA_HDA, M.FK_ID_PROVINCIA_MED, M.FK_ID_LOCALIDAD_MED, E.NOMBRE_ESP, M.FK_ID_ESPECIALIDAD_MED, " +
                                            "CAST(H.HORA_INICIO_HDA AS CHAR(5)) + ' - ' + CAST(H.HORA_FIN_HDA AS CHAR(5)) AS Horarios " +
                                            "FROM MEDICOS M INNER JOIN LOCALIDADES L ON M.FK_ID_LOCALIDAD_MED = L.ID_LOCALIDAD_LOC " +
                                            "INNER JOIN PROVINCIAS PRO ON M.FK_ID_PROVINCIA_MED = PRO.ID_PROVINCIA_PRO " +
                                            "INNER JOIN ESPECIALIDADES E ON M.FK_ID_ESPECIALIDAD_MED = E.ID_ESPECIALIDAD_ESP " +
                                            "INNER JOIN HORARIO_ATENCION H ON M.FK_DNI_MED = H.FK_DNI_MEDICO_HDA " +
                                            "WHERE " + filtro + " LIKE '%" + dato + "%' AND M.ESTADO_MED = 'Activo'");
            return tabla;
        }
        public DataTable GetMedicosPorEspecialidad(int idEspecialidad)
        {
            string query = "SELECT FK_DNI_MED, NOMBRE_MED + ' ' + APELLIDO_MED AS NOMBRE_COMPLETO FROM Medicos WHERE FK_ID_ESPECIALIDAD_MED = " + idEspecialidad + " AND ESTADO_MED = 'Activo'";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IdEspecialidad", idEspecialidad)
            };
            return ds.ObtenerTabla("Medicos", query);
        }
        public bool ExisteMedico(string columna, string dato)
        {
            string sql = "SELECT COUNT(*) FROM MEDICOS WHERE'" + columna + "' = '" + dato + "'";

            DataTable tabla = ds.ObtenerTabla("MEDICOS", sql);

            if (tabla.Rows.Count > 0)
            {
                return Convert.ToInt32(tabla.Rows[0][0]) > 0;
            }
            return false;
        }
        public void ArmarParametrosMedicosBajaLogica(ref SqlCommand Comando, Medico medico)
        {
            SqlParameter sqlParametros = new SqlParameter();
            sqlParametros = Comando.Parameters.Add("@DNIMEDICO", SqlDbType.Char);
            sqlParametros.Value = medico.getDni();
        }
        public void ArmarParametrosMedicosModificacion(ref SqlCommand Comando, Medico medico)
        {
            SqlParameter sqlParametros = new SqlParameter();
            sqlParametros = Comando.Parameters.Add("@DNIMEDICO", SqlDbType.Char);
            sqlParametros.Value = medico.getDni();
            sqlParametros = Comando.Parameters.Add("@LOCALIDAD", SqlDbType.Int);
            sqlParametros.Value = medico.getLocalidad();
            sqlParametros = Comando.Parameters.Add("@PROVINCIA", SqlDbType.Int);
            sqlParametros.Value = medico.getProvincia();
            sqlParametros = Comando.Parameters.Add("@ESPECIALIDAD", SqlDbType.Int);
            sqlParametros.Value = medico.getEspecialidad();
            sqlParametros = Comando.Parameters.Add("@NOMBRE", SqlDbType.Char);
            sqlParametros.Value = medico.getNombre();
            sqlParametros = Comando.Parameters.Add("@APELLIDO", SqlDbType.Char);
            sqlParametros.Value = medico.getApellido();
            sqlParametros = Comando.Parameters.Add("@SEXO", SqlDbType.Char);
            sqlParametros.Value = medico.getSexo();
            sqlParametros = Comando.Parameters.Add("@NACIONALIDAD", SqlDbType.Char);
            sqlParametros.Value = medico.getNacionalidad();
            sqlParametros = Comando.Parameters.Add("@NACIMIENTO", SqlDbType.Date);
            sqlParametros.Value = medico.getNacimiento();
            sqlParametros = Comando.Parameters.Add("@DIRECCION", SqlDbType.Char);
            sqlParametros.Value = medico.getDireccion();
            sqlParametros = Comando.Parameters.Add("@EMAIL", SqlDbType.Char);
            sqlParametros.Value = medico.getEmail();
            sqlParametros = Comando.Parameters.Add("@TELEFONO", SqlDbType.Char);
            sqlParametros.Value = medico.getTelefono();
            sqlParametros = Comando.Parameters.Add("@DIAS", SqlDbType.Char);
            sqlParametros.Value = medico.getDias();
            sqlParametros = Comando.Parameters.Add("@HORARIO", SqlDbType.Char);
            sqlParametros.Value = medico.getHorario();
        }
        public int ActualizarMedico(Medico medico)
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosMedicosModificacion(ref Comando, medico);
            return ds.EjecutarProcedimientoAlmacenado(Comando, "spModificarMedico");
        }
        public int bajaLogicaMedico(Medico medico)
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosMedicosBajaLogica(ref Comando, medico);
            return ds.EjecutarProcedimientoAlmacenado(Comando, "spBajaLogicaMedico");
        }
    }
}