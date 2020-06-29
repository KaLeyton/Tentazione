<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageTentazione.Master" AutoEventWireup="true" CodeBehind="WebFormAdministrarProductos.aspx.cs" Inherits="CapaGUIWeb.WebFormAdministrarProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style44 {
        text-align: center;
    }
    .auto-style46 {
        width: 210px;
    }
    .auto-style47 {
        width: 31px;
    }
    .auto-style48 {
        width: 31px;
        height: 28px;
    }
    .auto-style49 {
        width: 210px;
        height: 28px;
    }
    .auto-style50 {
        width: 66px;
        height: 33px;
    }
    .auto-style51 {
        width: 103%;
    }
    .auto-style52 {
        width: 188px;
        height: 33px;
    }
    .auto-style54 {
        height: 33px;
    }
    .auto-style55 {
        width: 62px;
        height: 33px;
    }
    .auto-style56 {
        width: 136px;
        height: 33px;
    }
    .auto-style57 {
        width: 317px;
        height: 28px;
    }
    .auto-style58 {
        width: 317px;
    }
    .auto-style60 {
        width: 58px;
    }
    .auto-style61 {
        width: 58px;
        height: 28px;
    }
    .auto-style62 {
        width: 100%;
    }
    .auto-style63 {
        margin-left: 0px;
    }
    .auto-style65 {
        height: 29px;
    }
    .auto-style67 {
        height: 29px;
        text-align: right;
    }
    .auto-style69 {
        height: 28px;
        text-align: right;
    }
    .auto-style71 {
        width: 100%;
        height: 217px;
    }
    .auto-style73 {
        height: 35px;
    }
    .auto-style74 {
        height: 24px;
        text-align: right;
    }
    .auto-style75 {
        height: 17px;
    }
    .auto-style76 {
        height: 22px;
        text-align: center;
    }
    .auto-style77 {
        height: 32px;
        text-align: center;
    }
    .auto-style78 {
        text-align: right;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style44">
    <br />
    <asp:Label ID="lblAdministrarClientes" runat="server" BackColor="White" Font-Size="XX-Large" Text="Administrar Clientes"></asp:Label>                    
    </div>

    <table style="width:100%;">
        <tr>
            <td class="auto-style48"></td>
            <td class="auto-style57"></td>
            <td class="auto-style61"></td>
            <td class="auto-style49"></td>
            <td class="auto-style69">
                <asp:Button ID="btnCerrarSesion" runat="server" CssClass="auto-style63" Text="Cerrar Sesión" Width="121px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style47">&nbsp;</td>
            <td class="auto-style58">
                <asp:GridView ID="GridView1" runat="server" BackColor="White" Height="168px" Width="324px">
                </asp:GridView>
            </td>
            <td class="auto-style60">&nbsp;</td>
            <td class="auto-style46">
                <table class="auto-style62">
                    <tr>
                        <td class="auto-style74">
                            <asp:TextBox ID="txtIdCliente" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style67">
                            <asp:Label ID="lblSku" runat="server" BackColor="White" Text="Sku :"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style67">
                            <asp:Label ID="lblNombreProducto" runat="server" BackColor="White" Text="Nombre Producto :"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style67">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style67">
                            <asp:Label ID="lblCantPaquete" runat="server" BackColor="White" Text="Cantidad por Unidad :"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style67">
                            <asp:Label ID="lblValor" runat="server" BackColor="White" Text="Valor :"></asp:Label>
                            <asp:Label ID="lblUnidadMedida" runat="server" BackColor="White" Text="Unidad Medida :"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style76">
                            <asp:Button ID="btnNuevoCliente" runat="server" Text="Nuevo Cliente" />
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <table class="auto-style71">
                    <tr>
                        <td class="auto-style65">
                            <asp:Button ID="btnBuscarCliente" runat="server" Height="26px" Text="Buscar" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style65">
                            <asp:TextBox ID="txtSku" runat="server" Height="16px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtNombreProducto" runat="server" Height="16px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style75">
                            <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtCantPaquete" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style73">
                            <select id="slctUnidadMedida" name="D1">
                                <option></option>
                            </select></td>
                    </tr>
                    <tr>
                        <td class="auto-style77">
                            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="auto-style47">&nbsp;</td>
            <td class="auto-style58">&nbsp;</td>
            <td class="auto-style60">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style47">&nbsp;</td>
            <td class="auto-style58">
                <table class="auto-style51">
                    <tr>
                        <td class="auto-style50">
                            <asp:Button ID="btnListar" runat="server" Text="Listar" Width="67px" />
                        </td>
                        <td class="auto-style56"></td>
                        <td class="auto-style55">
                            <asp:Button ID="btnEditar" runat="server" Text="Editar" />
                        </td>
                        <td class="auto-style52"></td>
                        <td class="auto-style54">
                            <asp:Button ID="btnEliminarCliente" runat="server" Text="Eliminar" />
                        </td>
                    </tr>
                </table>
            </td>
            <td class="auto-style60">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td class="auto-style78">
                <asp:Button ID="btnSalir" runat="server" CssClass="auto-style63" Text="Salir" Width="87px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style47">&nbsp;</td>
            <td class="auto-style58">&nbsp;</td>
            <td class="auto-style60">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        </table>
</asp:Content>
