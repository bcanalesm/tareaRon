$("#crearMesa").click(function () {

    $.ajax({
        url: window.location.origin + '/Maestro/CrearMesa',
        type: 'POST',
        contentType: 'application/json;',
        data: JSON.stringify({ cantidad: $("#Capacidad").val() }),
        success: function (valid) {

            if (valid == "True") {
                console.log("Se Agrego");
               
            }
            else { alert("Usuario Incorrecto"); }
        }
    });

});