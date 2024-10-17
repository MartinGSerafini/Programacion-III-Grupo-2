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
    public class DaoProvincia
    {
        AccesoDatos ds = new AccesoDatos();

        public Provincia getProvincia(Provincia prov)
        {
            DataTable tabla = ds.ObtenerTabla("Provincia", "SELECT * FROM Provincia WHERE Id_Provincia = " + prov.getId_Provincia());
            prov.setId_Provincia(Convert.ToInt32(tabla.Rows[0][0].ToString()));
            prov.setDescripcionProvincia(tabla.Rows[0][1].ToString());
            return prov;
        }

        public DataTable getTablaProvincia()
        {
            DataTable tabla = ds.ObtenerTabla("Provincia", "SELECT * FROM Provincia");
            return tabla;
        }
    }
}
