<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP2_Grupo_Nro_XX.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Lblnombre1" runat="server" Text="Ingrese nombre del producto: "></asp:Label>
            <asp:TextBox ID="Txbnombre1" runat="server" Width="230px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LblCant1" runat="server" Text="Cantidad: "></asp:Label>
            <asp:TextBox ID="Txbcant1" runat="server" Width="230px"></asp:TextBox>
            <p>
                <asp:Label ID="Lblnombre2" runat="server" Text="Ingrese nombre del producto: "></asp:Label>
                <asp:TextBox ID="Txbnombre2" runat="server" Width="230px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="LblCant2" runat="server" Text="Cantidad: "></asp:Label>
                <asp:TextBox ID="Txbcant2" runat="server" Width="230px"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="Btntabla" runat="server" OnClick="Btntabla_Click" Text="Generar Tabla" />
                <asp:Label ID="LabelError" runat="server"></asp:Label>
            </p>
            <p>
                <asp:Label ID="Lbltabla" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
