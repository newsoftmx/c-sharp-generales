<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="conexionDatosMySQL._default" %>

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
        Por favor capture la informacion solicitada<br />
        <br />
        Nombre:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <br />
        Apellidos:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
        <br />
        <br />
        Edad:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblProceso" runat="server"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar" ToolTip=" " Width="164px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBuscarID" runat="server" Text="Buscar ID" OnClick="btnBuscarID_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBuscarTodos" runat="server" Text="Buscar Todos" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnProbarConexion" runat="server" BackColor="#99FF99" OnClick="btnProbarConexion_Click" Text="Test Connection" />
    
    </div>
    </form>
</body>
</html>
