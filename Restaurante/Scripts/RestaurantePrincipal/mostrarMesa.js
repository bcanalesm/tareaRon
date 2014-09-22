
$.ajax({
    url: window.location.origin + '/Maestro/obtenerMesas',
    type: 'POST',
    contentType: 'application/json;',
    data: JSON.stringify({}),
    success: function (data) {


        var arreglo = JSON.parse("[" + data + "]");
        console.log(arreglo);

        arreglo.forEach(function (entry) {
            console.log(entry);
        });


    }
});




