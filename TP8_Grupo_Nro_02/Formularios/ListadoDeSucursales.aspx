<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoDeSucursales.aspx.cs" Inherits="TP8_Grupo_Nro_02.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" type="text/css" href="main.css" />
</head>
<body>
    <div>
        <nav>
            <h2>Listado de sucursales</h2>
            <ul>
                <li class="button">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Formularios/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                </li>
                <li class="button">
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Formularios/ListadoDeSucursales.aspx">Lista de Sucursales</asp:HyperLink>
                </li>
                <li class="button">
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Formularios/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                </li>
            </ul>
        </nav>
    </div>

    <form id="form2" runat="server" class="layout ls">
        <div class="form-section">
            <asp:TextBox ID="txtid_sucursal" runat="server" ValidationGroup="1" CssClass="input" placeholder=" Ingrese un ID de Sucursal"></asp:TextBox>
            <div class="button-container">
                <asp:Button ID="btnfiltrar" runat="server" Text="Filtrar" CcsClass="button" OnClick="btnfiltrar_Click" ValidationGroup="vg1" CssClass="button" />
                <asp:Button ID="btnMostrarTodos" runat="server" Text="Mostrar Todos" OnClick="btnMostrarTodos_Click" ValidationGroup="2" CssClass="button" />
                <asp:Label ID="LblSucursal" runat="server" ForeColor="Red" Visible="False" Font-Bold="True">No se encontró el ID de Sucursal</asp:Label>

            </div>
            <asp:RequiredFieldValidator ID="CvSucursal" runat="server" ControlToValidate="txtid_sucursal" ForeColor="Red" ValidationGroup="vg1" ErrorMessage="Debe Ingrese un ID de Sucursal">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="Evsucursal" runat="server" ControlToValidate="txtid_sucursal" ForeColor="Red" ValidationExpression="^\d+$" ErrorMessage="Solo se permiten numeros" ValidationGroup="vg1">*</asp:RegularExpressionValidator>
        </div>
        <asp:GridView ID="Gvsucursales" runat="server" CssClass="table">
        </asp:GridView>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="vg1" />
    </form>
</body>
</html>
