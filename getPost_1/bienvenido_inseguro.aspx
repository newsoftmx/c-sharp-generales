<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bienvenido_inseguro.aspx.cs" Inherits="bienvenido_inseguro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Hola&nbsp; estas pasando datos por GET, tu usuario es
        <asp:Label ID="lblUsuario" runat="server" Text="No ha iniciado sesión"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <%
            Response.Write("Su nombre de usuario es: " 
                + Request.QueryString["txtUsuario"].ToString() 
                + "<br/>");
             %>
    </div>
    </form>
</body>
</html>
