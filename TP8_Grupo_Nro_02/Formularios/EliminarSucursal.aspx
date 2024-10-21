<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursal.aspx.cs" Inherits="TP8_Grupo_Nro_02.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="main.css" />
</head>
<body>
    <form id="form2" runat="server">
        <div>
             <nav>
     <h2>Grupo N2</h2>
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
        <h1> Eliminar Sucursal</h1>
        <div class="form-section">

                <label for="txtIdSucursal">Ingresar ID Sucursal:</label>
                    <asp:TextBox ID="txtIdSucursal" runat="server" CssClass="input"></asp:TextBox>
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" ValidationGroup="vg1" CssClass="button" />
                    <asp:Label ID="lblValidacion" runat="server" ForeColor="Red"></asp:Label>
        </div>
                <asp:RegularExpressionValidator ID="revIdSucursal" runat="server" ControlToValidate="txtIdSucursal" ForeColor="Red" ValidationExpression="^\d+$" ErrorMessage="Solo se Permiten Ingresar Numeros" ValidationGroup="vg1">*</asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="rfcIdSucursal" runat="server" ControlToValidate="txtIdSucursal" ErrorMessage="Debe Ingresar un ID" ForeColor="Red" ToolTip="vg1" ValidationGroup="vg1">*</asp:RequiredFieldValidator>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="vg1" />
    </form>
</body>
</html>
