/// <reference path="../AngularJS/_references.js" />
(function (app) {
    var ResturanteController = function ($scope, $http) {
        $scope.rest = {
            Codigo: 0,
            Nome: '',
            Pratos: null
        };
        $scope.Pratos = {
            Codigo: 0,
            Nome: '',
            Valor: null
        };
        $scope.obtenhaRestaurante = function () {
            if ($scope.rest.Nome == undefined) {
                $scope.rest.Nome = ""
            }
            $http.get("http://localhost:12195/api/ServicoRestaurante/ObtenhaRestaurantes", {
                params: {
                    Nome: $scope.rest.Nome
                },
                ContentType: 'application/json'
            })
                .then(function (response) {
                    $scope.Restaurantes = response.data;
                });
        }
        $scope.cadastrarRestaurante = function () {
            $http({
                url: 'http://localhost:12195/api/ServicoRestaurante/CadastrarRestaurante',
                method: "POST",
                data: $scope.rest
            }).then(function (response) {
                $scope.rest.nome = "";
                $scope.obtenhaRestaurante();
            },
                function (response) { });
        }

        $scope.excluirRestaurante = function (codigo) {
            $http({
                url: 'http://localhost:12195/api/ServicoRestaurante/DeletarResturante',
                method: "POST",
                data: {
                    codigo
                }
            }).then(function (response) {
                $scope.rest.nome = "";
                $scope.obtenhaRestaurante();
            },
                function (response) { });
        }

        $scope.ObtenhaPratos = function () {
            if ($scope.Pratos.nome == undefined) {
                $scope.Pratos.nome = ""
            }
            $http.get("http://localhost:12195/api/ServicoRestaurante/ObtenhaPratos", {
                params: {
                    Nome: $scope.Pratos.Codigo
                },
                ContentType: 'application/json'
            })
                .then(function (response) {
                    $scope.Pratos = response.data;
                });
        }

        $scope.cadastrarPrato = function () {
            $http({
                url: 'http://localhost:12195/api/ServicoRestaurante/CadastrarPrato',
                method: "POST",
                data: $scope.Pratos
            }).then(function (response) {
                $scope.Pratos.nome = "";
                $scope.ObtenhaPratos();
            },
                function (response) { });
        }

        $scope.excluirPratos = function (codigo) {
            $http({
                url: 'http://localhost:12195/api/ServicoRestaurante/DeletarPrato',
                method: "POST",
                data: {
                    codigo
                }
            }).then(function (response) {
                $scope.Pratos.nome = "";
                $scope.ObtenhaPratos();
            },
                function (response) { });
        }
    };

    app.controller('RestauranteController', ResturanteController)
}(angular.module('RestauranteModule', ['ngRoute'])));