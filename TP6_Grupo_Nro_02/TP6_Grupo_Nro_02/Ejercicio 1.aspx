<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio 1.aspx.cs" Inherits="TP6_Grupo_Nro_02.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Formulario de Selección de Fecha</title>
    <link href="https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.min.js"></script>
    <script>
        $(function () {
            $("#<%= txtFecha.ClientID %>").datepicker({
                dateFormat: 'dd/mm/yy',
                beforeShowDay: function (date) {
                    var day = date.getDay();
                    return [(day !== 0 && day !== 6), ''];
                },
                changeMonth: true,
                changeYear: true,
                yearRange: "1900:2100"
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 20px;">
            <h2>Selecciona una Fecha de Consulta</h2>
            <label for="txtFecha">Fecha:</label>
            <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" style="margin-left: 10px;" />
            <br /><br />
            <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor="Green"></asp:Label>
        </div>
    </form>
</body>
</html>
