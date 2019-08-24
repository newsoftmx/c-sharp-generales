<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BienvenidoPOST.aspx.cs" Inherits="Bienvenido" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Bienvenido al sitio web de sus películas favoritas
        por el método POST<br />
        Usted ha ingresado como
        <asp:Label ID="lblUsuario" runat="server" Text="Nombre de Usuario"></asp:Label>
&nbsp;<asp:Label ID="lblPassword" runat="server" Text="Password de Usuario"></asp:Label>
        <br />
        <br />
        <h1>
            <%
                Response.Write("Su nombre es: " + Request.Form["txtUsuarioPost"].ToString() + "<br>");
                Response.Write("Su password es: " + Request.Form["txtPasswordPost"].ToString() + "<br>");
            %>
        </h1>
    </div>
    </form>
</body>
</html>
