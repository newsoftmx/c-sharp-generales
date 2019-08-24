<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Clientes.aspx.vb" Inherits="Clientes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link href="default.css" rel="stylesheet" type="text/css" />
</head>
<body class="transpa" background="fondos.jpg">
    <form id="form1" runat="server">
    <div>
    
        <br />
        datos de la session del cliente<br />
        <br />
        <br />
        <asp:Label ID="lblIdcleinte" runat="server" Text="Idcliente"></asp:Label>
&nbsp;
        <asp:Label ID="lblNombre" runat="server" Text="Nombre de Cliente"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblPaterno" runat="server" Text="Paterno"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMaterno" runat="server" Text="Materno"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="lblCredito" runat="server" Text="Credito"></asp:Label>
&nbsp;&nbsp;
        <asp:Label ID="lblVisita" runat="server" Text="Visita"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;<asp:Label ID="lblMensaje" runat="server" ForeColor="Red" 
            Text="Su Credito ha sido autorizado" Visible="False"></asp:Label>
        <br />
        <br />
        <br />
        <br />
    
    </div>
    <div>
        <br />
        barra de menu<br />
    </div>
    <div class="transpalight" style="height: 580px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; operaciones<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; seleccione su tipo de servicio&nbsp;
        <asp:DropDownList ID="LISTA" runat="server" CssClass="transpa">
            <asp:ListItem Value="1">CFE</asp:ListItem>
            <asp:ListItem Value="2">SAPAL</asp:ListItem>
            <asp:ListItem Value="3">TELMEX</asp:ListItem>
        </asp:DropDownList>
&nbsp;Escribe tu no. de contrato&nbsp;&nbsp;
        <asp:TextBox ID="txtReferencia" runat="server" CssClass="transpa"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BTNbUSCARsERVICIO" runat="server" CssClass="transpa" 
            Text="BUSCAR SERVICIO" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblCreditonodisponible" runat="server" ForeColor="Red" 
            Text="Carece de credito para poder comprar" Visible="False"></asp:Label>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp; Id tipo servicio
        <asp:TextBox ID="txtTipoServicio" runat="server" CssClass="transpa"></asp:TextBox>
&nbsp; Referencia
        <asp:TextBox ID="txtReferencia2" runat="server" CssClass="transpa"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Cantidad&nbsp;
        <asp:TextBox ID="txtCantidad" runat="server" CssClass="transpa" 
            style="margin-bottom: 0px" Width="128px"></asp:TextBox>
        <br />
&nbsp;
        <br />
&nbsp;&nbsp;&nbsp; Fecha vencimiento&nbsp;
        <asp:TextBox ID="txtFecha" runat="server" CssClass="transpa"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Escoja su forma de pago
        <asp:DropDownList ID="listaFormapago" runat="server" CssClass="transpa">
            <asp:ListItem>Contado</asp:ListItem>
            <asp:ListItem>Credito</asp:ListItem>
        </asp:DropDownList>
&nbsp;<br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Meses a credito
        <asp:TextBox ID="txtmeses" runat="server" CssClass="transpa"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnpagarcredito" runat="server" CssClass="transpa" 
            Text="Pagar" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblImposiblepagar" runat="server" ForeColor="Red" 
            Text="Imposible pagar, su Credito es menor al monto" Visible="False"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" CssClass="transpa" Text="Pagar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" CssClass="transpa" Text="Cancelar" />
    </div>
    </form>
</body>
</html>
