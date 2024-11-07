<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form_Menu_Administrador.aspx.cs" Inherits="TPINT_GRUPO_02_PR3.Formularios.Form_Menu_Administrador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <style type="text/css">
            .auto-style58 {
                width: 451px;
                height: 90px;
            }
            .auto-style59 {
                width: 342px;
                height: 47px;
            }
            .auto-style60 {
                width: 201px;
                height: 90px;
            }
            .auto-style61 {
                width: 97px;
                height: 47px;
            }
            .auto-style65 {
                width: 342px;
                height: 23px;
            }
            .auto-style66 {
                width: 433px;
                height: 17px;
            }
            .auto-style67 {
                width: 156px;
                height: 47px;
            }
            .auto-style68 {
                width: 155px;
                height: 47px;
            }
            .auto-style69 {
                width: 160px;
                height: 47px;
            }
            .auto-style70 {
                width: 92px;
                height: 47px;
            }
            .auto-style71 {
                width: 899px;
                height: 32px;
            }
            .auto-style72 {
                width: 102px;
                height: 32px;
            }
            .auto-style73 {
                width: 135px;
                height: 32px;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <header>
        <table>
            <tr>
                <td class="auto-style72">
                    <asp:Image ID="Image1" runat="server" Height="27px" Width="29px" />
                </td>
                <td class="auto-style71" style="font-weight: bold;font-size: 27px">
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                </td>
                <td class="auto-style73" style="font-weight: bold;font-size: 27px">
                    <asp:Label ID="lblUsuario" runat="server"></asp:Label>
                    <br/>
                </td>
            </tr>
        </table>
    </header>
        <table>
            <tr>
                <td class="auto-style58"></td>
                <td class="auto-style60" style="font-weight: bold;font-size: 27px">&nbsp;&nbsp;&nbsp;&nbsp; Menu inicio
                    <br />
                    Adiministradores<br/>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style66"></td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style59"></td>
                <td class="auto-style69" style="font-weight: bold;font-size: 27px">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/FormAdmin/Form_Admin_Listado_Pacientes.aspx">PACIENTES</asp:HyperLink>
                    <br/>
                </td>
                <td class="auto-style70"></td>
                <td class="auto-style69" style="font-weight: bold;font-size: 27px">
                    <asp:HyperLink ID="HyperLink2" runat="server">TURNOS</asp:HyperLink>
                    <br/>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style65"></td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style59"></td>
                <td class="auto-style67" style="font-weight: bold;font-size: 27px">
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/FormAdmin/Agregar_Medico.aspx">MEDICOS</asp:HyperLink>
                    <br/>
                </td>
                <td class="auto-style61"></td>
                <td class="auto-style68" style="font-weight: bold;font-size: 27px">
                    <asp:HyperLink ID="HyperLink4" runat="server">REPORTES</asp:HyperLink>
                    <br/>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
