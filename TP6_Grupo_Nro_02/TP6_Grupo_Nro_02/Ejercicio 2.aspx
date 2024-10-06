<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio 2.aspx.cs" Inherits="TP6_Grupo_Nro_02.Ejercicio_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            height: 46px;
        }
        .auto-style3 {
            height: 4px;
        }
        .auto-style2 {
            height: 30px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    <table class="auto-style1">
    <tr>
        <td class="auto-style3"></td>
    </tr>
    <tr>
        <td class="auto-style1" style="font-size: 37px;"><strong>Inicio</strong></td>
    </tr>
    <tr>
        <td class="auto-style2"></td>
    </tr>
    <tr>
        <td class="auto-style2" style="font-size: 21px;">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="Hlink1" runat="server" NavigateUrl="~/SeleccionarProductos.aspx">Seleccionar productos</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="auto-style2" style="font-size: 21px;">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkDelete" runat="server" OnClick="LinkDelete_Click">Eliminar productos seleccionados</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
    </tr>
    <tr>
        <td class="auto-style2" style="font-size: 21px;">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="Hlink2" runat="server" NavigateUrl="~/MostrarProductos.aspx"> Mostrar productos</asp:HyperLink>
        </td>
    </tr>
    
</table>
        </div>
        <p>
            <asp:HyperLink ID="Back" runat="server" NavigateUrl="~/Inicio.aspx">Volver</asp:HyperLink>
        </p>
    </form>
</body>
</html>
