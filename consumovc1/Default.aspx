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
        <br />
        Nombre:
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <br />
        Apellido Paterno:&nbsp;&nbsp;
        <asp:TextBox ID="txtApePaterno" runat="server"></asp:TextBox>
        <br />
        <br />
        Apellido Materno:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtApeMaterno" runat="server"></asp:TextBox>
        <br />
        <br />
        edad:&nbsp;&nbsp;
        <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
        <br />
        <br />
        Estatus:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEstatus" runat="server"></asp:TextBox>
        <br />
        <br />
        Nivel:&nbsp;&nbsp;
        <asp:TextBox ID="txtNivel" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblResultado" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnMostrarTodos" runat="server" OnClick="btnMostrarTodos_Click" Text="Mostrar Todos" />
        <br />
        <br />
        <asp:GridView ID="gdvDatos" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
