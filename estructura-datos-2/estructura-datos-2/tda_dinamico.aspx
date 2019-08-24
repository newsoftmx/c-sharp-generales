<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tda_dinamico.aspx.cs" Inherits="estructura_datos_2.tda_dinamico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Valor del arreglo estatico:
            <asp:TextBox ID="txtValorDinamico" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDatoDinamico" runat="server" Text="0"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnProbarDinamico" runat="server" OnClick="btnProbarDinamico_Click" Text="Probar dinámico" />
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
