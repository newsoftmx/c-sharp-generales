<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="patitas.aspx.cs" Inherits="proyectoU2.patitas" %>

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
            <br />
            <asp:Label ID="Label1" runat="server" Text="Por favor presiona clic en la raza de la mascota que deseas adoptar"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnMaltes" runat="server" OnClick="btnMaltes_Click" Text="Maltes ($200)" />
&nbsp;&nbsp;
            <asp:Button ID="btnMestizos" runat="server" Text="Mestizos  ($250)" OnClick="btnMestizos_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnPastorIngles" runat="server" Text="Pastor Ingles ($300)" OnClick="btnPastorIngles_Click" />
&nbsp;&nbsp;
            <asp:Button ID="btnChihuahua" runat="server" Text="Chihuahua ($350)" OnClick="btnChihuahua_Click" />
&nbsp;&nbsp;
            <asp:Button ID="btnPitBull" runat="server" Text="Pitbull ($400)" OnClick="btnPitBull_Click" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblMascotaAdoptada" runat="server"></asp:Label>
            <asp:Label ID="lblPrecioAdoptado" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="lblEstatusOperacion" runat="server" BorderColor="Red"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
