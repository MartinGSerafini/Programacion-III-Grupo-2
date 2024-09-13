<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="Programacion3_Grupo2_TP4.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 89px;
        }
        .auto-style3 {
            width: 151px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Id Producto:<br />
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DdlProducto" runat="server" AutoPostBack="True" Width="141px">
                        <asp:ListItem>Igual a:</asp:ListItem>
                        <asp:ListItem>Mayor a:</asp:ListItem>
                        <asp:ListItem>Menor a:</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                </td>
                <td>
                    <asp:TextBox ID="TxbProducto" runat="server" Width="240px"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Id Categoria:<br />
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DdlCategoria" runat="server" AutoPostBack="True" Width="141px">
                        <asp:ListItem>Igual a:</asp:ListItem>
                        <asp:ListItem>Mayor a:</asp:ListItem>
                        <asp:ListItem>Menor a:</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                </td>
                <td>
                    <asp:TextBox ID="TxbCategoria" runat="server" Width="240px"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnQuitar" runat="server" Text="Quitar filtro" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="grdProductos" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
