﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form_Admin_Agregar_Turno.aspx.cs" Inherits="TPINT_GRUPO_02_PR3.FormsAdmin.Form_Admin_Agregar_Turno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
            width: 100%; /* Asegura que tanto el header como el container ocupen el 100% del ancho disponible */
            max-width: 100vw; /* Limita el ancho al 100% de la pantalla */
            box-shadow: 0px 4px 10px rgba(0, 0, 0, 0.3);
            border-radius: 15px;
        }

        .header {
            width: 106%;
            background-color: #3A104D;
            padding: 20px;
            display: flex;
            justify-content: space-between;
            align-items: center;
            border-top-left-radius: 15px;
            border-top-right-radius: 15px;
        }

        /* Contenedor secundario */
        .container {
            background-color: #6C2C91;
            padding: 40px;
            border-radius: 15px;
            width: 100%; /* Igual al ancho del header */
            max-width: 100vw; /* Se asegura de no exceder el 100% de la ventana */
            text-align: center;
            box-shadow: 0px 4px 10px rgba(0, 0, 0, 0.3);
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
        .btn-search {
            background-color: #7e57c2;
            color: #ffffff;
            padding: 8px 12px;
            border: none;
            border-radius: 4px;
            font-weight: bold;
            font-size: 15px;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

        .btn-search:hover {
            background-color: #5e35b1;
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
                            <li><a href="../FormsAdmin/Form_Admin_Reportes.aspx">REPORTES</a></li>
                            <li><a href="<%= ResolveUrl("~/FormsLogins/Form_Login.aspx") %>">CERRAR SESIÓN</a></li>
                        </ul>
                    </div>
                </div>
                <div class="admin-links">
                    <asp:HyperLink ID="hlAgregarPaciente" runat="server" NavigateUrl="~/FormsAdmin/Form_Admin_Agregar_Turno.aspx" CssClass="btn-search">AGREGAR TURNO</asp:HyperLink>
                    <asp:HyperLink ID="hlListadoPacientes" runat="server" NavigateUrl="~/FormsAdmin/Form_Admin_Listado_Turnos.aspx" CssClass="btn-search">LISTAR TURNOS</asp:HyperLink>
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
        <table align="center">
            <tr>
                <td style="font-weight: bold;font-size: 40px" class="auto-style8">Carga de Turnos<br />
                    <br/>
                </td>
            </tr>
        </table>
        <table align="center" class="auto-style10">
            <tr>
                <td class="auto-style12" style="width: 50%;">DNI de Paciente: </td>
                <td class="auto-style9" style="width: 50%;">
                    <asp:TextBox ID="txtDNI" runat="server" Height="18px" Width="215px" MaxLength="8" ValidationGroup="VG1"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="validator">
                    <asp:RequiredFieldValidator ID="RfvDNI" runat="server" ControlToValidate="txtDNI" CssClass="validator-message" ValidationGroup="VG1" ForeColor="#FFC2C2" Display="Dynamic" Text="Ingrese un DNI"  />
                    &nbsp;<asp:RegularExpressionValidator ID="RevDni" runat="server" ControlToValidate="txtDNI" CssClass="validator-message" ValidationExpression="^\d{8}$" ValidationGroup="VG1" ForeColor="#FFC2C2" Display="Dynamic" Text="Debe ingresar 8 Números" />
                </td>
            </tr>

            <tr>
                <td class="auto-style12" style="width: 50%;">Especialidad: </td>
                <td class="auto-style9" style="width: 50%;">
                    <asp:DropDownList ID="ddlespecialidad" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlespecialidad_SelectedIndexChanged" ValidationGroup="VG1" Width="221px">
                        <asp:ListItem Value="-1">--Seleccione una especialidad--</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="validator">
                    <asp:RequiredFieldValidator ID="RfvEspecialidad" runat="server" ControlToValidate="ddlespecialidad" CssClass="validator-message" InitialValue="-1" ValidationGroup="VG1" ForeColor="#FFC2C2" Display="Dynamic">Seleccione una especialidad</asp:RequiredFieldValidator>
                    <br />
                </td>
            </tr>

            <tr>
                <td class="auto-style12" style="width: 50%;">Medico: </td>
                <td class="auto-style9" style="width: 50%;">
                    <asp:DropDownList ID="ddlMedicos" runat="server" Height="23px" CssClass="dropdown-filter" Width="222px" ValidationGroup="VG1" OnSelectedIndexChanged="ddlMedicos_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem Value="-1">--Seleccione un Medico--</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="validator">
                    <asp:RequiredFieldValidator ID="RfvProvincia" runat="server" ControlToValidate="ddlMedicos" CssClass="validator-message" InitialValue="-1" ValidationGroup="VG1" ForeColor="#FFC2C2" Display="Dynamic">Seleccione un Medico</asp:RequiredFieldValidator>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style12" style="width: 50%;">Día:</td>
                <td class="auto-style9" style="width: 50%;">
                    <asp:TextBox ID="txtDia" runat="server" type="date" Height="18px" Width="215px" MaxLength="8" ValidationGroup="VG1" OnTextChanged="txtDia_TextChanged" AutoPostBack="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="validator">
                    <asp:Label ID="lblErrorDia" runat="server" ForeColor="#FFC2C2" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style12" style="width: 50%;">Horario: </td>
                <td class="auto-style9" style="width: 50%;">
                    <asp:DropDownList ID="DdlHorario" runat="server" Height="23px" CssClass="dropdown-filter" Width="222px" ValidationGroup="VG1" OnSelectedIndexChanged="ddlMedicos_SelectedIndexChanged">
                        <asp:ListItem Value="-1">--Seleccione un Horario--</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="validator">
                    <asp:RequiredFieldValidator ID="RdvHorario" runat="server" ControlToValidate="DdlHorario" CssClass="validator-message" InitialValue="-1" ValidationGroup="VG1" ForeColor="#FFC2C2" Display="Dynamic">Seleccione un Horario</asp:RequiredFieldValidator>
                    <br />
                </td>
            </tr>  
        </table>
        <br />
        <table align="center" class="admin-links">
            <tr>
                <td class="link">
                    <asp:Button ID="btnAtras" runat="server" Text="Atrás" CssClass="btn-search" Width="122px" OnClick="btnAtras_Click" Height="40px" />
                </td>
                <td class="link">
                    <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" CssClass="btn-search" Width="121px" ValidationGroup="VG1" OnClick="BtnAgregar_Click" Height="40px" OnClientClick="return ConfirmarIngreso();" />
                </td>
                <script type="text/javascript">
                    function ConfirmarIngreso() {
                        var isValid = Page_ClientValidate("VG1");
                        if (isValid) {
                            var resultado = confirm("¿Esta seguro de querer ingresar el Turno en el sistema?");
                            if (resultado) {
                                return true;
                            } else {
                                return false;
                            }
                        } else {
                            return false;
                        }
                    }
                </script>
            </tr>
        </table>
    </div>
</div>
</form>
</body>
</html>

