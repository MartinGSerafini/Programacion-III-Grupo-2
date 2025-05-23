﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form_Login.aspx.cs" Inherits="TPINT_GRUPO_02_PR3.Formularios.Form_Login_Admin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Medical Studio - Login</title>
    <style type="text/css">
        body{
            background-color: #4C1766;
            display: flex;
            align-items: center;
            justify-content: center;
            height: 100vh;
            margin: 0;
            font-family: Arial, sans-serif;
            color: #FFFFFF;
            overflow-x: hidden;
            flex-wrap: wrap;
        }

        .container {
            background-color: #6C2C91;
            padding: 40px;
            border-radius: 15px;
            width: 80%;
            max-width: 400px;
            text-align: center;
            box-shadow: 0px 4px 10px rgba(0, 0, 0, 0.3);
        }

        .logo {
            font-size: 5vw; 
            font-weight: bold;
            color: #FFFFFF;
            margin-bottom: 20px;
        }

        .input-group {
            margin: 10px 0;
            text-align: left;
        }

        .input-group label {
            font-size: 17px;
            font-weight: bold;
        }

        .input-group input {
            width: 100%;
            padding: 10px;
            margin-top: 5px;
            border-radius: 10px;
            border: none;
            outline: none;
            font-size: 16px;
            background-color: #A472B4;
            color: #FFFFFF;
        }

        .input-group input::placeholder {
            color: #E5D4EC;
        }

        .error-message {
            font-size: 12px;
            color: #FFC2C2;
            margin-top: 10px;
        }

        .button-container {
            margin-top: 20px;
        }
        .social-icons {
            display: flex;
            justify-content: center;
            gap: 15px;
            margin-top: 20px;
        }

        .Container {
            background-color: #6C2C91;
            padding: 40px;
            border-radius: 15px;
            width: 402px;
            text-align: center;
            box-shadow: 0px 4px 10px rgba(0, 0, 0, 0.3);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="Container">
            <div style="display: flex; justify-content: center; align-items: center;">
                <div style="display: flex; flex-direction: column; margin-right: 10px;">
                    <span style="font-size: 60px;">Medical</span>
                    <span style="font-size: 50px;">Studio</span>
                </div>
                <img src="../Imagenes/Logo_MS.png" alt="Logo" style = "width: 170px; height: 160px;"/>
            </div>
            <div class="input-group">        
                <div class="input-group">
                    <asp:Label ID="DNI" runat="server" Text="DNI:" AssociatedControlID="TxbUsuario"></asp:Label>
                    <asp:TextBox ID="TxbUsuario" runat="server" Width="100%" MaxLength="8" placeholder="Ingrese su DNI"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxbUsuario" ErrorMessage="* Debe ingresar un DNI" ForeColor="#FFC2C2" Display="Dynamic" ValidationGroup="VG1" />
                    <br />
                    <asp:Label ID="CONTRA" runat="server" Text="Contraseña:" AssociatedControlID="TxbContra"></asp:Label>
                    <asp:TextBox ID="TxbContra" runat="server" TextMode="Password" Width="100%" MaxLength="20" placeholder="************"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxbContra" ErrorMessage="* Debe ingresar una contraseña" ForeColor="#FFC2C2" Display="Dynamic" ValidationGroup="VG1" />
                    <br />
                    <br />
                </div>

                <div class="button-container">
                    <asp:Button ID="BtnIniciar_Sesion" runat="server" Text="Iniciar Sesión" ValidationGroup="VG1" OnClick="BtnIniciar_Sesion_Click" />
                </div>

                <div class="social-icons">
                    <asp:HyperLink ID="HLInstagram" runat="server" NavigateUrl="https://www.instagram.com/medical_studio_2024/" Target="_blank">
                        <img src="https://upload.wikimedia.org/wikipedia/commons/a/a5/Instagram_icon.png" alt="Instagram" style="width: 30px; height: 30px;"/>
                    </asp:HyperLink>
                    <asp:HyperLink ID="HLFacebook" runat="server" NavigateUrl="https://www.facebook.com/profile.php?id=61567773056854" Target="_blank">
                        <img src="https://upload.wikimedia.org/wikipedia/commons/5/51/Facebook_f_logo_%282019%29.svg" alt="Facebook" style="width: 30px; height: 30px;"/>
                    </asp:HyperLink>
                    <asp:HyperLink ID="HLTwitter" runat="server" NavigateUrl="https://x.com/Guillermoseraf3" Target="_blank">
                        <img src="https://upload.wikimedia.org/wikipedia/commons/6/6f/Logo_of_Twitter.svg" alt="Twitter" style="width: 30px; height: 30px;"/>
                    </asp:HyperLink>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
