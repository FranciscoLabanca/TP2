<%@ Page Title="Materias" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Materias.aspx.cs" Inherits="UI.Web.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="desc_materias" HeaderText="descripcion"  />
                <asp:BoundField DataField="hs_semanales" HeaderText="horas semanales" />
                <asp:BoundField DataField="hs_totales" HeaderText="horas totales" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />

            </Columns>
        </asp:GridView>
    </asp:Panel>
    <asp:Panel ID="formPanel" Visible="false" runat="server">
        <asp:Label ID="descLabel" runat="server" Text="Descripcion: "></asp:Label>
        <asp:TextBox ID="descTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="hsemLabel" runat="server" Text="Horas semanales: "></asp:Label> 
        <asp:TextBox ID="hsemTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="htotLabel" runat="server" Text="Horas totales: "></asp:Label>
        <asp:TextBox ID="htotTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Panel ID="formActionsPanel" runat="server">
             <asp:LinkButton ID="LinkButton1" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
             <asp:LinkButton ID="LinkButton2" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
        </asp:Panel>
    </asp:Panel>
    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="LinkButton4" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="LinkButton5" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>
</asp:Content>