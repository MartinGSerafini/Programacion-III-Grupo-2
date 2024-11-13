<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form_Admin_Agregar_Medico.aspx.cs" Inherits="TPINT_GRUPO_02_PR3.FormAdmin.Agregar_Medico" %>

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
    .btn-search {
        background-color: #7e57c2; /* Morado medio */
        color: #ffffff; /* Texto blanco */
        padding: 8px 12px;
        border: none;
        border-radius: 4px;
        font-weight: bold;
        font-size: 15px;
        cursor: pointer;
        transition: background-color 0.3s ease;
    }

    .btn-search:hover {
        background-color: #5e35b1; /* Morado oscuro al pasar el mouse */
    }
        .auto-style1 {
            width: 7%;
        }
        .auto-style2 {
            width: 9%;
        }
        .auto-style3 {
            width: 7%;
            height: 26px;
        }
        .auto-style4 {
            width: 9%;
            height: 26px;
        }
        .auto-style5 {
            width: 24%;
            height: 26px;
        }
        .auto-style6 {
            width: 24%;
        }
        .auto-style7 {
            width: 438px;
        }
        /* Clase para el DropDownList */
        .dropdown-filter {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; /* Fuente moderna */
            font-size: 14px; /* Tamaño adecuado para legibilidad */
            color: #4a148c; /* Color morado oscuro */
            background-color: #f3e5f5; /* Fondo claro que contraste bien con el texto */
            border: 1px solid #b39ddb; /* Borde sutil para el dropdown */
            padding: 8px; /* Espaciado interno */
            border-radius: 4px; /* Bordes redondeados */
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1); /* Sombras sutiles */
            width: 250px; /* Asegura que el ancho se mantiene */
        }

        /* Cambiar color cuando el mouse pasa por encima */
        .dropdown-filter:hover {
            background-color: #d1c4e9; /* Color claro al pasar el ratón */
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
                            <li><a href="#">TURNOS</a></li>
                            <li><a href="../FormsAdmin/Form_Admin_Listado_Medicos.aspx">MEDICOS</a></li>
                            <li><a href="#">REPORTES</a></li>
                            <li><a href="<%= ResolveUrl("~/FormsLogins/Form_Login.aspx") %>">CERRAR SESIÓN</a></li>
                        </ul>
                    </div>
                </div>
                <div class="admin-links">
                    <asp:HyperLink ID="hlAgregarMedico" runat="server" NavigateUrl="~/FormsAdmin/Form_Admin_Agregar_Medico.aspx" class="btn-search">AGREGAR MEDICO</asp:HyperLink>
                    <asp:HyperLink ID="hlListadoMedicos" runat="server" NavigateUrl="~/FormsAdmin/Form_Admin_Listado_Medicos.aspx" class="btn-search">LISTAR MEDICOS</asp:HyperLink>
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
            <td style="font-weight: bold;font-size: 40px" class="auto-style8">Carga de Medicos<br/>
        </td>
        </tr>
    </table>
    <table align="center" class="auto-style7">
        <tr>
            <td class="auto-style1">Legajo:</td>
            <td class="auto-style2">
                <br />
                <asp:TextBox ID="txtLegajo" runat="server" ValidationGroup="VG1" MaxLength="5" Width="200px"></asp:TextBox>
                &nbsp;</td>
            <td class="auto-style6">
                <asp:RequiredFieldValidator ID="rfvLegajo" runat="server" ControlToValidate="txtLegajo" ForeColor="#FFC2C2" ValidationGroup="VG1">Ingrese un Legajo</asp:RequiredFieldValidator>
                <br />
                &nbsp;<asp:RegularExpressionValidator ID="RevLegajo" runat="server" ControlToValidate="txtLegajo" CssClass="validator-message" ValidationExpression="^\d{5}$" ValidationGroup="VG1" ForeColor="#FFC2C2" Display="Dynamic" Text="Debe ingresar 5 Números" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">DNI:</td>
            <td class="auto-style2">
                <br />
                <asp:TextBox ID="txtDNI" runat="server" ValidationGroup="VG1" MaxLength="8" Width="200px"></asp:TextBox>
                &nbsp;</td>
            <td class="auto-style6">
                <asp:RequiredFieldValidator ID="rfvDNI" runat="server" ControlToValidate="txtDNI" ForeColor="#FFC2C2" ValidationGroup="VG1">Ingrese un DNI</asp:RequiredFieldValidator>
                <br />
                &nbsp;<asp:RegularExpressionValidator ID="RevDni" runat="server" ControlToValidate="txtDNI" CssClass="validator-message" ValidationExpression="^\d{8}$" ValidationGroup="VG1" ForeColor="#FFC2C2" Display="Dynamic" Text="Debe ingresar 8 Números" />  
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Nombre:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtNombre" runat="server" Width="200px" ValidationGroup="VG1"></asp:TextBox>
            </td>
            <td class="auto-style6">
                <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ForeColor="#FFC2C2" ValidationGroup="VG1">Ingrese un Nombre</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Apellido:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtApellido" runat="server" Width="198px" ValidationGroup="VG1"></asp:TextBox>
            </td>
            <td class="auto-style6">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtApellido" ForeColor="#FFC2C2" ValidationGroup="VG1">Ingrese un Apellido</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Genero:</td>
            <td class="auto-style2">
                <asp:DropDownList ID="ddlSexo" runat="server" ValidationGroup="VG1" Width="200px">
                    <asp:ListItem Value="-1">--Seleccione una opción--</asp:ListItem>
                    <asp:ListItem Value="1">M</asp:ListItem>
                    <asp:ListItem Value="2">F</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style6">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlSexo" ForeColor="#FFC2C2" InitialValue="--Seleccione una opción--" ValidationGroup="VG1">Seleccione un Genero</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Nacionalidad:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtnacionalidad" runat="server" Width="198px" ValidationGroup="VG1"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtnacionalidad" ForeColor="#FFC2C2" ValidationGroup="VG1">Ingrese una Nacionalidad</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Nacimiento:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtNacimiento" runat="server" TextMode="Date" ValidationGroup="VG1" Width="200px"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtnacionalidad" ForeColor="#FFC2C2" ValidationGroup="VG1">Ingrese una Nacionalidad</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Dirección:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtDireccion" runat="server" Width="200px" ValidationGroup="VG1"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="rfvDirección" runat="server" ControlToValidate="txtDireccion" ForeColor="#FFC2C2" ValidationGroup="VG1">Ingrese una Direccion</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Provincia:</td>
            <td class="auto-style2">
                <asp:DropDownList ID="ddlProvincia" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged" ValidationGroup="VG1" Width="200px">
                    <asp:ListItem>--Seleccione la provincia--</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ddlProvincia" ForeColor="#FFC2C2" InitialValue="--Seleccione la provincia--" ValidationGroup="VG1">Seleccione una Provincia</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Localidad:</td>
            <td class="auto-style2">
                <asp:DropDownList ID="ddlLocalidad" runat="server" AutoPostBack="True" ValidationGroup="VG1" Width="200px">
                    <asp:ListItem>--Seleccione la localidad--</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddlLocalidad" ForeColor="#FFC2C2" InitialValue="--Seleccione la localidad--" ValidationGroup="VG1">Seleccione una Localidad</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Correo:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtCorreo" runat="server" Width="200px" ValidationGroup="VG1"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtCorreo" ForeColor="#FFC2C2" ValidationGroup="VG1" Width="200px">Ingrese un Correo</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Teléfono:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtTelefono" runat="server" ValidationGroup="VG1" Width="200px"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtTelefono" ForeColor="#FFC2C2" ValidationGroup="VG1">Ingrese un Telefono</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Especialidad:</td>
            <td class="auto-style2">
                <asp:DropDownList ID="ddlEspecialidad" runat="server" ValidationGroup="VG1" Width="200px">
                    <asp:ListItem>--Seleccione la especialidad--</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="ddlEspecialidad" ForeColor="#FFC2C2" InitialValue="--Seleccione la especialidad--" ValidationGroup="VG1">Seleccione una Localidad</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Días de atención:</td>
            <td class="auto-style2">
                <asp:CheckBoxList ID="cblDias" runat="server" Height="105px" RepeatColumns="3" Width="180px" ValidationGroup="VG1">
                    <asp:ListItem>Lunes</asp:ListItem>
                    <asp:ListItem>Martes</asp:ListItem>
                    <asp:ListItem>Miércoles</asp:ListItem>
                    <asp:ListItem>Jueves</asp:ListItem>
                    <asp:ListItem>Viernes</asp:ListItem>
                    <asp:ListItem>Sábado</asp:ListItem>
                </asp:CheckBoxList>
            </td>
            <td class="auto-style5">
                <asp:CustomValidator ID="cvDias" runat="server" ValidationGroup="VG1" OnServerValidate="cvDias_ServerValidate" ForeColor="#FFC2C2" ErrorMessage="Debe Seleccionar al menos un Día."></asp:CustomValidator>
                <br />
                <asp:Label ID="lblDias" runat="server" ForeColor="#FFC2C2"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Horario de atención:</td>
            <td class="auto-style2">
                De:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtHoraInicio" runat="server" TextMode="Time" ValidationGroup="VG1" Width="200px"></asp:TextBox>
                <br />
                Hasta: <asp:TextBox ID="txtHoraFinal" runat="server" TextMode="Time" ValidationGroup="VG1" Width="200px"></asp:TextBox>
                <br />
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtHoraInicio" ForeColor="#FFC2C2" ValidationGroup="VG1" Width="200px">Ingrese un Horario de Inicio</asp:RequiredFieldValidator>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtHoraFinal" ForeColor="#FFC2C2" ValidationGroup="VG1" Width="200px">Ingrese un Horario de Salida</asp:RequiredFieldValidator>
                <br />
                <asp:CustomValidator 
                    ID="cvHora" 
                    runat="server" 
                    ControlToValidate="txtHoraFinal" 
                    ErrorMessage="La hora de salida no puede ser menor a la de entrada." 
                    ClientValidationFunction="validateHora" 
                    ValidationGroup="VG1" 
                    ForeColor="#FFC2C2"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Contraseña:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password" Width="200px" ValidationGroup="VG1"></asp:TextBox>   
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="rfvContra" runat="server" ControlToValidate="txtContraseña" ForeColor="#FFC2C2" ValidationGroup="VG1">Ingrese una Contraseña</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Repetir Contraseña:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtRepetirContraseña" runat="server" TextMode="Password" Width="200px" ValidationGroup="VG1"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RfvRepeContra" runat="server" ControlToValidate="txtRepetirContraseña" ForeColor="#FFC2C2" ValidationGroup="VG1">Ingrese la Confirmacion de la Contraseña</asp:RequiredFieldValidator>
            </td>
        </tr>
        </table>
    <table align="center" class="admin-links">
    <tr>
        <td class="link">
            <asp:Button ID="btnAtras" runat="server" Text="Atrás" CssClass="btn-search" Width="122px" OnClick="btnAtras_Click" Height="40px" />
        </td>
        <td class="link">
    <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" CssClass="btn-search" Width="121px" ValidationGroup="VG1" OnClick="btnAgregar_Click" Height="40px" OnClientClick="return ConfirmarIngreso();" />
</td>

<script type="text/javascript">
    function ConfirmarIngreso() {
        var isValid = Page_ClientValidate("VG1");
        if (isValid) {
            var resultado = confirm("¿Esta seguro de querer ingresar el Medico en el sistema?");
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
