<%@ Page Language="C#" AutoEventWireup="true"
CodeBehind="ListarSucursal.aspx.cs" Inherits="TP5_Grupo_Nro_02.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <link rel="stylesheet" type="text/css" href="../main.css" />
    <title>Listado de sucursales</title>
      <style type="text/css">
          .auto-style1 {
              margin-left: 0px;
          }
      </style>
  </head>
  <body>
    <form id="form1" runat="server">
      <div>
        <table class="auto-style1">
          <tr>
            <td>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:HyperLink
                ID="Hlink1"
                runat="server"
                NavigateUrl="~/AgregarSucursal.aspx"
                >Agregar Sucursal</asp:HyperLink
              >
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:HyperLink
                ID="Hlink2"
                runat="server"
                NavigateUrl="~/ListarSucursal.aspx"
                >Listado de Sucursales</asp:HyperLink
              >
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:HyperLink
                ID="Hlink3"
                runat="server"
                NavigateUrl="~/EliminarSucursal.aspx"
                >Eliminar Sucursal</asp:HyperLink
              >
            </td>
          </tr>
        </table>
      </div>
      <h1>Listado Sucursales</h1>
      <label>Busqueda ingrese ID de sucursal:&nbsp;&nbsp;&nbsp;&nbsp; </label>
      <asp:TextBox ID="TxtID" runat="server" Width="261px"></asp:TextBox>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:Button ID="filtro" runat="server" Text="Filtrar" OnClick="filtro_Click" ValidationGroup="Vg1" Width="61px" />
      &nbsp;<asp:RequiredFieldValidator ID="Rfv1" runat="server" ControlToValidate="TxtID" ErrorMessage="Debe ingresar un ID" ForeColor="Red" ValidationGroup="Vg1">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TxtID" ErrorMessage="Solo debe ingresar Numeros para el ID" ForeColor="Red" ValidationExpression="^\d+$" ValidationGroup="Vg1">*</asp:RegularExpressionValidator>
&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:Button ID="Mostrar" runat="server" Text="Mostrar todo" OnClick="Mostrar_Click" CssClass="auto-style1" Width="119px" />

        <br />
        <br />
        <br />

      <asp:GridView ID="GrdSucursales" runat="server"></asp:GridView>
        <br />
        <asp:ValidationSummary ID="Vs1" runat="server" HeaderText="Errores: " ValidationGroup="Vg1" />
    </form>
  </body>
</html>
