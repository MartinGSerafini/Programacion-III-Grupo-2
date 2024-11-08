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
    }

}
