<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP3_Programacion3_Grupo2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300;400;500;600;700;800&display=swap" rel="stylesheet"/>
    <link rel="stylesheet" type="text/css" href="main.css"/>
    <script src="https://cdn.tailwindcss.com"></script>
    <title>Ejercicio 1, formulario de usuario</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">

            <!-- Formulario de Localidades -->
            <fieldset>
                <legend>Localidades</legend>
                <div class="form-group">
                    <label for="Txtboxlocalidad">Localidad:</label>
                    <asp:TextBox placeholder="Localidad" ID="Txtboxlocalidad" runat="server" CssClass="form-control" ValidationGroup="Grupo1"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="Rfvlocalidad" runat="server" ControlToValidate="Txtboxlocalidad" ErrorMessage="Debe ingresar una localidad" CssClass="error-message" ValidationGroup="Grupo1">*</asp:RequiredFieldValidator>
                    <asp:CustomValidator ID="CvLocalidad" runat="server" ErrorMessage="Localidad ya existente" CssClass="error-message" OnServerValidate="CvLocalidad_ServerValidate" ValidationGroup="Grupo1">*</asp:CustomValidator>
                </div>
                <div class="form-group">
                    <asp:Button ID="btnGuardarLoc" runat="server" Text="Guardar Localidad" CssClass="btn-submit" ValidationGroup="Grupo1" />
                </div>
            </fieldset>

            <!-- Formulario de Usuarios -->
            <fieldset>
                <legend>Usuarios</legend>
                <div class="form-group">
                    <label for="TextBox1">Nombre:</label>
                    <asp:TextBox placeholder="Nombre" ID="TextBox1" runat="server" CssClass="form-control" ValidationGroup="Grupo2"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ControlToValidate="TextBox1" CssClass="error-message" ValidationGroup="Grupo2">*</asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label for="txtbContra">Contraseña:</label>
                    <asp:TextBox placeholder="Contraseña" ID="txtbContra" runat="server" TextMode="Password" CssClass="form-control" ValidationGroup="Grupo2"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvContraseña" runat="server" ControlToValidate="txtbContra" CssClass="error-message" ValidationGroup="Grupo2">*</asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label for="txtbRepeContra">Repetir contraseña:</label>
                    <asp:TextBox placeholder="Repetir la contraseña" ID="txtbRepeContra" runat="server" TextMode="Password" CssClass="form-control" ValidationGroup="Grupo2"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvRepetirContraseña" runat="server" ControlToValidate="txtbRepeContra" CssClass="error-message" ValidationGroup="Grupo2">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CVContrasenia" runat="server" ControlToCompare="txtbContra" ControlToValidate="txtbRepeContra" CssClass="error-message" ValidationGroup="Grupo2">Contraseña diferente</asp:CompareValidator>
                </div>
                <div class="form-group">
                    <label for="txtMail">Correo electrónico:</label>
                    <asp:TextBox placeholder="Email" ID="txtMail" runat="server" CssClass="form-control" ValidationGroup="Grupo2"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCorreo" runat="server" ControlToValidate="txtMail" CssClass="error-message" ValidationGroup="Grupo2">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtMail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="error-message" ValidationGroup="Grupo2">Email incorrecto</asp:RegularExpressionValidator>
                </div>
                <div class="form-group">
                    <label for="txtCP">CP:</label>
                    <asp:TextBox placeholder="Código postal" ID="txtCP" runat="server" CssClass="form-control" MaxLength="4" ValidationGroup="Grupo2"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCP" runat="server" ControlToValidate="txtCP" CssClass="error-message" ValidationGroup="Grupo2">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revCP" runat="server" ControlToValidate="txtCP" ValidationExpression="^\d+$" CssClass="error-message" ValidationGroup="Grupo2">Solo números</asp:RegularExpressionValidator>
                <div class="form-group dropdown">
                    <label for="ddlLocality">Localidades:</label>
                    <asp:DropDownList ID="ddlLocality" runat="server" CssClass="form-control" AutoPostBack="True" ValidationGroup="Grupo2"></asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RfvLocalidades" runat="server" ControlToValidate="ddlLocality" CssClass="error-message" ValidationGroup="Grupo2"></asp:RequiredFieldValidator>
                </div> </div>
               
                <div class="form-group">
                    <asp:Button ID="Btnguardarusuario" runat="server" Text="Guardar Usuario" CssClass="btn-submit" ValidationGroup="Grupo2" />
                </div>
            </fieldset>

            <!-- Botón para ir a la página de inicio -->
            <div class="form-group">
                <asp:Button ID="Btninicio" runat="server" Text="Ir a inicio.aspx" CssClass="btn-back" OnClick="Btninicio_Click" />
            </div>

            <!-- Resumen de validación -->
            <asp:ValidationSummary ID="ValidationSummary" runat="server" HeaderText="Errores:" CssClass="error-summary" ValidationGroup="Grupo1" />
        </div>

    </form>
</body>
</html>
