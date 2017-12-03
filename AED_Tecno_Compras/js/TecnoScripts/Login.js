var app = angular.module("app", []);
app.controller("controller", function ($scope, $http) {
    $scope.passw = "";
    $scope.user = "";

    $scope.galleta = Cookies.getJSON('userTecno');
    $scope.errorLogin = false;
    $scope.peticion = false;

    if ($scope.galleta !== undefined)
    {
        alert(JSON.stringify($scope.galleta));
        window.location.assign("/Home/Index");
    }

    $scope.iniciar = function () {

        $scope.errorLogin = false;
        $scope.peticion = true;

        let data = {
            userName: $scope.user,
            passw: $scope.passw
        }

        data = JSON.stringify(data);

        $http.post("/Login/Ingresar",
            data)
    .then(function (response) {

        $scope.galleta = Cookies.getJSON('userTecno');

        if (response.data.error === undefined) {
            Cookies.set('userTecno', { userName: response.data.user, passw: response.data.passw }, { expires: 1 });
            window.location.assign("/Home/Index");
        }
        else
            $scope.errorLogin = true;


        $scope.peticion = false;
    });

    };



});