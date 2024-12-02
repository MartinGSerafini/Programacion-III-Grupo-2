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
    public class DaoPacientes
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaPacientes()
        {
            DataTable tabla = ds.ObtenerTabla("PACIENTES", "SELECT P.DNI_PAS, P.NOMBRE_PAS, P.APELLIDO_PAS, P.SEXO_PAS, " +
                "P.NACIONALIDAD_PAS, P.NACIMIENTO_PAS, P.DIRECCION_PAS, L.NOMBRE_LOC, PRO.NOMBRE_PRO, P.EMAIL_PAS, " +
                "P.TELEFONO_PAS, P.FK_ID_LOCALIDAD_PAS, P.FK_ID_PROVINCIA_PAS " +
                "FROM PACIENTES P INNER JOIN LOCALIDADES L ON P.FK_ID_LOCALIDAD_PAS = L.ID_LOCALIDAD_LOC " +
                "INNER JOIN PROVINCIAS PRO ON P.FK_ID_PROVINCIA_PAS = PRO.ID_PROVINCIA_PRO " +
                "WHERE P.ESTADO_PAS = 'Activo'");
            return tabla;
        }

        public DataTable getTablaPacientesFiltrada(string filtro, string dato)
        {
            string cons = "SELECT P.DNI_PAS, P.NOMBRE_PAS, P.APELLIDO_PAS, P.SEXO_PAS, " +
                           "P.NACIONALIDAD_PAS, P.NACIMIENTO_PAS, P.DIRECCION_PAS, L.NOMBRE_LOC, PRO.NOMBRE_PRO, P.EMAIL_PAS, P.TELEFONO_PAS " +
                           "FROM PACIENTES P INNER JOIN LOCALIDADES L ON P.FK_ID_LOCALIDAD_PAS = L.ID_LOCALIDAD_LOC " +
                           "INNER JOIN PROVINCIAS PRO ON P.FK_ID_PROVINCIA_PAS = PRO.ID_PROVINCIA_PRO " +
                           "WHERE " + filtro + " LIKE '%" + dato + "%' AND P.ESTADO_PAS = 'Activo'";

            return ds.ObtenerTabla("PACIENTES", cons);
        }

        public void ArmarParametrosPacientesBajaLogica(ref SqlCommand Comando, Pacientes paciente)
        {
            SqlParameter sqlParametros = new SqlParameter();
            sqlParametros = Comando.Parameters.Add("@DNIPACIENTE", SqlDbType.Char);
            sqlParametros.Value = paciente.getDNI();
        }

        public int bajaLogicaPaciente(Pacientes paciente)
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosPacientesBajaLogica(ref Comando, paciente);
            return ds.EjecutarProcedimientoAlmacenado(Comando, "spBajaLogicaPaciente");
        }

        public void ArmarParametrosPacientesModificacion(ref SqlCommand Comando, Pacientes paciente)
        {
            SqlParameter sqlParametros = new SqlParameter();
            sqlParametros = Comando.Parameters.Add("@DNIPACIENTE", SqlDbType.Char);
            sqlParametros.Value = paciente.getDNI();
            sqlParametros = Comando.Parameters.Add("@LOCALIDAD", SqlDbType.Int);
            sqlParametros.Value = paciente.getLocalidad();
            sqlParametros = Comando.Parameters.Add("@PROVINCIA", SqlDbType.Int);
            sqlParametros.Value = paciente.getProvincia();
            sqlParametros = Comando.Parameters.Add("@NOMBRE", SqlDbType.Char);
            sqlParametros.Value = paciente.getNombre();
            sqlParametros = Comando.Parameters.Add("@APELLIDO", SqlDbType.Char);
            sqlParametros.Value = paciente.getApellido();
            sqlParametros = Comando.Parameters.Add("@SEXO", SqlDbType.Char);
            sqlParametros.Value = paciente.getSexo();
            sqlParametros = Comando.Parameters.Add("@NACIONALIDAD", SqlDbType.Char);
            sqlParametros.Value = paciente.getNacionalidad();
            sqlParametros = Comando.Parameters.Add("@NACIMIENTO", SqlDbType.Date);
            sqlParametros.Value = paciente.getNacimiento();
            sqlParametros = Comando.Parameters.Add("@DIRECCION", SqlDbType.Char);
            sqlParametros.Value = paciente.getDireccion();
            sqlParametros = Comando.Parameters.Add("@EMAIL", SqlDbType.Char);
            sqlParametros.Value = paciente.getEmail();
            sqlParametros = Comando.Parameters.Add("@TELEFONO", SqlDbType.Char);
            sqlParametros.Value = paciente.getTelefono();
        }

        public int ActualizarPaciente(Pacientes paciente)
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosPacientesModificacion(ref Comando, paciente);
            return ds.EjecutarProcedimientoAlmacenado(Comando, "spModificarPaciente");
        }
        public bool ExistePacienteConDNI(string DNI)
        {
            string sql = "SELECT COUNT(*) FROM PACIENTES WHERE DNI_PAS = '" + DNI + "'";

            DataTable tabla = ds.ObtenerTabla("PACIENTES", sql);

            if (tabla.Rows.Count > 0)
            {
                return Convert.ToInt32(tabla.Rows[0][0]) > 0;
            }
            return false;
        }
        public bool InsertarPaciente(Pacientes paciente)
        {
            string sql = "INSERT INTO PACIENTES (DNI_PAS, NOMBRE_PAS, APELLIDO_PAS, SEXO_PAS, " +
                         "FK_ID_LOCALIDAD_PAS, FK_ID_PROVINCIA_PAS, NACIONALIDAD_PAS, NACIMIENTO_PAS, " +
                         "DIRECCION_PAS, EMAIL_PAS, TELEFONO_PAS, ESTADO_PAS) " +
                         "VALUES (@DNI, @Nombre, @Apellido, @Sexo, @LocalidadId, @ProvinciaId, @Nacionalidad, " +
                         "@Nacimiento, @Direccion, @Email, @Telefono, @Estado)";

            SqlCommand cmd = new SqlCommand(sql);

            cmd.Parameters.AddWithValue("@DNI", paciente.getDNI());
            cmd.Parameters.AddWithValue("@Nombre", paciente.getNombre());
            cmd.Parameters.AddWithValue("@Apellido", paciente.getApellido());
            cmd.Parameters.AddWithValue("@Sexo", paciente.getSexo());
            cmd.Parameters.AddWithValue("@LocalidadId", paciente.getLocalidad());
            cmd.Parameters.AddWithValue("@ProvinciaId", paciente.getProvincia());
            cmd.Parameters.AddWithValue("@Nacionalidad", paciente.getNacionalidad());
            SqlParameter paramNacimiento = new SqlParameter("@Nacimiento", SqlDbType.Date);
            paramNacimiento.Value = paciente.getNacimiento();
            cmd.Parameters.Add(paramNacimiento);
            cmd.Parameters.AddWithValue("@Direccion", paciente.getDireccion());
            cmd.Parameters.AddWithValue("@Email", paciente.getEmail());
            cmd.Parameters.AddWithValue("@Telefono", paciente.getTelefono());
            cmd.Parameters.AddWithValue("@Estado", paciente.getEstado());

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
        public int ObtenerIdPaciente(string dni)
        {
            string sql = "SELECT ID_PACIENTE_PAS FROM PACIENTES WHERE DNI_PAS = " + dni + " AND ESTADO_PAS = 'Activo'";

            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@dni", dni);

            DataTable tabla = ds.ObtenerTabla("PACIENTES", sql);

            if (tabla.Rows.Count > 0)
            {
                return Convert.ToInt32(tabla.Rows[0]["ID_PACIENTE_PAS"]);
            }

            return 0;
        }
    }
}
