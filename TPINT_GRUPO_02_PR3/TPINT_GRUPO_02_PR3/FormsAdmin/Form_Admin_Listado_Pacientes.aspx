<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form_Admin_Listado_Pacientes.aspx.cs" Inherits="TPINT_GRUPO_02_PR3.Form_Admin_Listado_Pacientes" %>

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
        height: 100vh;
    }

    /* Encabezado */
    .header {
        background-color: #3A104D;
        padding: 20px;
        width: 100%;
        display: flex;
        justify-content: space-between;
        align-items: center;
        box-shadow: 0px 4px 10px rgba(0, 0, 0, 0.3);
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

    .menu-dropdown ul{
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

    /* Contenedor principal */
    .container {
        background-color: #6C2C91;
        padding: 60px;
        border-bottom-left-radius: 15px;
        border-bottom-right-radius: 15px;
        width: 600px;
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
    .auto-style1 {
        background-color: #3A104D;
        padding: 20px;
        width: 95%;
        display: flex;
        justify-content: space-between;
        align-items: center;
        box-shadow: 0px 4px 10px rgba(0, 0, 0, 0.3);
        border-top-left-radius: 15px;
        border-top-right-radius: 15px;
    }
            .auto-style62 {
                width: 232px;
                height: 61px;
            }
            .auto-style63 {
                width: 128px;
                height: 61px;
            }
            .auto-style64 {
                width: 84px;
                height: 61px;
            }
            .auto-style70 {
                width: 231px;
                height: 61px;
            }
            .auto-style72 {
                width: 722px;
            }
            .auto-style73 {
                width: 225px;
                height: 61px;
            }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <div class="menu-left">
                <img src="../Imagenes/Logo_MS.png" alt="Logo" />
                <div class="menu-dropdown">
                    <button>☰</button>
                    <ul>
                        <li><a href="../FormsAdmin/Form_Admin_Listado_Pacientes.aspx">PACIENTES</a></li>
                        <li><a href="#">TURNOS</a></li>
                        <li><a href="#">MEDICOS</a></li>
                        <li><a href="#">REPORTES</a></li>
                        <li><a href="<%= ResolveUrl("~/FormsLogins/Form_Login.aspx") %>">CERRAR SESIÓN</a></li>
                    </ul>
                </div>
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
        <table class="auto-style72">
            <tr>
                Listado de pacientes                
                <td class="auto-style62">
                    <asp:TextBox ID="txtBuscador" Style="font-weight: bold; font-size: 15px" runat="server" Width="220px" Height="20px"></asp:TextBox>
                </td>
                <td class="auto-style63">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                </td>
                <td class="auto-style64">
                    <asp:Label ID="Label1" Style="font-weight: bold; font-size: 15px" runat="server" Text="Filtrar por: "></asp:Label>
                </td>
                <td class="auto-style70">
                    <asp:DropDownList ID="ddlFiltros" runat="server" Height="23px" Width="226px">
                        <asp:ListItem>SELECCIONE UNA CATEGORIA</asp:ListItem>
                        <asp:ListItem Value="P.DNI_PAS">DNI</asp:ListItem>
                        <asp:ListItem Value="P.NOMBRE_PAS">NOMBRE</asp:ListItem>
                        <asp:ListItem Value="P.APELLIDO_PAS">APELLIDO</asp:ListItem>
                        <asp:ListItem Value="P.SEXO_PAS">SEXO</asp:ListItem>
                        <asp:ListItem Value="P.NACIONALIDAD_PAS">NACIONALIDAD</asp:ListItem>
                        <asp:ListItem Value="P.NACIMIENTO_PAS">FECHA DE NACIMIENTO</asp:ListItem>
                        <asp:ListItem Value="P.DIRECCION_PAS">DIRECCIÓN</asp:ListItem>
                        <asp:ListItem Value="L.NOMBRE_LOC">LOCALIDAD</asp:ListItem>
                        <asp:ListItem Value="PRO.NOMBRE_PRO">PROVINCIA</asp:ListItem>
                        <asp:ListItem Value="P.EMAIL_PAS">EMAIL</asp:ListItem>
                        <asp:ListItem Value="P.TELEFONO_PAS">TELEFONO</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <asp:GridView ID="GrdPacientes" runat="server" AutoGenerateColumns="False" OnRowDeleting="GrdPacientes_RowDeleting" OnRowEditing="GrdPacientes_RowEditing" OnRowCancelingEdit="GrdPacientes_RowCancelingEdit" OnRowUpdating="GrdPacientes_RowUpdating">
            <Columns>
                <asp:TemplateField HeaderText="DNI">
                    <EditItemTemplate>
                        <asp:Label ID="lblDNI" runat="server" Text='<%# Bind("DNI_PAS") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_DNI" runat="server" Text='<%# Bind("DNI_PAS") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtNombre" runat="server" Text='<%# Bind("NOMBRE_PAS") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Nombre" runat="server" Text='<%# Bind("NOMBRE_PAS") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Apellido">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtApellido" runat="server" Text='<%# Bind("APELLIDO_PAS") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Apellido" runat="server" Text='<%# Bind("APELLIDO_PAS") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sexo">
                    <EditItemTemplate>
                        <asp:DropDownList ID="ddlSexo" runat="server" SelectedValue='<%# Bind("SEXO_PAS") %>'>
                            <asp:ListItem>F</asp:ListItem>
                            <asp:ListItem>M</asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Sexo" runat="server" Text='<%# Bind("SEXO_PAS") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nacionalidad">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtNacionalidad" runat="server" Text='<%# Bind("NACIONALIDAD_PAS") %>' TextMode="Date"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Nacionalidad" runat="server" Text='<%# Bind("NACIONALIDAD_PAS") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nacimiento">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtNacimiento" runat="server" Text='<%# Bind("NACIMIENTO_PAS") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Nacimiento" runat="server" Text='<%# Bind("NACIMIENTO_PAS") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Dirección">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtDireccion" runat="server" Text='<%# Bind("DIRECCION_PAS") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Direccion" runat="server" Text='<%# Bind("DIRECCION_PAS") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

<asp:TemplateField HeaderText="Provincia">
    <EditItemTemplate>
        <asp:DropDownList ID="ddlProvincias" runat="server" AutoPostBack="True" AppendDataBoundItems="True" 
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
        <asp:DropDownList ID="ddlLocalidades" runat="server" DataSourceID="SqlDataSource2" DataTextField="NOMBRE_LOC" DataValueField="ID_LOCALIDAD_LOC">
            <asp:ListItem Text="Seleccione una Localidad" Value="-1" />
        </asp:DropDownList>
    </EditItemTemplate>
    <ItemTemplate>
        <asp:Label ID="lbl_it_Localidad" runat="server" Text='<%# Bind("NOMBRE_LOC") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>
                <asp:TemplateField HeaderText="Email">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEmail" runat="server" Text='<%# Bind("EMAIL_PAS") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Email" runat="server" Text='<%# Bind("EMAIL_PAS") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Telefono">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtTelefono" runat="server" Text='<%# Bind("TELEFONO_PAS") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Telefono" runat="server" Text='<%# Bind("TELEFONO_PAS") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ButtonType="Button" ShowEditButton="True" />
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:MedicalStudioConnectionString %>" 
            SelectCommand="SELECT ID_PROVINCIA_PRO, NOMBRE_PRO FROM [PROVINCIAS]">
        </asp:SqlDataSource>

        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:MedicalStudioConnectionString %>" 
            SelectCommand="SELECT ID_LOCALIDAD_LOC, NOMBRE_LOC FROM [LOCALIDADES] WHERE FK_ID_PROVINCIA_LOC = @ID_PROVINCIA_PRO">
            <SelectParameters>
                <asp:Parameter Name="ID_PROVINCIA_PRO" Type="Int32" DefaultValue="-1" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
