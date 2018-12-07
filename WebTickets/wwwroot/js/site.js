// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {

});

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
                console.log(item);
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