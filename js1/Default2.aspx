<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type="tel" id="telefono" value="47758963" />
        <br />
        <span id="nombre"> Nombre: </span>
        <input id="campoNombre" name="nombre" type="text" />
        <label id="labelFabian" value="hola mundo"> 
            Hola Mundo</label>
        <input type="button" id="llamarAFabian"
             value="Invocar  a Fabian" />
    </div>
    </form>
    <script src="js/jsGeneral.js"></script>
</body>
</html>
