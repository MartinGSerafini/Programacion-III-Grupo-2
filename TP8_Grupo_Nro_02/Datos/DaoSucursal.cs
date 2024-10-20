using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DaoSucursal
    {
        AccesoDatos ds = new AccesoDatos();

        public Sucursal getSucursal(Sucursal sucursal)
        {
            DataTable tabla = ds.ObtenerTabla("Sucursal", "SELECT * FROM Sucursal WHERE Id_Sucursal =" + sucursal.getId_Sucursal());
            sucursal.setNombreSucursal(tabla.Rows[0][0].ToString());
            sucursal.setDescripcionSucursal(tabla.Rows[0][1].ToString());
            sucursal.setId_HorarioSucursal(Convert.ToInt32(tabla.Rows[0][2].ToString()));
            sucursal.setId_ProvinciaSucursal(Convert.ToInt32(tabla.Rows[0][3].ToString()));
            sucursal.setDireccionSucursal(tabla.Rows[0][4].ToString());
            return sucursal;
        }

        public Boolean existeSucursal(Sucursal sucu)
        {
            string consulta = "SELECT * FROM Sucursal WHERE Id_Sucursal = '" + sucu.getId_Sucursal();
            return ds.existe(consulta);
        }

        public DataTable getTablaSucursales()
        {
            DataTable tabla = ds.ObtenerTabla("Sucursal", "SELECT Id_Sucursal, NombreSucursal AS Nombre, " +
                "DescripcionSucursal AS Descripción, Provincia.DescripcionProvincia AS Provincia, " +
                "DireccionSucursal AS Dirección FROM Sucursal INNER JOIN Provincia ON Sucursal.Id_ProvinciaSucursal = Provincia.Id_Provincia");
            return tabla;
        }

        public int agregarSucursal(Sucursal sucu)
        {
            sucu.setId_Sucursal(ds.ObtenerMaximo("SELECT max(Id_Sucursal) FROM Sucursales") + 1);
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSucursalAgregar(ref comando, sucu);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAgregarsucursal");
        }

        public int eliminarSucursal(Sucursal sucu)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSucursalEliminar(ref comando, sucu);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarSucursal");
        }

        private void ArmarParametrosSucursalEliminar(ref SqlCommand comando, Sucursal sucu)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDSUCURSAL", SqlDbType.Int);
            SqlParametros.Value = sucu.getId_Sucursal();
        }

        private void ArmarParametrosSucursalAgregar(ref SqlCommand comando, Sucursal sucu)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDSUCURSAL", SqlDbType.Int);
            SqlParametros.Value = sucu.getId_Sucursal();
            SqlParametros = comando.Parameters.Add("@NOMBRESUCURSAL", SqlDbType.VarChar);
            SqlParametros.Value = sucu.getNombreSucursal();
        }

        public Boolean tablaVacia(DataTable tabla)
        {
            string consulta = "SELECT COUNT(*) FROM Sucursal";
            int max = ds.ObtenerMaximo(consulta);
            if (max == 0)
            {
                return false;
            }
            return true;
        }
    }
}
