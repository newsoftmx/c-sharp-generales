<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datos personales.aspx.cs" Inherits="datos_personales.datos_personales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            FORMULARIO DE REGISTRO A CAMPAÑA
            <br />
            <br />
            Nombre:
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <br />
            Apellido paterno:
            <asp:TextBox ID="txtApePaterno" runat="server"></asp:TextBox>
            <br />
            <br />
            Apellido materno:
            <asp:TextBox ID="txtApeMaterno" runat="server"></asp:TextBox>
            <br />
            <br />
            Edad:
            <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
            <br />
            <br />
            Genero:
            <asp:TextBox ID="txtGenero" runat="server"></asp:TextBox>
            <br />
            <br />
            Estado civil:
            <asp:TextBox ID="txtEstadoCivil" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPrueba" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblInformador" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnRegistrar" runat="server" OnClick="btnRegistrar_Click" Text="Registrar" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnGuardarDatos" runat="server" OnClick="btnGuardarDatos_Click" Text="Guardar Datos" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnLeerDatos" runat="server" OnClick="btnLeerDatos_Click" Text="LeerDatos" />
            <br />
            <br />
&nbsp;&nbsp;
            <asp:Button ID="btnGuardarDatosInformador" runat="server" OnClick="btnGuardarDatosInformador_Click" Text="Guardar Datos Informando" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Button ID="btnComapararEdad" runat="server" OnClick="btnComapararEdad_Click" Text="Comparar Edad" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnGuardarDatosConMetodo" runat="server" OnClick="btnGuardarDatosConMetodo_Click" Text="Guardar Datos con Método" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnGuardarArregloMensaje" runat="server" OnClick="btnGuardarArregloMensaje_Click" Text="Guardar Datos y Mostrar Mensaje" />
        </div>
    </form>
</body>
</html>
