<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2A.aspx.cs" Inherits="TP2_Grupo_Nro_XX.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ejercicio 2, Resumen de paginas
    </title>
    <link rel="stylesheet" type="text/css" href="main.css" />
</head>
<body>
<<<<<<< HEAD
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
                    AutoPostBack="True" Font-Bold="True" Font-Italic="True" Font-Overline="False" Font-Size="12pt" ValidateRequestMode="Enabled">
                    <asp:ListItem Value="0">Ciencias</asp:ListItem>
                    <asp:ListItem Value="1">Literatura</asp:ListItem>
                    <asp:ListItem Value="3">Historia</asp:ListItem>
                </asp:CheckBoxList>
            </div>
            <div class="btn-container">
                <asp:Button ID="Btnverresumen" runat="server" Text="Ver resumen" OnClick="Btnverresumen_Click" CssClass="btn" />
            </div>
=======
    <form id="form1" runat="server">
        <div style="margin-left: 20px">
            <asp:Label ID="Lblnombre" runat="server" Text="Nombre:" Font-Size="15pt"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txbnombre" runat="server" Width="150px" Style="position: relative; left: 8px; top: -1px; height: 18px;"></asp:TextBox>
            <br />
            <br />
            <asp:Label Font-Size="15pt" ID="Lblapellido" runat="server" Text="Apellido:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="Txbapellido" runat="server" Width="150px" Style="position: relative; left: 0px; top: -2px; height: 18px;"></asp:TextBox>
            <br />
            <br />
            <asp:Label Font-Size="15pt" ID="Lblciudad" runat="server" Text="Ciudad:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:DropDownList ID="Ddlzona" runat="server" AutoPostBack="True" Style="position: relative; left: 9px; top: 0px; height: 19px; width: 143px;">
                <asp:ListItem Value="Zona Norte">Gral. Pacheco</asp:ListItem>
                <asp:ListItem Value="Zona Oeste">San Miguel</asp:ListItem>
                <asp:ListItem Value="Zona Sur">Boedo</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label Font-Size="15pt" ID="Lbltemas" runat="server" Text="Temas"></asp:Label>
            <br />
            <asp:CheckBoxList ID="CheckBoxList" runat="server" 
                 Style="position: relative; left: 90px; top: -26px; height: 103px; width: 116px;" AutoPostBack="True" Font-Bold="True" Font-Italic="True" Font-Overline="False" Font-Size="12pt" ValidateRequestMode="Enabled">
                <asp:ListItem Value="0">Ciencias</asp:ListItem>
                <asp:ListItem Value="1">Literatura</asp:ListItem>
                <asp:ListItem Value="3">Historia</asp:ListItem>
            </asp:CheckBoxList>
            <asp:Button style="font-family: Cooper" ID="Btnverresumen" runat="server" Font-Size="12pt" Text="Ver resumen" OnClick="Btnverresumen_Click" Height="33px" Width="136px" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
>>>>>>> f84b021e387306a7fc0badbeae27b78d9355a3ad
        </div>
    </form>
</body>
</html>
