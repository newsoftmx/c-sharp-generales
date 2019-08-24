<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="mastePagePractica._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Bienvenidos a las Master Page</h1>
    <p style="padding:.5em .5em .5em .5em;"> contenedor será para mostrar el contenido de la pagina default, dentro de la pagina maestra</p>
    <p style="padding:.5em .5em .5em .5em;"> 
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p style="padding:.5em .5em .5em .5em;"> 
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p style="padding:.5em .5em .5em .5em;"> 
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </p>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <p>Excelente fin de semana, es el contentPlaceHolder4</p>
</asp:Content>
<asp:Content ID="Contenedor4" ContentPlaceHolderID="Contenedor4" runat="server">
    <p>El ultimo en mostrar es el contenedor 4, sin importar el orden, afectan en la misma posicion </p>
</asp:Content>
<asp:Content id="Contenedor3" ContentPlaceHolderID="Contenedor3" runat="server">
    <p id="P1">Como pueden ver tendo en desorden la alteracion de los contenedores, este es el contenedor 3</p>
</asp:Content>

