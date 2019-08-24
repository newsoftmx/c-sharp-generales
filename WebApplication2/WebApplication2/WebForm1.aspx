<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" enableviewstate="True">
    <div>
    
        Datos Personales<br />
        <br />
        Usuario&nbsp;
        <asp:TextBox ID="txtUsuario" runat="server" ViewStateMode="Enabled"></asp:TextBox>
        <asp:RequiredFieldValidator ID="requisicionUsuario" runat="server" ControlToValidate="txtUsuario" ErrorMessage="Es necesario que escriba un nombre de Usuario" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        Password&nbsp;
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="compararDatosCorreo" runat="server" ControlToCompare="txtConfirmacionPassword" ControlToValidate="txtPassword" ErrorMessage="El password no coincide, escribalo correctamente" ForeColor="Red"></asp:CompareValidator>
        <br />
        Confirme Password
        <asp:TextBox ID="txtConfirmacionPassword" runat="server"></asp:TextBox>
        &nbsp;<br />
        Correo
        <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="verificarCorreo" runat="server" ControlToValidate="txtCorreo" ErrorMessage="Su correo no es valido" ForeColor="Red" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        Nombre&nbsp;
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        Apellidos
        <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
        <br />
        C. P.
        <asp:TextBox ID="txtCP" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="verificadorCP" runat="server" ControlToValidate="txtCP" ErrorMessage="Escriba solo números" ValidationExpression="^[0-9]{1,5}"></asp:RegularExpressionValidator>
        <br />
        Edad
        <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="verificarEdad" runat="server" ControlToValidate="txtEdad" ErrorMessage="La edad mínima es de 18 y máxima de 60" ForeColor="Red" MaximumValue="60" MinimumValue="18"></asp:RangeValidator>
        <br />
        Existencia&nbsp;
        <asp:TextBox ID="txtExistencia" runat="server"></asp:TextBox>
        &nbsp;Cantidad a envíar
        <asp:TextBox ID="txtCantidadEnviar" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="compararCantidades" runat="server" ControlToCompare="txtExistencia" ControlToValidate="txtCantidadEnviar" ErrorMessage="La cantidad a enviar debe ser menor o igual a la existencia" ForeColor="Red" Operator="LessThanEqual"></asp:CompareValidator>
        <br />
        <asp:ValidationSummary ID="resumenValidaciones" runat="server" ForeColor="Red" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" PostBackUrl="~/bienvenido.aspx" Text="Button" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
