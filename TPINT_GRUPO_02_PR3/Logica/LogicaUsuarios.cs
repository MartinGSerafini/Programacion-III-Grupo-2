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
        DaoUsuarios dao = new DaoUsuarios();
        public Usuarios getUsuario(string DNI)
        {
            Usuarios usu = new Usuarios();
            usu.setDNIusuario(DNI);
            return dao.getUsuario(usu);
        }
        public Boolean ExisteUsuario(Usuarios usu)
        {
            return dao.existeUsuario(usu);
        }
        public int TipoUsuario(Usuarios usu)
        {
            return dao.TipoDeUsuario(usu);
        }
        public int AgregarUsuario(int tipo, string dni, string contra)
        {
            return dao.agregarUsuario(tipo, dni, contra);
        }
        public int ActualizarContraseña(string dni, string nuevaContraseña)
        {
            return dao.ActualizarContraseña(dni, nuevaContraseña);
        }
        public bool VerificarExistenciaDeDni(string dni)
        {
            return dao.ExisteDni(dni);
        }
    }
}
