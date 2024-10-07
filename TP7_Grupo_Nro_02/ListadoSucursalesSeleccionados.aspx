<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoSucursalesSeleccionados.aspx.cs" Inherits="TP7_Grupo_Nro_02.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 313px;
        }
        .auto-style2 {
            width: 425px;
        }
        </style>
</head>
<body>
    <form id="form2" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Font-Size="14pt" NavigateUrl="~/ListadoSucursalesSeleccionados.aspx">Listado de Sucursales</asp:HyperLink>
                    <br />
                    <br />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" Font-Size="14pt" NavigateUrl="~/SeleccionarSucursales.aspx">Mostrar Sucursales Seleccionadas</asp:HyperLink>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-weight: bold; font-size: 25pt;">Listado de sucursales<br />
                    <br /></td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-size: 14pt;">Busqueda por nombre de sucursal:<br /></td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server" Width="407px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="BtnBuscar" runat="server" ClientIDMode="AutoID" Text="Buscar" Width="76px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
