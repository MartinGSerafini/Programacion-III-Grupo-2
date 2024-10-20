<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursal.aspx.cs" Inherits="TP8_Grupo_Nro_02.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 181px;
        }
        .auto-style4 {
            width: 334px;
        }
        .auto-style5 {
            width: 394px;
        }
        .auto-style6 {
            width: 181px;
            height: 30px;
        }
        .auto-style7 {
            width: 326px;
            height: 30px;
        }
        .auto-style8 {
            height: 30px;
        }
        .auto-style9 {
            width: 326px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Formularios/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style5">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Formularios/ListadoDeSucursales.aspx">Lista de Sucursales</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Formularios/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <h1>Eliminar Sucursal</h1>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">Ingresar ID Sucursal:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtIdSucursal" runat="server" Width="273px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfcIdSucursal" runat="server" ControlToValidate="txtIdSucursal" ErrorMessage="Debe Ingresar un ID" ForeColor="Red" ToolTip="vg1" ValidationGroup="vg1">*</asp:RequiredFieldValidator>
                &nbsp;<asp:RegularExpressionValidator ID="revIdSucursal" runat="server" ControlToValidate="txtIdSucursal" ForeColor="Red" ValidationExpression="^\d+$" ErrorMessage="Solo se Permiten Ingresar Numeros" ValidationGroup="vg1">*</asp:RegularExpressionValidator>
                </td>
                <td class="auto-style8">
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" ValidationGroup="vg1" />
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="lblValidacion" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <br />
                </td>
            </tr>
        </table>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="vg1" />
    </form>
</body>
</html>
