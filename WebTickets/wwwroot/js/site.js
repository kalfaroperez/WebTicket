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
function cargar_Usuario(_Id, urlAction) {
    //var token = $('input[name="__RequestVerificationToken"]', $('#ticketForm')).val();
    var usuario = new Object();
    usuario.Id = _Id;

    //var dataWithAntiforgeryToken = $.extend(myData, { '__RequestVerificationToken': token });
    if (usuario != null) {
        $.ajax({
            type: "POST",
            url: urlAction,
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            data: JSON.stringify(usuario),
            success: function (item) {

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
            },
            failure: function (item) {
                alert(item.responseText);
            }, //End of AJAX failure function  
            error: function (item) {
                alert(item.responseText);
            } //End of AJAX error function  
        });
    }

}

angular.module("webticket", [])
    .controller("SeguimientoTicketController", ['$scope', '$http', function ($scope, $http) {
        $scope.lista_seg = "";
        $scope.loadSegTicketController = function (_Id) {
            var sigo = new Object();
            sigo.Id = _Id;
            console.log($("#Id").val());
            // Simple GET request example:
            var req = {
                method: 'POST',
                url: '/Tickets/GetSeguimientoTicket_NG/',
                data: JSON.stringify(sigo)
            }

            $http(req).then(function successCallback(response) {
                // this callback will be called asynchronously
                // when the response is available
                console.log(response.data);
                $scope.lista_seg = response.data;
            }, function errorCallback(response) {
                // called asynchronously if an error occurs
                // or server returns response with an error status.
            });


        }
    }]);
