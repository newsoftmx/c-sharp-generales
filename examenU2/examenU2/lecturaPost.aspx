<%@ Page Title="" Language="C#" MasterPageFile="~/MP1.Master" AutoEventWireup="true" CodeBehind="lecturaPost.aspx.cs" Inherits="examenU2.lecturaPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    
        <%
            //Response.Write(Request.Form["txtUsuario"].ToString());
            //Response.Write(Request.Form["txtPassword"].ToString());
        %>
<asp:Label ID="lblUsuario" runat="server" Text="usuario"></asp:Label>
<br />
<asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
<br />
    
</asp:Content>
