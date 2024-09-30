<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="TP6_Grupo_Nro_02.Ejercicio1a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 46px;
        }
        .auto-style2 {
            height: 30px;
        }
        .auto-style3 {
            height: 4px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style3"></td>
    </tr>
    <tr>
        <td class="auto-style1" style="font-size: 37px;"><strong>GRUPO N2</strong></td>
    </tr>
    <tr>
        <td class="auto-style2"></td>
    </tr>
    <tr>
        <td class="auto-style2" style="font-size: 21px;">
            <asp:HyperLink ID="Hlink1" runat="server" NavigateUrl="~Ejercicio 1.aspx">Ejercicio 1</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="auto-style2"></td>
    </tr>
    <tr>
        <td class="auto-style2" style="font-size: 21px;">
            <asp:HyperLink ID="Hlink2" runat="server" NavigateUrl="~Ejercicio 2.aspx">Ejercicio 2</asp:HyperLink>
        </td>
    </tr>
    
</table>
    </form>
</body>
</html>
