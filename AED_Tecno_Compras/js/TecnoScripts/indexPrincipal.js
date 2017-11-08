var app = angular.module("app", []);

app.controller("controller", function ($scope, $http) {

    $scope.listaProducto = [];

    $http.get("/Home/ObtenerProductosHome")
    .then(function (response) {
        
        $scope.listaProducto = response.data.listaProducto;


    });

});