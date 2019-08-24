<%@ Page Language="C#" AutoEventWireup="true" CodeFile="inicio_session.aspx.cs" Inherits="inicio_session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="get">
    <div>
    
        <br />
        Inicio de Sesión<br />
        <br />
        Usuario&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br />
        <br />
        Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAceptar" runat="server" PostBackUrl="~/bienvenido_inseguro.aspx" Text="Iniciar Sesion" />
        <br />
        <br />
        <br />
        Este es un control html<br />
        <br />
        <br />
        <input type="text" />
        &nbsp;&nbsp;&nbsp;&nbsp; 
    
    </div>
    </form>
</body>
</html>
