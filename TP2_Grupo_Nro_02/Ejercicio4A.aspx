<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio4A.aspx.cs" Inherits="TP2_Grupo_Nro_XX.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="main.css" />
    <title>Ejercicio 4, Formulario de usuario</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapper">
            <div class="data-box">
            <asp:Label ID="Lblusuario" runat="server" Text="Usuario:" Font-Size="14pt" ></asp:Label>
            <asp:TextBox ID="Txbnombre" runat="server" MaxLength="20" CssClass="input"></asp:TextBox>
            </div>
            <div class="data-box">
            <asp:Label ID="Lblclave" runat="server" Text="Clave:" ></asp:Label>
            <asp:TextBox ID="TxbClave" runat="server" MaxLength="20" TextMode="Password" CssClass="input"></asp:TextBox>
            </div>
            <div class="btn-container">
            <asp:Button ID="Btnvalidar" runat="server" Text="Validar" OnClick="Btnvalidar_Click" CssClass="btn" />
            </div>
        </div>
    </form>
</body>
</html>
