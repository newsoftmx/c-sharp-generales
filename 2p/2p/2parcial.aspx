<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2parcial.aspx.cs" Inherits="_2p._2parcial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Nombre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
            <br />
            Apellido Paterno&nbsp;
            <asp:TextBox ID="txtapellidopa" runat="server"></asp:TextBox>
&nbsp;<br />
            Apellido Materno
            <asp:TextBox ID="txtapellidoma" runat="server"></asp:TextBox>
            <br />
            <br />
            Monto Solicitado
            <asp:TextBox ID="txtmontosolicitado" runat="server"></asp:TextBox>
            <br />
            Plazo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtplazo" runat="server"></asp:TextBox>
&nbsp;<br />
            Interes&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtinteres" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calcular" />
        </div>
    </form>
</body>
</html>
