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
    public class Producto
    {
        private int i_idproducto;
        private string s_nombreproducto;
        private string s_cantidadxunidad;
        private decimal d_preciounidad;
       
        public Producto()
        {
        }

        public Producto(int i_idproducto, string s_nombreproducto, string s_cantidadxunidad, decimal d_preciounidad) {
            this.i_idproducto = i_idproducto;
            this.s_nombreproducto = s_nombreproducto;
            this.s_cantidadxunidad = s_cantidadxunidad;
            this.d_preciounidad = d_preciounidad;
        }

        public int idproducto
        {
            get {return i_idproducto; }
            set {i_idproducto=value; }
        }
        public string nombreproducto
        {
            get { return s_nombreproducto; }
            set { s_nombreproducto=value; }
        }

        public string cantidadxunidad
        {
            get { return s_cantidadxunidad; }
            set { s_cantidadxunidad = value; }
        }

        public decimal preciounidad
        {
            get { return d_preciounidad; }
            set { d_preciounidad = value; }
        }
    }
}