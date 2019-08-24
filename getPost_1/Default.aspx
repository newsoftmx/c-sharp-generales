<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post">
    <div>
    
        <br />
        Inicio de Sesión<br />
        <br />
        Usuario&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtUsuario" runat="server" name="usuario"></asp:TextBox>
        <br />
        <br />
        Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAceptar" runat="server" PostBackUrl="~/bienvenidos.aspx" Text="Iniciar Sesion" />
        <br />
        <br />
        <br />
        Este es un control html<br />
        <br />
        <br />
        <input type="text" />
        &nbsp;&nbsp;&nbsp;&nbsp; </div>
    </form>
    <form id="form2" method="post" action="http://localhost:90/post/lectura_post.php">
        Formulario usado para enviar datos por 
        m&eacute;todo post hasta server Apache
        <br />
        Usuario:
        <input type="text" name="txtUsuarioPost" />
        <br />
        Password:
        <br />
        <input type="text" name="txtPasswordPost" />
        <br /><input type="submit" value="Ingresar" id="enviarPost" />
        <input type="reset" value="Cancelar" /> 
    </form>
    <form id="form3" method="get" action="http://localhost:90/post/lectura_get.php">
        Formulario usado para enviar datos por 
        m&eacute;todo GET hasta server Apache
        <br />
        Usuario:
        <input type="text" name="txtUsuarioGet" />
        <br />
        Password:
        <br />
        <input type="text" name="txtPasswordGet" />
        <br /><input type="submit" value="Ingresar" id="enviarGet" />
        <input type="reset" value="Cancelar" /> 
    </form>
</body>

</html>
