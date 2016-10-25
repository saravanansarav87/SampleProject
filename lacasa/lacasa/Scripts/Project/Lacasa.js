var LacasaApp = angular.module('LacasaApp', []);

LacasaApp.controller('LacasaController', function ($scope, LacasaService) {

    $scope.UserLogin = function () {
        alert("hi");
        var Userinfm = {
            Email:$('#Email').val(),
        Password:$('#Password').val()
    };

        LacasaService.LacasaUserLogininfm(Userinfm)

    .success(function (data) {
        $scope.itemvalues = data;
        console.log($scope.data);
        return false;
        
    })
      .error(function (error) {
          $scope.status = "sss" + error.message;
          console.log($scope.status);
      });
    }
});
LacasaApp.factory('LacasaService', ['$http', function ($http) {

    var LacasaService = {};
    //main category
    LacasaService.LacasaUserLogininfm = function (userinfm) {

        return $http.post('/Account/Init/' + userinfm);
    };
}]);
