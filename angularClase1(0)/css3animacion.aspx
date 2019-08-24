<%@ Page Language="C#" AutoEventWireup="true" CodeFile="css3animacion.aspx.cs" Inherits="css3animacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/general.css" rel="stylesheet" />
    <link href="css/animate.css" media="all" type="text/css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="caja" runat="server" ></asp:TextBox>
        <div class="option animated wobble">Este texto será animado.</div>
<!-- 
    Esta librería es altamente personalizable, si deseamos tener mas opciones en 
    las animaciones solo debemos agregarlas en la clase .option. Como ya se ha 
    mencionado antes, por defecto se ejecutara solo una vez la animación, una vez
     este cargada la pagina, pero si queremos que tenga un retraso para la animacion,
     o que se ejecute varias veces (loop)?

    Debemos de tener en cuenta los prefijos que hay para los diversos navegadores,
     y con esto evitar problemas de compatibilidad, un ejemplo sobre la personalización 
    por medio de la clase .option es la siguiente:
    .option {
    -webkit-animation-duration: 3s;
    -webkit-animation-delay: 2s;
    -webkit-animation-iteration-count: 5;
}

    -->
    </div>
    </form>
    <div class="demo animated">
   <p>This text will animate. <a href="" id="ref">Click to animate!</a>
   </p>
        <!--<div class="tunombre animated">-->
        <h1 class="tunombre animated" id="miidentificador">TU NOMBRE</h1>

        <!--</div>-->
</div>

    <script type="text/javascript" src="http://code.jquery.com/jquery-latest.min.js"></script>
    <script src="js/jsGeneral.js"></script>
</body>
</html>
