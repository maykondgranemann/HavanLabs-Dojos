<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Produto.aspx.cs" Inherits="WebApp.Produto" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <h1>Cadastro Produto</h1>
    <h6>Digite as infos do Produto</h6>

    <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
    <asp:TextBox ID="txbId" runat="server"></asp:TextBox> <br />
    <asp:Label ID="Label2" runat="server" Text="Nome"></asp:Label>
    <asp:TextBox ID="txbNome" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label3" runat="server" Text="Descrição"></asp:Label>
    <asp:TextBox ID="txbDescricao" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label4" runat="server" Text="Valor"></asp:Label>
    <asp:TextBox ID="txbValor" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />

    <asp:GridView ID="gdProdutos" runat="server"></asp:GridView>

</asp:Content>