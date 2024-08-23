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
        <asp:Label ID="lblResumen" runat="server" Font-Bold="True" Font-Size="24pt" Text="Resumen"></asp:Label>
        <p>
            <asp:Label ID="lblNombre" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblNombreNegrita" runat="server" Font-Bold="True"></asp:Label>
        </p>
        <asp:Label ID="lblApellido" runat="server"></asp:Label>
        &nbsp;&nbsp;
        <asp:Label ID="lblApellidoNegrita" runat="server" Font-Bold="True"></asp:Label>
        &nbsp;<p>
            <asp:Label ID="lblZona" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblZonaNegrita" runat="server" Font-Bold="True"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblTemas" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblTemasNegrita" runat="server" Font-Bold="True"></asp:Label>
        </p>
    </form>
</body>
</html>
