<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Clase 1 de Angular</title>
    <script src="js/angular.js"></script>
    <script src="js/general.js"></script>
    <link href="css/bootstrap.css" rel="stylesheet" />
     <script src="http://code.jquery.com/jquery-2.1.3.min.js"></script>
</head>
    <!-- Angular trabaja con directivas,
        en este caso en el body, se
        iundica ng-app, con esto se
        establece que se puede usar
        AngularJS en mi documento-->
<body ng-app class="media-body">
    <form id="form1" runat="server">
    <div>
        <p>Sumar&eacute; los números {{7+8}} </p>
        <p>
            <input type="text" ng-model="nombrePonente" />
        </p>
        <p>
            <h1>
                {{nombrePonente}}
            </h1>
            <br /><h2>Ponente</h2>
        </p>
        <p>
   <!--La directiva ng-model. sirve para indicar el nombre
       de una varibale en un control-->
            <asp:TextBox ID="TextBox1" ng-model="nombreCachu" runat="server"></asp:TextBox>
            <br />Nuestro ponente en Desarrollo en Fire Fox OS es
            <br /><h1>{{nombreCachu}}   </h1>
            <br /><h2>PONENTE</h2>
        </p>
    </div>
    <div>
        <p>
            <h2>¿Cómo lo hace JQuery?</h2>
            <p>
                Nombre del mejor guitarrista
                <input type="text" />
                <h1>JQuery Dice: 
                    <p id="nombre"></p>
                    <script>
                        $(document).ready(function () {
                            $("input").keypress(function () {
                                $("#nombre").text($(this).val());
                            });
                        });
                    </script>
                </h1>
            </p>
        </p>
        <p>
            <h1>
                Convierto mi escritura a mayuscula y minuscula
                </h1>
            <br />
            Escribe lo que desear convertir:
            <asp:TextBox ID="TextBox2" ng-model="cachu2" runat="server"></asp:TextBox>
            <h1>En mayuscula {{cachu2 | uppercase}} </h1>
            <h1>En minuscula {{cachu2 | lowercase}}</h1>
        </p>
    </div>
    </form>
</body>
</html>
