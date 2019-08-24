<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tda_dinamico.aspx.cs" Inherits="estruc_datos_dinamico.tda_dinamico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            El tamaño del arreglo dinámico es:
            <asp:TextBox ID="txtTamaño" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDatoDinamico" runat="server" Text="0"></asp:Label>
            <br />
            <br />
            El tamño del arreglo dinamico es:
            <asp:Label ID="lblTamañoDinamico" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnProbarDinamico" runat="server" OnClick="btnProbarDinamico_Click" Text="Probar Dato Dinámico" />
            <br />
            <br />
            <br />
            Escriba el valor a eliminar del arreglo:
            <asp:TextBox ID="txtEliminar" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnRemove" runat="server" OnClick="Button1_Click" Text="Remove" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnContains" runat="server" OnClick="btnContains_Click" Text="Contains" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSort" runat="server" OnClick="btnSort_Click" Text="Sort" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnReverse" runat="server" OnClick="btnReverse_Click" Text="Reverse" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button6" runat="server" Text="Button" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
