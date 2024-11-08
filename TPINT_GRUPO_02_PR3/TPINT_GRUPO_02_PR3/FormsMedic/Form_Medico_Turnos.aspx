<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form_Medico_Turnos.aspx.cs" Inherits="TPINT_GRUPO_02_PR3.Form_Medico_Turnos" %>

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
            height: 33px;
            width: 37px;
        }
        .auto-style9 {
            height: 33px;
            width: 1208px;
        }
        .auto-style2 {
            height: 33px;
        }
        .auto-style58 {
            width: 492px;
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
            .auto-style66 {
                width: 144px;
                height: 61px;
            }
            </style>
</head>
<body>
    <form id="form1" runat="server">
            <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:Image ID="Image1" runat="server" Height="40px" Width="41px" ImageUrl="/Imagenes/Logo_MS.png" />
                    </td>
                    <td class="auto-style9">
                        <asp:Button ID="Button1" runat="server" Text="Cerrar Sesión" />
                        </td>
                    <td class="auto-style2">
                        <asp:Label ID="lblUsuario" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
        <table>
            <tr>
                <td class="auto-style58"></td>
                <td class="auto-style66" style="font-weight: bold;font-size: 27px">Mis Turnos
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
            <br />
            <asp:GridView ID="grdListadoMedicos" runat="server">
            </asp:GridView>
        </div>
    </form>
    </form>
</body>
</html>
