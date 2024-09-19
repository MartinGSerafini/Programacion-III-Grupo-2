<%@ Page Language="C#" AutoEventWireup="true"
CodeBehind="ListarSucursal.aspx.cs" Inherits="TP5_Grupo_Nro_02.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <link rel="stylesheet" type="text/css" href="../main.css" />
    <title>Listado de sucursales</title>
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
      <label>Busqueda ingrese ID de sucursal: </label>
      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
      <asp:Button ID="filtro" runat="server" Text="Filtrar" />
      <asp:Button ID="Mostrar" runat="server" Text="Mostrar todo" OnClick="Mostrar_Click" />

      <asp:GridView ID="GrdSucursales" runat="server"></asp:GridView>
    </form>
  </body>
</html>
