using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Logica;

namespace TPINT_GRUPO_02_PR3.Formularios
{
    public partial class Form_Login_Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void BtnIniciar_Sesion_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.setDNIusuario(TxbUsuario.Text);
            LogicaUsuarios Logica = new LogicaUsuarios();
            if (Logica.ExisteUsuario(usuario))
            {
                Usuarios usuario2 = new Usuarios();
                usuario2 = Logica.getUsuario(usuario.getDNIusuario());
                if (TxbContra.Text != usuario2.getContraseniaUsuario())
                {
                    lblError.Text = "Contraseña incorrecta";
                }
                else
                {
                    //Verificar que tipo de usuraio es para poder redirigirlo
                }
            }
            else
            {
                lblError.Text = "Usuario no encontrado";
            }
            
        }
    }
}