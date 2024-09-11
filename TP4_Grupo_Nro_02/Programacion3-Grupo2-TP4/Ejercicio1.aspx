<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="Programacion3_Grupo2_TP4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 144px;
        }
        .auto-style2 {
            width: 102px;
        }
        .auto-style3 {
            text-decoration: underline;
        }
        .auto-style4 {
            text-decoration: underline;
            width: 157px;
        }
        .auto-style5 {
            width: 157px;
        }
        .auto-style6 {
            width: 102px;
            height: 31px;
        }
        .auto-style7 {
            width: 157px;
            height: 31px;
        }
        .auto-style8 {
            height: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">DESTINO INICIO</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style7">PROVINCIA:</td>
                <td class="auto-style8">
                    <asp:DropDownList ID="DdlProvinciainicio" runat="server" Height="16px" Width="148px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">LOCALIDAD:</td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="148px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">DESTINO FINAL</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">PROVINCIA:</td>
                <td>
                    <asp:DropDownList ID="DropDownList3" runat="server" Height="16px" Width="148px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">LOCALIDAD:</td>
                <td>
                    <asp:DropDownList ID="DropDownList4" runat="server" Height="16px" Width="148px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="Grdviajes" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
