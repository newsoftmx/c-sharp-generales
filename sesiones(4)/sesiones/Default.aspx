<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="sesiones.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta content="10" http-equiv="REFRESH" /> 

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblErrorSesion" runat="server" ForeColor="Red" Text="Los Datos con los que desea ingresar son incorrectos, vuelta a intentarlo" Visible="False"></asp:Label>
        <br />
        <br />
        Bienvenido al sistema:
        <asp:label ID="lblSession" runat="server" text="Su Nombre va Aquí"></asp:label>
        <%: this.Session["Usuario"] %>
        <br />
        <br />
        <br />
        La variable de session que se creo para verificar con la bd<br />
        <asp:Label ID="lblSesionBD" runat="server" Text="El usuario de la bd va aquí"></asp:Label>
        <%: this.Session["usuarioBD"] %>
        <br />
        <br />
        <asp:Button ID="btnCerrarSesión" runat="server" BorderStyle="None" OnClick="btnCerrarSesión_Click" Text="Cerrar Sesión" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnOtraWEB" runat="server" OnClick="btnOtraWEB_Click" Text="otra página" Width="154px" />
    </div>
    </form>
</body>
</html>
