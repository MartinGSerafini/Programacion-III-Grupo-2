<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio4A.aspx.cs" Inherits="TP2_Grupo_Nro_XX.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Lblusuario" runat="server" Text="Usuario:" Font-Size="14pt" Style="position: absolute; left: 20px; top: 20px;"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txbnombre" runat="server" Width="150px" Height="19px" Style="position: absolute; left: 90px; top: 20px; bottom: 631px;" MaxLength="20"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Lblclave" runat="server" Text="Clave:" Font-Size="14pt" Style="position: absolute; left: 20px; top: 60px;"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxbClave" runat="server" Width="150px" Height="19px" Style="position: absolute; left: 90px; top: 60px;" MaxLength="20" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:Button ID="Btnvalidar" runat="server" Text="Validar" OnClick="Btnvalidar_Click"/>
        </div>
    </form>
</body>
</html>
