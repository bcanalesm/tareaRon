
$.ajax({
    url: window.location.origin + '/Maestro/obtenerMesas',
    type: 'POST',
    contentType: 'application/json;',
    data: JSON.stringify({}),
    success: function (data) {
        var tabla = $("#Mesas");
        
        var arreglo = JSON.parse("[" + data + "]");
        console.log(arreglo);
        var fila = "<tr><td>Num Mesa</td><td>Cant Pesonas</td><td>Acciones</td></tr>";
       
        arreglo.forEach(function (entry) {
            console.log(entry);
            
            entry.forEach(function (datos) {
                
                var textoCelda0 = "<tr><td  Style='text-align: center;' id='" + datos.IdMesa + "'>" + datos.IdMesa + "</td><td id='" + datos.Capacidad + "'><input id='pass' style='width:40px;text-align: center;' value ='" + datos.Capacidad + "'>" +
                    "</td><td>" + "<a href='url' Style='margin-right:10px;'>Actualizar</a>" + "<a id='borrar" + datos.IdMesa + "' href='BorarMesa?id=" + datos.IdMesa + "'>Eliminar</a>" + "</td></tr>";

               
                fila += textoCelda0;
               
               
            });

        });
   
        tabla.append(fila);

    }
});




