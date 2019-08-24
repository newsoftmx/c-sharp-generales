<%@ Page Title="" Language="C#" MasterPageFile="~/MP1.Master" AutoEventWireup="true" CodeBehind="logueo.aspx.cs" Inherits="examenU2.logueo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form2" action="lecturaPost.aspx" method="post">
        Usuario:
        <input name="txtUsuario" id="txtUsuario" type="text" /><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <br />
        <br />
        Password: <input id="txtPassword" type="text" /><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <br />
        <br />
        <input id="btnIngresar" name="txtPassword" type="submit" value="ingresar" />
    </form>
</asp:Content>
