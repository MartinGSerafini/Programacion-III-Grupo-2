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
        .auto-style4 {
            width: 192px;
            height: 45px;
        }
        .auto-style10 {
            width: 192px;
        }
        .auto-style11 {
            width: 192px;
            height: 26px;
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
        .auto-style18 {
            width: 377px;
            height: 45px;
        }
        .auto-style19 {
            width: 377px;
        }
        .auto-style20 {
            height: 26px;
            width: 377px;
        }
        .auto-style22 {
            height: 69px;
        }
        .auto-style23 {
            height: 81px;
        }
        .auto-style24 {
            height: 73px;
        }
        .auto-style25 {
            height: 94px;
        }
        .auto-style26 {
            height: 86px;
        }
        .auto-style27 {
            height: 85px;
        }
        .auto-style28 {
            height: 80px;
        }
        </style>
</head>
<body>
    <form id="form2" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style18">
                    <asp:HyperLink ID="HyperLink3" runat="server" Font-Bold="True" Font-Size="14pt" NavigateUrl="~/SeleccionarSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                    <br />
                    <br />
                </td>
                <td class="auto-style17">
                    <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" Font-Size="14pt" NavigateUrl="~/ListadoSucursalesSeleccionados.aspx">Mostrar Sucursales Seleccionadas</asp:HyperLink>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style19" style="font-weight: bold; font-size: 25pt;">Listado de sucursales<br />
                    <br /></td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">
                <td class="auto-style20" style="font-size: 14pt;">Busqueda por nombre de sucursal:<br /></td>
                    &nbsp;</td>
                <td class="auto-style16">
                    <asp:TextBox ID="txtSucursal" runat="server" Width="407px"></asp:TextBox>
                </td>
                <td class="auto-style14">
                    <asp:Button ID="BtnBuscar" runat="server" ClientIDMode="AutoID" Text="Buscar" Width="76px" />
                </td>
                <td class="auto-style13"></td>
            </tr>
            <tr>
                <td class="auto-style30"></td>
                <td class="auto-style19">
                    <asp:ListView ID="lvSucursales" runat="server" DataSourceID="SqlDataSource">
                    </asp:ListView>
                </td>
                <td class="auto-style32">
                    <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:BDSucursalesConnectionString %>" SelectCommand="SELECT [Id_Sucursal], [NombreSucursal], [DescripcionSucursal], [Id_ProvinciaSucursal], [URL_Imagen_Sucursal] FROM [Sucursal]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                 <td class="auto-style22">
                     <asp:Button ID="btnBuenosAires" runat="server" Text="Buenos Aires" Width="180px" />
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
