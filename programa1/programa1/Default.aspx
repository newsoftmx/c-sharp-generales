<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="programa1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Software para obtener areas de figuras<br />
            <br />
            Area del circulo<br />
            Escriba el valor del radio:
            <asp:TextBox ID="txtRadio" runat="server"></asp:TextBox>
            <br />
            El valor del área es:
            <asp:Label ID="lblAreaCirculo" runat="server" Text="resultado area"></asp:Label>
&nbsp;y el valor del perimetro es:
            <asp:Label ID="lblPerimetroCirculo" runat="server" Text="Resultado Perimetro"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnAreaCirculo" runat="server" OnClick="btnAreaCirculo_Click" Text="Presiona para cálcular área" />
            <br />
            <br />
            Obtención del área de un triangulo<br />
            <br />
            Por favor escriba la base:
            <asp:TextBox ID="txtBaseTriangulo" runat="server"></asp:TextBox>
            <br />
            <br />
            Por favor escrciba la altura:
            <asp:TextBox ID="txtAltura" runat="server"></asp:TextBox>
            <br />
            El área del triangulo es:
            <asp:Label ID="lblAreaTriangulo" runat="server" Text="Resultado Area Triangulo"></asp:Label>
            <br />
            <br />
            El triangulo tiene estas observaciones:
            <asp:Label ID="lblObservaciones" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnAreaTriangulo" runat="server" OnClick="btnAreaTriangulo_Click" Text="Area Triangulo" />
            <br />
        </div>
    </form>
</body>
</html>
