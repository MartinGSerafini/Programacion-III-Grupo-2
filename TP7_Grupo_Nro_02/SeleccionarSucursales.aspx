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
        .auto-style41 {
            width: 309px;
        }
        .auto-style43 {
            width: 380px;
        }
        .auto-style45 {
            width: 217px;
        }
        .auto-style46 {
            width: 214px;
        }
        .auto-style48 {
            width: 272px;
        }
        </style>
</head>
<body>
    <form id="form2" runat="server">
        <table class="Links">
            <tr>
                <td class="auto-style46">&nbsp;</td>
                <td class="auto-style43">
                    <asp:HyperLink ID="HyperLink3" runat="server" Font-Bold="True" Font-Size="14pt" NavigateUrl="~/SeleccionarSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                <td>
                    <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" Font-Size="14pt" NavigateUrl="~/ListadoSucursalesSeleccionados.aspx">Mostrar Sucursales Seleccionadas</asp:HyperLink>
                    </td>
            </tr>
        </table>
        <table class="Titulo y Busqueda">
            <tr>
                <td class="auto-style45">&nbsp;</td>
                <td class="auto-style41">&nbsp;</td>
                <td class="auto-style48">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style45">&nbsp;</td>
                <td class="auto-style41" style="font-weight: bold;font-size: 25px">Listado de sucursales<br />
                    <br />
                </td>
                <td class="auto-style48">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style45">&nbsp;</td>
                <td class="auto-style41">Busqueda por nombre de sucursal:</td>
                <td class="auto-style48">
        <asp:TextBox ID="txtSucursal" runat="server" Width="250px"></asp:TextBox>
                </td>
                <td>
        <asp:Button ID="BtnBuscar" runat="server" ClientIDMode="AutoID" Text="Buscar" Width="76px" OnClick="BtnBuscar_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style45">&nbsp;</td>
                <td class="auto-style41">
                    <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:BDSucursalesConnectionString %>" SelectCommand="SELECT [NombreSucursal], [DescripcionSucursal], [URL_Imagen_Sucursal], [Id_Sucursal] FROM [Sucursal]"></asp:SqlDataSource>
                </td>
                <td class="auto-style48">
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDSucursalesConnectionString %>" SelectCommand="SELECT DISTINCT [DescripcionProvincia] FROM [Provincia]"></asp:SqlDataSource>
                 </td>
                <td>&nbsp;</td>
            </tr>
        </table>
            <div style="display: flex; justify-content: flex-start;">
                <table class="Botones">
            <tr>
                <td>
                     <asp:DataList ID="DlProvincias" runat="server" DataSourceID="SqlDataSource1">
                         <ItemTemplate>
                             <asp:Button ID="btnProvincias" runat="server" Text='<%# Bind("DescripcionProvincia") %>' Width="250px" CommandArgument='<%# Bind("DescripcionProvincia") %>' CommandName="ComandoBoton" Height="40px" OnCommand="btnProvincias_Command" />
                             <br />
                             <br />
                             <br />
                         </ItemTemplate>
                     </asp:DataList>
                 </td>
                <td>
                     &nbsp;</td>
            </tr>
            </table>
        <table class="ListView" style="width: auto;">
            <tr>
                <td class="auto-style1" rowspan="7">
                    <asp:ListView ID="lvSucursales" runat="server" DataSourceID="SqlDataSource" GroupItemCount="3" OnPagePropertiesChanging="lvSucursales_PagePropertiesChanging">
                        <EditItemTemplate>
                            <td runat="server" style="background-color: #999999;">NombreSucursal:
                                <asp:TextBox ID="NombreSucursalTextBox" runat="server" Text='<%# Bind("NombreSucursal") %>' style="text-align: center; font-weight: bold;"/>
                                <br />
                                DescripcionSucursal:
                                <asp:TextBox ID="DescripcionSucursalTextBox" runat="server" Text='<%# Bind("DescripcionSucursal") %>' style="text-align: center; font-weight: bold;"/>
                                <br />
                                URL_Imagen_Sucursal:
                                <asp:TextBox ID="URL_Imagen_SucursalTextBox" runat="server" Text='<%# Bind("URL_Imagen_Sucursal") %>' style="text-align: center;"/>
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
                                <asp:TextBox ID="DescripcionSucursalTextBox" runat="server" Text='<%# Bind("DescripcionSucursal") %>'/>
                                <br />
                                URL_Imagen_Sucursal:
                                <asp:TextBox ID="URL_Imagen_SucursalTextBox" runat="server" Text='<%# Bind("URL_Imagen_Sucursal") %>'/>
                                <br />
                                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
                                <br />
                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" />
                                <br />
                            </td>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <td runat="server" style="background-color: #E0FFFF; color: #333333; padding: 10px; border: none;">
                            <div style="display: flex; flex-direction: column; align-items: center; height: 100%;">
                            <asp:Label ID="lblNombreSucursal" runat="server" Text='<%# Eval("NombreSucursal") %>' 
                                 style="font-weight: bold; margin-bottom: 5px; text-align: center;" />
                            <div style="display: flex; justify-content: center; align-items: center; width: 200px; height: 200px; overflow: hidden; margin: 0 auto; padding: 0; border: none;">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%# Bind("URL_Imagen_Sucursal") %>' 
                                 style="width: 100%; height: auto; max-height: 100%; object-fit: cover; border: none;" />
                            </div>
                            <asp:Label ID="lblDescripcionSucursal" runat="server" Text='<%# Bind("DescripcionSucursal") %>' 
                                 style="font-weight: normal; display: block; overflow: hidden; white-space: normal; width: 200px; margin: 5px 0; line-height: 1.5; height: 120px; text-align: center; text-overflow: ellipsis;" />
                            <div style="display: flex; justify-content: center; width: 100%;">
                            <asp:Button ID="btnSeleccionar" runat="server" Text="Seleccionar" CommandName="eventoSeleccionar" OnCommand="btnSeleccionar_Command" style="margin-top: 10px;" CommandArgument='<%# Eval("Id_Sucursal")+"|"+Eval("NombreSucursal")+"|"+Eval("DescripcionSucursal") %>' />
                            </div>
                            </div>
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
        </table>
            </div>
    </form>
        </body>
</html>