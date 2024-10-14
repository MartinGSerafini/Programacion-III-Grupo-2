<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarSucursales.aspx.cs" Inherits="TP7_Grupo_Nro_02.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="Styles/main.css" />
    <title>Seleccionar sucursal</title>

</head>
<body>
    <form id="form2" runat="server">
        <nav class="nav">
            <h1>Listado de sucursales</h1>
            <ul class="nav-links">
                <li class="nav-item">
                    <asp:HyperLink ID="HyperLink3" runat="server" CssClass="btn" NavigateUrl="~/SeleccionarSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                </li>
                <li class="nav-item">
                    <asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn" NavigateUrl="~/ListadoSucursalesSeleccionados.aspx">Mostrar Sucursales Seleccionadas</asp:HyperLink>
                </li>
            </ul>
        </nav>
        <section class="search-section">
            <h2>Busqueda por nombre:</h2>
            <asp:TextBox ID="txtSucursal" runat="server" placeholder="Ingresa un nombre de sucursal" CssClass="input"></asp:TextBox>
            <asp:Button ID="BtnBuscar" runat="server" ClientIDMode="AutoID" Text="Buscar" class="btn" OnClick="BtnBuscar_Click" />
            <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:BDSucursalesConnectionString %>" SelectCommand="SELECT [NombreSucursal], [DescripcionSucursal], [URL_Imagen_Sucursal], [Id_Sucursal] FROM [Sucursal]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDSucursalesConnectionString %>" SelectCommand="SELECT DISTINCT [DescripcionProvincia] FROM [Provincia]"></asp:SqlDataSource>
        </section>

        <section class="grid">
            <asp:DataList ID="DlProvincias" runat="server" DataSourceID="SqlDataSource1" CssClass="province-buttons">
                <ItemTemplate>
                    <asp:Button ID="btnProvincias" runat="server" Text='<%# Bind("DescripcionProvincia") %>' CssClass="btn" CommandArgument='<%# Bind("DescripcionProvincia") %>' CommandName="ComandoBoton" OnCommand="btnProvincias_Command" />
                </ItemTemplate>
            </asp:DataList>
            <table class="ListView">
                <tr>
                    <td >
                        <asp:ListView ID="lvSucursales" runat="server" DataSourceID="SqlDataSource" GroupItemCount="3" OnPagePropertiesChanging="lvSucursales_PagePropertiesChanging">
                            <EditItemTemplate>
                                <td runat="server" style="background-color: #080f24;">NombreSucursal:
                                <asp:TextBox ID="NombreSucursalTextBox" runat="server" Text='<%# Bind("NombreSucursal") %>' Style="text-align: center; font-weight: bold;" />
                                    <br />
                                    DescripcionSucursal:
                                <asp:TextBox ID="DescripcionSucursalTextBox" runat="server" Text='<%# Bind("DescripcionSucursal") %>' Style="text-align: center; font-weight: bold;" />
                                    <br />
                                    URL_Imagen_Sucursal:
                                <asp:TextBox ID="URL_Imagen_SucursalTextBox" runat="server" Text='<%# Bind("URL_Imagen_Sucursal") %>' Style="text-align: center;" />
                                    <br />
                                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" />
                                    <br />
                                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
                                    <br />
                                </td>
                            </EditItemTemplate>
                            <EmptyDataTemplate>
                                <table runat="server" style="background-color: #080f24; border-collapse: collapse; border-style: none;">
                                    <tr>
                                        <td>No se han devuelto datos.</td>
                                    </tr>
                                </table>
                            </EmptyDataTemplate>
                            <EmptyItemTemplate>
                                <td runat="server" />
                            </EmptyItemTemplate>
                            <GroupTemplate>
                                <tr id="itemPlaceholderContainer" runat="server">
                                    <td id="itemPlaceholder" runat="server"></td>
                                </tr>
                            </GroupTemplate>
                            <InsertItemTemplate>
                                <td runat="server" style="">NombreSucursal:
                                <asp:TextBox ID="NombreSucursalTextBox" runat="server" Text='<%# Bind("NombreSucursal") %>' />
                                    <br />
                                    DescripcionSucursal:
                                <asp:TextBox ID="DescripcionSucursalTextBox" runat="server" Text='<%# Bind("DescripcionSucursal") %>' />
                                    <br />
                                    URL_Imagen_Sucursal:
                                <asp:TextBox ID="URL_Imagen_SucursalTextBox" runat="server" Text='<%# Bind("URL_Imagen_Sucursal") %>' />
                                    <br />
                                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" CssClass="btn insert" Text="Insertar" />
                                    <br />
                                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" CssClass="btn cancel" Text="Borrar" />
                                    <br />
                                </td>
                            </InsertItemTemplate>
                            <ItemTemplate>
                                <td runat="server" class="Item-hover" style="background-color: #080f24; color: #fff; padding: 10px; border: none;">
                                    <div style="display: flex; flex-direction: column; align-items: center; height: 100%;">
                                        <asp:Label ID="lblNombreSucursal" runat="server" Text='<%# Eval("NombreSucursal") %>'
                                            Style="font-weight: bold; margin-bottom: 5px; text-align: center;" />
                                        <div style="display: flex; justify-content: center; align-items: center; width: 200px; height: 200px; overflow: hidden; margin: 0 auto; padding: 0; border: none;">
                                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%# Bind("URL_Imagen_Sucursal") %>'
                                                Style="width: 100%; height: auto; max-height: 100%; object-fit: cover; border: none;" />
                                        </div>
                                        <asp:Label ID="lblDescripcionSucursal" runat="server" Text='<%# Bind("DescripcionSucursal") %>'
                                            Style="font-weight: normal; display: block; overflow: hidden; white-space: normal; width: 200px; margin: 5px 0; line-height: 1.5; height: 120px; text-align: center; text-overflow: ellipsis;" />
                                        <div style="display: flex; justify-content: center; width: 100%;">
                                            <asp:Button ID="btnSeleccionar" runat="server" Text="Seleccionar" CommandName="eventoSeleccionar" OnCommand="btnSeleccionar_Command" CssClass="btn" CommandArgument='<%# Eval("Id_Sucursal")+"|"+Eval("NombreSucursal")+"|"+Eval("DescripcionSucursal") %>' />
                                        </div>
                                    </div>
                                </td>
                            </ItemTemplate>
                            <LayoutTemplate>
                                <table runat="server">
                                    <tr runat="server">
                                        <td runat="server">
                                            <table id="groupPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px; font-family: Verdana, Arial, Helvetica, sans-serif;">
                                                <tr id="groupPlaceholder" runat="server">
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr runat="server">
                                        <td runat="server" style="text-align: center; background-color: #5D7B9D; font-family: Verdana, Arial, Helvetica, sans-serif; color: #FFFFFF">
                                            <asp:DataPager ID="DataPager1" runat="server" PageSize="6">
                                                <Fields>
                                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                                    <asp:NumericPagerField />
                                                    <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                                </Fields>
                                            </asp:DataPager>
                                        </td>
                                    </tr>
                                </table>
                            </LayoutTemplate>
                            <SelectedItemTemplate>
                                <td runat="server" style="background-color: #E2DED6; font-weight: bold; color: #333333;">NombreSucursal:
                                <asp:Label ID="NombreSucursalLabel" runat="server" Text='<%# Eval("NombreSucursal") %>' />
                                    <br />
                                    DescripcionSucursal:
                                <asp:Label ID="DescripcionSucursalLabel" runat="server" Text='<%# Eval("DescripcionSucursal") %>' />
                                    <br />
                                    URL_Imagen_Sucursal:
                                <asp:Label ID="URL_Imagen_SucursalLabel" runat="server" Text='<%# Eval("URL_Imagen_Sucursal") %>' />
                                    <br />
                                </td>
                            </SelectedItemTemplate>
                        </asp:ListView>
                    </td>
                </tr>
            </table>
        </section>
    </form>
</body>
</html>
