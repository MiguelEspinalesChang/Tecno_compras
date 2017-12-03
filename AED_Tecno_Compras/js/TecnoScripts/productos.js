var app = angular.module("app", []);

app.controller("controller", function ($scope, $http) {

    $scope.listaProducto = [];
    $scope.listaOfertas = [];

    $http.get("/Productos/ObtenerProducto")
    .then(function (response) {

        $scope.listaProducto = response.data.listaProducto;

    });

});