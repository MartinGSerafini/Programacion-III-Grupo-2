<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="TP8_Grupo_Nro_02.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Agregar Sucutsales</title>
    <link rel="stylesheet" type="text/css" href="main.css" />
</head>
<body>
    <nav>
    <h2>Grupo N2</h2>
        <ul>
            <li class="button"><a href="~/Formularios/AgregarSucursal.aspx">Agregar Sucursal</a></li>
            <li class="button"><a href="~/Formularios/ListadoDeSucursales.aspx">Lista de Sucursales</a></li>
            <li class="button"><a href="~/Formularios/EliminarSucursal.aspx">Eliminar Sucursal</a></li>
        </ul>
    </nav>


<section class="layout">
    <h1>Agregar Sucursal</h1>
    <form id="formAgregarSucursal" runat="server">
        <div class="form-section">
            <label for="txtNombreSucursal">Nombre Sucursal:</label>
            <asp:TextBox ID="txtNombreSucursal" runat="server" CssClass="input"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvNombreSucursal" runat="server" ControlToValidate="txtNombreSucursal" ErrorMessage="Debe Ingresar un Nombre de Sucursal" ForeColor="Red" ValidationGroup="vg1">*</asp:RequiredFieldValidator>
        </div>

        <div class="form-section">
            <label for="txtDescripcion">Descripción:</label>
            <asp:TextBox ID="txtDescripcion" runat="server"  CssClass="input desc"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="Debe Ingresar una Descripción de Sucursal" ForeColor="Red" ValidationGroup="vg1">*</asp:RequiredFieldValidator>
        </div>

        <div class="form-section">
            <label for="ddlProvincia">Provincia:</label>
            <asp:DropDownList ID="ddlProvincia" runat="server" CssClass="dropdown"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="Rfv" runat="server" ControlToValidate="ddlProvincia" ErrorMessage="Debe Seleccionar una Provincia" ForeColor="Red" InitialValue="0" ValidationGroup="vg1">*</asp:RequiredFieldValidator>
        </div>

        <div class="form-section">
            <label for="txtDireccion">Dirección:</label>
            <asp:TextBox ID="txtDireccion" runat="server" CssClass="input"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDireccion" ErrorMessage="Debe Ingresar una Dirección de Sucursal" ForeColor="Red" ValidationGroup="vg1">*</asp:RequiredFieldValidator>
        </div>

        <div class="form-submit">
            <asp:Button ID="btnAceptar" runat="server" CcsClass="button" Text="Aceptar" OnClick="btnAceptar_Click" ValidationGroup="vg1" CssClass="button" />
            <asp:Label ID="lblconfirmacion" runat="server" Text="La Sucursal fue agregada con éxito" Visible="False"></asp:Label>
        </div>

        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="vg1" />
    </form>
</section>

</body>
</html>
