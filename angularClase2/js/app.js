function controlador($scope){
    $scope.value = "ABERCROMBIE";
}
function controlador2($scope) {
    $isidroReSharper = "También lo hace";
    $scope.value = "Hola Mundo" + " " + $isidroReSharper;
}
function incremento($scope) {
    $scope.value = 10;
    $scope.incrementValue = function (increment) {
        $scope.value += increment;
    };
}
function carlos($scope) {
    $scope.value = 12;
    $scope.getIncrementedValue = function () {
        return $scope.value +2;
    };
}
var app = angular.module("ahumadaGuzman", []);
app.directive("myWidget", function () {
    /*Usar la funcion link en esta directiva
    para cambiar los atributos css del parrafo*/
    var linkFunction = function (scope, element, attributes) {
        var paragraph = element.children()[0];
        $(paragraph).on("click", function () {
            $(this).css({ "background-color": "red" })
            $(this).css({ "color": "white" });
        });
    };
    return {
        restrict: "E",
        link:linkFunction
    };
});
