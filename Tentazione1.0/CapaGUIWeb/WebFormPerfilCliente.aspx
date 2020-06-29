<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageTentazione.Master" AutoEventWireup="true" CodeBehind="WebFormPerfilCliente.aspx.cs" Inherits="CapaGUIWeb.WebFormPerfilCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style19 {
        text-align: center;
        width: 324px;
    }
    .auto-style20 {
        width: 109%;
    }
    .auto-style21 {
        width: 324px;
    }
    .auto-style22 {
        width: 41%;
    }
    .auto-style23 {
        height: 26px;
    }
    .auto-style24 {
        text-align: right;
    }
    .auto-style25 {
        width: 177px;
    }
    .auto-style26 {
        height: 26px;
        width: 177px;
    }
    .auto-style27 {
        height: 26px;
        width: 177px;
        text-align: right;
    }
    .auto-style28 {
        width: 110px;
        text-align: center;
    }
    .auto-style29 {
        text-align: center;
    }
    .auto-style30 {
        margin-left: 56px;
    }
    .auto-style31 {
        text-align: center;
        width: 111px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style22">
    <tr>
        <td class="auto-style19">
            <asp:Label ID="lblEditarPerfil" runat="server" BackColor="White" Font-Size="XX-Large" Text="Perfil"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style21">
            <table class="auto-style20">
                <tr>
                    <td class="auto-style25">&nbsp;</td>
                    <td class="auto-style24">
                        <asp:Button ID="btnCerrarSesion" runat="server" CssClass="auto-style30" Height="27px" Text="Cerrar Sesión" Width="115px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style26"></td>
                    <td class="auto-style23"></td>
                </tr>
                <tr>
                    <td class="auto-style27">
                        <asp:Label ID="lblIdCliente" runat="server" BackColor="White" Text="Id Cliente :"></asp:Label>
                    </td>
                    <td class="auto-style23">
                        <asp:TextBox ID="txtIdCliente" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style27">
                        <asp:Label ID="lblNombreCompleto" runat="server" BackColor="White" Text="Nombre Completo :"></asp:Label>
                    </td>
                    <td class="auto-style23">
                        <asp:TextBox ID="txtNombreCompleto" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style27">
                        <asp:Label ID="lblEdad" runat="server" BackColor="White" Text="Edad :"></asp:Label>
                    </td>
                    <td class="auto-style23">
                        <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style27">
                        <asp:Label ID="lblTelefono" runat="server" BackColor="White" Text="Telefono :"></asp:Label>
                    </td>
                    <td class="auto-style23">
                        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style27">
                        <asp:Label ID="lblEmail" runat="server" BackColor="White" Text="Email :"></asp:Label>
                    </td>
                    <td class="auto-style23">
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style27">
                        <asp:Label ID="lblSexo" runat="server" BackColor="White" Text="Sexo :"></asp:Label>
                    </td>
                    <td class="auto-style23">
                        <asp:TextBox ID="txtSexo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style25">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="auto-style21">
            <table class="auto-style20">
                <tr>
                    <td class="auto-style28">
                        <asp:Button ID="btnEditar" runat="server" Text="Editar" />
                    </td>
                    <td class="auto-style31">
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Width="75px" />
                    </td>
                    <td class="auto-style29">
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="79px" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
</asp:Content>
