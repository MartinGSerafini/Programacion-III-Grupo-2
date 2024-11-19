<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form_Menu_Administrador.aspx.cs" Inherits="TPINT_GRUPO_02_PR3.Formularios.Form_Menu_Administrador" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Menú Administrador</title>
    <style type="text/css">
    /* Estilos generales */
    body {
        background-color: #4C1766;
        display: flex;
        align-items: center;
        justify-content: center;
        height: 100vh;
        margin: 0;
        font-family: Arial, sans-serif;
        color: #FFFFFF;
        flex-wrap: wrap;
    }

    /* Contenedor principal */
    .wrapper {
        display: inline-block;
        text-align: center;
    }

    /* Encabezado */
    .header, .container {
        width: auto; /* Ajusta el ancho según el contenido */
        max-width: 100vw; /* Limita el ancho al 90% de la pantalla */
        box-shadow: 0px 4px 10px rgba(0, 0, 0, 0.3);
        border-radius: 15px;
    }

    .header {
        background-color: #3A104D;
        padding: 20px;
        display: flex;
        justify-content: space-between;
        align-items: center;
        border-top-left-radius: 15px;
        border-top-right-radius: 15px;
    }

    /* Logo y menú */
    .menu-left {
        display: flex;
        align-items: center;
        gap: 15px;
    }

    .menu-left img {
        width: 50px;
        height: auto;
    }

    .menu-dropdown {
        position: relative;
        display: inline-block;
    }

    .menu-dropdown button {
        background: none;
        border: none;
        font-size: 24px;
        color: #FFFFFF;
        cursor: pointer;
    }

    .menu-dropdown ul {
        display: none;
        position: absolute;
        top: 100%;
        left: 0;
        background-color: #A472B4;
        list-style: none;
        padding: 0;
        margin: 0;
        border-radius: 10px;
        box-shadow: 0px 4px 10px rgba(0, 0, 0, 0.3);
        z-index: 100;
    }

    .menu-dropdown:hover ul {
        display: block;
    }

    .menu-dropdown ul li {
        padding: 5px 0;
        text-align: center;
    }

    .menu-dropdown ul li a {
         color: #4B0082;
        text-decoration: none;
        transition: color 0.3s, background-color 0.3s;
        display: block; 
        padding: 8px 12px; 
    }

    .menu-dropdown ul li a:hover {
        color: #FFFFFF;
        background-color: #6C2C91; 
        border-radius: 5px;
    }

    /* Redes sociales y usuario */
    .user-info {
        display: flex;
        align-items: center;
        gap: 15px;
    }

    .social-icon {
        font-size: 18px;
        color: #FFFFFF;
        text-decoration: none;
        transition: color 0.3s;
    }

    .social-icon:hover {
        color: #A472B4;
    }

    .username {
        font-size: 16px;
    }

    /* Contenedor secundario */
    .container {
        background-color: #6C2C91;
        padding: 40px;
        border-radius: 15px;
        width: 80%;
        max-width: 400px;
        text-align: center;
        box-shadow: 0px 4px 10px rgba(0, 0, 0, 0.3);
    }

    /* Botones de menú */
    .button-container {
        display: grid;
        grid-template-columns: 1fr 1fr;
        gap: 20px;
        margin-top: 20px;
    }

    .button-container a {
        display: flex;
        justify-content: center;
        align-items: center;
        padding: 15px;
        font-size: 20px;
        font-weight: bold;
        color: #FFFFFF;
        text-decoration: none;
        border: 2px solid #FFFFFF;
        border-radius: 10px;
        background-color: transparent;
        transition: background-color 0.3s ease;
    }

    .button-container a:hover {
        background-color: #6C2C91;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapper">
        <div class="header">
            <div class="menu-left">
                <img src="../Imagenes/Logo_MS.png" alt="Logo" />
                <div class="menu-dropdown">
                    <button>☰</button>
                    <ul>
                        <li><a href="../FormsAdmin/Form_Admin_Listado_Pacientes.aspx">PACIENTES</a></li>
                        <li><a href="../FormsAdmin/Form_Admin_Listado_Turnos.aspx">TURNOS</a></li>
                        <li><a href="../FormsAdmin/Form_Admin_Listado_Medicos.aspx">MEDICOS</a></li>
                        <li><a href="#">REPORTES</a></li>
                        <li><a href="<%= ResolveUrl("~/FormsLogins/Form_Login.aspx") %>">CERRAR SESIÓN</a></li>
                    </ul>
                </div>
            </div>
            <div class="user-info">
                <asp:HyperLink ID="HLInstagram" runat="server" NavigateUrl="https://www.instagram.com/medical_studio_2024/" Target="_blank">
                    <img src="https://upload.wikimedia.org/wikipedia/commons/a/a5/Instagram_icon.png" alt="Instagram" style="width: 30px; height: 30px;"/>
                </asp:HyperLink>
                <asp:HyperLink ID="HLFacebook" runat="server" NavigateUrl="https://www.facebook.com/profile.php?id=61567773056854" Target="_blank">
                    <img src="https://upload.wikimedia.org/wikipedia/commons/5/51/Facebook_f_logo_%282019%29.svg" alt="Facebook" style="width: 30px; height: 30px;"/>
                </asp:HyperLink>
                <asp:HyperLink ID="HLTwitter" runat="server" NavigateUrl="https://x.com/Guillermoseraf3" Target="_blank">
                    <img src="https://upload.wikimedia.org/wikipedia/commons/6/6f/Logo_of_Twitter.svg" alt="Twitter" style="width: 30px; height: 30px;"/>
                </asp:HyperLink>
                <asp:Label ID="LblUsuario" runat="server" CssClass="username"></asp:Label>
            </div>
        </div>
        <div class="container">
            <h1>Menu inicio</h1>
            <h2>Desarrolladores</h2>
            <p>&nbsp;</p>

            <div class="button-container">
                <a href="../FormsAdmin/Form_Admin_Listado_Pacientes.aspx">PACIENTES</a>
                <a href="../FormsAdmin/Form_Admin_Listado_Turnos.aspx">TURNOS</a>
                <a href="../FormsAdmin/Form_Admin_Listado_Medicos.aspx">MEDICOS</a>
                <a href="#">REPORTES</a>
            </div>
        </div>
       </div>
    </form>
</body>
</html>
