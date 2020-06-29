<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageTentazione.Master" AutoEventWireup="true" CodeBehind="WebFormAdministrarClientes.aspx.cs" Inherits="CapaGUIWeb.WebFormMantenedorProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style21 {
            width: 100%;
        }
        .auto-style23 {
        width: 387px;
    }
        .auto-style24 {
            width: 387px;
            text-align: left;
        }
    .auto-style25 {
        width: 52px;
    }
    .auto-style26 {
        width: 17px;
    }
    .auto-style27 {
        width: 11px;
    }
        .auto-style28 {
            width: 43px;
            text-align: center;
        }
        .auto-style29 {
            text-align: center;
        }
        .auto-style31 {
            width: 387px;
            text-align: center;
            height: 26px;
        }
        .auto-style32 {
            width: 43px;
            text-align: center;
            height: 26px;
        }
        .auto-style36 {
            width: 15px;
            text-align: left;
        }
        .auto-style37 {
            width: 102%;
        }
        .auto-style38 {
            text-align: right;
            height: 26px;
        }
        .auto-style39 {
            width: 299px;
            text-align: center;
            height: 26px;
        }
        .auto-style40 {
        width: 299px;
        text-align: center;
    }
        .auto-style42 {
            width: 15px;
            height: 247px;
        }
        .auto-style43 {
            width: 387px;
            height: 247px;
        }
        .auto-style44 {
            width: 43px;
            text-align: center;
            height: 247px;
        }
        .auto-style45 {
            width: 147px;
            text-align: center;
            height: 247px;
        }
        .auto-style48 {
            height: 29px;
            text-align: right;
        }
        .auto-style49 {
            height: 25px;
            text-align: right;
        }
        .auto-style50 {
            height: 30px;
            text-align: right;
        }
        .auto-style51 {
            text-align: right;
        }
        .auto-style52 {
            margin-left: 0px;
        }
        .auto-style53 {
            height: 28px;
            text-align: right;
        }
    .auto-style54 {
        width: 15px;
        text-align: center;
        height: 26px;
    }
    .auto-style55 {
        width: 15px;
    }
    .auto-style56 {
        text-align: right;
        height: 26px;
        width: 300px;
    }
    .auto-style57 {
        text-align: right;
        width: 300px;
    }
    .auto-style58 {
        width: 300px;
        text-align: center;
        height: 247px;
    }
    .auto-style59 {
        width: 300px;
        text-align: center;
    }
    .auto-style60 {
        width: 299px;
        text-align: center;
        height: 247px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style29">
    <br />
                    <asp:Label ID="lblAdministrarClientes" runat="server" BackColor="White" Text="Administrar Clientes" Font-Size="XX-Large"></asp:Label>
                </div>
        <table class="auto-style21">
            <tr>
                <td class="auto-style54">
                    &nbsp;</td>
                <td class="auto-style31">
                </td>
                <td class="auto-style32"></td>
                <td class="auto-style39"></td>
                <td class="auto-style56">
                    <asp:Button ID="btnCerrarSesion" runat="server" Text="Cerrar Sesión" Height="24px" Width="156px" />
                </td>
                <td class="auto-style38">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style42">
                </td>
                <td class="auto-style43">
                    <asp:GridView ID="GridViewUsuario" runat="server" Height="185px" Width="396px" BackColor="White" BorderColor="Black" ForeColor="Black">
                    </asp:GridView>
                </td>
                <td class="auto-style44"></td>
                <td class="auto-style60">
                    <table style="width:100%;">
                        <tr>
                            <td>
                                <asp:TextBox ID="txtIdCliente" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style53">
                                <asp:Label ID="lblNombreCliente" runat="server" BackColor="White" Text="Nombre Completo :"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style53">
                                <asp:Label ID="lblEdad" runat="server" BackColor="White" Text="Edad :"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style48">
                                <asp:Label ID="lblTelefono" runat="server" BackColor="White" Text="Telefono :"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style49">
                                <asp:Label ID="lblEmail" runat="server" BackColor="White" Text="Email :"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style50">
                                <asp:Label ID="lblSexo" runat="server" BackColor="White" Text="Sexo :"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnNuevoCliente" runat="server" Text="Nuevo Cliente" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="auto-style58">
                    <table style="width:100%;">
                        <tr>
                            <td>
                                <asp:Button ID="btnBuscarCliente" runat="server" Height="28px" Text="Buscar" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="txtNombreCliente" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="txtSexo" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="auto-style45">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style55">
                    &nbsp;</td>
                <td class="auto-style23">
                    &nbsp;</td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style40">&nbsp;</td>
                <td class="auto-style59">&nbsp;</td>
                <td class="auto-style29">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style36">
                    &nbsp;</td>
                <td class="auto-style24">
                    <table class="auto-style37">
                        <tr>
                            <td class="auto-style25">
                                <asp:Button ID="btnListarClientes" runat="server" Text="Listar" />
                            </td>
                            <td class="auto-style29">&nbsp;</td>
                            <td class="auto-style26">
                                <asp:Button ID="btnEditarCliente" runat="server" Text="Editar" />
                            </td>
                            <td class="auto-style29">&nbsp;</td>
                            <td class="auto-style27">
                                <asp:Button ID="btnEliminarCliente" runat="server" Text="Eliminar" Width="68px" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style40">&nbsp;</td>
                <td class="auto-style57">
                    <asp:Button ID="btnSalir" runat="server" CssClass="auto-style52" Text="Salir" Width="66px" />
                </td>
                <td class="auto-style51">
                    &nbsp;</td>
            </tr>
        </table>
</p>
</asp:Content>
