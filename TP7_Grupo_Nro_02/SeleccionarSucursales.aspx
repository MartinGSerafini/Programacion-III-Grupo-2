<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarSucursales.aspx.cs" Inherits="TP7_Grupo_Nro_02.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style13 {
            height: 26px;
        }
        .auto-style14 {
            width: 77px;
            height: 26px;
        }
        .auto-style15 {
            width: 438px;
        }
        .auto-style16 {
            height: 26px;
            width: 438px;
        }
        .auto-style17 {
            width: 438px;
            height: 45px;
        }
        .auto-style22 {
            height: 69px;
            width: 21px;
        }
        .auto-style23 {
            height: 81px;
            width: 21px;
        }
        .auto-style24 {
            height: 73px;
            width: 21px;
        }
        .auto-style25 {
            height: 94px;
            width: 21px;
        }
        .auto-style26 {
            height: 86px;
            width: 21px;
        }
        .auto-style27 {
            height: 85px;
            width: 21px;
        }
        .auto-style28 {
            height: 80px;
            width: 21px;
        }
        .auto-style29 {
            width: 412px;
        }
        .auto-style32 {
            width: 204px;
            height: 26px;
        }
        .auto-style33 {
            width: 311px;
            height: 45px;
        }
        .auto-style34 {
            width: 306px;
        }
        .auto-style35 {
            width: 311px;
            height: 26px;
        }
        .auto-style36 {
            width: 311px;
        }
        </style>
</head>
<body>
    <form id="form2" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style33">
                    <asp:HyperLink ID="HyperLink3" runat="server" Font-Bold="True" Font-Size="14pt" NavigateUrl="~/SeleccionarSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                <td class="auto-style17">
                    <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" Font-Size="14pt" NavigateUrl="~/ListadoSucursalesSeleccionados.aspx">Mostrar Sucursales Seleccionadas</asp:HyperLink>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style36">
                    <h1 class="auto-style29">Listado de sucursales<br />
                    </h1>
                </td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
           <tr>
    <td class="auto-style35">Busqueda por nombre de sucursal:</td>
    <td class="auto-style16">
        <asp:TextBox ID="txtSucursal" runat="server" Width="407px"></asp:TextBox>
    </td>
    <td class="auto-style14">
        <asp:Button ID="BtnBuscar" runat="server" ClientIDMode="AutoID" Text="Buscar" Width="76px" />
    </td>
    <td class="auto-style13"></td>
</tr>
            <tr>
                <td class="auto-style36">&nbsp;</td>
                <td class="auto-style32">
                    <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:BDSucursalesConnectionString %>" SelectCommand="SELECT [NombreSucursal], [DescripcionSucursal], [URL_Imagen_Sucursal] FROM [Sucursal]"></asp:SqlDataSource>
                </td>
            </tr>
            </table>
        <table class="auto-style1">
            <tr>
                 <td class="auto-style22">
                     <asp:Button ID="btnBuenosAires" runat="server" Text="Buenos Aires" Width="180px" />
                 </td>
                 <td class="auto-style34" rowspan="7">
                    <asp:ListView ID="lvSucursales" runat="server" DataSourceID="SqlDataSource" GroupItemCount="3">
                        <%--<AlternatingItemTemplate>
                            <td runat="server" style="background-color: #FFFFFF;color: #284775;">
                                <asp:Label ID="lblNombreSucursal" runat="server" Text='<%# Eval("NombreSucursal") %>' />
                                <br />
                                <asp:Label ID="lblDescripcionSucursal" runat="server" Text='<%# Bind("DescripcionSucursal") %>'></asp:Label>
                                <br />
                                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl='<%# Bind("URL_Imagen_Sucursal") %>' />
                                <br />
                            </td>
                        </AlternatingItemTemplate>--%>
                        <EditItemTemplate>
                            <td runat="server" style="background-color: #999999;">NombreSucursal:
                                <asp:TextBox ID="NombreSucursalTextBox" runat="server" Text='<%# Bind("NombreSucursal") %>' />
                                <br />
                                DescripcionSucursal:
                                <asp:TextBox ID="DescripcionSucursalTextBox" runat="server" Text='<%# Bind("DescripcionSucursal") %>' />
                                <br />
                                URL_Imagen_Sucursal:
                                <asp:TextBox ID="URL_Imagen_SucursalTextBox" runat="server" Text='<%# Bind("URL_Imagen_Sucursal") %>' />
                                <br />
                                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" />
                                <br />
                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
                                <br />
                            </td>
                        </EditItemTemplate>
                        <EmptyDataTemplate>
                            <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
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
                                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
                                <br />
                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" />
                                <br />
                            </td>
                        </InsertItemTemplate>
    <ItemTemplate>
        <td runat="server" style="background-color: #E0FFFF;color: #333333;">
            <asp:Label ID="lblNombreSucursal" runat="server" Text='<%# Eval("NombreSucursal") %>' />
            <br />
            <asp:Label ID="lblDescripcionSucursal" runat="server" Text='<%# Bind("DescripcionSucursal") %>' />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%# Bind("URL_Imagen_Sucursal") %>' />
            <br />
            <br />
            <asp:Button ID="btnSeleccionar" runat="server" Text="Seleccionar" />
            <br />
        </td>
    </ItemTemplate>
                        <LayoutTemplate>
                            <table runat="server">
                                <tr runat="server">
                                    <td runat="server">
                                        <table id="groupPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                            <tr id="groupPlaceholder" runat="server">
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr runat="server">
                                    <td runat="server" style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF">
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
                            <td runat="server" style="background-color: #E2DED6;font-weight: bold;color: #333333;">NombreSucursal:
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
            <tr>
                 <td class="auto-style23">
                     <asp:Button ID="btnEntreRios" runat="server" Text="Entre Rios" Width="180px" />
                 </td>
            </tr>
            <tr>
                <td class="auto-style24">
                    <asp:Button ID="btnSantaFe" runat="server" Text="Santa Fe" Width="180px" />
                </td>
            </tr>
            <tr>
                 <td class="auto-style25">
                     <asp:Button ID="btnLaPampa" runat="server" Text="La Pampa" Width="180px" />
                 </td>
            </tr>
            <tr>
                 <td class="auto-style26">
                     <asp:Button ID="btnCordoba" runat="server" Text="Cordoba" Width="180px" />
                 </td>
            </tr>
            <tr>
                 <td class="auto-style28">
                     <asp:Button ID="btnMisiones" runat="server" Text="Misiones" Width="180px" />
                 </td>
            </tr>
            <tr>
                 <td class="auto-style27">
                     <asp:Button ID="btnChaco" runat="server" Text="Chaco" Width="180px" />
                 </td>
            </tr>
        </table>
    </form>
        </body>
</html>
