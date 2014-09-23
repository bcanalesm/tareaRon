
$.ajax({
    url: window.location.origin + '/Maestro/obtenerMesas',
    type: 'POST',
    contentType: 'application/json;',
    data: JSON.stringify({}),
    success: function (data) {
        var tabla = $("#Mesas");
        var tblBody = document.createElement("tbody");
       

        var arreglo = JSON.parse("[" + data + "]");
        console.log(arreglo);

        arreglo.forEach(function (entry) {
            console.log(entry);
            var fila = document.createElement("tr");
            entry.forEach(function (datos) {
                var columna = document.createElement("td");
                var columna1 = document.createElement("td");
                var textoCelda0 = document.createTextNode(datos.IdMesa);
                var textoCelda1 = document.createTextNode(datos.Capacidad);
                columna.appendChild(textoCelda0);
                columna1.appendChild(textoCelda1);

                fila.appendChild(columna);
                fila.appendChild(columna1);
                console.log(datos.IdMesa);
            });

        });
        tblBody.appendChild(fila);
        tabla.appendChild(tblBody);

    }
});


