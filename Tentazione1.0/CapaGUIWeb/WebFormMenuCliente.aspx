<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageTentazione.Master" AutoEventWireup="true" CodeBehind="WebFormMenuCliente.aspx.cs" Inherits="CapaGUIWeb.WebFormMenuCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style19 {
        height: 26px;
    }
    .auto-style20 {
        width: 108%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="auto-style20">
    <tr>
        <td class="auto-style19">
            <asp:Label ID="lblMenuCliente" runat="server" BackColor="White" Text="Menú"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:HyperLink ID="HypPerfil" runat="server" ForeColor="Black" NavigateUrl="~/WebFormPerfilCliente.aspx">Perfil</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td>
            <asp:HyperLink ID="HyplnkGenerarCotizacion" runat="server" ForeColor="Black" NavigateUrl="~/WebFormPantallaGenerarCotizacion.aspx">Generar Cotización</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td>
            <asp:HyperLink ID="hyplnkRevisarCotizacion" runat="server">Revisar Cotización</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td>
            <asp:HyperLink ID="HyplnkCerrarSesion" runat="server" ForeColor="Black" NavigateUrl="~/WebFormlogin.aspx">Cerrar Sesión</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
