
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
                
                var textoCelda0 = "<tr><td  Style='text-align: center;' id='" + datos.IdMesa + "'>" + datos.IdMesa + "</td><td id='" + datos.Capacidad + "'><input id='pass" + datos.IdMesa + "' style='width:40px;text-align: center;' value ='" + datos.Capacidad + "'>" +
                    "</td><td>" + "<input type='button' class='BtnActualizar' value='Actualizar'  Style='margin-right:10px;'/></a>" + "<input class='BtnBorrar' type='button' value='Eliminar' id='borrar" + datos.IdMesa  + "'></a>" + "</td></tr>";

               
                fila += textoCelda0;
               
               
            });

        });
   
        tabla.append(fila);

    }
});



function actualizarMesa() {
    
    var par = $(this).parent().parent();
  
    console.log(par.children("td:nth-child(2)").children().attr("value"));
    window.location.href = window.location.origin + "/Maestro/AtcualizarMesa?id=" + par.children("td:nth-child(1)").attr("id") + "&cantidad=" + par.children("td:nth-child(2)").children().attr("value");
};

function borrarMesa() {

    var par = $(this).parent().parent();

    console.log(par.children("td:nth-child(2)").children().attr("value"));
    window.location.href = window.location.origin + "/Maestro/BorarMesa?id=" + par.children("td:nth-child(1)").attr("id") ;
};


$("#Mesas").on("click", ".BtnActualizar", actualizarMesa);

$("#Mesas").on("click", ".BtnBorrar", borrarMesa);