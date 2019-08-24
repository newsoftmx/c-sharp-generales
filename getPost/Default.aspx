<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post" >
        
            <asp:Label ID="lblUsuario" runat="server" Text="Usuario "></asp:Label>
&nbsp;<asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPassword" runat="server" Text="Password "></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
            <asp:Button ID="btnEnviarGET" runat="server" PostBackUrl="BienvenidoGET.aspx" Text="Enviar por GET" />
&nbsp;<br />
            <br />
            <asp:Label ID="lblUsuarioPost" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox ID="txtUsuarioPost" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPasswordPost" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPasswordPost" runat="server"></asp:TextBox>
            <br />
            <br />
        <asp:Button ID="btnEnviarPost" runat="server" Text="Enviar por POST" PostBackUrl="BienvenidoPOST.aspx" OnClick="btnEnviarPost_Click"   />
            <br />
        <br />
            
        </form>
    
</body>
</html>
