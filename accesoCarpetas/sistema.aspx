<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sistema.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">      
        <asp:Label ID="lblErrorNombreUsuario" runat="server" Text="Escriba un nombre de Usuario" Visible="False"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Entrar" OnClick="btnEntrar_Click" />
        <br />
     
  </form>
</body>
</html>
