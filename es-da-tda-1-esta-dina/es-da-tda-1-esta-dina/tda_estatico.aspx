<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tda_estatico.aspx.cs" Inherits="es_da_tda_1_esta_dina.tda_estatico" %>

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
            El valor del arreglo es:
            <asp:Label ID="lblValorArreglo" runat="server" Text="[0,0,0,0,0]"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnLlenarArreglo" runat="server" OnClick="btnLlenarArreglo_Click" Text="Llenar arreglo" />
            <br />
            <br />
            <asp:Button ID="btnVaciarArreglo" runat="server" OnClick="btnVaciarArreglo_Click" Text="Vaciar Areglo" />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
