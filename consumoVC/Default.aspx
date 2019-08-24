<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        Nombre:&nbsp;&nbsp;
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        Ape Paterno:&nbsp;&nbsp;
        <asp:TextBox ID="txtApePaterno" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <br />
        Ape Materno:&nbsp;&nbsp;
        <asp:TextBox ID="txtApeMaterno" runat="server" ></asp:TextBox>
        <br />
        Edad:&nbsp;&nbsp;
        <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
        <br />
        Estatus:&nbsp;&nbsp;
        <asp:TextBox ID="txtEstatus" runat="server"></asp:TextBox>
        <br />
        Nivel:&nbsp;&nbsp;
        <asp:TextBox ID="txtNivel" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnMostrarTodos" runat="server" OnClick="btnMostrarTodos_Click" Text="Mostrar Todos" />
        <br />
        <br />
        <asp:Label ID="lblResultado" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:GridView ID="gdvDatos" runat="server">
        </asp:GridView>
        <br />
        <br />
        <br />
        <asp:Label ID="lbCentigrados" runat="server" Text="Centigrados"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCentigrados" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFarenheit" runat="server" OnClick="btnFarenheit_Click" Text="a °Farenheit" />
        <asp:Label ID="lblFaren" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblFarenheit" runat="server" Text="Farenheit"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtFarenheit" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCelcius" runat="server" OnClick="btnCelcius_Click" Text="a °Celcius" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblCelcius" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
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
