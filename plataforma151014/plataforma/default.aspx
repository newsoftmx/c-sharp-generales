<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="plataforma._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

    
        <br />
        Sistema:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtSistema" runat="server"></asp:TextBox>
&nbsp;
        <br />
        <br />
        Escuela:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEscuela" runat="server"></asp:TextBox>
&nbsp;
        <br />
        <br />
        Carrera:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCarrera" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <br />
        <br />
        Nombre:&nbsp;&nbsp;
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="lblProceso" runat="server"></asp:Label>
        <br />
        <br />
&nbsp;<asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBuscarID" runat="server" Text="Buscar ID" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEliminarID" runat="server" Text="Eliminar ID" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBuscarTodos" runat="server" Text="Buscar Todos" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnProbarConexion" runat="server" OnClick="btnProbarConexion_Click" Text="Probar Conexion" />

    
    </div>
    </form>
</body>
</html>
