<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageTentazione.Master" AutoEventWireup="true" CodeBehind="WebFormlogin.aspx.cs" Inherits="CapaGUIWeb.WebFormlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <p>
        <asp:Label ID="lblNombreUsuario" runat="server" Text="Usuario" BackColor="White"></asp:Label>
        <asp:TextBox ID="txtNombreUsuario" runat="server" ></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="LblContrasena" runat="server" Text="Contraseña" BackColor="White"></asp:Label>
        <asp:TextBox ID="txtContrasena" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnEntrar" runat="server" Text="Entrar" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
