<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="TP2_Grupo_Nro_XX.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;<asp:Label ID="lblElijaConfiguración" runat="server" Font-Size="X-Large" Text="Elija su Configuración"></asp:Label>
            <br />
            <br />
&nbsp;
            <br />
            Seleccione cantidad de memoria:<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                <asp:ListItem Value="200">2GB</asp:ListItem>
                <asp:ListItem Value="375">4GB</asp:ListItem>
                <asp:ListItem Value="500">6GB</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <br />
&nbsp; Selecioone accesorios:<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
                <asp:ListItem Value="2000,50">MonitorLCD</asp:ListItem>
                <asp:ListItem Value="550,50">HD 500GB</asp:ListItem>
                <asp:ListItem Value="1200">Grabador DVD</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            <br />
&nbsp;
            <asp:Button ID="lblCalcularPrecio" runat="server" Text="Calcular Precio" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblPrecioFinal" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
