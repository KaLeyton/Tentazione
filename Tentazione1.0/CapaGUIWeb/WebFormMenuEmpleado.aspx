<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageTentazione.Master" AutoEventWireup="true" CodeBehind="WebFormMenuEmpleado.aspx.cs" Inherits="CapaGUIWeb.WebFormMenuEmpleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style19 {
        width: 106%;
    }
    .auto-style20 {
        width: 188px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="auto-style19">
    <tr>
        <td class="auto-style20">
            <asp:Label ID="lblMenu" runat="server" BackColor="White" Text="Menú :"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style20">
            <asp:HyperLink ID="hyplnkAdministrarClientes" runat="server" ForeColor="Black" NavigateUrl="~/WebFormAdministrarClientes.aspx">Administrar Clientes.</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="auto-style20">
            <asp:HyperLink ID="hyplinkAdministrarProductos" runat="server" ForeColor="Black" NavigateUrl="~/WebFormAdministrarProductos.aspx">Administrar Productos</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="auto-style20">
            <asp:HyperLink ID="hyplnkRevisarCotizaciones" runat="server">Revisar Cotizaciones</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="auto-style20">
            <asp:HyperLink ID="hyplnkCerrarSesion" runat="server" ForeColor="Black" NavigateUrl="~/WebFormlogin.aspx">Cerrar Sesión</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="auto-style20">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style20">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style20">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style20">&nbsp;</td>
    </tr>
</table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
