<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form_Admin_Listado_Turnos.aspx.cs" Inherits="TPINT_GRUPO_02_PR3.FormsAdmin.Form_Admin_Listado_Turnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <style type="text/css">
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
            width: 100%; 
            max-width: 100vw;
            box-shadow: 0px 4px 10px rgba(0, 0, 0, 0.3);
            border-radius: 15px;
        }

        .header {
            width: 103%;
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

        .auto-style4, .auto-style4 * {
            font-weight: bold;
        }
        .table-style {
            width: 100%;
            border-collapse: collapse;
            font-family: Arial, sans-serif;
        }

        .table-style th, .table-style td {
            border: 1px solid #d1c4e9; /* Borde lila suave */
            padding: 8px;
            text-align: left;
            color: #4a148c; /* Texto morado oscuro para registros */
        }

        .table-style th {
            background-color: #7e57c2; /* Fondo morado oscuro para encabezados */
            color: #f3e5f5; /* Texto lila claro */
            font-weight: bold;
        }

        .table-style tr {
            background-color: #ede7f6;
        }

        .table-style tr:hover {
            background-color: #d1c4e9; /* Fondo lila intermedio al pasar el mouse */
        }

        .input-style {
            width: 90%;
            padding: 6px;
            border: 1px solid #9575cd; /* Borde morado intermedio */
            border-radius: 4px;
        }

        .table-style button {
            background-color: #9575cd; /* Morado medio para botones */
            color: #ffffff; /* Texto blanco */
            border: none;
            padding: 5px 10px;
            cursor: pointer;
            border-radius: 4px;
            font-size: 14px;
        }

        .table-style button:hover {
            background-color: #7e57c2; /* Morado oscuro al pasar el mouse */
        }
        .search-table {
            width: 100%;
            border-spacing: 8px;
            font-family: Arial, sans-serif;
        }

        .input-search {
            padding: 8px;
            font-weight: bold;
            font-size: 15px;
            color: #4a148c; /* Morado oscuro */
            border: 1px solid #9575cd; /* Borde morado */
            border-radius: 4px;
            background-color: #ede7f6; /* Fondo lila claro */
            width: 100%;
            box-sizing: border-box;
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

        .label-filter {
            font-weight: bold;
            font-size: 15px;
            color: #4a148c; /* Morado oscuro */
        }

        .dropdown-filter {
            padding: 6px;
            font-size: 15px;
            color: #4a148c; /* Morado oscuro */
            border: 1px solid #9575cd; /* Borde morado */
            border-radius: 4px;
            background-color: #ede7f6; /* Fondo lila claro */
            width: 100%;
            box-sizing: border-box;
        }

        .auto-style5 {
            width: 76%;
            border-spacing: 8px;
            font-family: Arial, sans-serif;
        }

        .auto-style6 {
            width: 119px;
        }
        /* Clase para el DropDownList */
        .dropdown-filter {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            font-size: 14px;
            color: #4a148c;
            background-color: #f3e5f5;
            border: 1px solid #b39ddb;
            padding: 8px;
            border-radius: 4px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
            width: 250px; 
        }

        /* Cambiar color cuando el mouse pasa por encima */
        .dropdown-filter:hover {
            background-color: #d1c4e9;
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
            <div class="admin-links">
                <asp:HyperLink ID="hlAgregarPaciente" runat="server" NavigateUrl="~/FormsAdmin/Form_Admin_Agregar_Turno.aspx" CssClass="btn-search">CARGAR TURNO</asp:HyperLink>
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
                <td style="font-weight: bold;font-size: 40px" class="auto-style7">Administrador de Turnos<br/>
                &nbsp;</td>
            </tr>
        </table>
        
       <table align="center" class="auto-style5">
    <tr>
        <td>
            <asp:TextBox ID="txtBuscador" runat="server" CssClass="input-search" Width="220px"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn-search" OnClick="btnBuscar_Click" />
        </td>
        <td class="auto-style6">
            <asp:Label ID="Label1" runat="server" Text="Filtrar Por:" Style="font-weight: bold; font-size: 15px; color: #d1c4e9; white-space: nowrap;"></asp:Label>

        </td>
        <td>
            <asp:DropDownList ID="ddlFiltros" runat="server" CssClass="dropdown-filter">
                <asp:ListItem Value="-1">SELECCIONE UNA CATEGORÍA</asp:ListItem>
                <asp:ListItem Value="DNI_PAS">DNI del Paciente</asp:ListItem>
                <asp:ListItem Value="NOMBRE_PAS">Nombre del Paciente</asp:ListItem>
                <asp:ListItem Value="NOMBRE_MED">Nombre del Medico</asp:ListItem>
                <asp:ListItem Value="NOMBRE_ESP">Especialidad</asp:ListItem>
                <asp:ListItem Value="FECHA_TUR">Fecha</asp:ListItem>
                <asp:ListItem Value="HORA_TUR">Horario</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
</table>
        <br />
        <asp:GridView ID="GrdTurnos" runat="server" AutoGenerateColumns="False" CssClass="table-style" OnRowDeleting="GrdTurnos_RowDeleting">
            <Columns>
                <asp:TemplateField HeaderText="Dni del Paciente">
            <ItemTemplate>
                <asp:Label ID="lbl_it_ID" runat="server" Text='<%# Bind("DNI_PACIENTE") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Nombre del Paciente">
            <ItemTemplate>
                <asp:Label ID="lbl_it_DNI" runat="server" Text='<%# Bind("NOMBRE_PACIENTE") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="Nombre del Médico">
            <ItemTemplate>
                <asp:Label ID="lbl_it_Nombre" runat="server" Text='<%# Bind("NOMBRE_MEDICO") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="Especialidad">
            <ItemTemplate>
                <asp:Label ID="lbl_it_Especialidad" runat="server" Text='<%# Bind("NOMBRE_ESP") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="Fecha">
            <ItemTemplate>
                <asp:Label ID="lbl_it_Fecha" runat="server" Text='<%# Eval("FECHA_TUR", "{0:dd/MM/yyyy}") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="Horario">
            <ItemTemplate>
                <asp:Label ID="lbl_it_Horario" runat="server" Text='<%# Eval("HORA_TUR") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField>
            <ItemTemplate>
                <asp:Button ID="btnEliminar" runat="server" CommandName="Delete" Text="&#128465;" 
                    OnClientClick="return confirmarEliminacion();" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
        <script type="text/javascript">
            function confirmarEliminacion() {
                return confirm("¿Estás seguro de que deseas eliminar este registro?");
            }
        </script>
    </div>
    </div>
    </form>
</body>
</html>
