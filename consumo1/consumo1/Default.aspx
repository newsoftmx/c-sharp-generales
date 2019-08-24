<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="consumo1._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="lbCentigrados" runat="server" Text="Centigrados"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCentigrados" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFarenheit" runat="server" OnClick="btnFarenheit_Click" Text="a °Farenheit" />
        <asp:Label ID="lblFaren" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblFarenheit" runat="server" Text="Farenheit"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtFarenheit" runat="server" style="margin-bottom: 0px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCelcius" runat="server" OnClick="btnCelcius_Click" Text="a °Celcius" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblCelcius" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:TextBox ID="txtClima" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="btnClima" runat="server" OnClick="btnClima_Click" Text="Clima" Width="144px" />
        &nbsp;
        <asp:Label ID="lblClima" runat="server" Text="grados"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtIP" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btnObtenerInfo" runat="server" OnClick="btnObtenerInfo_Click" Text="Obtener info de IP" />
        <asp:GridView ID="gdvIP" runat="server" Height="105px" Width="278px">
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <br />
        Nombre:
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        Ape Paterno:
        <asp:TextBox ID="txtApePaterno" runat="server"></asp:TextBox>
        <br />
        Ape Materno:
        <asp:TextBox ID="txtApeMaterno" runat="server"></asp:TextBox>
        <br />
        Edad:
        <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
        <br />
        estatus
        <asp:TextBox ID="txtEstatus" runat="server"></asp:TextBox>
        <asp:CheckBox ID="ckbEstatus" runat="server" />
        <br />
        <br />
        nivel
        <asp:TextBox ID="txtNivel" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnMostrarTodos" runat="server" OnClick="btnMostrarTodos_Click" Text="Buscar Todos" />
        <br />
        <br />
        <asp:Label ID="lblDatos" runat="server"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="gdvDatos" runat="server">
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
