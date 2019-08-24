<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body >
    <form id="form1" runat="server">
    <div>
        <p>Hola, son los alumnos mas guap@s</p>
        
    </div>
    </form>
    <div>
        <!-- La etiqueta canvas se usa para hacer figuras
            en html5, recuerde agisnarle un nombre -->
        <canvas id="canvas" width="400" height="400"
             style="border:2px solid #000000;">
            Tu navegador NO APLICA
        </canvas>
    </div>
    <p>
        <label>x</label><input type ="text" id="ejex" />
        <label>y</label><input type="text" id="ejey" />
    </p>
    <input type="text" id="hamburguesa"
         value="Super Hamburguesa 250gm"
        onchange="cambioCaja();" />
    <input type="submit" id="btnPaulina" onclick="ahumadaRecta();"
        value="Dibujar Recta" />




    <!-- todos javascrip
        -->
    <script src="js/jsGeneral.js"></script>
</body>
</html>
