<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="UI.Web.Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 39px;
        }
        .auto-style2 {
            width: 103px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 403px">
            <br />
            <br />
            <table style="width: 66%; height: 120px; margin-left: 193px; margin-top: 0px;">
                <tr>
                    <td class="auto-style1" colspan="3" style="text-align: center">Menu Principal</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnUsuarios" runat="server" Text="Usuarios (WIP - IB)" OnClick="btnUsuarios_Click" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
