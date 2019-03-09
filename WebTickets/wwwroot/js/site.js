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
        }, 15000);

        initTabs();

        autocomplete_planta();
        autocomplete_comboBox();


        $sidebar = $('.sidebar');

        $sidebar_img_container = $sidebar.find('.sidebar-background');

        $full_page = $('.full-page');

        $sidebar_responsive = $('body > .navbar-collapse');

        window_width = $(window).width();

        fixed_plugin_open = $('.sidebar .sidebar-wrapper .nav li.active a p').html();

        if (window_width > 767 && fixed_plugin_open == 'Dashboard') {
            if ($('.fixed-plugin .dropdown').hasClass('show-dropdown')) {
                $('.fixed-plugin .dropdown').addClass('open');
            }

        }

        $('.fixed-plugin a').click(function (event) {
            // Alex if we click on switch, stop propagation of the event, so the dropdown will not be hide, otherwise we set the  section active
            if ($(this).hasClass('switch-trigger')) {
                if (event.stopPropagation) {
                    event.stopPropagation();
                } else if (window.event) {
                    window.event.cancelBubble = true;
                }
            }
        });

        $('.fixed-plugin .active-color span').click(function () {
            $full_page_background = $('.full-page-background');

            $(this).siblings().removeClass('active');
            $(this).addClass('active');

            var new_color = $(this).data('color');

            if ($sidebar.length != 0) {
                $sidebar.attr('data-color', new_color);
            }

            if ($full_page.length != 0) {
                $full_page.attr('filter-color', new_color);
            }

            if ($sidebar_responsive.length != 0) {
                $sidebar_responsive.attr('data-color', new_color);
            }
        });

        $('.fixed-plugin .background-color .badge').click(function () {
            $(this).siblings().removeClass('active');
            $(this).addClass('active');

            var new_color = $(this).data('background-color');

            if ($sidebar.length != 0) {
                $sidebar.attr('data-background-color', new_color);
            }
        });

        $('.fixed-plugin .img-holder').click(function () {
            $full_page_background = $('.full-page-background');

            $(this).parent('li').siblings().removeClass('active');
            $(this).parent('li').addClass('active');


            var new_image = $(this).find("img").attr('src');

            if ($sidebar_img_container.length != 0 && $('.switch-sidebar-image input:checked').length != 0) {
                $sidebar_img_container.fadeOut('fast', function () {
                    $sidebar_img_container.css('background-image', 'url("' + new_image + '")');
                    $sidebar_img_container.fadeIn('fast');
                });
            }

            if ($full_page_background.length != 0 && $('.switch-sidebar-image input:checked').length != 0) {
                var new_image_full_page = $('.fixed-plugin li.active .img-holder').find('img').data('src');

                $full_page_background.fadeOut('fast', function () {
                    $full_page_background.css('background-image', 'url("' + new_image_full_page + '")');
                    $full_page_background.fadeIn('fast');
                });
            }

            if ($('.switch-sidebar-image input:checked').length == 0) {
                var new_image = $('.fixed-plugin li.active .img-holder').find("img").attr('src');
                var new_image_full_page = $('.fixed-plugin li.active .img-holder').find('img').data('src');

                $sidebar_img_container.css('background-image', 'url("' + new_image + '")');
                $full_page_background.css('background-image', 'url("' + new_image_full_page + '")');
            }

            if ($sidebar_responsive.length != 0) {
                $sidebar_responsive.css('background-image', 'url("' + new_image + '")');
            }
        });

        $('.switch-sidebar-image input').change(function () {
            $full_page_background = $('.full-page-background');

            $input = $(this);

            if ($input.is(':checked')) {
                if ($sidebar_img_container.length != 0) {
                    $sidebar_img_container.fadeIn('fast');
                    $sidebar.attr('data-image', '#');
                }

                if ($full_page_background.length != 0) {
                    $full_page_background.fadeIn('fast');
                    $full_page.attr('data-image', '#');
                }

                background_image = true;
            } else {
                if ($sidebar_img_container.length != 0) {
                    $sidebar.removeAttr('data-image');
                    $sidebar_img_container.fadeOut('fast');
                }

                if ($full_page_background.length != 0) {
                    $full_page.removeAttr('data-image', '#');
                    $full_page_background.fadeOut('fast');
                }

                background_image = false;
            }
        });

        $('.switch-sidebar-mini input').change(function () {
            $body = $('body');

            $input = $(this);

            if (md.misc.sidebar_mini_active == true) {
                $('body').removeClass('sidebar-mini');
                md.misc.sidebar_mini_active = false;

                $('.sidebar .sidebar-wrapper, .main-panel').perfectScrollbar();

            } else {

                $('.sidebar .sidebar-wrapper, .main-panel').perfectScrollbar('destroy');

                setTimeout(function () {
                    $('body').addClass('sidebar-mini');

                    md.misc.sidebar_mini_active = true;
                }, 300);
            }

            // we simulate the window Resize so the charts will get updated in realtime.
            var simulateWindowResize = setInterval(function () {
                window.dispatchEvent(new Event('resize'));
            }, 180);

            // we stop the simulation of Window Resize after the animations are completed
            setTimeout(function () {
                clearInterval(simulateWindowResize);
            }, 1000);

        });


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
app.controller("TicketCtrl", ['$scope', '$http', 'orderByFilter', function ($scope, $http, orderBy) {

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


    $scope.load_resultados = function (urlLista) {
        if (urlLista == null || urlLista == "" || urlLista == undefined) {

        } else {
            $http({
                method: 'POST',
                url: urlLista
            }).then(function successCallback(response) {
                // this callback will be called asynchronously
                $scope.datos = response.data;
                $scope.paginarResultados();
                $scope.propertyName = 'Numero_Ticket';
                $scope.reverse = false;

                $scope.datos = orderBy($scope.datos, $scope.propertyName, $scope.reverse);

                $scope.sortBy = function (propertyName) {
                    $scope.reverse = (propertyName !== null && $scope.propertyName === propertyName)
                        ? !$scope.reverse : false;
                    $scope.propertyName = propertyName;
                    $scope.datos = orderBy($scope.datos, $scope.propertyName, $scope.reverse);
                };

                // when the response is available
            }, function errorCallback(response) {
                console.log(response);
                alert(response);
                // called asynchronously if an error occurs
                // or server returns response with an error status.
            });
        }

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

    $scope.load_resultados(urlLista);

    $scope.CargarUsuario = function (row) {
        var usuario = new Object();
        if (row.id != null) {
            // Simple GET request example:
            var req = {
                method: 'POST',
                url: '/Tickets/GetUsuario/',
                data: JSON.stringify(row.id)
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

    $scope.BuscarTickets = function () {
        var req = {
            method: 'POST',
            url: '/Tickets/BuscarTicket/',
            data: JSON.stringify($scope.txtBuscar)
        }

        $http(req).then(function successCallback(response) {
            // this callback will be called asynchronously
            // when the response is available
            console.log(response);
        }, function errorCallback(response) {
            // called asynchronously if an error occurs
            // or server returns response with an error status.
        });
    };
}]);

function autocomplete_planta() {
    $('#cbxPlanta').select2({
        ajax: {
            url: "/Tickets/Get_Plantas_Ajax/",
            method: 'POST',
            dataType: 'json',
            data: function (params) {

                return {
                    term: params.term, // search term
                };
            },
            processResults: function (data, params) {
                return {
                    results: data,
                };
            }
        },
        selectOnClose: true
    }).on('select2:select', function (e) {
        var id_planta = e.params.data.id;
        $("#sel_planta").attr("value", id_planta);
        autocomplete_equipoPrincipal(id_planta);
    });

}

function autocomplete_comboBox() {
    $('.cbx').select2({
        ajax: {
            url: function () {
                return $(this).attr("url_accion");
            },
            method: 'GET',
            dataType: 'json',
            data: function (params) {
                return {
                    term: params.term, // search term
                };
            },
            processResults: function (data, params) {
                return {
                    results: data,
                };
            }
        },
        placeholder: 'Seleccione un valor..',
        selectOnClose: true
    });

}

function autocomplete_equipoPrincipal(id_planta) {
    $('#cbxEquipoPrincipal').select2({
        ajax: {
            url: "/Tickets/Get_Equipos_principales_Ajax/",
            method: 'POST',
            dataType: 'json',
            data: function (params) {
                return {
                    term: params.term, // search term
                    id_planta: id_planta
                };
            },
            processResults: function (data, params) {
                return {
                    results: data,
                };
            }
        }
    }).on('select2:select', function (e) {
        var id_equipo_princ = e.params.data.id;
        $("#sel_equipo_princ").attr("value", id_equipo_princ);
        autocomplete_equipoSecundario(id_planta, id_equipo_princ);
    });

}

function autocomplete_equipoSecundario(id_planta, id_equipo_princ) {
    $('#cbxEquipoSecundario').select2({
        ajax: {
            url: "/Tickets/Get_Equipos_Secundarios_Ajax/",
            dataType: 'json',
            method: 'POST',
            data: function (params) {
                return {
                    term: params.term, // search term
                    id_planta: id_planta,
                    id_equipo_princ: id_equipo_princ
                };
            },
            processResults: function (data, params) {
                return {
                    results: data,
                };
            }
        }
    }).on('select2:select', function (e) {
        var id_equipo_sec = e.params.data.id;
        $("#sel_equipo_sec").attr("value", id_equipo_sec);
        autocomplete_Componente(id_planta, id_equipo_princ, id_equipo_sec);
    });

}

function autocomplete_Componente(id_planta, id_equipo_princ, id_equipo_sec) {
    $('#cbxComponente').select2({
        ajax: {
            url: "/Tickets/Get_Componentes_Ajax/",
            dataType: 'json',
            method: 'POST',
            data: function (params) {
                return {
                    term: params.term, // search term
                    id_planta: id_planta,
                    id_equipo_princ: id_equipo_princ,
                    id_equipo_sec: id_equipo_sec
                };
            },
            processResults: function (data, params) {
                return {
                    results: data,
                };
            }
        }
    }).on('select2:select', function (e) {
        var id_componente = e.params.data.id;
        $("#sel_componente").attr("value", id_componente);
    });

}




