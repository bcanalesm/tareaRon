$.ajax({
    url: window.location.origin + '/Maestro/obtenerMesas',
    type: 'POST',
    contentType: 'application/json;',
    success: function (data, status) {
        var itens = $.parseJSON(data);
        console.log(data);
    },
    error: function (xmlHttpRequest, status, err) {
        console.log("entro aca");

    }

});