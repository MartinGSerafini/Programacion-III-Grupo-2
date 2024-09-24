<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursal.aspx.cs" Inherits="TP5_Grupo_Nro_02.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="main.css" />
    <title>Eliminar sucursal</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class="nav">
                <h1 class="lato-bold">Eliminar sucursal</h1>
                <ul>
                    <li class="nav-item">
                        <asp:HyperLink ID="Hlink1" runat="server" NavigateUrl="~/AgregarSucursal.aspx" CssClass="nav-link">
Agregar Sucursal 🔼
                        </asp:HyperLink></li>
                    <li class="nav-item">
                        <asp:HyperLink ID="Hlink2" runat="server" NavigateUrl="~/ListarSucursal.aspx" CssClass="nav-link">
Listado de Sucursales 📚
                        </asp:HyperLink></li>
                    <li class="nav-item">
                        <asp:HyperLink ID="Hlink3" runat="server" NavigateUrl="~/EliminarSucursal.aspx" CssClass="nav-link">
Eliminar Sucursal ❌
                        </asp:HyperLink></li>
                </ul>
            </nav>

        </div>
        <div class="container ej3">
                <section class="form-group">
                    <label for="txtIDSucursal" class="label">Ingresar ID Sucursal:</label>
                    <asp:TextBox ID="txtIDSucursal" runat="server" CssClass="input-field" placeholder="Ingrese ID de sucursal:" ValidationGroup="Grupo1"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvIDEliminar" runat="server" ControlToValidate="txtIDSucursal" ErrorMessage="Ingresar ID" ForeColor="Red" ValidationGroup="Grupo1">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revEliminar" runat="server" ControlToValidate="txtIDSucursal" ErrorMessage="Solo se permiten números" ForeColor="Red" ValidationExpression="^\d+$" ValidationGroup="Grupo1">*</asp:RegularExpressionValidator>
                </section>

                <section class="form-group">
                    <asp:Button ID="btnEliminar" CssClass="btn" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" ValidationGroup="Grupo1" />
                </section>

            </div>
            <section class="form-group  text-center">
                <asp:Label ID="lblMensaje" runat="server" EnableTheming="False" ForeColor="Red"></asp:Label>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="Grupo1" CssClass="validation-summary" />
            </section>

    </form>
</body>
</html>
