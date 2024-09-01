<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio5.aspx.cs" Inherits="TP2_Grupo_Nro_XX.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="main.css" />
    <title>Ejercicio 5, calculo de precios
    </title>
</head>
<body>
    <form id="form1" class="ej5" runat="server">
        <div class="wrapper">
            <h1 class="subtitle">
            <asp:Label ID="lblElijaConfiguración" runat="server" Font-Size="X-Large" Text="Elija su Configuración" Font-Bold="True"></asp:Label>
            </h1>
            <div class="data-box">
            <asp:Label ID="lblSelecMemoria" runat="server" CssClass="subtitle" Text="Seleccione cantidad de memoria:"></asp:Label>
            <asp:DropDownList ID="Ddlist" runat="server" AutoPostBack="True" CssClass="dropdown">
                <asp:ListItem Value="0">2GB</asp:ListItem>
                <asp:ListItem Value="1">4GB</asp:ListItem>
                <asp:ListItem Value="2">6GB</asp:ListItem>
            </asp:DropDownList>
            </div>
            <div class="data-box">
            <asp:Label ID="lblSelecAccesorios" runat="server" CssClass="subtitle" Text="Seleccione accesorios:"></asp:Label>
            <asp:CheckBoxList ID="Cblist" runat="server" AutoPostBack="True" RepeatLayout="Flow" CssClass="cList">
                <asp:ListItem Value="0">Monitor LCD</asp:ListItem>
                <asp:ListItem Value="1">HD 500GB</asp:ListItem>
                <asp:ListItem Value="2">Grabador DVD</asp:ListItem>
            </asp:CheckBoxList>
            </div>
            <div class="btn-container">
            <asp:Button ID="Btncalcular" runat="server" Text="Calcular Precio" OnClick="Btncalcular_Click" CssClass="btn" />
            </div>
            <asp:Label ID="lblPrecioFinal" runat="server" Font-Bold="True"></asp:Label>
        </div>
    </form>
</body>
</html>
