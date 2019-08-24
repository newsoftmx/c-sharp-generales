<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="carpetas.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Ingrese los datos correspondientes para ingresar al sistema<br />
        <br />
        Usuario:
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br />
        Password:
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
&nbsp;<br />
        <br />
        <asp:Label ID="lblProceso" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnIngresar" runat="server" OnClick="btnIngresar_Click" Text="Ingresar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
    
    </div>
    </form>
</body>
</html>
