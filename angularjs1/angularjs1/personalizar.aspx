<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="personalizar.aspx.cs" Inherits="angularjs1.personalizar" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="js/angular.js"></script>
    <script src="js/app.js"></script>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
 <body ng-app="miAplicacion">
     <form runat="server">
    <label for="checkbox">
    <input id="checkbox" type="checkbox" ng-model="visible">Toggle me
    </label>
    <div show="visible">
    <p>Información básica de la clasificacion 1</p>
    </div>
    
         </form>
         </body>
</html>
