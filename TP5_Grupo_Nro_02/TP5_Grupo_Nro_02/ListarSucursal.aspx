<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="ListarSucursal.aspx.cs" Inherits="TP5_Grupo_Nro_02.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="../main.css" />
    <title>Listado de sucursales</title>
    <link rel="stylesheet" type="text/css" href="main.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <nav class="links-nav">
                <asp:HyperLink ID="Hlink1" runat="server" NavigateUrl="~/AgregarSucursal.aspx" CssClass="nav-link">
        Agregar Sucursal
                </asp:HyperLink>

                <asp:HyperLink ID="Hlink2" runat="server" NavigateUrl="~/ListarSucursal.aspx" CssClass="nav-link">
        Listado de Sucursales
                </asp:HyperLink>

                <asp:HyperLink ID="Hlink3" runat="server" NavigateUrl="~/EliminarSucursal.aspx" CssClass="nav-link">
        Eliminar Sucursal
                </asp:HyperLink>
            </nav>

            <h1>Listado Sucursales</h1>

            <section class="search-section">
                <label for="TxtID">Búsqueda, ingrese ID de sucursal:</label>
                <asp:TextBox ID="TxtID" runat="server" CssClass="input"></asp:TextBox>

                <asp:Button ID="filtro" runat="server" Text="Filtrar" OnClick="filtro_Click" ValidationGroup="Vg1" CssClass="btn btn-filter" />

                <asp:RequiredFieldValidator
                    ID="Rfv1"
                    runat="server"
                    ControlToValidate="TxtID"
                    ErrorMessage="Debe ingresar un ID"
                    ForeColor="Red"
                    ValidationGroup="Vg1"
                    CssClass="error-message">
                </asp:RequiredFieldValidator>

                <asp:RegularExpressionValidator
                    ID="RegularExpressionValidator1"
                    runat="server"
                    ControlToValidate="TxtID"
                    ErrorMessage="Solo debe ingresar Números para el ID"
                    ForeColor="Red"
                    ValidationExpression="^\d+$"
                    ValidationGroup="Vg1"
                    CssClass="error-message">
                </asp:RegularExpressionValidator>

                <asp:Button
                    ID="Mostrar"
                    runat="server"
                    Text="Mostrar todo"
                    OnClick="Mostrar_Click"
                    CssClass="btn btn-show-all" />
            </section>

            <section class="grid-section">
                <asp:GridView ID="GrdSucursales" runat="server" CssClass="grid-table"></asp:GridView>
            </section>

            <asp:ValidationSummary
                ID="Vs1"
                runat="server"
                HeaderText="Errores:"
                ValidationGroup="Vg1"
                CssClass="validation-summary" />
        </div>
    </form>

</body>
</html>
