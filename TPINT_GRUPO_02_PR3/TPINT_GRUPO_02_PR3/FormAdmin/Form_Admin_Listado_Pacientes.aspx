<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form_Admin_Listado_Pacientes.aspx.cs" Inherits="TPINT_GRUPO_02_PR3.Form_Admin_Listado_Pacientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <style type="text/css">
.auto-style46 {
    width: 307px;
    height: 47px;
}
.auto-style55 {
    width: 62px;
    height: 47px;
}
        .auto-style58 {
            width: 451px;
            height: 61px;
        }
        .auto-style60 {
            width: 243px;
            height: 61px;
        }
            .auto-style61 {
                width: 432px;
                height: 61px;
            }
            .auto-style62 {
                width: 232px;
                height: 61px;
            }
            .auto-style63 {
                width: 128px;
                height: 61px;
            }
            .auto-style64 {
                width: 84px;
                height: 61px;
            }
            .auto-style65 {
                width: 238px;
                height: 61px;
            }
            .auto-style67 {
                width: 229px;
                height: 47px;
            }
            .auto-style68 {
                width: 525px;
                height: 47px;
            }
            .auto-style69 {
                width: 125px;
                height: 47px;
            }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <header>
    <table>
        <tr>
            <td class="auto-style55">
                <asp:Image ID="Image1" runat="server" Height="27px" Width="29px" />
            </td>
            <td class="auto-style46" style="font-weight: bold;font-size: 27px">
                <asp:Button ID="Button1" runat="server" Text="Button" />
                <br/>
            </td>
            <td class="auto-style67">
                <asp:HyperLink ID="hlAgregarPaciente" runat="server" NavigateUrl="~/FormAdmin/Form_Agregar_Pacientes.aspx">AGREGAR PACIENTE</asp:HyperLink>
            </td>
            <td class="auto-style68">
                <asp:HyperLink ID="hlListadoPacientes" runat="server" NavigateUrl="~/FormAdmin/Form_Admin_Listado_Pacientes.aspx">LISTAR PACIENTES</asp:HyperLink>
            </td>
            <td class="auto-style69">
                <asp:Label ID="lblUsuario" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    </header>
        <table>
            <tr>
                <td class="auto-style58"></td>
                <td class="auto-style60" style="font-weight: bold;font-size: 27px">Listado de pacientes
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style61"></td>
                <td class="auto-style62">
                    <asp:TextBox ID="txtBuscador" style="font-weight: bold;font-size: 15px" runat="server" Width="220px" Height="20px"></asp:TextBox>
                </td>
                <td class="auto-style63">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
                </td>
                <td class="auto-style64">
                    <asp:Label ID="Label1" style="font-weight: bold;font-size: 15px" runat="server" Text="Filtrar por: "></asp:Label>
                </td>
                <td class="auto-style65">
                    <asp:DropDownList ID="ddlFiltros" runat="server" Height="19px" Width="173px">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <table>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </table>
    </form>
</body>
</html>
