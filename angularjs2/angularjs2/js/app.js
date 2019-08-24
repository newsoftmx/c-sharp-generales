function control1($scope){
    $scope.value = "Felicidades a los cumpleañeros";
}
function personalizadoSuper($scope) {
    $cumpleañero="Juan Victor";
    $scope.value = "Felicidades a los cumpleañeros" + $cumpleañero;
}
function MyCtrl($scope) {
    $scope.value = 3;
    $scope.incrementValue = function (increment) {
        $scope.value += increment;
    };
}
function MyCtrl2($scope) {
    $scope.value = 1;
    $scope.getIncrementedValue = function () {
        return $scope.value + 1;
    };
}

var app = angular.module("miAplicacion", []);
app.directive("myWidget", function () {
    /*usamos la funcion link en la directiva, para cambiar los
    atributos css del parrafo*/
    var linkFunction = function (scope, element, attributes) {
        var paragraph = element.children()[0];
        $(paragraph).on("click", function () {
            $(this).css({ "background-color": "red" })
            $(this).css({"color":"white"});
        });
    };
    return {
        restrict: "E",
        link: linkFunction
    };
});

var app = angular.module("anidados", []);
app.controller("controlAnidado", function ($scope) { $scope.name = "Peter"; $scope.user = { name: "Parker" };  });
app.controller("MyNestedCtrl", function ($scope) { });

var app = angular.module("nodosPredeterminados", []);
app.directive("myWidget", function () {
    return {
        restrict: "E",
        transclude: true,
        template: "<div ng-transclude><h3>Heading</h3><p><h1>Hola</p></div>"
    };
})