<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tda_dinamico.aspx.cs" Inherits="es_da_tda_1_esta_dina.tda_dinamico" %>

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
            Valor del arreglo estatico:
            <asp:TextBox ID="txtValorDinamico" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDatoDinamico" runat="server" Text="0"></asp:Label>
            <br />
            <br />
            el valor del arreglo es:
            <asp:Label ID="lblTamaño" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnProbarDinamico" runat="server" OnClick="btnProbarDinamico_Click" Text="Probar dinámico" />
            &nbsp;<br />
            Count:
            <asp:Label ID="lblCount" runat="server" Text="Label"></asp:Label>
            <br />
            Clear: <asp:Label ID="lblClear" runat="server" Text="Label"></asp:Label>
            <br />
            Contains: <asp:Label ID="lblContains" runat="server" Text="Label"></asp:Label>
            <br />
            Remove: <asp:Label ID="lblRemove" runat="server" Text="Label"></asp:Label>
            <br />
            Sort: <asp:Label ID="lblSort" runat="server" Text="Label"></asp:Label>
            <br />
            Reverse:
            <asp:Label ID="lblReverse" runat="server" Text="Label"></asp:Label>
            <br />
            Contiene:
            <asp:TextBox ID="txtContiene" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCount" runat="server" OnClick="btnCount_Click" Text="Count" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnContains" runat="server" Text="Contains" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnRemove" runat="server" OnClick="btnRemove_Click" Text="Remove" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSort" runat="server" Text="Sort" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnReverse" runat="server" Text="Reverse" />
            <br />
            <br />
            <asp:Button ID="btnGaby" runat="server" OnClick="btnGaby_Click" Text="Barbie Gaby" />
            <br />
            <br />
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
