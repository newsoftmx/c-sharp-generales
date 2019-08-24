<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="autenticacionForms.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        Autenticacion Mediante Forms con Usuarios Controlados por la Configuración
        <br />
        <br />
        Usuario:&nbsp; <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br />
        Password:&nbsp;
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        Recordar datos:
        <asp:CheckBox ID="chkRecordarDatos" runat="server" />
        <br />
        <asp:Label ID="lblMensajeError" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnEntrar" runat="server" OnClick="btnEntrar_Click" Text="Entrar" />
    
    </div>
    </form>
</body>
</html>
