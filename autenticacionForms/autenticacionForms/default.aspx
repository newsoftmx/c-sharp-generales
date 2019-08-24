<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="autenticacionForms._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <br />
        <asp:Menu ID="Menu1" runat="server" BackColor="#F7F6F3" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="Large" ForeColor="#7C6F57" StaticSubMenuIndent="10px" Orientation="Horizontal">
            <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#F7F6F3" />
            <DynamicSelectedStyle BackColor="#5D7B9D" />
            <Items>
                <asp:MenuItem Text="Inicio" Value="Inicio" NavigateUrl="~/default.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Nosotros" Value="Nosotros"></asp:MenuItem>
                <asp:MenuItem Selectable="False" Text="Catalogo" Value="Catalogo">
                    <asp:MenuItem NavigateUrl="~/productos.aspx" Text="Productos" Value="Productos"></asp:MenuItem>
                    <asp:MenuItem Text="Servicios" Value="Servicios"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/cerrar_session.aspx" Text="Cerrar Sesion" Value="Cerrar Sesion"></asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#5D7B9D" />
        </asp:Menu>
        <asp:Button ID="btnCerrarSesion" runat="server" OnClick="btnCerrarSesion_Click" Text="Cerrar Sesion" />
    
        <br />
        <asp:LinkButton ID="lkbProductos" runat="server" OnClick="lkbProductos_Click">Productos</asp:LinkButton>
    
        <br />
        <br />
        <asp:LinkButton ID="lkbCerrarSesion" runat="server" OnClick="lkbCerrarSesion_Click">Cerrar Sesión</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
