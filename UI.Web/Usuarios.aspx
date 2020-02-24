<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 29px;
        }
        .auto-style2 {
            margin-left: 5px;
        }
        .auto-style3 {
            text-align: right;
        }
        .auto-style4 {
            height: 174px;
        }
        .auto-style5 {
            height: 174px;
            width: 1px;
        }
        .auto-style6 {
            height: 174px;
            width: 566px;
        }
    </style>
</head>
<body style="height: 303px">
    <form id="form1" runat="server">
        <div>
            <br />
            Usuarios Existentes</div>
        <table style="width: 90%; height: 234px; margin-left: 49px; margin-top: 21px;">
            <tr>
                <td class="auto-style1" colspan="3">
                    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" />
                    <asp:Button ID="btnEditar" runat="server" CssClass="auto-style2" Text="Editar" />
                    <asp:Button ID="btnBorrar" runat="server" CssClass="auto-style2" Text="Borrar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style6"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="3">
                    <asp:Button ID="btnActualizar" runat="server" Height="23px" Text="Actualizar" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
