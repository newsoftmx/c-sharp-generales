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
        Campus: 

    
        <asp:DropDownList ID="ddlCampus" runat="server" Height="24px" Width="248px">
            <asp:ListItem Value="0">Campestre</asp:ListItem>
            <asp:ListItem Value="1">San Francisco</asp:ListItem>
            <asp:ListItem Value="2">Salamanca</asp:ListItem>
            <asp:ListItem Value="3">Américas</asp:ListItem>
            <asp:ListItem Value="4">Juan Alonso de Torres</asp:ListItem>
        </asp:DropDownList>

    
        <br />
        <br />
        Nivel (Sistema):&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlNivelSistema" runat="server" Height="22px" Width="192px">
            <asp:ListItem Value="1">Licenciatura</asp:ListItem>
            <asp:ListItem Value="4">TSU</asp:ListItem>
            <asp:ListItem Value="5">Especialidad</asp:ListItem>
            <asp:ListItem Value="6">Maestria</asp:ListItem>
        </asp:DropDownList>
        &nbsp; </asp:TextBox>
&nbsp;&nbsp;
        <br />
        <br />
        Escuela (Facultad):&nbsp; <asp:DropDownList ID="ddlEscuelaFacultad" runat="server" Height="16px" Width="245px">
            <asp:ListItem Value="1">AGRONOMÍA</asp:ListItem>
            <asp:ListItem Value="2">ARQUITECTURA</asp:ListItem>
            <asp:ListItem Value="3">NEGOCIOS</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Carrera :&nbsp;&nbsp;<asp:DropDownList ID="ddlNombreCarrera" runat="server" Height="16px" Width="309px">
            <asp:ListItem Value="15">LIC. - Ingeniero Agrónomo Fitotecnista</asp:ListItem>
            <asp:ListItem Value="14">LIC. - Arquitectura</asp:ListItem>
            <asp:ListItem Value="2">LIC. - Administración De Empresas</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
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
