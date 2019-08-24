/*Comentario!!!!*/
document.getElementById("telefono").hidden = true;
alert("Bienvenido a la mejor WEB, usted es el mejor");

document.getElementById("llamarAFabian").onmouseover =
    function () {
        document.getElementById("nombre").innerHTML
            = "Ha cambiado el texto del span";
        document.getElementById("labelFabian").innerHTML
        = "Tengo los dvd de hacking México";
    }





function ahumadaRecta() {

    /*las siguiente slíneas dibujan una recta*/
    /*declaro la variable ctx = contexto, lo que hace
    es tomar el canvas, y le indico que hará un
    dibujo en 2d*/
    var ctx = document.getElementById("canvas")
        .getContext("2d");
    /* declaro variables directamente les asigno valor,
    al igual que en java o en c, estas son para el 
    punto donde inicia el punto y tambien donde 
    terminará*/

    var x1 = 100, y1 = 200, x2 = 300, y2 = 100;
    /*determino el valor de x*/
    var dx = x2 - x1;
    /*determino el valor de y*/
    var dy = y2 - y1;
    /*ahora hago un ciclo for, donde x es donde inicia
    con el valor actual de x1 y llegara hasta igualarse 
    a x2*/
    for (var x = x1; x <= x2; x++) {
        var y = y1 + (dy) * (x - x1) / dx;
        ctx.fillRect(x, y, 1, 1);
    }

}



function obtenerCoordenadas(event) {
    /*con la siguiente línea se obtiene la
    coordenada xy, al usar el evento y la 
    propiedad clientx
    */
    x = event.clientX;
    y = event.clientY;
    /* mandamos los valores de las variables
    con la propiedad getElementById, con ella
    se especifíca a que ID se cargara el valor
    indicado*/
    document.getElementById("ejex").value = x;
    document.getElementById("ejey").value = y;
}

function cambioCaja() {
    /*'alert("Usted cambio el contenido");*/
    /*alert("Se ganó una hamburguesa de sirlon 400gm");*/
    document.getElementById("hamburguesa").value="10 hamburguesas";
}