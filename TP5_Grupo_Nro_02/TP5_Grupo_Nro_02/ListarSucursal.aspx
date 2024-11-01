<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarSucursal.aspx.cs" Inherits="TP5_Grupo_Nro_02.WebForm2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="../main.css" />
    <title>Listado de sucursales</title>
    <link rel="stylesheet" type="text/css" href="main.css" />
    <script src="https://kit.fontawesome.com/e31ccd8e46.js" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <nav class="nav">
                <h1 class="lato-bold">Listado de Sucursales 📚</h1>
                <ul>
                    <li class="nav-item">
                        <asp:HyperLink ID="Hlink1" runat="server" NavigateUrl="~/AgregarSucursal.aspx" CssClass="nav-link">
                            Agregar Sucursal 🔼
                        </asp:HyperLink>
                    </li>
                    <li class="nav-item">
                        <asp:HyperLink ID="Hlink2" runat="server" NavigateUrl="~/ListarSucursal.aspx" CssClass="nav-link">
                            Listado de Sucursales 📚
                        </asp:HyperLink>
                    </li>
                    <li class="nav-item">
                        <asp:HyperLink ID="Hlink3" runat="server" NavigateUrl="~/EliminarSucursal.aspx" CssClass="nav-link">
                            Eliminar Sucursal ❌
                        </asp:HyperLink>
                    </li>
                </ul>
            </nav>

            <section class="search-section">
                <div class="search-bar">
                    <asp:TextBox ID="TxtID" placeholder="Ingrese ID de sucursal:" runat="server" CssClass="input"></asp:TextBox>
                    <asp:Button ID="filtro" runat="server" Text="🔎" OnClick="filtro_Click" ValidationGroup="Vg1" CssClass="btn btn-filter" />
                </div>

                <asp:RequiredFieldValidator
                    ID="Rfv1"
                    runat="server"
                    ControlToValidate="TxtID"
                    ErrorMessage="Debe ingresar un ID"
                    ForeColor="Red"
                    ValidationGroup="Vg1"
                    CssClass="error-message hidden">
                </asp:RequiredFieldValidator>

                <asp:RegularExpressionValidator
                    ID="RegularExpressionValidator1"
                    runat="server"
                    ControlToValidate="TxtID"
                    ErrorMessage="Solo debe ingresar números para el ID"
                    ForeColor="Red"
                    ValidationExpression="^\d+$"
                    ValidationGroup="Vg1"
                    CssClass="error-message hidden">
                </asp:RegularExpressionValidator>

                <asp:Button ID="Mostrar" runat="server" Text="Mostrar todo" OnClick="Mostrar_Click" CssClass="btn btn-show-all" />
            </section>

            <section class="grid-section">
                <asp:GridView ID="GrdSucursales" runat="server" CssClass="grid-table" AutoGenerateColumns="False" OnRowCommand="GrdSucursales_RowCommand">
    <Columns>
        <asp:BoundField DataField="Id_Sucursal" HeaderText="ID" />
        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
        <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
        <asp:BoundField DataField="Provincia" HeaderText="Provincia" />
        <asp:BoundField DataField="Direccion" HeaderText="Dirección" />

       <asp:TemplateField HeaderText="Acciones">
    <ItemTemplate>
        <asp:LinkButton ID="LinkButton1" runat="server" Text="Acciones" OnClick="LinkButton1_Click" CommandArgument='<%# Eval("Id_Sucursal") %>' />
        <asp:Panel ID="pnlAcciones" runat="server" Visible="false">
            <asp:LinkButton ID="lnkEditar" runat="server" Text="Editar" CommandName="Editar" CommandArgument='<%# Eval("Id_Sucursal") %>' />
            <asp:LinkButton ID="lnkEliminar" runat="server" Text="Eliminar" CommandName="Eliminar" CommandArgument='<%# Eval("Id_Sucursal") %>' />
        </asp:Panel>
    </ItemTemplate>
</asp:TemplateField>
    </Columns>
</asp:GridView>
            </section>

            <div class="err">
                <asp:ValidationSummary ID="Vs1" runat="server" HeaderText="Errores:" ValidationGroup="Vg1" CssClass="validation-summary" />
            </div>
        </div>
    </form>
</body>
</html>
