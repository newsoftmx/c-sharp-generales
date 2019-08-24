<%@ Page Language="C#" AutoEventWireup="true" CodeFile="invocacion.aspx.cs" Inherits="invocacion" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
                Nombre:
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                <br />
                <br />
                Apellido Paterno:<asp:TextBox ID="txtApePaterno" runat="server"></asp:TextBox>
                <br />
                Apellido Materno:
                <asp:TextBox ID="txtApeMaterno" runat="server"></asp:TextBox>
                <br />
                Edad:
                <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:CheckBox ID="ckbEstatus" runat="server" Text="Estatus" />
                <br />
                <br />
                <asp:DropDownList ID="ddlNivel" runat="server">
                    <asp:ListItem>Básico</asp:ListItem>
                    <asp:ListItem>Estandar</asp:ListItem>
                    <asp:ListItem>Medio</asp:ListItem>
                    <asp:ListItem>Profesional</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="lblEstado" runat="server"></asp:Label>
                <br />
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnGuardarSP" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="btnGuardarNormal" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
        <br />
        <asp:Button ID="btnGuardarSP" runat="server" OnClick="btnGuardarSP_Click" Text="Guardar SP" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnGuardarNormal" runat="server" Text="Guardar Normal" OnClick="btnGuardarNormal_Click" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
