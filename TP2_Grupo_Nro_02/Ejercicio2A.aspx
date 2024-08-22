<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2A.aspx.cs" Inherits="TP2_Grupo_Nro_XX.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 20px">
            <asp:Label ID="Lblnombre" runat="server" Text="Nombre:" Font-Size="12pt"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txbnombre" runat="server" Width="150px" Height="19px" Style="position: relative; left: 10px;"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Lblapellido" runat="server" Text="Apellido:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="Txbapellido" runat="server" Width="150px" Height="19px" Style="position: relative; left: 10px;"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Lblciudad" runat="server" Text="Ciudad:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:DropDownList ID="Ddlzona" runat="server" AutoPostBack="True" Height="19px" Width="150px" Style="position: relative; left: 10px;">
                <asp:ListItem Value="zona norte">Gral. Pacheco</asp:ListItem>
                <asp:ListItem Value="zona oeste">San Miguel</asp:ListItem>
                <asp:ListItem Value="zona sur">Boedo</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Lbltemas" runat="server" Text="Temas"></asp:Label>
            <br />
            <asp:CheckBoxList ID="CheckBoxList" runat="server" 
                 Style="position: relative; left: 90px; top: 0px;" AutoPostBack="True" Font-Bold="True" Font-Italic="True" Font-Overline="False" Font-Size="12pt" ValidateRequestMode="Enabled" Width="150px">
                <asp:ListItem Value="0">Ciencias</asp:ListItem>
                <asp:ListItem Value="1">Literatura</asp:ListItem>
                <asp:ListItem Value="3">Historia</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btnverresumen" runat="server" Font-Size="12pt" Text="Ver resumen" OnClick="Btnverresumen_Click" />
            <br />
        </div>
    </form>
</body>
</html>
