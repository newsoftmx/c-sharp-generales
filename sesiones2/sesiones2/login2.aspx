<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login2.aspx.cs" Inherits="sesiones2.login2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body onload="document.form1.submit();">
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        Esta página se cargará y tomará el valor de la variable de sesión y si este existe en MySQL, entonces pasara a la página servicios<br />
        <br />
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnIngreso" runat="server" OnClick="btnIngreso_Click" Text="Ingresar" Width="193px" />
        <br />
    
    </div>
    </form>
</body>
</html>
