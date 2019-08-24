function MyCtrl($scope) {
    $scope.visible = true;

    $scope.toggle = function () {
        $scope.visible = !$scope.visible;
    };
}
var app = angular.module("alex", []);
app.directive("show", function () {
    return {
        link: function (scope, element, attributes) {
            scope.$watch(attributes.show, function
                (value) {
                element.css('display', value ? '' :
                    'none');
            });
        }
    };
});