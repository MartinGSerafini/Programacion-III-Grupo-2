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
        public int AgregarUsuario(int tipo, string dni, string contra)
        {
            DaoUsuarios dao = new DaoUsuarios();
            return dao.agregarUsuario(tipo, dni, contra);
        }
        public int ActualizarContraseña(string dni, string nuevaContraseña)
        {
            DaoUsuarios dao = new DaoUsuarios();
            return dao.ActualizarContraseña(dni, nuevaContraseña);
        }
    }
}
