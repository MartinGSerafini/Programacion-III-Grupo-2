<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="TP5_Grupo_Nro_02.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 190px;
        }
        .auto-style3 {
            width: 190px;
            height: 33px;
        }
        .auto-style4 {
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="LINKS">
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
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" style="font-size: 37px;"><strong>GRUPO N2</strong></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" style="font-size: 24px;"><strong>Agregar Sucursal</strong></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Nombre Sucursal</td>
                    <td>
                        <asp:TextBox ID="txtNombreSuc" runat="server" Width="250px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RfvNombre" runat="server" ControlToValidate="txtNombreSuc" ErrorMessage="Debe Ingresar un Nombre" ForeColor="Red" ValidationGroup="Vg1">*</asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Descripcion</td>
                    <td>
                        <asp:TextBox ID="txtDescripcionSuc" runat="server" Width="250px" Height="36px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RfvDescripcion" runat="server" ControlToValidate="txtDescripcionSuc" ErrorMessage="Debe Ingresar una Descripcion" ForeColor="Red" ValidationGroup="Vg1">*</asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Provincia</td>
                    <td>
                        <asp:DropDownList ID="DdlProvincias" runat="server" AutoPostBack="True" Width="260px">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Direccion</td>
                    <td>
                        <asp:TextBox ID="txtDireccionSuc" runat="server" Width="250px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RfvDireccion" runat="server" ControlToValidate="txtDireccionSuc" ErrorMessage="Debe Ingresar una Direccion" ForeColor="Red" ValidationGroup="Vg1">*</asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4">
                        <br />
                        <asp:Button ID="BtnAceptar" runat="server" Text="Aceptar" OnClick="BtnAceptar_Click" ValidationGroup="Vg1" />
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style4"></td>
                </tr>
            </table>
        </div>
        <p>
            </p>
        <asp:ValidationSummary ID="Vs" runat="server" ValidationGroup="Vg1" />
    </form>
</body>
</html>
