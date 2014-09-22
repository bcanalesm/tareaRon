$("#crearMesa").click(function () {

    $.ajax({
        url: 'Maestro/CrearMesa',
        type: 'POST',
        contentType: 'application/json;',
        data: JSON.stringify({ id: $("#IdMesa").val(), cantidad: $("#Capacidad").val() }),
        success: function (valid) {

            if (valid == "True") {
                console.log("Se Agrego");
               
            }
            else { alert("Usuario Incorrecto"); }
        }
    });

});