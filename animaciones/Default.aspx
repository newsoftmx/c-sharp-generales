<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox class="text-danger" placeholder="Carlos dijo que gracias" ID="TextBox1" runat="server"></asp:TextBox>
        <input type="tel" class="text-info" />
        <input type="date" class="text-warning" />
        <input type="submit" class="text-success" />
    </div>
        <div ng-app>
            <!-- con ng-app angular sabe que este div
                trabajará con AngularJS-->
            <asp:TextBox ID="TextBox2" 
                placeholder="Escribe el nombre de usuario"
                ng-model="pastel" 
                runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox3" 
                placehiolder="Escribe el tipo de formato del texto"
                ng-model="tipoTexto"
                runat="server"></asp:TextBox>
            <h3 class="text-{{tipoTexto}}">
                Feliz Cumpleaños {{pastel}} , p&aacute;sala del 1</h3>
            {{pastel}}
        </div>
    </form>
    <script 
   src="https://ajax.googleapis.com/ajax/libs/angularjs/1.2.25/angular.min.js">

    </script>
</body>
</html>
