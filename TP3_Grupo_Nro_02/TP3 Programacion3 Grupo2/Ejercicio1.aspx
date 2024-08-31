<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP3_Programacion3_Grupo2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style12 {
            width: 218px;
        }
        .auto-style14 {
            width: 216px;
        }
        .auto-style15 {
            width: 218px;
            height: 23px;
        }
        .auto-style16 {
            width: 216px;
            height: 23px;
        }
        .auto-style17 {
            height: 23px;
        }
        .auto-style18 {
            width: 218px;
            height: 56px;
        }
        .auto-style19 {
            width: 216px;
            height: 56px;
        }
        .auto-style20 {
            height: 56px;
        }
        .auto-style21 {
            width: 218px;
            height: 25px;
        }
        .auto-style22 {
            width: 216px;
            height: 25px;
        }
        .auto-style23 {
            height: 25px;
        }
        .auto-style24 {
            width: 218px;
            height: 26px;
        }
        .auto-style25 {
            width: 216px;
            height: 26px;
        }
        .auto-style26 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style14" style="font-weight: bold">Localidades</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">Nombre de la Localidad:</td>
                <td class="auto-style14">
                    <asp:TextBox ID="Txtboxlocalidad" runat="server" Width="205px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Lblerrorlocalidad" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style14">
                    <asp:Button ID="btnGuardarLoc" runat="server" Text="Guardar Localidad" Width="216px" OnClick="btnGuardarLoc_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    <p>
        &nbsp;</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style18"></td>
            <td class="auto-style19">Usuarios<br />
            </td>
            <td class="auto-style20"></td>
        </tr>
        <tr>
            <td class="auto-style12">Nombre usuario:</td>
            <td class="auto-style14">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">Contraseña:</td>
            <td class="auto-style16">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style17"></td>
        </tr>
        <tr>
            <td class="auto-style21">Repetir contraseña:</td>
            <td class="auto-style22">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style23"></td>
        </tr>
        <tr>
            <td class="auto-style12">Correo electrónico:</td>
            <td class="auto-style14">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">CP:</td>
            <td class="auto-style25">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style26"></td>
        </tr>
        <tr>
            <td class="auto-style25">Localidades:</td>
            <td class="auto-style26">
                <asp:DropDownList ID="ddlLocality" runat="server" AutoPostBack="True" Height="16px" Width="126px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
         <tr>

     <td class="auto-style27">
         <br />
             </td>
     <td class="auto-style128">
         <br />
         <asp:Button ID="Btnguardarusuario" runat="server" Height="20px" Text="Guardar Usuario" Width="126px" />
     </td>
     <td>&nbsp;</td>
 </tr>
    </table>
        <br />
        <br />
        <asp:Button ID="Btninicio" runat="server" Text="Ir a inicio.aspx" />
    </form>
    </body>
</html>
