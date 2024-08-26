<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2B.aspx.cs" Inherits="TP2_Grupo_Nro_XX.Ejercicio2B" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <div style="margin-left: 40px">
            <asp:Label ID="lblResumen" runat="server" Font-Bold="True" Font-Size="27pt" style="font-family: Impact" Text="Resumen"></asp:Label>
        </div>
        <p style="margin-left: 40px">
            <asp:Label Font-Size="15pt" ID="lblNombre" runat="server"></asp:Label>
            &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label Font-Size="15pt" ID="lblNombreNegrita" runat="server" Font-Bold="True" style="font-family: Cooper"></asp:Label>
        </p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label Font-Size="15pt" ID="lblApellido" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label Font-Size="15pt" ID="lblApellidoNegrita" runat="server" Font-Bold="True" style="font-family: Cooper"></asp:Label>
        &nbsp;<p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label Font-Size="15pt" ID="lblZona" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label Font-Size="15pt" ID="lblZonaNegrita" runat="server" Font-Bold="True" style="font-family: Cooper"></asp:Label>
        </p>
        <p style="margin-left: 40px">
            <asp:Label Font-Size="15pt" ID="lblTemas" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label Font-Size="15pt" ID="lblTemasNegrita" runat="server" Font-Bold="True" style="font-family: Cooper"></asp:Label>
        </p>
    </form>
</body>
</html>
