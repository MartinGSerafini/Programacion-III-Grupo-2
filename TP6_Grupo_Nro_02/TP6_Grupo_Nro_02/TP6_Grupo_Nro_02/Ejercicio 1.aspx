<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio 1.aspx.cs" Inherits="TP6_Grupo_Nro_02.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 159px;
        }
        .auto-style2 {
            width: 169px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
        <tr>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style2" style="font-size: 37px;"><strong>Productos</strong></td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
        </tr>
        </table>
        <asp:GridView ID="GrdProductos" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
