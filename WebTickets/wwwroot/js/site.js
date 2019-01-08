// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('#modalUsuario').on('shown.bs.modal', function () {
        //$('#myInput').trigger('focus')
    })
    window.setTimeout(function () {
        $(".alert").fadeTo(1000, 0).slideUp(1000, function () {
            $(this).remove();
        });
    }, 5000);

    initTabs();
});

function initTabs() {

    $(function () {
        var $tabButtonItem = $('#tab-button li'),
            $tabSelect = $('#tab-select'),
            $tabContents = $('.tab-contents'),
            activeClass = 'is-active';

        $tabButtonItem.first().addClass(activeClass);
        $tabContents.not(':first').hide();

        $tabButtonItem.find('a').on('click', function (e) {
            var target = $(this).attr('href');

            $tabButtonItem.removeClass(activeClass);
            $(this).parent().addClass(activeClass);
            $tabSelect.val(target);
            $tabContents.hide();
            $(target).show();
            e.preventDefault();
        });

        $tabSelect.on('change', function () {
            var target = $(this).val(),
                targetSelectNum = $(this).prop('selectedIndex');

            $tabButtonItem.removeClass(activeClass);
            $tabButtonItem.eq(targetSelectNum).addClass(activeClass);
            $tabContents.hide();
            $(target).show();
        });
    });

}


var app = angular.module("webticket", ['ui.bootstrap']);
app.controller("TicketCtrl", ['$scope', '$http', function ($scope, $http) {
   
    $scope.lista_seg = "";
    $scope.usuarios = "";
    $scope.loadSegTicketController = function (_Id) {
        var sigo = new Object();
        sigo.Id = _Id;
        
        // Simple GET request example:
        var req = {
            method: 'POST',
            url: '/Tickets/GetSeguimientoTicket_NG/',
            data: JSON.stringify(sigo)
        }

        $http(req).then(function successCallback(response) {
            // this callback will be called asynchronously
            // when the response is available
            $scope.lista_seg = response.data;
        }, function errorCallback(response) {
            // called asynchronously if an error occurs
            // or server returns response with an error status.
        });
    }

    var _Id = $("#Id").val();
    $scope.loadSegTicketController(_Id);

    
    $scope.load_Usuarios = function (urlLista) {
        $http({
            method: 'POST',
            url: urlLista
        }).then(function successCallback(response) {
            // this callback will be called asynchronously
            $scope.datos = response.data;
            $scope.paginarResultados();
           
            // when the response is available
            }, function errorCallback(response) {
                console.log(response);
                alert(response);
            // called asynchronously if an error occurs
            // or server returns response with an error status.
        });
    }

    $scope.paginarResultados = function () {
        $scope.viewby = 10;
        $scope.totalItems = $scope.datos.length;
        $scope.currentPage = 1;
        $scope.itemsPerPage = $scope.viewby;
        $scope.maxSize = 10; //Number of pager buttons to show

        $scope.setPage = function (pageNo) {
            $scope.currentPage = pageNo;
        };

        $scope.pageChanged = function () {
            console.log('Page changed to: ' + $scope.currentPage);
        };

        $scope.setItemsPerPage = function (num) {
            $scope.itemsPerPage = num;
            $scope.currentPage = 1; //reset to first page
        }
    }

    var urlLista = $("#div_url").attr("urlLista");
    $scope.load_Usuarios(urlLista);

    $scope.CargarUsuario = function (Id) {
        var usuario = new Object();
        usuario.Id = Id;
        if (usuario != null) {
            // Simple GET request example:
            var req = {
                method: 'POST',
                url: '/Tickets/GetUsuario/',
                data: JSON.stringify(usuario)
            }

            $http(req).then(function successCallback(response) {
                // this callback will be called asynchronously
                // when the response is available
                item = response.data;

                if (item.Operador_Id == null) {
                    $("#Operador_Id").val(item.id);
                    $("#Operador_UserName").val(item.userName);
                    $("#Operador_Nombre_completo").val(item.nombre_completo);
                    $("#Area").val(item.area);
                    $("#Area_Id").val(item.area_Id);
                    $("#Email").val(item.email);
                    $("#Ubicacion").val(item.ubicacion);
                    $("#Telefono").val(item.telefono);
                    $("#modalUsuario .close").click();
                } else {
                    alert("Sin resultados");
                }
                $("#modalUsuario .close").click();
            }, function errorCallback(response) {
                // called asynchronously if an error occurs
                // or server returns response with an error status.
            });
        }
    }

   
}]);





