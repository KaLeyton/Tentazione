<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageTentazione.Master" AutoEventWireup="true" CodeBehind="WebFormMenuInicio.aspx.cs" Inherits="CapaGUIWeb.WebFormMenuInicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style19 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style19">
                <asp:HyperLink ID="HyperLinkIniciarSesion" runat="server" ForeColor="Black" NavigateUrl="~/WebFormlogin.aspx">Iniciar Sesión</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLinkCrearCliente" runat="server" ForeColor="Black" NavigateUrl="~/WebFormCrearUsuarioCliente.aspx">Crear Perfil</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLinkVerProductos" runat="server" ForeColor="Black" NavigateUrl="~/WebFormListarProductos.aspx">Ver Productos</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
