<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3b.aspx.cs" Inherits="Programacion3_Grupo2_TP4.Ejercicio3b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblLibros" runat="server" Font-Bold="True" Text="Listado de Libros:"></asp:Label>
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:LinkButton ID="lbtnConsultar" runat="server">Consultar otro tema</asp:LinkButton>
    </form>
</body>
</html>
