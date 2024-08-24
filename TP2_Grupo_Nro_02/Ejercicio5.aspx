<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio5.aspx.cs" Inherits="TP2_Grupo_Nro_XX.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblElijaConfiguración" runat="server" Font-Size="X-Large" Text="Elija su Configuración" Font-Bold="True"></asp:Label>
            <br />
            &nbsp;
            <br />
&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            Seleccione cantidad de memoria:<br />
            &nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="Ddlist" runat="server" AutoPostBack="True" Height="18px" Width="92px">
                <asp:ListItem Value="0">2GB</asp:ListItem>
                <asp:ListItem Value="1">4GB</asp:ListItem>
                <asp:ListItem Value="2">6GB</asp:ListItem>
            </asp:DropDownList>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Selecioone accesorios:<br />
            &nbsp;<asp:CheckBoxList ID="Cblist" runat="server" AutoPostBack="True">
                <asp:ListItem Value="0">Monitor LCD</asp:ListItem>
                <asp:ListItem Value="1">HD 500GB</asp:ListItem>
                <asp:ListItem Value="2">Grabador DVD</asp:ListItem>
            </asp:CheckBoxList>
            &nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btncalcular" runat="server" Text="Calcular Precio" OnClick="Btncalcular_Click" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblPrecioFinal" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
