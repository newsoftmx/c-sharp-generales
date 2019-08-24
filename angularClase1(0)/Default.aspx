<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css" /> -->
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <!-- agregamos ng, par aindicar que es sintaxis de angular js-->
    <div ng-app><!--Con esto le indicamos que la aplicacion reside en angularjs, para eso se usa ng-app-->
    suc
        <h1>Ejemplo de AngularJS </h1>
        <!-- Ahora indicamos a la caja de texto, que todo lo escrito en ella, este ligado 
            al modelo ng-model, con ese nombre hare referencia a esa caja y la podre utilizar
            en cualquier momento dentro de la WEB, para ello se usan las llaves dobles, 
            esto lo hace gracias al enlace de datos bidireccional two way data binding -->
        <asp:TextBox ID="TextBox1" runat="server"  placeholder="Escribe tu usuario" ng-model="nombre"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"  placeholder="Color" ng-model="color"></asp:TextBox>
        <!-- Se pueden hacer info, success, warning, danger-->
        <br />
        <h3 class="text-danger">Gracias por estudiar en La Salle estimado {{nombre}},  46 años haciendo comunidad</h3>
        <h3 class="text-{{color}}">este titulo sale con el tipo de color escrito</h3>
        <br />
    
    </div>
    </form>
    <form name="formulario2">
        
        <div ng-app>
            <label>Ejemplo de AngularJS</label>
            <input type="text" maxlength="100"  placeholder="Escribe tu usuario" />
        </div>
    </form>
    <!--<script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.2.25/angular.min.js""></script>-->
    <script src="js/angular.min.js"></script>
</body>
</html>
