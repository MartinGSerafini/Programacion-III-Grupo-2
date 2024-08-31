<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2B.aspx.cs" Inherits="TP2_Grupo_Nro_XX.Ejercicio2B" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Ejercicio 2, Resumen</title>
    <link rel="stylesheet" type="text/css" href="main.css" />
</head>
<body >
    <form id="form1" runat="server" class="lblContainer wrapper">

        <h1 class="roboto-black title">
            <asp:Label ID="lblResumen" runat="server" Text="Resumen"></asp:Label>
        </h1>
        <p>
            <asp:Label ID="lblNombre" runat="server"></asp:Label>
            <asp:Label ID="lblNombreNegrita" runat="server" CssClass="roboto-bold"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblApellido" runat="server"></asp:Label>
            <asp:Label ID="lblApellidoNegrita" runat="server" CssClass="roboto-bold"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblZona" runat="server"></asp:Label>
            <asp:Label ID="lblZonaNegrita" runat="server" CssClass="roboto-bold"></asp:Label>
        </p>
        <p class="list-collapse">
            <asp:Label ID="lblTemas" runat="server"></asp:Label>
            <asp:Label ID="lblTemasNegrita" runat="server" CssClass="roboto-bold "></asp:Label>
        </p>
    </form>
</body>
</html>
