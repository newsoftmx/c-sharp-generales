<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="examen.aspx.cs" Inherits="Examen_del_pony.examen" %>

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
            Nombre<asp:TextBox ID="txtNombre" runat="server" OnTextChanged="TextBox1_TextChanged" style="height: 22px; margin-top: 0px"></asp:TextBox>
            <br />
            <br />
            Apellido Paterno<asp:TextBox ID="txtApellidoPaterno" runat="server" OnTextChanged="txtApellidoPaterno_TextChanged"></asp:TextBox>
            <br />
            <br />
            Apellido Materno<asp:TextBox ID="txtApellidoMaaterno" runat="server" OnTextChanged="txtApellidoMaaterno_TextChanged"></asp:TextBox>
            <br />
            <br />
            Plazo<asp:TextBox ID="txtPlazo" runat="server" OnTextChanged="txtPlazo_TextChanged"></asp:TextBox>
            <br />
            <br />
            Interes<asp:TextBox ID="txtInteres" runat="server" OnTextChanged="txtInteres_TextChanged"></asp:TextBox>
            <br />
            <br />
            Monto
            <asp:TextBox ID="txtMonto" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblTablaAmortizacion" runat="server" ForeColor="#000099"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcula tu prestamo " />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
