<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageTentazione.Master" AutoEventWireup="true" CodeBehind="WebFormMantenedorUsuario.aspx.cs" Inherits="CapaGUIWeb.WebFormMantenedorProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
<p>
</p>
<p>
    <asp:GridView ID="GridViewUsuario" runat="server" BackColor="White">
    </asp:GridView>
</p>
<p>
    <asp:Button ID="btnListarUsuario" runat="server" OnClick="btnListarUsuario_Click" Text="Listar" Width="79px" />
</p>



<p>
</p>
</asp:Content>
