<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form_Login.aspx.cs" Inherits="TPINT_GRUPO_02_PR3.Formularios.Form_Login_Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">


        .auto-style56 {
            width: 186px;
            height: 58px;
        }
        .auto-style58 {
            width: 194px;
            height: 64px;
        }
        .auto-style62 {
            width: 204px;
            height: 35px;
        }
        .auto-style65 {
            width: 204px;
            height: 33px;
        }
        .auto-style69 {
            width: 249px;
            height: 35px;
        }
        .auto-style70 {
            width: 204px;
            height: 58px;
        }
        .auto-style71 {
            width: 204px;
            height: 28px;
        }
        .auto-style72 {
            width: 330px;
            height: 28px;
        }
        .auto-style74 {
            width: 331px;
            height: 28px;
        }
        .auto-style75 {
            width: 329px;
            height: 28px;
        }
        .auto-style76 {
            width: 247px;
            height: 33px;
        }
        .auto-style77 {
            width: 249px;
            height: 33px;
        }
        .auto-style78 {
            width: 39px;
            height: 35px;
        }
        .auto-style79 {
            width: 40px;
            height: 35px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td class="auto-style58" style="font-weight: bold;font-size: 30px">Medical Sudio</td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style62"></td>
                <td class="auto-style69"><asp:Label ID="Label1" runat="server" style="font-weight: bold;font-size: 17px" Text="DNI:"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style65"></td>
                <td class="auto-style77">
                    <asp:TextBox ID="txtUsuario" runat="server" Width="234px"></asp:TextBox>
                </td>
                <td class="auto-style78">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style62"></td>
                <td class="auto-style69">
                    <asp:Label ID="Label3" runat="server" style="font-weight: bold;font-size: 17px" Text="Contraseña:"></asp:Label>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style65"></td>
                <td class="auto-style76">
                    <asp:TextBox ID="txtPassword" runat="server" Width="235px"></asp:TextBox>
                </td>
                <td class="auto-style79">
                    &nbsp;</td>
            </tr>
        </table>
        <table>
            <td class="auto-style71"></td>
            <td class="auto-style75">
                    <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ControlToValidate="txtUsuario" ForeColor="Red">DEBE INGRESAR UN DNI</asp:RequiredFieldValidator>
                </td>
        </table>
        <table>
            <td class="auto-style71"></td>
            <td class="auto-style72">
                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ForeColor="Red">DEBE INGRESAR UNA CONTRASEÑA</asp:RequiredFieldValidator>
                </td>
        </table>
        <table>
            <td class="auto-style71"></td>
            <td class="auto-style74">
        <asp:Label ID="lblValidation" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </table>
        <table>
            <tr>
                <td class="auto-style70"></td>
                <td class="auto-style56">
                    <asp:Button ID="Button1" type="password" runat="server" Height="41px" Text="Iniciar Sesión" Width="143px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
