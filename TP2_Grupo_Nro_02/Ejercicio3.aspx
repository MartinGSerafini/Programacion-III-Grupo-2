<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="TP2_Grupo_Nro_XX.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="main.css" />
    <title>Ejercicio 3, boton de colores
    </title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapper w-btn">
            <button class="btn red">
            <asp:LinkButton ID="lbtnRojo" runat="server" OnClick="lbtnRojo_Click">Rojo</asp:LinkButton>
            </button>
            <button class="btn blue">
            <asp:LinkButton ID="lbtnAzul" runat="server" OnClick="lbtnAzul_Click">Azul</asp:LinkButton>
            </button>
            <button class="btn green">
            <asp:LinkButton ID="lbtnVerde" runat="server" OnClick="lbtnVerde_Click">Verde</asp:LinkButton>
            </button>
        </div>
            <div class="btn-container roboto-black colorize">
            <asp:Label ID="lblTextoColoreado" runat="server" Text="Texto coloreado"></asp:Label>
            </div>
    </form>
</body>
</html>
