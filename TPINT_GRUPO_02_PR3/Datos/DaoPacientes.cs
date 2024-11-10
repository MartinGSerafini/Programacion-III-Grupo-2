using System;
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
                "P.TELEFONO_PAS, P.FK_ID_LOCALIDAD_PAS, P.FK_ID_PROVINCIA_PAS " +  // Agregar las columnas FK_ID_LOCALIDAD_PAS y FK_ID_PROVINCIA_PAS
                "FROM PACIENTES P INNER JOIN LOCALIDADES L ON P.FK_ID_LOCALIDAD_PAS = L.ID_LOCALIDAD_LOC " +
                "INNER JOIN PROVINCIAS PRO ON P.FK_ID_PROVINCIA_PAS = PRO.ID_PROVINCIA_PRO " +
                "WHERE P.ESTADO_PAS = 'Activo'");
            return tabla;
        }

        public DataTable getTablaPacientesFiltrada(string filtro, string dato)
        {
            DataTable tabla = ds.ObtenerTabla("PACIENTES", "SELECT P.DNI_PAS, P.NOMBRE_PAS, P.APELLIDO_PAS, P.SEXO_PAS, " +
                "P.NACIONALIDAD_PAS, P.NACIMIENTO_PAS, P.DIRECCION_PAS, L.NOMBRE_LOC, PRO.NOMBRE_PRO, P.EMAIL_PAS, P.TELEFONO_PAS " +
                "FROM PACIENTES P INNER JOIN LOCALIDADES L ON P.FK_ID_LOCALIDAD_PAS = L.ID_LOCALIDAD_LOC " +
                "INNER JOIN PROVINCIAS PRO ON P.FK_ID_PROVINCIA_PAS = PRO.ID_PROVINCIA_PRO " +
                "WHERE " + filtro + " = '" + dato + "' AND P.ESTADO_PAS = 'Activo'");
            return tabla;
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
            sqlParametros = Comando.Parameters.Add("@LOCALIDAD", SqlDbType.Char);
            sqlParametros.Value = paciente.getLocalidad();
            sqlParametros = Comando.Parameters.Add("@PROVINCIA", SqlDbType.Char);
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

        public int ModificaiónPaciente(Pacientes paciente)
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosPacientesModificacion(ref Comando, paciente);
            return ds.EjecutarProcedimientoAlmacenado(Comando, "spModificarPaciente");
        }

        public Pacientes getPaciente(Pacientes paciente)
        {
            DataTable tabla = ds.ObtenerTabla("PACIENTES", "SELECT * FROM PACIENTES WHERE DNI_PAS = " + paciente.getDNI());
            paciente.setId_Paciente(Convert.ToInt32(tabla.Rows[0][0].ToString()));
            paciente.setLocalidad(Convert.ToInt32(tabla.Rows[0][1].ToString()));
            paciente.setProvincia(Convert.ToInt32(tabla.Rows[0][2].ToString()));
            paciente.setDNI(tabla.Rows[0][3].ToString());
            paciente.setNombre(tabla.Rows[0][4].ToString());
            paciente.setApellido(tabla.Rows[0][5].ToString());
            paciente.setSexo(tabla.Rows[0][6].ToString());
            paciente.setNacionalidad(tabla.Rows[0][7].ToString());
            paciente.setNacimiento(Convert.ToDateTime(tabla.Rows[0][8].ToString()));
            paciente.setDireccion(tabla.Rows[0][9].ToString());
            paciente.setEmail(tabla.Rows[0][7].ToString());
            paciente.setTelefono(tabla.Rows[0][7].ToString());
            paciente.setEstado(tabla.Rows[0][7].ToString());

            return paciente;
        }

        
    }
}
