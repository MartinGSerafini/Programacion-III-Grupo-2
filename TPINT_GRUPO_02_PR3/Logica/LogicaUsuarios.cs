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
    public class LogicaUsuarios
    {
        public Usuarios getUsuario(string DNI)
        {
            DaoUsuarios dao = new DaoUsuarios();
            Usuarios usu = new Usuarios();
            usu.setDNIusuario(DNI);
            return dao.getUsuario(usu);
        }

        public Boolean ExisteUsuario(Usuarios usu)
        {
            DaoUsuarios dao = new DaoUsuarios();
            return dao.existeUsuario(usu);
        }

        public int TipoUsuario(Usuarios usu)
        {
            DaoUsuarios dao = new DaoUsuarios();
            return dao.TipoDeUsuario(usu);
        }
    }
}
