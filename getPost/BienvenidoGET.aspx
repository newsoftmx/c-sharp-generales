<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BienvenidoGET.aspx.cs" Inherits="BienvenidoGET" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Bienvenido al sitio web de sus películas favoritas
        por el método GET<br />
        <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
&nbsp;<asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
        <h1>
            <%Response.Write("Su nombre es: " + Request.QueryString["txtUsuario"].ToString() + "<br>");
          Response.Write("Su password es: " + Request.QueryString["txtPassword"].ToString() + "<br>"); %>
        </h1>
    
    </div>
    </form>
</body>
</html>
