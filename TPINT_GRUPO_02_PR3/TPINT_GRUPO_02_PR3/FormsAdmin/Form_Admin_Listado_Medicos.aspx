<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form_Admin_Listado_Medicos.aspx.cs" Inherits="TPINT_GRUPO_02_PR3.FormAdmin.ListadoMedicos" %>

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
            width: 59%;
            border-spacing: 8px;
            font-family: Arial, sans-serif;
        }

        .auto-style6 {
            width: 87px;
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
                            <li><a href="../FormsAdmin/Form_Admin_Reportes.aspx">REPORTES</a></li>
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
                <td style="font-weight: bold;font-size: 40px" class="auto-style8">Administrador de Medicos<br/>
            </td>
            </tr>
        </table>
        <table align="center">
            <tr>
                <td class="auto-style62">
                    <asp:TextBox ID="txtBuscador" CssClass="input-search" style="font-weight: bold;font-size: 15px" runat="server" Width="220px" Height="20px"></asp:TextBox>
                </td>
                <td class="auto-style63">
                    <asp:Button ID="btnBuscar" CssClass="btn-search" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                </td>
                <td class="auto-style64">
                    <asp:Label ID="Label1" runat="server" Text="FILTRAR POR:" Style="font-weight: bold; font-size: 15px; color: #d1c4e9; white-space: nowrap;"></asp:Label>

                </td>
                <td class="auto-style65">
                    <asp:DropDownList ID="ddlFiltros" runat="server" CssClass="dropdown-filter" Width="231px">
                        <asp:ListItem Value="-1">SELECCIONE UNA CATEGORÍA</asp:ListItem>
                        <asp:ListItem Value="M.LEGAJO_MED">LEGAJO</asp:ListItem>
                        <asp:ListItem Value="M.FK_DNI_MED">DNI</asp:ListItem>
                        <asp:ListItem Value="M.NOMBRE_MED">NOMBRE</asp:ListItem>
                        <asp:ListItem Value="M.APELLIDO_MED">APELLIDO</asp:ListItem>
                        <asp:ListItem Value="M.SEXO_MED">SEXO</asp:ListItem>
                        <asp:ListItem Value="M.NACIONALIDAD_MED">NACIONALIDAD</asp:ListItem>
                        <asp:ListItem Value="M.NACIMIENTO_MED">FECHA DE NACIMIENTO</asp:ListItem>
                        <asp:ListItem Value="M.DIRECCION_MED">DIRECCIÓN</asp:ListItem>
                        <asp:ListItem Value="L.NOMBRE_LOC">LOCALIDAD</asp:ListItem>
                        <asp:ListItem Value="PRO.NOMBRE_PRO">PROVINCIA</asp:ListItem>
                        <asp:ListItem Value="M.EMAIL_MED">EMAIL</asp:ListItem>
                        <asp:ListItem Value="M.TELEFONO_MED">TELÉFONO</asp:ListItem>
                        <asp:ListItem Value="H.DIA_HDA">DIAS</asp:ListItem>
                        <asp:ListItem Value="CAST(H.HORA_INICIO_HDA AS CHAR(5)) + ' - ' + CAST(H.HORA_FIN_HDA AS CHAR(5))">HORARIOS</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
            <br />
            <asp:GridView ID="grdListadoMedicos" runat="server" AutoGenerateColumns="False" CssClass="table-style" OnRowEditing="grdListadoMedicos_RowEditing" OnRowUpdating="grdListadoMedicos_RowUpdating" OnRowCancelingEdit="grdListadoMedicos_RowCancelingEdit" OnRowDeleting="grdListadoMedicos_RowDeleting" OnRowDataBound="grdListadoMedicos_RowDataBound" AllowPaging="True" OnPageIndexChanging="grdListadoMedicos_PageIndexChanging">
                <Columns>
                    <asp:TemplateField HeaderText="Legajo">
                        <EditItemTemplate>
                            <asp:Label ID="lblLegajo" runat="server" Text='<%# Bind("LEGAJO_MED") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Legajo" runat="server" Text='<%# Bind("LEGAJO_MED") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="DNI">
                        <EditItemTemplate>
                            <asp:Label ID="lblDNI" runat="server" Text='<%# Bind("FK_DNI_MED") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_DNI" runat="server" Text='<%# Bind("FK_DNI_MED") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNombre" CssClass="input-style" runat="server" Text='<%# Bind("NOMBRE_MED") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Nombre" runat="server" Text='<%# Bind("NOMBRE_MED") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Apellido">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtApellido" CssClass="input-style" runat="server" Text='<%# Bind("APELLIDO_MED") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Apellido" runat="server" Text='<%# Bind("APELLIDO_MED") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Sexo">
                        <EditItemTemplate>
                            <asp:DropDownList ID="ddlSexo" CssClass="input-style" runat="server" SelectedValue='<%# Bind("SEXO_MED") %>'>
                                <asp:ListItem>F</asp:ListItem>
                                <asp:ListItem>M</asp:ListItem>
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Sexo" runat="server" Text='<%# Bind("SEXO_MED") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Nacionalidad">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNacionalidad" CssClass="input-style" runat="server" Text='<%# Bind("NACIONALIDAD_MED") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Nacionalidad" runat="server" Text='<%# Bind("NACIONALIDAD_MED") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Nacimiento">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNacimiento" CssClass="input-style" runat="server" 
                                Text='<%# DataBinder.Eval(Container.DataItem, "NACIMIENTO_MED", "{0:yyyy-MM-dd}") %>' 
                                type="date"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Nacimiento" runat="server" 
                                Text='<%# Eval("NACIMIENTO_MED", "{0:dd/MM/yyyy}") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Direccion">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDireccion" CssClass="input-style" runat="server" Text='<%# Bind("DIRECCION_MED") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Direccion" runat="server" Text='<%# Bind("DIRECCION_MED") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Provincia">
                        <EditItemTemplate>
                             <asp:DropDownList ID="ddlProvincias" CssClass="input-style" runat="server" AutoPostBack="True" 
                                               AppendDataBoundItems="True" 
                                               OnSelectedIndexChanged="ddlProvincias_SelectedIndexChanged" 
                                               DataSourceID="SqlDataSource1" 
                                               DataTextField="NOMBRE_PRO" DataValueField="ID_PROVINCIA_PRO">
                                 <asp:ListItem Text="Seleccione una Provincia" Value="-1" />
                             </asp:DropDownList>
                         </EditItemTemplate>
                         <ItemTemplate>
                             <asp:Label ID="lbl_it_Provincia" runat="server" Text='<%# Bind("NOMBRE_PRO") %>'></asp:Label>
                         </ItemTemplate>
                     </asp:TemplateField>

                    <asp:TemplateField HeaderText="Localidad">
                        <EditItemTemplate>
                            <asp:DropDownList ID="ddlLocalidades" CssClass="input-style" runat="server" DataSourceID="SqlDataSource2" 
                                              DataTextField="NOMBRE_LOC" DataValueField="ID_LOCALIDAD_LOC" AutoPostBack="True">
                                <asp:ListItem Text="Seleccione una Localidad" Value="-1" />
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Localidad" runat="server" Text='<%# Bind("NOMBRE_LOC") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="Email">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEmail" CssClass="input-style" runat="server" Text='<%# Bind("EMAIL_MED") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Email" runat="server" Text='<%# Bind("EMAIL_MED") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Telefono">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtTelefono" CssClass="input-style" runat="server" Text='<%# Bind("TELEFONO_MED") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Telefono" runat="server" Text='<%# Bind("TELEFONO_MED") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Especialidad">
                        <EditItemTemplate>
                            <asp:DropDownList ID="ddlEspecialidades" CssClass="input-style" runat="server" AutoPostBack="True" 
                                              AppendDataBoundItems="True" 
                                              DataSourceID="SqlDataSource3" 
                                              DataTextField="NOMBRE_ESP" DataValueField="ID_ESPECIALIDAD_ESP">
                                <asp:ListItem Text="Seleccione una Especialidad" Value="-1" />
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Especialidad" runat="server" Text='<%# Bind("NOMBRE_ESP") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                   <asp:TemplateField HeaderText="Dias">
                    <EditItemTemplate>
                        <asp:CheckBoxList ID="cblDias" CssClass="input-style hidden" runat="server" Width="125px">
                            <asp:ListItem Text="Lunes" Value="Lunes"></asp:ListItem>
                            <asp:ListItem Text="Martes" Value="Martes"></asp:ListItem>
                            <asp:ListItem Text="Miércoles" Value="Miércoles"></asp:ListItem>
                            <asp:ListItem Text="Jueves" Value="Jueves"></asp:ListItem>
                            <asp:ListItem Text="Viernes" Value="Viernes"></asp:ListItem>
                            <asp:ListItem Text="Sábado" Value="Sábado"></asp:ListItem>
                            <asp:ListItem Text="Domingo" Value="Domingo"></asp:ListItem>
                        </asp:CheckBoxList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Dias" runat="server" Text='<%# Bind("DIA_HDA") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                    <asp:TemplateField HeaderText="Horarios">
                        <EditItemTemplate>
                            Inicio:
                            <asp:DropDownList ID="ddlHoraInicio" runat="server" CssClass="input-style" Width="100px">
                                <asp:ListItem Text="Selecciona una hora de inicio" Value="-1" />
                                <asp:ListItem Text="00:00" Value="0" />
                                <asp:ListItem Text="01:00" Value="1" />
                                <asp:ListItem Text="02:00" Value="2" />
                                <asp:ListItem Text="03:00" Value="3" />
                                <asp:ListItem Text="04:00" Value="4" />
                                <asp:ListItem Text="05:00" Value="5" />
                                <asp:ListItem Text="06:00" Value="6" />
                                <asp:ListItem Text="07:00" Value="7" />
                                <asp:ListItem Text="08:00" Value="8" />
                                <asp:ListItem Text="09:00" Value="9" />
                                <asp:ListItem Text="10:00" Value="10" />
                                <asp:ListItem Text="11:00" Value="11" />
                                <asp:ListItem Text="12:00" Value="12" />
                                <asp:ListItem Text="13:00" Value="13" />
                                <asp:ListItem Text="14:00" Value="14" />
                                <asp:ListItem Text="15:00" Value="15" />
                                <asp:ListItem Text="16:00" Value="16" />
                                <asp:ListItem Text="17:00" Value="17" />
                                <asp:ListItem Text="18:00" Value="18" />
                                <asp:ListItem Text="19:00" Value="19" />
                                <asp:ListItem Text="20:00" Value="20" />
                                <asp:ListItem Text="21:00" Value="21" />
                                <asp:ListItem Text="22:00" Value="22" />
                                <asp:ListItem Text="23:00" Value="23" />
                            </asp:DropDownList>
                            <br />
                            Final:
                            <asp:DropDownList ID="ddlHoraFinal" runat="server" CssClass="input-style" Width="100px">
                                <asp:ListItem Text="Selecciona una hora final" Value="-1" />
                                <asp:ListItem Text="00:00" Value="0" />
                                <asp:ListItem Text="01:00" Value="1" />
                                <asp:ListItem Text="02:00" Value="2" />
                                <asp:ListItem Text="03:00" Value="3" />
                                <asp:ListItem Text="04:00" Value="4" />
                                <asp:ListItem Text="05:00" Value="5" />
                                <asp:ListItem Text="06:00" Value="6" />
                                <asp:ListItem Text="07:00" Value="7" />
                                <asp:ListItem Text="08:00" Value="8" />
                                <asp:ListItem Text="09:00" Value="9" />
                                <asp:ListItem Text="10:00" Value="10" />
                                <asp:ListItem Text="11:00" Value="11" />
                                <asp:ListItem Text="12:00" Value="12" />
                                <asp:ListItem Text="13:00" Value="13" />
                                <asp:ListItem Text="14:00" Value="14" />
                                <asp:ListItem Text="15:00" Value="15" />
                                <asp:ListItem Text="16:00" Value="16" />
                                <asp:ListItem Text="17:00" Value="17" />
                                <asp:ListItem Text="18:00" Value="18" />
                                <asp:ListItem Text="19:00" Value="19" />
                                <asp:ListItem Text="20:00" Value="20" />
                                <asp:ListItem Text="21:00" Value="21" />
                                <asp:ListItem Text="22:00" Value="22" />
                                <asp:ListItem Text="23:00" Value="23" />
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Horarios" runat="server" Text='<%# Bind("Horarios") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Usuario">
                    <ItemTemplate>
                        <asp:Label ID="lblUsuario" runat="server" Text='<%# Eval("Usuario") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Label ID="lblUsuarioEdit" runat="server" Text='<%# Bind("Usuario") %>'></asp:Label>
                    </EditItemTemplate>
                </asp:TemplateField>
                    <asp:TemplateField HeaderText="Contraseña">
                        <ItemTemplate>
                            <asp:Label ID="lblContraseña" runat="server" Text='<%# Eval("Contraseña") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtContraseña" runat="server" Text='<%# Bind("Contraseña") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnEditar" runat="server" CommandName="Edit" Text="&#9881;" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Button ID="btnUpdate" runat="server" CommandName="Update" Text="&#10004;" OnClientClick="return confirmarEdicion();" />
                            <asp:Button ID="btnCancel" runat="server" CommandName="Cancel" Text="&#10060;" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnEliminar" runat="server" CommandName="Delete" Text="&#128465;" OnClientClick="return confirmarEliminacion();" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <script type="text/javascript">
                function confirmarEdicion() {
                    return confirm("¿Estás seguro de que deseas actualizar este registro?");
                }
                function confirmarEliminacion() {
                    return confirm("¿Estás seguro de que deseas eliminar este registro?");
                }
            </script>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:MedicalStudioConnectionString %>" 
                SelectCommand="SELECT ID_PROVINCIA_PRO, NOMBRE_PRO FROM [PROVINCIAS] ">
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                ConnectionString="<%$ ConnectionStrings:MedicalStudioConnectionString %>" 
                SelectCommand="SELECT ID_LOCALIDAD_LOC, NOMBRE_LOC FROM [LOCALIDADES] WHERE FK_ID_PROVINCIA_LOC = @ID_PROVINCIA_PRO">
                <SelectParameters>
                    <asp:Parameter Name="ID_PROVINCIA_PRO" Type="Int32" DefaultValue="-1" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                ConnectionString="<%$ ConnectionStrings:MedicalStudioConnectionString %>" 
                SelectCommand="SELECT ID_ESPECIALIDAD_ESP, NOMBRE_ESP FROM [ESPECIALIDADES]">
            </asp:SqlDataSource>
    </div>
    </div>
    </form>
</body>
</html>
