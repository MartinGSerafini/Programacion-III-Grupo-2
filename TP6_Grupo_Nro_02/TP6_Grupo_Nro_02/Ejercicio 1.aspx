<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio 1.aspx.cs" Inherits="TP6_Grupo_Nro_02.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="./styles/main.css" />
    <title>Ejercicio 1</title>

</head>
<body>
    <form id="form1" runat="server">
        <h1>Productos</h1>

        <asp:GridView ID="GrdProductos" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
