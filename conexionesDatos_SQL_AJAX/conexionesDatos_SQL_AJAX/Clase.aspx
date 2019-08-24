<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clase.aspx.cs" Inherits="conexionesDatos_SQL_AJAX.Clase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
<br />
<br />
                
        Probando la conexión<br />
        <br />
        <asp:Button ID="btnProbarConexion" runat="server" OnClick="btnProbarConexion_Click" Text="Probar Conexion" />
        <br />
        <br />
        <asp:Label ID="lblEstadoConexion" runat="server" Text="Sin Conexión"></asp:Label>
        <br />
        ID para buscar:
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <br />
        <br />
        Nombre:&nbsp;
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <br />
        Apellido Paterno:&nbsp;
        <asp:TextBox ID="txtApePaterno" runat="server"></asp:TextBox>
        <br />
        <br />
        Apellido Materno:
        <asp:TextBox ID="txtApeMAterno" runat="server"></asp:TextBox>
        <br />
        <br />
        Edad:&nbsp;
        <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="ckbEstatus" runat="server" Text="Estatus" />
        <br />
        <br />
        Seleccione su Nivel de Condición Física:&nbsp;
        <asp:DropDownList ID="ddlNivel" runat="server">
            <asp:ListItem>Basico</asp:ListItem>
            <asp:ListItem>Intermedio</asp:ListItem>
            <asp:ListItem>Profesional</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="lblProceso" runat="server"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="grvDatos" runat="server">
        </asp:GridView>
        <br />
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnActualizar" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="btnBuscarID" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="btnEliminarID" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="btnGuardar" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="btnProbarConexion" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
        <br />
        <br />
        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar Registro" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" Width="145px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBuscarID" runat="server" OnClick="btnBuscarID_Click" Text="Buscar ID" Width="150px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEliminarID" runat="server" OnClick="btnEliminarID_Click" Text="Eliminar ID" Width="152px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBuscarTodos" runat="server" OnClick="btnBuscarTodos_Click" Text="Buscar Todos" Width="153px" />
        <br />
    
    </div>
    </form>
</body>
</html>
