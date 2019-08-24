<%@ Page Language="C#" AutoEventWireup="true" CodeFile="javier1.aspx.cs" Inherits="javier1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  <form id="form1" method="post" runat="server">
        <div class="Controles">
            Solicitar Auto Pagani<br />
            <br />

            <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>

            Nombre
            <input type="text"  id="txtNombre" name="Nombre" /><br />

            Apellido Paterno
            <input type="text" name="txtApellidoP" /><br />

            Apellido Materno
            <input type="text" name="txtApellidoM" /><br />

            Fecha de Nacimiento
            <input type="date" name="dtFechaNacimiento" /><br />

            Modelo Pagani
            <input type="checkbox" name="checkHyura" />Hyurda
        <input type="checkbox" name="checkZonda" />Zonda<br />

            Color del Auto
            <input type="color" name="txtColor" /><br />

            Cantidad de Autos
            <input type="number" name="nmCantidad" /><br />

            Email
            <input type="email" name="txtCorreo" /><br />

            Telefono
            <input type="tel" name="txtTelefono" /><br />

            Domicilio
            <input type="text" name="txtDomicilio" size="43" /><br />

            Fecha que le gustaria recibir
            <input type="date" name="fechaHoraRecibir" /><br />

            Comentarios
            <input type="text" name="txtComentarios" size="50" /><br />
            cambie el boton por uno de asp<br />

            
            <br />
            <asp:Button ID="Button1" runat="server" PostBackUrl="~/javierLectura.aspx" Text="aceptar" />

            
        </div>
    </form>




</body>
</html>
