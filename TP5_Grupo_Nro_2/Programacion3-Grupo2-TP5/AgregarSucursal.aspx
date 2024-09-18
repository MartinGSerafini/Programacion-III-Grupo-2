<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="Programacion3_Grupo2_TP5.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 115px;
        }
        .auto-style4 {
            width: 937px;
        }
        .auto-style7 {
            width: 331px;
        }
        .auto-style9 {
            width: 224px;
        }
        .auto-style10 {
            width: 928px;
        }
        .auto-style11 {
            width: 584px;
        }
        .auto-style12 {
            width: 488px;
        }
        .auto-style13 {
            width: 19px;
        }
        .auto-style14 {
            font-size: xx-large;
        }
        .auto-style15 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style10">
                        <asp:HyperLink ID="hlAgregar" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style4">
                        <asp:HyperLink ID="hlListado" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td class="auto-style11">
                        <asp:HyperLink ID="hlEliminar" runat="server" NavigateUrl="~/EliminarSucursales.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
            </table>
        </div>
        <strong><span class="auto-style14">Grupo N° 2</span></strong><br />
        <br />
        <strong><span class="auto-style15">Agregar Sucursal</span></strong><br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Nombre Sucursal:</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtNombreSuc" runat="server" Height="16px" Width="500px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Descripción:</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtNombreSuc0" runat="server" Height="32px" Width="500px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Provincia:</td>
                <td>&nbsp;</td>
                <td>
                    <asp:DropDownList ID="ddlProvincia" runat="server" Width="500px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Dirección</td>
                <td>&nbsp;</td>
                <td>
                    <asp:TextBox ID="txtDireccionSuc" runat="server" Height="16px" Width="500px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnAceptar" runat="server" Height="24px" Text="Aceptar" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
