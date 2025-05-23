﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            Session.Remove("NombreUsuario");
        }

        protected void BtnIniciar_Sesion_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.setDNIusuario(TxbUsuario.Text);//
            LogicaUsuarios Logica = new LogicaUsuarios();
            if (Logica.ExisteUsuario(usuario))
            {
                Usuarios usuario2 = new Usuarios();
                usuario2 = Logica.getUsuario(usuario.getDNIusuario());
                if (TxbContra.Text != usuario2.getContraseniaUsuario())
                {
                    string script = "alert('Usuario o Contraseña incorrecta.');";
                    ClientScript.RegisterStartupScript(this.GetType(), "mensajeError", script, true);
                    TxbUsuario.Text = "";
                    TxbContra.Text = "";
                }
                else
                {
                if (Logica.TipoUsuario(usuario) == 1)
                    {
                        LogicaAdministradores logicaAdministrador = new LogicaAdministradores();
                        string NombreUsuario = logicaAdministrador.ObtenerNombreYApellidoAdministrador(usuario.getDNIusuario());
                        TxbUsuario.Text = "";
                        TxbContra.Text = "";
                        Session["NombreUsuario"] = NombreUsuario;
                        Response.Redirect("/FormsAdmin/Form_Menu_Administrador.aspx");

                    }
                    else if (Logica.TipoUsuario(usuario) == 2)
                    {
                        LogicaMedicos logicaMedico = new LogicaMedicos();
                        string NombreUsuario = logicaMedico.ObtenerNombreYApellidoMedico(usuario.getDNIusuario());
                        TxbUsuario.Text = "";
                        TxbContra.Text = "";
                        Session["NombreUsuario"] = NombreUsuario;
                        Response.Redirect("/FormsMedico/Form_Medico_Listado_Turnos.aspx");
                    }
                }
            }
            else
            {
                string script = "alert('Usuario o Contraseña incorrecta.');";
                ClientScript.RegisterStartupScript(this.GetType(), "mensajeError", script, true);
                TxbUsuario.Text = "";
                TxbContra.Text = "";
            }
        }
    }
}