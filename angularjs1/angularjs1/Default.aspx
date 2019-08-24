<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="angularjs1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://code.angularjs.org/1.3.14/angular.js">
    </script>
    <script src="js/app.js"></script>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <!-- Latest compiled and minified CSS 
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/css/bootstrap.min.css">-->
    <!--<script src="http://code.jquery.com/jquery.min.js"></script>-->
    <script src="http://code.jquery.com/jquery-2.1.3.min.js"></script>
</head>
    <!--El agregar la directiva ng-app, permite hacer la sumatoria
        esto indica que se puede usar angular en cualquier parte
        del objeto body-->
<body ng-app>
    <form id="form1" runat="server">
    <div>
        <p>This is your first angular expression: {{ 1 + 2 }}</p>
    </div>
    <div>
        <p>Uniendo una caja de texto a una expresion</p>
        <p>
            Escribe el nombre para su gafette
            <!--La directiva ng-model es para unir un control
                con un espacio asignado con ñ{{}}-->
            <asp:TextBox ID="TextBox1" ng-model="nombrePonente"
                runat="server"></asp:TextBox>
        </p>
        <p>Ponente<br /><h1>NOMBRE ANGULAR
            {{nombrePonente}}</h1>
        </p>
        <p>
                La Razon por la que es mas fuerte Angula que jquery
                es esta<br />
                Nombre de JQUERY: <input type="text"></input>
            <p id="nombre">NOMBRE DE JQUERY</p>
           <script>
               $(document).ready(function () {
                   $("input").keypress(function () {
                       $("#nombre").text($(this).val());
                   });
               });
            </script>
        </p>
        <p>es independiente<br />
              <asp:TextBox ID="TextBox2" ng-model="nuevoNombre"
                runat="server"></asp:TextBox>
        </p>
        <p>Ponente<br /><h1>NOMBRE ANGULAR
            {{nuevoNombre}}</h1>
        </p>
        <p>
            Convertir una expresion de salida<br />
            <!--Para esto usamos la directiva ng-hide, -->
        </p>
        Escribe tu nombre: <input type="text" ng-model="mayusMin"></input>
        <p>MAYUSCULA {{mayusMin | uppercase }}!</p>
        <p>minuscula {{mayusMin | lowercase }}!</p>
    </div>     
        
        
        
        lowercase   
    </form>
</body>
</html>
