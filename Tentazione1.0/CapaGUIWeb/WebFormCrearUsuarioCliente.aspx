<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageTentazione.Master" AutoEventWireup="true" CodeBehind="WebFormCrearUsuarioCliente.aspx.cs" Inherits="CapaGUIWeb.WebFormCrearUsuarioCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style20 {
            width: 100%;
        }
        .auto-style21 {
            text-align: center;
            width: 889px;
        }
        .auto-style22 {
            width: 889px;
        }
        .auto-style23 {
            width: 42%;
            height: 310px;
        }
        .auto-style24 {
            width: 169px;
        }
        .auto-style25 {
            width: 169px;
            height: 29px;
            text-align: right;
        }
        .auto-style26 {
            height: 29px;
        }
        .auto-style27 {
            text-align: center;
        }
        .auto-style28 {
            width: 169px;
            text-align: center;
        }
        .auto-style29 {
            width: 169px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <table class="auto-style23">
        <tr>
            <td class="auto-style21">
                <asp:Label ID="lblCrearUsuario" runat="server" BackColor="White" Font-Size="XX-Large" Text="Crear Perfil"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style22">
                <table class="auto-style20">
                    <tr>
                        <td class="auto-style24">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style29">
                            <asp:Label ID="lblNombreUsuario" runat="server" BackColor="White" Text="Nombre Usuario :"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style25">
                            <asp:Label ID="lblContrasena" runat="server" BackColor="White" Text="Contraseña"></asp:Label>
                        </td>
                        <td class="auto-style26">
                            <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style29">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style28">
                            <asp:Button ID="btnCrear" runat="server" Text="Crear" />
                        </td>
                        <td class="auto-style27">
                            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="auto-style22">&nbsp;</td>
        </tr>
    </table>
    <br />
    <br />
</asp:Content>
