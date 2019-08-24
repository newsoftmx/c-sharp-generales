
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="_default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Probando las conexiones a datos<br />
        <br />
        <asp:Button ID="btnProbarConexon" runat="server" OnClick="btnProbarConexon_Click" Text="Probar Conexión" />
        <br />
        <br />
        <asp:Label ID="lblConexion" runat="server" Text="Sin conectar"></asp:Label>
        <br />
        <br />
        <br />
        Nombre:
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <br />
        Apellido Paterno:
        <asp:TextBox ID="txtApePaterno" runat="server"></asp:TextBox>
        <br />
        <br />
        Apellido Materno:
        <asp:TextBox ID="txtApeMaterno" runat="server"></asp:TextBox>
        <br />
        <br />
        Edad:
        <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;<asp:CheckBox ID="ckbEstatus" runat="server" Text="  Estatus" />
        <br />
        <br />
        Nivel
        <asp:DropDownList ID="ddlNivel" runat="server">
            <asp:ListItem>Basico</asp:ListItem>
            <asp:ListItem>Estandar</asp:ListItem>
            <asp:ListItem>Profesional</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar Cambios" />
        <br />
        <br />
        <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" />
        <br />
        <asp:Label ID="lblEstatusGuardar" runat="server" ForeColor="Maroon"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnBuscarID" runat="server" OnClick="btnBuscarID_Click" style="width: 85px" Text="Buscar ID" />
        <br />
        <br />
        <asp:Button ID="btnEliminarID" runat="server" Text="Eliminar ID Encontrado" OnClick="btnEliminarID_Click" />
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="gridDeportistas" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="btnBuscarTodos" runat="server" OnClick="btnBuscarTodos_Click" Text="Buscar Todos" />
        <br />
        <br />
        <br />
        Hola<br />
    
    </div>
    </form>
</body>
</html>
