<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="sesiones2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Bienvenido estimado
        <asp:Label ID="lblUsuario" runat="server" Text="AQUI APARECERA EL NOMBRE DE LA VARIABLE DE SESSION"></asp:Label>
        <!-- hago impresión de la variable de session, llamada
            como se indica en el codigo-->
        <%: this.Session["usuario"] %>
        <br />
        <br />
        Esta es la otra variable de session
        <asp:Label ID="lblUsuarioBD" runat="server" Text="Esta es la variable de session  verificada con la bd"></asp:Label>
    
        <br />
        <br />
        <asp:Button ID="btnCerrarSesion" runat="server" BorderStyle="None" OnClick="btnCerrarSesion_Click" Text="Salir" />
    
        <br />
        <br />
        <asp:Button ID="btnOtraWEB" runat="server" BackColor="#6699FF" OnClick="btnOtraWEB_Click" Text="Otra WEB" Width="338px" />
    
    </div>
    </form>
</body>
</html>
