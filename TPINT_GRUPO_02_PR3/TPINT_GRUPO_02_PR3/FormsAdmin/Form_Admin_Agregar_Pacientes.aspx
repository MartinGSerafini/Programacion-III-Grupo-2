<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form_Admin_Agregar_Pacientes.aspx.cs" Inherits="TPINT_GRUPO_02_PR3.Form_Agregar_Pacientes" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
            <style type="text/css">
.auto-style46 {
    width: 307px;
    height: 47px;
}
.auto-style55 {
    width: 62px;
    height: 47px;
}
        .auto-style58 {
            width: 451px;
            height: 61px;
        }
        .auto-style60 {
            width: 243px;
            height: 61px;
        }
            .auto-style67 {
                width: 326px;
                height: 47px;
            }
            .auto-style68 {
                width: 525px;
                height: 47px;
            }
                .auto-style71 {
                    width: 221px;
                    height: 43px;
                }
                .auto-style73 {
                    width: 35px;
                    height: 43px;
                }
                .auto-style75 {
                    width: 224px;
                    height: 43px;
                }
                .auto-style77 {
                    width: 121px;
                    height: 43px;
                }
                .auto-style78 {
                    width: 97px;
                    height: 43px;
                }
                .auto-style79 {
                    width: 227px;
                    height: 43px;
                }
                .auto-style80 {
                    width: 164px;
                    height: 47px;
                }
                .auto-style83 {
                    width: 389px;
                    height: 43px;
                    text-align: left;
                }
                .auto-style84 {
                    width: 100%;
                }
                .auto-style85 {
                    width: 465px;
                }
                .auto-style86 {
                    width: 150px;
                }
                .auto-style87 {
                    width: 223px;
                    height: 43px;
                }
        </style>
</head>
<body style="height: 512px">
    <form id="form1" runat="server">
        <header>
            <table>
                <tr>
                    <td class="auto-style55">
                        <asp:Image ID="Image1" runat="server" Height="27px" Width="29px" />
                    </td>
                    <td class="auto-style46" style="font-weight: bold;font-size: 27px">
                        <asp:Button ID="Button1" runat="server" Text="Button" />
                        <br/>
                    </td>
                    <td class="auto-style67">
                        <asp:HyperLink ID="hlAgregarPaciente" runat="server" NavigateUrl="~/FormAdmin/Form_Agregar_Pacientes.aspx">AGREGAR PACIENTE</asp:HyperLink>
                    </td>
                    <td class="auto-style68">
                        <asp:HyperLink ID="hlListadoPacientes" runat="server" NavigateUrl="~/FormAdmin/Form_Admin_Listado_Pacientes.aspx">LISTAR PACIENTES</asp:HyperLink>
                    </td>
                    <td class="auto-style80">
                        <asp:Label ID="lblUsuario" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </header>
        <table>
            <tr>
                <td class="auto-style58"></td>
                <td class="auto-style60" style="font-weight: bold;font-size: 27px">Carga de pacientes
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style79"></td>
                <td class="auto-style77" style="font-weight: bold;font-size: 17px">DNI: </td>
                <td class="auto-style71">
                    <asp:TextBox ID="txtDNI" runat="server" Height="18px" Width="215px"></asp:TextBox>
                </td>
                <td class="auto-style73">
                    <asp:RequiredFieldValidator ID="rfvDNI" runat="server" ControlToValidate="txtDNI" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style78" style="font-weight: bold;font-size: 17px">Dirección: </td>
                <td class="auto-style75">
                    <asp:TextBox ID="txtDirección" runat="server" Height="18px" Width="215px"></asp:TextBox>
                </td>
                <td class="auto-style73">
                    <asp:RequiredFieldValidator ID="rfvDirección" runat="server" ControlToValidate="txtDirección" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style79"></td>
                <td class="auto-style77" style="font-weight: bold;font-size: 17px">Nombre: </td>
                <td class="auto-style71">
                    <asp:TextBox ID="txtNombre" runat="server" Height="18px" Width="215px"></asp:TextBox>
                </td>
                <td class="auto-style73">
                    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style78" style="font-weight: bold;font-size: 17px">Provincia: </td>
                <td class="auto-style75">
                    <asp:DropDownList ID="ddlProvincia" runat="server" Height="21px" Width="222px" AutoPostBack="True" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged">
                        <asp:ListItem Value="-1">--Seleccione una provincia--</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style73">
                    <asp:RequiredFieldValidator ID="rfvProvincia" runat="server" ControlToValidate="ddlProvincia" ForeColor="Red" InitialValue="--Seleccione una provincia--">*</asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style79"></td>
                <td class="auto-style77" style="font-weight: bold;font-size: 17px">Apellido: </td>
                <td class="auto-style71">
                    <asp:TextBox ID="txtApellido" runat="server" Height="18px" Width="215px"></asp:TextBox>
                </td>
                <td class="auto-style73">
                    <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="txtApellido" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style78" style="font-weight: bold;font-size: 17px">Localidad: </td>
                <td class="auto-style75">
                    <asp:DropDownList ID="ddlLocalidad" runat="server" Height="23px" Width="221px" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged">
                    <asp:ListItem Value="-1">--Seleccione una localidad--</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style73">
                    <asp:RequiredFieldValidator ID="rfvLocalidad" runat="server" ControlToValidate="ddlLocalidad" ForeColor="Red" InitialValue="--Seleccione una localidad-">*</asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style79"></td>
                <td class="auto-style77" style="font-weight: bold;font-size: 17px">Sexo: </td>
                <td class="auto-style71">
                    <asp:DropDownList ID="ddlSexo" runat="server" Height="21px" Width="222px">
                        <asp:ListItem Value="-1">--Seleccióne una opción--</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style73">
                    <asp:RequiredFieldValidator ID="rfvSexo" runat="server" ControlToValidate="ddlSexo" ForeColor="Red" InitialValue="--Seleccióne una opción--">*</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style78" style="font-weight: bold;font-size: 17px">Correo: </td>
                <td class="auto-style75">
                    <asp:TextBox ID="txtCorreo" runat="server" Height="18px" Width="311px"></asp:TextBox>
                </td>
                <td class="auto-style73">
                    <asp:RequiredFieldValidator ID="rfvCorreo" runat="server" ControlToValidate="txtCorreo" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style79"></td>
                <td class="auto-style77" style="font-weight: bold;font-size: 17px">Nacionalidad: </td>
                <td class="auto-style71">
                <asp:TextBox ID="TxbNacionalidad" runat="server" Height="18px" Width="215px"></asp:TextBox>
                </td>
                <td class="auto-style73">
                    <asp:RequiredFieldValidator ID="rfvNacionalidad" runat="server" ControlToValidate="TxbNacionalidad" ForeColor="Red" InitialValue="--Ingrese la nacionalidad--">*</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style78" style="font-weight: bold;font-size: 17px">Telefono: </td>
                <td class="auto-style75">
                    <asp:TextBox ID="txtTelefono" runat="server" Height="18px" Width="215px"></asp:TextBox>
                </td>
                <td class="auto-style73">
                    <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ControlToValidate="txtTelefono" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style79"></td>
                <td class="auto-style77" style="font-weight: bold;font-size: 17px">Nacimiento: </td>
                <td class="auto-style71">
                    <asp:TextBox ID="txtNacimiento" runat="server" Height="18px" Width="215px"></asp:TextBox>
                </td>
                <td class="auto-style73">
                    <asp:RequiredFieldValidator ID="rfvNacimiento" runat="server" ControlToValidate="txtNacimiento" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style87">&nbsp;</td>
                <td class="auto-style83">
                    <asp:Label ID="PRUEBA" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <table class="auto-style84">
            <tr>
                <td class="auto-style85">&nbsp;</td>
                <td class="auto-style86">
                    <asp:Button ID="btnAtras" runat="server" Text="Atrás" Width="100px" />
                </td>
                <td>
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Width="100px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
