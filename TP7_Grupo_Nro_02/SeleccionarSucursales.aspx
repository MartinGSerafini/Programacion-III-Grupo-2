<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarSucursales.aspx.cs" Inherits="TP7_Grupo_Nro_02.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="Styles/main.css" />
    <title>Seleccionar Sucursales</title>
</head>
<body>
    <form id="form2" runat="server">
        <nav>
            <!-- Título -->
            <div class="title">
                <h1>Listado de Sucursales
                </h1>
            </div>
            <div class="links">
                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/SeleccionarSucursales.aspx" CssClass="btn">Listado de Sucursales</asp:HyperLink>
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ListadoSucursalesSeleccionados.aspx" CssClass="btn">Mostrar Sucursales Seleccionadas</asp:HyperLink>
            </div>

        </nav>

        <div class="search-section">
            <asp:TextBox ID="txtSucursal" runat="server" CssClass="input" placeholder="Ingresa un nombre de sucursal" ></asp:TextBox>
            <asp:Button ID="BtnBuscar" runat="server" Text="Buscar🔎" CssClass="btn" OnClick="BtnBuscar_Click" />
        </div>

        <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:BDSucursalesConnectionString %>" SelectCommand="SELECT [NombreSucursal], [DescripcionSucursal], [URL_Imagen_Sucursal], [Id_Sucursal] FROM [Sucursal]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDSucursalesConnectionString %>" SelectCommand="SELECT DISTINCT [DescripcionProvincia] FROM [Provincia]"></asp:SqlDataSource>

        <div class="province-buttons">
            <asp:DataList ID="DlProvincias" runat="server" DataSourceID="SqlDataSource1">
                <ItemTemplate>
                    <asp:Button ID="btnProvincias" runat="server" CssClass="btn" Text='<%# Bind("DescripcionProvincia") %>'
                        CommandArgument='<%# Bind("DescripcionProvincia") %>' CommandName="ComandoBoton"
                        OnCommand="btnProvincias_Command" />
                </ItemTemplate>
            </asp:DataList>
        </div>


        <table class="ListView">
            <tr>
                <td>
                    <asp:ListView ID="lvSucursales" runat="server" DataSourceID="SqlDataSource" GroupItemCount="3">
                        <LayoutTemplate>
                            <table runat="server" border="1">
                                <tr id="groupPlaceholderContainer" runat="server">
                                    <td id="groupPlaceholder" runat="server"></td>
                                </tr>
                            </table>
                            <asp:DataPager ID="DataPager1" runat="server" PageSize="6" PagedControlID="lvSucursales">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                                    <asp:NumericPagerField />
                                </Fields>
                            </asp:DataPager>
                        </LayoutTemplate>

                        <ItemTemplate>
                            <td>
                                <div class="desc">
                                    <asp:Label ID="lblNombreSucursal" runat="server" Text='<%# Eval("NombreSucursal") %>' />
                                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%# Bind("URL_Imagen_Sucursal") %>' />
                                    <asp:Label ID="lblDescripcionSucursal" runat="server" Text='<%# Bind("DescripcionSucursal") %>' />
                                    <asp:Button ID="btnSeleccionar" runat="server" Text="Seleccionar" CommandName="eventoSeleccionar" OnCommand="btnSeleccionar_Command" CommandArgument='<%# Eval("Id_Sucursal") + "|" + Eval("NombreSucursal") + "|" + Eval("DescripcionSucursal") %>' />
                                </div>
                            </td>
                        </ItemTemplate>

                        <EditItemTemplate>
                            <td>
                                <asp:TextBox ID="NombreSucursalTextBox" runat="server" Text='<%# Bind("NombreSucursal") %>' />
                                <asp:TextBox ID="DescripcionSucursalTextBox" runat="server" Text='<%# Bind("DescripcionSucursal") %>' />
                                <asp:TextBox ID="URL_Imagen_SucursalTextBox" runat="server" Text='<%# Bind("URL_Imagen_Sucursal") %>' />
                                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" CssClass="btn" />
                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" CssClass="btn" />
                            </td>
                        </EditItemTemplate>

                        <EmptyDataTemplate>
                            <table runat="server">
                                <tr>
                                    <td>No se han devuelto datos.</td>
                                </tr>
                            </table>
                        </EmptyDataTemplate>

                        <GroupTemplate>
                            <tr id="itemPlaceholderContainer" runat="server">
                                <td id="itemPlaceholder" runat="server"></td>
                            </tr>
                        </GroupTemplate>

                        <InsertItemTemplate>
                            <td>
                                <asp:TextBox ID="NombreSucursalTextBox" runat="server" Text='<%# Bind("NombreSucursal") %>' />
                                <asp:TextBox ID="DescripcionSucursalTextBox" runat="server" Text='<%# Bind("DescripcionSucursal") %>' />
                                <asp:TextBox ID="URL_Imagen_SucursalTextBox" runat="server" Text='<%# Bind("URL_Imagen_Sucursal") %>' />
                                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" CssClass="btn" />
                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" CssClass="btn" />
                            </td>
                        </InsertItemTemplate>

                        <SelectedItemTemplate>
                            <td>
                                <asp:Label ID="NombreSucursalLabel" runat="server" Text='<%# Eval("NombreSucursal") %>' />
                                <asp:Label ID="DescripcionSucursalLabel" runat="server" Text='<%# Eval("DescripcionSucursal") %>' />
                                <asp:Label ID="URL_Imagen_SucursalLabel" runat="server" Text='<%# Eval("URL_Imagen_Sucursal") %>' />
                            </td>
                        </SelectedItemTemplate>

                    </asp:ListView>
                </td>
            </tr>
        </table>

    </form>
</body>
</html>
