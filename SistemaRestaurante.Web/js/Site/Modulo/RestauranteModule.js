/// <reference path="../AngularJS/_references.js" />
(function () {
    var app = angular.module('RestauranteModule', ['ngRoute']);

    app.config(['$routeProvider',

        function ($routeProvider) {
            $routeProvider.
            when("/Home", {
                templateUrl: 'html/Home.html'
            })
            when("/Restaurante", {
                templateUrl: 'html/restaurante.html'
            })
            when("/Pratos", {
                templateUrl: 'html/pratos.html'
            })
            when("/CadastrarRestaurante", {
                templateUrl: 'html/CadastrarRestaurante.html'
            })
            when("/ConsultarPratos", {
                templateUrl: 'html/ConsultarPratos.html'
            })
            when("/CadastrarPratos", {
                templateUrl: 'html/CadastrarPratos.html'
            })
            otherwise({
                redirectTo: '/Home'
            });
        }
    ]);
})();