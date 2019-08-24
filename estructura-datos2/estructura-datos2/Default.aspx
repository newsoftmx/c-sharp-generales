<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="estructura_datos2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Suma de dos números enteros<br />
            Número 1:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNumero1" runat="server"></asp:TextBox>
            <br />
            Numero 2:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNumero2" runat="server"></asp:TextBox>
            <br />
            <br />
            Número 3:
            <asp:TextBox ID="txtNumero3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnPX" runat="server" OnClick="Button1_Click" Text="PX" />
&nbsp;<asp:Button ID="btnVector3D" runat="server" OnClick="btnVector3D_Click" Text="Vector 3D" />
            <br />
            <br />
            El valor del vector es px: <asp:Label ID="lblPX" runat="server" Text="0"></asp:Label>
&nbsp;py:
            <asp:Label ID="lblPY" runat="server" Text="0"></asp:Label>
&nbsp;pz:
            <asp:Label ID="lblPZ" runat="server" Text="0"></asp:Label>
            <br />
            <br />
            El valor de la suma de dos números enteros es <asp:Label ID="lblResultadoSuma" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnSuma" runat="server" OnClick="btnSuma_Click" Text="Sumar" />
        </div>
    </form>
</body>
</html>
