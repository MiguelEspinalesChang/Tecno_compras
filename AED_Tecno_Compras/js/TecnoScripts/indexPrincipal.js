var app = angular.module("app", []);

app.controller("controller", function ($scope, $http) {

    $scope.listaProducto = [];
    $scope.listaOfertas = [];

    $http.get("/Home/ObtenerProductosHome")
    .then(function (response) {
        
        $scope.listaProducto = response.data.listaProducto;


    });

    $http.get("/Home/ObtenerOfertas")
    .then(function (response) {

     $scope.listaOfertas = response.data.listaOfertas;


 });

});