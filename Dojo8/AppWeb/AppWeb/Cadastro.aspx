<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="AppWeb.Cadastro" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset>
        <legend>Novo Carro</legend>
        <label for="txtId">ID</label>
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>

        <label for="txtMarca">Marca</label>
        <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>

        <label for="txtModelo">Modelo</label>
        <asp:TextBox ID="txtModelo" runat="server"></asp:TextBox>
        <div id="botoes">
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            <asp:Button ID="btnLimpar" runat="server" Text="Limpar" />
        </div>
    </fieldset>
</asp:Content>
