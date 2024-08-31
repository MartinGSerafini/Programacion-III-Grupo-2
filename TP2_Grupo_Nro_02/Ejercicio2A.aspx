<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2A.aspx.cs" Inherits="TP2_Grupo_Nro_XX.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Cache-Control" content="no-cache, no-store, must-revalidate" />
<meta http-equiv="Pragma" content="no-cache" />
<meta http-equiv="Expires" content="0" />

    <title>Ejercicio 2, Resumen de paginas
    </title>
    <link rel="stylesheet" type="text/css" href="main.css" />
</head>
<body>
    <form id="form1" runat="server" class="size2A">
        <div class="layout">
            <div class="data-box">
                <asp:Label ID="Lblnombre" runat="server" Text="Nombre:" CssClass="subtitle roboto-bold"></asp:Label>
                <asp:TextBox ID="Txbnombre" runat="server" CssClass="input"></asp:TextBox>
            </div>

            <div class="data-box">
                <asp:Label ID="Lblapellido" runat="server" Text="Apellido:" CssClass="subtitle roboto-bold"></asp:Label>
                <asp:TextBox ID="Txbapellido" runat="server" CssClass="input"></asp:TextBox>
            </div>

            <div class="data-box">
                <asp:Label ID="Lblciudad" runat="server" Text="Ciudad:" CssClass="subtitle roboto-bold"></asp:Label>
                <asp:DropDownList ID="Ddlzona" runat="server" AutoPostBack="True" CssClass="dropdown">
                    <asp:ListItem Value="zona norte">Gral. Pacheco</asp:ListItem>
                    <asp:ListItem Value="zona oeste">San Miguel</asp:ListItem>
                    <asp:ListItem Value="zona sur">Boedo</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="data-box">
                <asp:Label ID="Lbltemas" runat="server" Text="Temas" CssClass="subtitle roboto-bold"></asp:Label>
                <asp:CheckBoxList ID="CheckBoxList" runat="server"
                    AutoPostBack="True" Font-Bold="True" Font-Overline="False" Font-Size="12pt" ValidateRequestMode="Enabled">
                    <asp:ListItem Value="0">Ciencias</asp:ListItem>
                    <asp:ListItem Value="1">Literatura</asp:ListItem>
                    <asp:ListItem Value="3">Historia</asp:ListItem>
                </asp:CheckBoxList>
            </div>
            <div class="btn-container">
                <asp:Button ID="Btnverresumen" runat="server" Text="Ver resumen" OnClick="Btnverresumen_Click" CssClass="btn" />
            </div>
        </div>
    </form>
</body>
</html>
