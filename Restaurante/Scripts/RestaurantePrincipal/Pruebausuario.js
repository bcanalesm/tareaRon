
$("#iPagina").click(function () {

    $.ajax({
        url: 'Maestro/login',
        type: 'POST',
        contentType: 'application/json;',
        data: JSON.stringify({ pass: $("#pass").val().trim() }),
        success: function (valid)
        {
           
            if (valid=="True") {
                console.log("Persona correcta");
                window.location.href =  window.location.origin+"/Maestro/Principal";
            }
            else { alert("Usuario Incorrecto"); }
         }
    });
   
});