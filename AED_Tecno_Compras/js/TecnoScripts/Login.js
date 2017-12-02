var app = angular.module("app", []);
app.controller("controller", function ($scope, $http) {
    $scope.passw = "";
    $scope.user = "";

    $scope.iniciar = function () {

        let data = {
            userName: $scope.user,
            passw: $scope.passw
        }

        data = JSON.stringify(data);
        
        $http.post("/Login/ObtenerUsuario",
            data)
    .then(function (response) {

        alert("response");


    });

    };

    

});