<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form_Admin_Agregar_Pacientes.aspx.cs" Inherits="TPINT_GRUPO_02_PR3.Form_Agregar_Pacientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title></title>
    <style type="text/css">
    /* Estilos generales */
        body {
            background-color: #4C1766;
            font-family: Arial, sans-serif;
            color: #FFFFFF;
            margin: 0;
            display: flex;
            align-items: center;
            justify-content: center;
        }

        /* Encabezado */
        .header {
                position: fixed;
                top: 0;
                left: 0;
                width: 100%;
                display: flex;
                justify-content: space-between;
                align-items: center;
                box-shadow: 0px 4px 10px rgba(0, 0, 0, 0.3);
                border-top-left-radius: 15px;
                border-top-right-radius: 15px;
                z-index: 1000;
                padding: 20px;
                background-color: #3A104D;
                height: 60px;
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
            padding: 8px 12px;
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

        /* Estilo de los enlaces de administración */
        .link {
            color: white;
            text-decoration: none;
            font-weight: bold;
            background-color: #6C2C91;
            padding: 10px 20px;
            border-radius: 5px;
            transition: background-color 0.3s, transform 0.2s;
            margin-top: 20px;
        }

        .link:hover {
            background-color: #3A104D;
            transform: scale(1.05);
        }

        .link:active {
            background-color: #5B1F6D;
        }

        /* Contenedor principal */
        .container {
            background-color: #6C2C91;
            padding: 60px;
            border-bottom-left-radius: 15px;
            border-bottom-right-radius: 15px;
            width: 600px;
            text-align: center;
            box-shadow: 0px 4px 10px rgba(0, 0, 0, 0.3);
            font-weight: bold;
            display: flex;
            flex-direction: column;
            justify-content: center;
            align-items: center;
            margin-top: 60px;
        }

        /* Botones de menú */
        .button-container {
            display: grid;
            grid-template-columns: 1fr 1fr;
            gap: 20px;
            top: 20px;
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

        .auto-style4, .auto-style4 * {
            font-weight: bold;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <div class="menu-left">
                <img src="../Imagenes/Logo_MS.png" alt="Logo" class="logo" />
                <div class="menu-dropdown">
                    <button>☰</button>
                    <ul>
                        <li><a href="../FormAdmin/Form_Admin_Listado_Pacientes.aspx">PACIENTES</a></li>
                        <li><a href="#">TURNOS</a></li>
                        <li><a href="#">MEDICOS</a></li>
                        <li><a href="#">REPORTES</a></li>
                        <li><a href="<%= ResolveUrl("~/FormsLogins/Form_Login.aspx") %>">CERRAR SESIÓN</a></li>
                    </ul>
                </div>
            </div>
            <div class="admin-links">
                <asp:HyperLink ID="hlAgregarPaciente" runat="server" NavigateUrl="~/FormsAdmin/Form_Admin_Agregar_Pacientes.aspx" class="link">AGREGAR PACIENTE</asp:HyperLink>
                <asp:HyperLink ID="hlListadoPacientes" runat="server" NavigateUrl="~/FormsAdmin/Form_Admin_Listado_Pacientes.aspx" class="link">LISTAR PACIENTES</asp:HyperLink>
            </div>
            <div class="user-info">
                <asp:HyperLink ID="HLInstagram" runat="server" NavigateUrl="https://www.instagram.com" Target="_blank">
                    <img src="https://upload.wikimedia.org/wikipedia/commons/a/a5/Instagram_icon.png" alt="Instagram" style="width: 30px; height: 30px;"/>
                </asp:HyperLink>
                <asp:HyperLink ID="HLFacebook" runat="server" NavigateUrl="https://www.facebook.com/profile.php?id=61567773056854" Target="_blank">
                    <img src="https://upload.wikimedia.org/wikipedia/commons/5/51/Facebook_f_logo_%282019%29.svg" alt="Facebook" style="width: 30px; height: 30px;"/>
                </asp:HyperLink>
                <asp:HyperLink ID="HLTwitter" runat="server" NavigateUrl="https://www.twitter.com" Target="_blank">
                    <img src="https://upload.wikimedia.org/wikipedia/commons/6/6f/Logo_of_Twitter.svg" alt="Twitter" style="width: 30px; height: 30px;"/>
                </asp:HyperLink>
                <asp:Label ID="LblUsuario" runat="server" CssClass="username"></asp:Label>
            </div>
        </div>

    <div align="center" class="container">
    <table>
        <tr>
            <td style="font-weight: bold;font-size: 40px" class="auto-style8">Carga de Pacientes<br />
                <br/>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
        </tr>
    </table>
    <table align="center" class="auto-style10">
        <tr>
            <td class="auto-style12" style="width: 50%;">DNI: </td>
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
            <td class="auto-style12" style="width: 50%;">Nombre: </td>
            <td class="auto-style9" style="width: 50%;">
                <asp:TextBox ID="txtNombre" runat="server" Height="18px" Width="215px" MaxLength="30" ValidationGroup="VG1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="validator">
                <asp:RequiredFieldValidator ID="RfvNombre" runat="server" ControlToValidate="txtNombre" CssClass="validator-message" ValidationGroup="VG1" ForeColor="#FFC2C2" Display="Dynamic">Ingrese un Nombre</asp:RequiredFieldValidator>
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style12" style="width: 50%;">Apellido: </td>
            <td class="auto-style9" style="width: 50%;">
                <asp:TextBox ID="txtApellido" runat="server" Height="18px" Width="215px" MaxLength="30" ValidationGroup="VG1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="validator">
                <asp:RequiredFieldValidator ID="RfvApellido" runat="server" ControlToValidate="txtApellido" CssClass="validator-message" ValidationGroup="VG1" ForeColor="#FFC2C2" Display="Dynamic">Ingrese un Apellido</asp:RequiredFieldValidator>
                <br />
            </td>
        </tr>

        <tr>
            <td class="auto-style12" style="width: 50%;">Genero: </td>
            <td class="auto-style9" style="width: 50%;">
                <asp:DropDownList ID="ddlSexo" runat="server" Height="21px" Width="222px" ValidationGroup="VG1">
                    <asp:ListItem Value="-1">--Seleccione una opción--</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="validator">
                <asp:RequiredFieldValidator ID="RfvSexo" runat="server" ControlToValidate="ddlSexo" CssClass="validator-message" InitialValue="-1" ValidationGroup="VG1" ForeColor="#FFC2C2" Display="Dynamic">Seleccione un Genero</asp:RequiredFieldValidator>
                <br />
            </td>
        </tr>

        <tr>
            <td class="auto-style12" style="width: 50%;">Nacionalidad: </td>
            <td class="auto-style9" style="width: 50%;">
                <asp:TextBox ID="TxbNacionalidad" runat="server" Height="18px" Width="215px" MaxLength="30" ValidationGroup="VG1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="validator">
                <asp:RequiredFieldValidator ID="RfvNacionalidad" runat="server" ControlToValidate="TxbNacionalidad" CssClass="validator-message" ValidationGroup="VG1" ForeColor="#FFC2C2" Display="Dynamic">Ingrese una Nacionalidad</asp:RequiredFieldValidator>
                <br />
            </td>
        </tr>

        <tr>
            <td class="auto-style12" style="width: 50%;">Dirección: </td>
            <td class="auto-style9" style="width: 50%;">
                <asp:TextBox ID="txtDirección" runat="server" Height="18px" Width="215px" MaxLength="40" ValidationGroup="VG1" Display="Dynamic"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="auto-style12">
                <asp:RequiredFieldValidator ID="RfvDirección" runat="server" ControlToValidate="txtDirección" CssClass="validator-message" ValidationGroup="VG1" ForeColor="#FFC2C2" Display="Dynamic">Ingrese una Dirección</asp:RequiredFieldValidator>
                <br />
            </td>
        </tr>

        <tr>
            <td class="auto-style12" style="width: 50%;">Provincia: </td>
            <td class="auto-style9" style="width: 50%;">
                <asp:DropDownList ID="ddlProvincia" runat="server" Height="23px" Width="222px" AutoPostBack="True" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged" ValidationGroup="VG1">
                    <asp:ListItem Value="-1">--Seleccione una provincia--</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="validator">
                <asp:RequiredFieldValidator ID="RfvProvincia" runat="server" ControlToValidate="ddlProvincia" CssClass="validator-message" InitialValue="-1" ValidationGroup="VG1" ForeColor="#FFC2C2" Display="Dynamic">Seleccione una Provincia</asp:RequiredFieldValidator>
                <br />
            </td>
        </tr>

        <tr>
            <td class="auto-style12" style="width: 50%;">Localidad: </td>
            <td class="auto-style9" style="width: 50%;">
                <asp:DropDownList ID="ddlLocalidad" runat="server" Height="23px" Width="222px" ValidationGroup="VG1">
                    <asp:ListItem Value="-1">--Seleccione una localidad--</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="validator">
                <asp:RequiredFieldValidator ID="RfvLocalidad" runat="server" ControlToValidate="ddlLocalidad" CssClass="validator-message" InitialValue="-1" ValidationGroup="VG1" ForeColor="#FFC2C2" Display="Dynamic">Seleccione una Localidad</asp:RequiredFieldValidator>
                <br />
            </td>
        </tr>

        <tr>
            <td class="auto-style12" style="width: 50%;">Nacimiento: </td>
            <td class="auto-style9" style="width: 50%;">
                <asp:TextBox ID="txtNacimiento" runat="server" type="date" Height="18px" Width="215px" ValidationGroup="VG1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="validator">
                <asp:RequiredFieldValidator ID="RfvNacimiento" runat="server" ControlToValidate="txtNacimiento" CssClass="validator-message" ValidationGroup="VG1" ForeColor="#FFC2C2" Display="Dynamic">Ingrese una Fecha</asp:RequiredFieldValidator>
                <br />
            </td>
        </tr>

        <tr>
            <td class="auto-style12" style="width: 50%;">Correo: </td>
            <td class="auto-style9" style="width: 50%;">
                <asp:TextBox ID="txtCorreo" runat="server" Height="18px" Width="215px" MaxLength="50" ValidationGroup="VG1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="validator">
                <asp:RequiredFieldValidator ID="RfvCorreo" runat="server" ControlToValidate="txtCorreo" CssClass="validator-message" ValidationGroup="VG1" ForeColor="#FFC2C2" Display="Dynamic">Ingrese un Correo</asp:RequiredFieldValidator>
                <br />
            </td>
        </tr>

        <tr>
            <td class="auto-style12" style="width: 50%;">Telefono: </td>
            <td class="auto-style9" style="width: 50%;">
                <asp:TextBox ID="txtTelefono" runat="server" Height="18px" Width="215px" MaxLength="15" ValidationGroup="VG1"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="validator">
                <asp:RequiredFieldValidator ID="RfvTelefono" runat="server" ControlToValidate="txtTelefono" CssClass="validator-message" ValidationGroup="VG1" ForeColor="#FFC2C2" Display="Dynamic">Ingrese un Teléfono</asp:RequiredFieldValidator>
                <br />
            </td>
        </tr>
    </table>

    <table align="center" class="admin-links">
    <tr>
        <td class="link">
            <asp:Button ID="btnAtras" runat="server" Text="Atrás" Width="122px" OnClick="btnAtras_Click" Height="40px" />
        </td>
        <td class="link">
    <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" Width="121px" ValidationGroup="VG1" OnClick="BtnAgregar_Click" Height="40px" OnClientClick="return ConfirmarIngreso();" />
</td>

<script type="text/javascript">
    function ConfirmarIngreso() {
        var isValid = Page_ClientValidate("VG1");
        if (isValid) {
            var resultado = confirm("¿Esta seguro de querer ingresar el paciente en el sistema?");
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
</form>
</body>
</html>
