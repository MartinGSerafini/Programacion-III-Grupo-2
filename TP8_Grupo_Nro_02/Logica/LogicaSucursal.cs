using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Logica
{
    public class LogicaSucursal
    {
        public DataTable getTabla()
        {
            DaoSucursal dao = new DaoSucursal();
            return dao.getTablaSucursales();
        }

        public int ConexionSQL(string consulta)
        {
            AccesoDatos ad = new AccesoDatos();
            return ad.ejecutarConsulta(consulta);
        }

        public Sucursal get(int id)
        {
            DaoSucursal dao = new DaoSucursal();
            Sucursal sucu = new Sucursal();
            sucu.setId_Sucursal(id);
            return dao.getSucursal(sucu);
        }

        public bool eliminarSucursal(int id)
        {
            DaoSucursal dao = new DaoSucursal();
            Sucursal sucu = new Sucursal();
            sucu.setId_Sucursal(id);
            int op = dao.eliminarSucursal(sucu);
            if (op == 1)
                return true;
            else
                return false;
        }

        public bool agregarSucursal(String nombre)
        {
            int cantFilas = 0;

            Sucursal sucu = new Sucursal();
            sucu.setNombreSucursal(nombre);

            DaoSucursal dao = new DaoSucursal();
            if (dao.existeSucursal(sucu) == false)
            {
                cantFilas = dao.agregarSucursal(sucu);
            }

            if (cantFilas == 1)
                return true;
            else
                return false;
        }
    }
}
