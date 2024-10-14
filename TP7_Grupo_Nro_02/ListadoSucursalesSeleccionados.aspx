<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoSucursalesSeleccionados.aspx.cs" Inherits="TP7_Grupo_Nro_02.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="Styles/main.css" />
    <title>Sucursal seleccionado</title>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="nav">
            <h1>Listado de sucursales</h1>
            <ul class="nav-links">
                <li class="nav-item">
                    <asp:HyperLink ID="HyperLink3" runat="server" CssClass="btn" NavigateUrl="~/SeleccionarSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                </li>
                <li class="nav-item">
                    <asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn" NavigateUrl="~/ListadoSucursalesSeleccionados.aspx">Mostrar Sucursales Seleccionadas</asp:HyperLink>
                </li>
            </ul>
        </nav>

        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
