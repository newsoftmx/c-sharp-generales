<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="controlesBasicos._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post">
    <div>
    
        Seleccione la fecha de su viaje:
        <asp:TextBox ID="TextBox1" runat="server">12</asp:TextBox>
        <br />
        <asp:Calendar ID="calFechaViaje" runat="server"></asp:Calendar>
        <br />
        Indique que deporte prácticará<br />
        <br />
        <asp:DropDownList ID="ddlDeporte" runat="server">
            <asp:ListItem>Futbol</asp:ListItem>
            <asp:ListItem>Atletismo</asp:ListItem>
            <asp:ListItem>Beisbol</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Nivel de Ingles<br />
        <asp:CheckBoxList ID="cblNivelInges" runat="server">
            <asp:ListItem>25%</asp:ListItem>
            <asp:ListItem>50%</asp:ListItem>
            <asp:ListItem>75%</asp:ListItem>
            <asp:ListItem>100%</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        Nivel de Office<asp:BulletedList ID="blbNivelOffice" runat="server" DisplayMode="LinkButton">
            <asp:ListItem>Bajo</asp:ListItem>
            <asp:ListItem>Medio</asp:ListItem>
            <asp:ListItem>Alto</asp:ListItem>
        </asp:BulletedList>
        <br />
        Musica a escuchar en su viaje<br />
        <asp:ListBox ID="lsbMusica" runat="server">
            <asp:ListItem>Pop</asp:ListItem>
            <asp:ListItem>Ranchero</asp:ListItem>
            <asp:ListItem>Rock</asp:ListItem>
            <asp:ListItem>Instrumental</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <br />
        <asp:RadioButton ID="rbtDisco" runat="server" Text="¿Visitará la Disco?" />
        <br />
        <br />
        Ciudades a visitar<asp:RadioButtonList ID="rblCiudadVisitar" runat="server">
            <asp:ListItem>Paris</asp:ListItem>
            <asp:ListItem>Argentina</asp:ListItem>
            <asp:ListItem>Jamaica</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Xml ID="Xml1" runat="server"></asp:Xml>
        <br />
        <br />
        <asp:Button ID="btnEnviar" runat="server" Height="26px" Text="Enviar" PostBackUrl="~/preferencias.aspx" />
    
    </div>
    </form>
</body>
</html>
