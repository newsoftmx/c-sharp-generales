<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tda_estatico.aspx.cs" Inherits="estruc_datos_tda_1.tda_estatico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Posicion 0:&nbsp;
            <asp:TextBox ID="txtP0" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblImpresionArreglo" runat="server" Text="Sin valores"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnLlenarArreglo" runat="server" OnClick="btnLlenarArreglo_Click" Text="Llenar arreglo" />
            <br />
            <br />
            <asp:Button ID="btnImprimirArreglo" runat="server" OnClick="btnImprimirArreglo_Click" Text="Imprimir Arreglo" />
        </div>
    </form>
</body>
</html>
