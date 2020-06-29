<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageTentazione.Master" AutoEventWireup="true" CodeBehind="WebFormPantallaGenerarCotizacion.aspx.cs" Inherits="CapaGUIWeb.WebFormPantallaGenerarCotizacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style19 {
        text-align: center;
    }
    .auto-style20 {
        width: 353px;
    }
    .auto-style22 {
        width: 85px;
    }
    .auto-style23 {
        width: 100%;
        height: 261px;
    }
    .auto-style26 {
        width: 137px;
        height: 31px;
    }
    .auto-style27 {
        width: 65px;
        height: 31px;
    }
    .auto-style28 {
        height: 31px;
    }
    .auto-style30 {
        width: 137px;
    }
    .auto-style31 {
        width: 65px;
    }
    .auto-style32 {
        width: 137px;
        height: 26px;
    }
    .auto-style33 {
        width: 65px;
        height: 26px;
    }
    .auto-style34 {
        height: 26px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
    <tr>
        <td class="auto-style19">
            <asp:Label ID="lblGenerarCotizacion" runat="server" BackColor="White" Font-Size="XX-Large" Text="Generar Cotización"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style22">
                        <asp:GridView ID="GridViewListaProductos" runat="server" BackColor="White" Height="263px" Width="392px">
                        </asp:GridView>
                    </td>
                    <td class="auto-style20">
                        <table class="auto-style23">
                            <tr>
                                <td class="auto-style30">&nbsp;</td>
                                <td class="auto-style31">&nbsp;</td>
                                <td>
                                    <asp:Button ID="btnCerrarSesion" runat="server" Height="22px" Text="Cerrar Sesión" Width="116px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style26">
                                    <asp:TextBox ID="txtNombreProducto" runat="server" Width="133px"></asp:TextBox>
                                </td>
                                <td class="auto-style27">
                                    <asp:Button ID="btnBuscarProducto" runat="server" Text="Buscar" />
                                </td>
                                <td class="auto-style28"></td>
                            </tr>
                            <tr>
                                <td class="auto-style30">&nbsp;</td>
                                <td class="auto-style31">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style32">
                                    <asp:Button ID="btnConfirmarCotizacion" runat="server" Height="36px" Text="Confirmar Cotización" Width="201px" />
                                </td>
                                <td class="auto-style33">
                                    <asp:Button ID="btnGenerarCotización" runat="server" Height="35px" Text="Generar Cotización" />
                                </td>
                                <td class="auto-style34"></td>
                            </tr>
                            <tr>
                                <td class="auto-style30">
                                    <asp:Button ID="btnListarProductos" runat="server" Height="32px" Text="Listar" Width="200px" />
                                </td>
                                <td class="auto-style31">
                                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="214px" />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style30">&nbsp;</td>
                                <td class="auto-style31">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style30">&nbsp;</td>
                                <td class="auto-style31">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
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
