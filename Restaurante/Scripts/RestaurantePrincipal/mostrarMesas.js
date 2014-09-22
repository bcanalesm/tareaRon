$.ajax({
    url: window.location.origin + '/Maestro/obtenerMesas',
    type: 'POST',
    data: "{}",
    contentType: "application/json; charset=utf-8",
    dataType: JSON,
    success: function (data,status) {
        var itens = $.parseJSON(data.Pedidoes);
        console.log(itens);
    },
    error: function (xmlHttpRequest, status, err) {
        console.log("entro aca");
        
    }

});