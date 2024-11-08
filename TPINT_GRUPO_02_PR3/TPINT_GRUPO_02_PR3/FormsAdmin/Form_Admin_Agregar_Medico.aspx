<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form_Admin_Agregar_Medico.aspx.cs" Inherits="TPINT_GRUPO_02_PR3.FormAdmin.Agregar_Medico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 33px;
        }
        .auto-style3 {
            height: 33px;
            width: 37px;
        }
        .auto-style5 {
            height: 33px;
            width: 690px;
        }
        .auto-style6 {
            height: 33px;
            width: 401px;
        }
        .auto-style9 {
            height: 33px;
            width: 523px;
        }
        .auto-style10 {
            width: 49%;
            float: left;
            height: 372px;
        }
        .auto-style11 {
            width: 49%;
            float: right;
        }
        .auto-style12 {
            width: 558px;
            text-align: right;
        }
        .auto-style13 {
            width: 177px;
        }
        .auto-style14 {
            width: 377px;
        }
        .auto-style15 {
            width: 558px;
            height: 32px;
            text-align: right;
        }
        .auto-style16 {
            height: 32px;
            width: 450px;
            text-align: right;
        }
        .auto-style17 {
            width: 112px;
            height: 26px;
        }
        .auto-style18 {
            height: 26px;
        }
        .auto-style19 {
            text-align: right;
            width: 503px;
        }
        .auto-style20 {
            width: 558px;
            height: 30px;
            text-align: right;
        }
        .auto-style21 {
            height: 30px;
            width: 450px;
            text-align: right;
        }
        .auto-style23 {
            width: 450px;
            text-align: right;
        }
        .auto-style24 {
            width: 558px;
            height: 37px;
            text-align: right;
        }
        .auto-style25 {
            width: 450px;
            text-align: right;
            height: 37px;
        }
        .auto-style26 {
            width: 2290px;
            height: 37px;
            text-align: right;
        }
        .auto-style27 {
            width: 2290px;
            text-align: right;
        }
        .auto-style28 {
            width: 2290px;
            height: 30px;
            text-align: right;
        }
        .auto-style29 {
            width: 2290px;
            height: 32px;
            text-align: right;
        }
        .auto-style30 {
            width: 345px;
        }
        .auto-style31 {
            width: 317px;
        }
        .auto-style32 {
            width: 169px;
        }
        .auto-style33 {
            width: 143px;
        }
        .auto-style34 {
            width: 112px;
        }
        .auto-style36 {
            width: 292px;
        }
        .auto-style37 {
            width: 217px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:Image ID="Image1" runat="server" Height="27px" Width="29px" />
                    </td>
                    <td class="auto-style9">
                        <asp:Button ID="Button1" runat="server" Text="Button" />
                        </td>
                    <td class="auto-style6">
                        <asp:HyperLink ID="hyAgregarMédico" runat="server" NavigateUrl="~/FormAdmin/Agregar_Medico.aspx">Agregar Médico</asp:HyperLink>
                    </td>
                    <td class="auto-style5">
                        <asp:HyperLink ID="hlListadoMedicos" runat="server" NavigateUrl="~/FormAdmin/ListadoMedicos.aspx">Listar médicos</asp:HyperLink>
                    </td>
                    <td class="auto-style2">
                        <asp:Label ID="lblUsuario" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style32">
                        <h1></h1>
                    </td>
                    <td class="auto-style33">&nbsp;</td>
                    <td class="auto-style37">&nbsp;</td>
                    <td class="auto-style31">
                        <h1>Carga de Médicos</h1>
                    </td>
                    <td class="auto-style36">&nbsp;</td>
                    <td class="auto-style34">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style32">&nbsp;</td>
                    <td class="auto-style33">&nbsp;</td>
                    <td class="auto-style37">&nbsp;</td>
                    <td class="auto-style31">&nbsp;</td>
                    <td class="auto-style36">&nbsp;</td>
                    <td class="auto-style34">&nbsp;</td>
                </tr>
            </table>
            <table align="right" class="auto-style10">
                <tr>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style24">Legajo:</td>
                    <td class="auto-style25">
                        <asp:TextBox ID="txtLegajo" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvLegajo" runat="server" ControlToValidate="txtLegajo" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style27">&nbsp;</td>
                    <td class="auto-style12">DNI:</td>
                    <td class="auto-style23">
                        <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvDNI" runat="server" ControlToValidate="txtDNI" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style27">&nbsp;</td>
                    <td class="auto-style12">Nombre:</td>
                    <td class="auto-style23">
                        <asp:TextBox ID="txtNombre" runat="server" Width="201px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style27">&nbsp;</td>
                    <td class="auto-style12">Apellido:</td>
                    <td class="auto-style23">
                        <asp:TextBox ID="txtApellido" runat="server" Width="198px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="txtApellido" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style27">&nbsp;</td>
                    <td class="auto-style12">Sexo:</td>
                    <td class="auto-style23">
                        <asp:DropDownList ID="ddlSexo" runat="server">
                            <asp:ListItem Value="-1">--Seleccione una opción--</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvSexo" runat="server" ControlToValidate="ddlSexo" ForeColor="Red" InitialValue="--Seleccione una opción--">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style27">&nbsp;</td>
                    <td class="auto-style12">Nacionalidad:</td>
                    <td class="auto-style23">
                        <asp:DropDownList ID="ddlNacionalidad" runat="server">
                            <asp:ListItem Value="-1">--Seleccione su nacionalidad--</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvNacionalidad" runat="server" ControlToValidate="ddlNacionalidad" ForeColor="Red" InitialValue="--Seleccione su nacionalidad--">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style28">&nbsp;</td>
                    <td class="auto-style20">Nacimiento:</td>
                    <td class="auto-style21">
                        <asp:TextBox ID="txtNacimiento" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvNacimiento" runat="server" ControlToValidate="txtNacimiento" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style27">&nbsp;</td>
                    <td class="auto-style12">Dirección:</td>
                    <td class="auto-style23">
                        <asp:TextBox ID="txtDireccion" runat="server" Width="211px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvDirección" runat="server" ControlToValidate="txtDireccion" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style27">&nbsp;</td>
                    <td class="auto-style12">Provincia:</td>
                    <td class="auto-style23">
                        <asp:DropDownList ID="ddlProvincia" runat="server">
                            <asp:ListItem>--Seleccione la provincia--</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvProvincia" runat="server" ControlToValidate="ddlProvincia" ForeColor="Red" InitialValue="--Seleccione la provincia--">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style29">&nbsp;</td>
                    <td class="auto-style15">Localidad:</td>
                    <td class="auto-style16">
                        <asp:DropDownList ID="ddlLocalidad" runat="server">
                            <asp:ListItem>--Seleccione la localidad--</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvLocalidad" runat="server" ControlToValidate="ddlLocalidad" ForeColor="Red" InitialValue="--Seleccione la localidad--">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
            <table class="auto-style11">
                <tr>
                    <td class="auto-style13">Correo:</td>
                    <td class="auto-style30">
                        <asp:TextBox ID="txtCorreo" runat="server" Width="226px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvCorreo" runat="server" ControlToValidate="txtCorreo" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">Teléfono:</td>
                    <td class="auto-style30">
                        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvtelefono" runat="server" ControlToValidate="txtTelefono" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">Especialidad:</td>
                    <td class="auto-style30">
                        <asp:DropDownList ID="ddlEspecialidad" runat="server">
                            <asp:ListItem>--Seleccione la especialidad--</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvEspecialidad" runat="server" ControlToValidate="ddlEspecialidad" ForeColor="Red" InitialValue="--Seleccione la especialidad--">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">Días de atención:</td>
                    <td class="auto-style30">
                        <asp:CheckBoxList ID="cblDías" runat="server" Height="105px" RepeatColumns="2" Width="294px">
                            <asp:ListItem>Lunes</asp:ListItem>
                            <asp:ListItem>Martes</asp:ListItem>
                            <asp:ListItem>Miércoles</asp:ListItem>
                            <asp:ListItem>Jueves</asp:ListItem>
                            <asp:ListItem>Viernes</asp:ListItem>
                            <asp:ListItem>Sábado</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13" rowspan="2">Horario de atención:</td>
                    <td class="auto-style30">De&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtHoraInicio" runat="server"></asp:TextBox>
&nbsp;hs&nbsp;
                        <asp:RequiredFieldValidator ID="rfvHoraInicio" runat="server" ControlToValidate="txtHoraInicio" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style30">Hasta&nbsp;
                        <asp:TextBox ID="txtHoraFinal" runat="server"></asp:TextBox>
&nbsp; hs&nbsp;
                        <asp:RequiredFieldValidator ID="rfvHorarioFinal" runat="server" ControlToValidate="txtHoraFinal" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">Contraseña:</td>
                    <td class="auto-style30">
                        <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password" Width="205px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="rfvContraseña" runat="server" ControlToValidate="txtContraseña" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">Repita la contraseña:</td>
                    <td class="auto-style30">
                        <asp:TextBox ID="txtRepetirContraseña" runat="server" TextMode="Password" Width="203px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvRepetirContraseña" runat="server" ControlToValidate="txtRepetirContraseña" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <br />
                        <asp:CompareValidator ID="cvContraseña" runat="server" ControlToCompare="txtContraseña" ControlToValidate="txtRepetirContraseña" ForeColor="Red">Las contraseñas no coinciden</asp:CompareValidator>
                    </td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
            </table>
            <br />
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style17"></td>
                <td class="auto-style18"></td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style19">
                    <asp:Button ID="btnAtras" runat="server" Text="Atrás" Width="100px" />
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Width="100px" />
                </td>
            </tr>
        </table>
        <br />
    </form>
</body>
</html>
