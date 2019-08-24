<%@ Page Language="C#" AutoEventWireup="true" CodeFile="validadores.aspx.cs" Inherits="validadores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Datos Personales<br />
        <br />
        Usuario&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Password&nbsp;
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="compararDatosCorreo" runat="server" ControlToCompare="txtConfirmacionPassword" ControlToValidate="txtPassword" ErrorMessage="El password no coincide, escribalo correctamente"></asp:CompareValidator>
        <br />
        Confirme Password <asp:TextBox ID="txtConfirmacionPassword" runat="server"></asp:TextBox>
&nbsp;<br />
        Correo
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        Nombre&nbsp;
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        Apellidos
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        Edad
        <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="verificarEdad" runat="server" ControlToValidate="txtEdad" ErrorMessage="La edad mínima es de 18 y máxima de 60"></asp:RangeValidator>
        <br />
        Existencia&nbsp;
        <asp:TextBox ID="txtExistencia" runat="server"></asp:TextBox>
&nbsp;Cantidad a envíar
        <asp:TextBox ID="txtCantidadEnviar" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtExistencia" ControlToValidate="txtCantidadEnviar" ErrorMessage="La cantidad a enviar debe ser menor o igual a la existencia" Operator="LessThanEqual"></asp:CompareValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:ValidationSummary ID="resumenValidaciones" runat="server" />
        <br />
    
    </div>
    </form>
</body>
</html>
