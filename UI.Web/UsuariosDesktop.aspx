<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuariosDesktop.aspx.cs" Inherits="UI.Web.UsuariosDesktop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 317px;
        }
        .auto-style2 {
            width: 165px;
        }
        .auto-style5 {
            width: 86px;
        }
        .auto-style6 {
            width: 63px;
        }
        .auto-style7 {
            width: 132px;
        }
        .auto-style8 {
            width: 95px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="LblNombre" runat="server" Text="Nombre"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TxtBxNombre" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="LblApellido" runat="server" Text="Apellido"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtBxApellido" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="LblNombreUsuario" runat="server" Text="Nombre de Usuario"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TxtBxNombreUsu" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="LblEmail" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtBxEmail" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="LblClave" runat="server" Text="Clave"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TxtBxClave" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="LblRepetirClave" runat="server" Text="Repetir Clave"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtBxRepClave" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Label ID="LblHabilitado" runat="server" Text="Habilitado"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBox ID="ChkBxHabilitado" runat="server" OnInit="ChkBxHabilitado_Init" />
                    </td>
                    <td class="auto-style5">
                        <asp:Button ID="BtnCancelar" runat="server" OnClick="BtnCancelar_Click" Text="Cancelar" />
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="BtnGuardar" runat="server" OnClick="BtnGuardar_Click" Text="Guardar" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
