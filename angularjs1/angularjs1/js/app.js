function MyCtrl($scope) {
    $scope.visible = true;

    $scope.toggle = function () {
        $scope.visible = !$scope.visible;
    };
}
var app = angular.module("miAplicacion", []);
app.directive("show", function () {
    return {
        link: function (scope, element, attributes) {
            scope.$watch(attributes.show, function (value) {
                element.css('display', value ? '' : 'none');
            });
        }
    };
});
/*declaro otra directiva
app.directive("shows", function () {
    return {
        link: function (scope, element, attributes) {
            scope.$watch(attributes.show, function (value) {
                element.css('display', value ? '' : 'none');
            });
        }
    };
});*/