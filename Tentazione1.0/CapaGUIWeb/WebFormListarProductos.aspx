<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageTentazione.Master" AutoEventWireup="true" CodeBehind="WebFormListarProductos.aspx.cs" Inherits="CapaGUIWeb.WebFormListarProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style19 {
        width: 100%;
        height: 306px;
    }
    .auto-style20 {
        height: 66px;
        text-align: center;
    }
    .auto-style21 {
        width: 100%;
    }
    .auto-style22 {
        text-align: center;
    }
    .auto-style23 {
        width: 273px;
    }
    .auto-style24 {
        width: 213px;
    }
    .auto-style25 {
        width: 145%;
    }
    .auto-style26 {
        width: 164px;
    }
    .auto-style27 {
        text-align: center;
        width: 409px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style19">
    <tr>
        <td class="auto-style20">
            <asp:Label ID="lblListaProductos" runat="server" BackColor="White" Font-Size="XX-Large" Text="Lista Productos"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <table class="auto-style21">
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style24">
                        <table class="auto-style25">
                            <tr>
                                <td class="auto-style26">
                                    <asp:TextBox ID="TextBox1" runat="server" Width="184px"></asp:TextBox>
                                </td>
                                <td class="auto-style22">
                                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style24">
                        <asp:GridView ID="GridView1" runat="server" BackColor="White" Height="197px" Width="309px">
                        </asp:GridView>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style24">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style27">
                        <asp:Button ID="btnListarProductos" runat="server" Text="Listar Productos" Width="177px" />
                    </td>
                    <td class="auto-style22">
                        <asp:Button ID="btnLogIn" runat="server" Text="LogIn" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
