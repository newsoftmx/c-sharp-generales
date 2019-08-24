<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bienvenidos.aspx.cs" Inherits="bienvenidos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;Bienvenido a su banco personalizado
        <asp:Label ID="lblUsuario" runat="server" Text="No ha iniciado sesión"></asp:Label>
        <br />
        <br />
        de<br />
        fe<br />
        as<br />
        fe<br />
        <br />
        <%
            Response.Write("Su nombre de usuario es : " 
                + Request.Form["txtUsuario"].ToString() 
                + "<br/>"); 
        %>
    </div>
    </form>
</body>
</html>
