<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP2_Grupo_Nro_XX.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ejercicio 1, creador de tablas</title>
    <link rel="stylesheet" type="text/css" href="main.css" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapper layout">
            <div class="data-box">
                <asp:Label ID="Lblnombre1" runat="server" Text="Ingrese nombre del producto: "></asp:Label>
                <asp:TextBox ID="Txbnombre1" runat="server" CssClass="input"></asp:TextBox>

            </div>
            <div class="data-box">
                <asp:Label ID="LblCant1" runat="server" Text="Cantidad: "></asp:Label>
                <asp:TextBox ID="Txbcant1" runat="server" CssClass="input" class="input"></asp:TextBox>
            </div>
            <div class="data-box">
                <asp:Label ID="Lblnombre2" runat="server" Text="Ingrese nombre del producto: "></asp:Label>
                <asp:TextBox ID="Txbnombre2" runat="server" CssClass="input"></asp:TextBox>
            </div>
            <div class="data-box">
                <asp:Label ID="LblCant2" runat="server" Text="Cantidad: "></asp:Label>
                <asp:TextBox ID="Txbcant2" runat="server" CssClass="input"></asp:TextBox>
            </div>

            <div class="btn-container">
                <asp:Button ID="Btntabla" runat="server" OnClick="Btntabla_Click" Text="Generar Tabla" CssClass="btn" />
            </div>
        </div>
    </form>
            <p>
                <asp:Label ID="Lbltabla" runat="server"></asp:Label>
            </p>
</body>
</html>
