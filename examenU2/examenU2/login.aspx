<%@ Page Title="" Language="C#" MasterPageFile="~/MP1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="examenU2.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" method="post" enctype="multipart/form-data">  
   <br />
Usuario:
<asp:TextBox ID="txtUsuario" runat="server" ViewStateMode="Enabled"></asp:TextBox>
<br />
Password:
<asp:TextBox ID="txtPassword" runat="server" ViewStateMode="Enabled"></asp:TextBox>
<br />
<br />
<asp:Button ID="btnAceptar" runat="server" PostBackUrl="~/lecturaPost.aspx" Text="aceptar" OnClick="btnAceptar_Click" />
<br />
</form>
</asp:Content>
