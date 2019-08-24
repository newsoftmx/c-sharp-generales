<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <form id="Form1" runat="server" method="post">
    Excelente contenido&nbsp;&nbsp;&nbsp;&nbsp;<br />
<br />
Usuario
<asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
<br />
<br />
Password
<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
<br />
<br />
<asp:Button ID="btnAceptar" runat="server" PostBackUrl="~/lecturaPost.aspx" Text="aceptar" />
<br />
<br />
<br />
&nbsp;&nbsp;
    <br />
&nbsp;<br />
    </form>
</asp:Content>

