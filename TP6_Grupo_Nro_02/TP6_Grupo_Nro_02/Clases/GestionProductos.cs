using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_Grupo_Nro_02
{
    public class GestionProductos
    {
        private int i_idproducto;
        private string s_nombreproducto;
        private string s_cantidadxunidad;
        private decimal d_preciounidad;

        public GestionProductos()
        {
        }

        private DataTable ObtenerTabla(string Nombre, String Sql)
        {
            DataSet ds = new DataSet();
            ConexionSQL datos = new ConexionSQL();
            SqlDataAdapter adp = datos.ObtenerAdaptador(Sql);
            adp.Fill(ds, Nombre);
            return ds.Tables[Nombre];
        }

        public DataTable ObtenerTodosLosProductos()
        {
            return ObtenerTabla("Productos", "select * from Productos");
        }

        private void ArmarParametrosProductosEliminar(ref SqlCommand cmd, Producto producto)
        {
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter = cmd.Parameters.Add("@IDPRODUCTO", SqlDbType.Int);
            sqlParameter.Value = producto.idproducto;
        }

        private void ArmarParametrosProductos(ref SqlCommand cmd, Producto producto)
        {
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter = cmd.Parameters.Add("@IDPRODUCTO", SqlDbType.Int);
            sqlParameter.Value = producto.idproducto;
            sqlParameter = cmd.Parameters.Add("@NOMBREPRODUCTO", SqlDbType.NVarChar, 40);
            sqlParameter.Value = producto.nombreproducto;
            sqlParameter = cmd.Parameters.Add("@CANTIDADPORUNIDAD", SqlDbType.NVarChar, 20);
            sqlParameter.Value = producto.cantidadxunidad;
            sqlParameter = cmd.Parameters.Add("@PRECIOUNIDAD", SqlDbType.Money);
            sqlParameter.Value = producto.preciounidad;
        }

        public bool ActualizarProducto(Producto producto)
        {
            SqlCommand comando  = new SqlCommand();
            ArmarParametrosProductos(ref comando, producto);
            ConexionSQL con = new ConexionSQL();
            int FilasInsertadas = con.EjecutarProcedimientoAlmacenado(comando, "spActualizarProducto");
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }

        public bool EliminarProducto(Producto producto)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosProductosEliminar(ref comando, producto);
            ConexionSQL con = new ConexionSQL();
            int FilasInsertadas = con.EjecutarProcedimientoAlmacenado(comando, "spEliminarProducto");
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }
    }
}