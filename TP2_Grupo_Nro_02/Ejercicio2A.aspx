<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2A.aspx.cs"
Inherits="TP2_Grupo_Nro_XX.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <link rel="stylesheet" type="text/css" href="normalize.css" />
    <title>Ejercicio 2, Formulario de resumen</title>
  </head>
  <body>
    <form id="form1" runat="server">
      <div class="layout">
        <div class="container input poppins-bold">
          <asp:Label
            ID="Lblnombre"
            runat="server"
            Text="Nombre:"
            Font-Size="12pt"
              
          ></asp:Label>
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:TextBox
            ID="Txbnombre"
            runat="server"
            Width="150px"
            Height="19px"

          ></asp:TextBox>
        </div>
        <div class="container input poppins-bold">
          <asp:Label
            ID="Lblapellido"
            runat="server"
            Text="Apellido:"
          ></asp:Label>
          &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox
            ID="Txbapellido"
            runat="server"
            Width="150px"
            Height="19px"
          ></asp:TextBox>
        </div>
        <div class="container list poppins-bold">
            <asp:Label ID="Lblciudad" runat="server" Text="Ciudad:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:DropDownList
              ID="Ddlzona"
              runat="server"
              AutoPostBack="True"
              Height="19px"
              Width="150px"
            >
              <asp:ListItem Value="zona norte">Gral. Pacheco</asp:ListItem>
              <asp:ListItem Value="zona oeste">San Miguel</asp:ListItem>
              <asp:ListItem Value="zona sur">Boedo</asp:ListItem>
        </asp:DropDownList>
        </div>
        <div class="container list">
          <asp:Label ID="Lbltemas" runat="server" Text="Temas"></asp:Label>
          <asp:CheckBoxList
            ID="CheckBoxList1"
            runat="server"
            AutoPostBack="True"
            Font-Bold="True"
            Font-Italic="True"
            Font-Overline="False"
            Font-Size="12pt"
            ValidateRequestMode="Enabled"
            Width="150px"
            OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged1"
          CssClass="cList">
            <asp:ListItem Value="0">Ciencias</asp:ListItem>
            <asp:ListItem Value="1">Literatura</asp:ListItem>
            <asp:ListItem Value="3">Historia</asp:ListItem>
          </asp:CheckBoxList>
        </div>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <div class="btn">
          <asp:Button
          ID="Btnverresumen"
          runat="server"
          Font-Size="12pt"
          Text="Ver resumen"
          OnClick="Btnverresumen_Click"
        CssClass="resumeBtn" />
        </div>
      </div>
    </form>
  </body>
</html>
