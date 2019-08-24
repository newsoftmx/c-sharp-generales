<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Programa_3_Examen.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <br />
            Nombre:
            <asp:TextBox ID="txtNombre" runat="server" OnTextChanged="TextBox1_TextChanged">Nombre</asp:TextBox>
        </p>
        <p>
            Sueldo:
            <asp:TextBox ID="txtSueldo" runat="server">Sueldo</asp:TextBox>
&nbsp;<asp:Label ID="lblObservaSueldo" runat="server" Text="Observaciones Sueldo"></asp:Label>
        </p>
        <p>
            Porcentaje:
            <asp:TextBox ID="txtPorcentaje" runat="server">Porcentaje</asp:TextBox>
&nbsp;<asp:Label ID="lblObservaPorcentaje" runat="server" Text="Observaciones Porcentaje"></asp:Label>
        </p>
        <p>
            Ganancia:
            <asp:Label ID="lblGanancia" runat="server" Text="Ganancia"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnVerificadorGanancia" runat="server" OnClick="btnVerificadorGanancia_Click" Text="Verificador de Ganancia" Width="262px" />
        </p>
        <p>
            Muchas gracias , usted tiene un sueldo de&nbsp; y una ganancia de
            <asp:Label ID="lblGanancia0" runat="server" Text="Ganancia"></asp:Label>
        </p>
        <div>
        </div>
    </form>
</body>
</html>
