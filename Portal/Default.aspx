<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link href="default.css" rel="stylesheet" type="text/css" />
</head>
<body class="transpa" background="fondos.jpg">
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp; Usuario&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtUsuario" runat="server" CssClass="transpa"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="RE1" runat="server" ForeColor="Red" Text="Usario incorrecto" 
            Visible="False"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp; Password<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPassword" runat="server" CssClass="transpa" 
            TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="RE2" runat="server" ForeColor="Red" Text="Password incorrecto" 
            Visible="False"></asp:Label>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" CssClass="transpa" Height="49px" 
            Text="Acceder" />
        <br />
        <br />
        <asp:TextBox ID="txtusu" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:TextBox ID="txtpas" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
