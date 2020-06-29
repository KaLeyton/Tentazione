<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageTentazione.Master" AutoEventWireup="true" CodeBehind="WebFormlogin.aspx.cs" Inherits="CapaGUIWeb.WebFormlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style19 {
            height: 390px;
        }
        .auto-style20 {
            width: 24%;
        }
        .auto-style21 {
            text-align: center;
            width: 197px;
        }
        .auto-style23 {
            width: 197px;
        }
        .auto-style24 {
            text-align: left;
            width: 197px;
        }
        .auto-style25 {
            width: 197px;
            height: 5px;
        }
        .auto-style26 {
            width: 197px;
            height: 6px;
        }
        .auto-style27 {
            width: 197px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style19">
        <br />
        <table class="auto-style20">
            <tr>
                <td class="auto-style21">
                    <asp:Label ID="lblLogIn" runat="server" BackColor="White" Font-Size="X-Large" Text="LogIn"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style23">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style24">
                    <asp:Label ID="lblNombreUsuario" runat="server" BackColor="White" Text="Usuario :"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style23">
                    <asp:TextBox ID="txtNombreUsuario" runat="server" Width="166px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style23">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style23">
                    <asp:Label ID="lblContrasena" runat="server" BackColor="White" Text="Contraseña :"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style23">
                    <asp:TextBox ID="txtContrasena" runat="server" Width="169px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style23">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">
                    <asp:Button ID="btnEntrar" runat="server" Text="Entrar" Width="135px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style26"></td>
            </tr>
            <tr>
                <td class="auto-style23">
                    <asp:Button ID="btnVerProductos" runat="server" Text="Ver Productos" Width="118px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style27">&nbsp;</td>
            </tr>
        </table>
    </p>
    </asp:Content>
