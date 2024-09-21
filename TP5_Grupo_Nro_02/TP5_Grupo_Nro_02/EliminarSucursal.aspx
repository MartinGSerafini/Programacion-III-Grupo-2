<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursal.aspx.cs" Inherits="TP5_Grupo_Nro_02.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 238px;
        }
        .auto-style3 {
            font-weight: normal;
        }
        .auto-style4 {
            width: 377px;
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
                      <asp:HyperLink ID="Hlink1" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:HyperLink ID="Hlink2" runat="server" NavigateUrl="~/ListarSucursal.aspx">Listado de Sucursales</asp:HyperLink>
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:HyperLink ID="Hlink3" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                 </td>
               </tr>
            </table>
        </div>
        <p>
            &nbsp;</p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <h2>Eliminar Sucursal</h2>
                    <p class="auto-style3">
                        &nbsp;</p>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Ingresar ID sucursal</td>
                <td class="auto-style4">
<<<<<<< HEAD
                    <asp:TextBox ID="TxbID" runat="server" Width="323px" ValidationGroup="Grupo1"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvIDEliminar" runat="server" ControlToValidate="txtIDSucursal" ErrorMessage="Ingresar ID " ForeColor="Red" ValidationGroup="Grupo1">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revEliminar" runat="server" ControlToValidate="txtIDSucursal" ErrorMessage="Solo se permiten numeros" ForeColor="Red" ValidationExpression="^\d+$" ValidationGroup="Grupo1">*</asp:RegularExpressionValidator>
                </td>
<<<<<<< HEAD
                <td>
                    <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" ValidationGroup="Grupo1" />
                </td>
<<<<<<< HEAD
                <td>
                    &nbsp;</td>
=======
>>>>>>> 3fb131957d7047c5fd687b93d7c3ba09b4b0d327
=======
                    <asp:TextBox ID="txtIDSucursal" runat="server" Width="323px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
>>>>>>> parent of 3fb1319 (Add files via upload)
=======
                <td>&nbsp;</td>
>>>>>>> parent of beb2b44 (.)
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
