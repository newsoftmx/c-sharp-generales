/*Introduzca su JS*/

/*Variables*/
var valorIF = true;
var precioTotal = 0;
/*Fin de región de variables*/
function estructuraIF() {
    //alert("Condición cumplida");
    if (valorIF)
    {
        document.getElementById("texto1").value = "Hola";
        document.getElementById("lblCambiar").textContent = "La condición se cumplio";
    }
}
function estructuraIFParametro(variableParametro1, variableParametro2) {
    //alert("Condición cumplida");
    if (variableParametro1 == true) {
        document.getElementById("texto2").value = "Hola";
        document.getElementById("lblCambiar2").textContent = "La condición se cumplio";
    }
    if(variableParametro1== true && variableParametro2=="chema"){
        document.getElementById("texto3").value = "Se cumplieron las 2 condiciones";
        document.write("Se han cumplido las 2 condiciones");
    }
}
function estructuraIFValor(variableValor) {
    //alert("Condición cumplida");
    if (variableValor == "Hola") {
        document.getElementById("texto2").value = "Hola";
        document.getElementById("lblCambiar2").textContent = "La condición se cumplio";
    }
}
function verificarDisponibilidad(valor) {
    if (valor == "León de los Aldama") {
        document.getElementById("lblCiudad").textContent = "Disponible";
        document.getElementById("lblCiudad").style.color = "#006B53";
        document.getElementById("lblCiudad").style.fontFamily = "Impact";
    }
    else {
        document.getElementById("lblCiudad").textContent = "No disponible";
        document.getElementById("lblCiudad").style.color = "#FF4C00";
        document.getElementById("lblCiudad").style.fontFamily="Verdana";
    }
}
function totalCompra(precio) {
    
    total=total + (precio*1);
    return total;

}
function calcularTotalCompra(precio, total) {
    //var precioTotal = totalCompra(precio);
    //var precioTotal=1, precio1=2;
    //precioTotal = precioTotal + precio;

    //precioTotal = (1*precio) + precioTotal;
    precioTotal = totalCompra(precio);

    document.getElementById("totalCompra").textContent = precioTotal
}

/*Como se ha visto, un elemento XHTML sencillo, como por ejemplo un párrafo, genera dos nodos: el primer nodo es de tipo Element y representa la etiqueta <p> y el segundo nodo es de tipo Text y representa el contenido textual de la etiqueta <p>.

Por este motivo, crear y añadir a la página un nuevo elemento XHTML sencillo consta de cuatro pasos diferentes:

Creación de un nodo de tipo Element que represente al elemento.
Creación de un nodo de tipo Text que represente el contenido del elemento.
Añadir el nodo Text como nodo hijo del nodo Element.
Añadir el nodo Element a la página, en forma de nodo hijo del nodo correspondiente al lugar en el que se quiere insertar el elemento.
De este modo, si se quiere añadir un párrafo simple al final de una página XHTML, es necesario incluir el siguiente código JavaScript:

// Crear nodo de tipo Element
var parrafo = document.createElement("p");
 
// Crear nodo de tipo Text
var contenido = document.createTextNode("Hola Mundo!");
 
// Añadir el nodo Text como hijo del nodo Element
parrafo.appendChild(contenido);
 
// Añadir el nodo Element como hijo de la pagina
document.body.appendChild(parrafo);*/

       /* Afortunadamente, eliminar un nodo del árbol DOM de la página es mucho más sencillo que añadirlo. En este caso, solamente es necesario utilizar la función removeChild():

        var parrafo = document.getElementById("provisional");
        parrafo.parentNode.removeChild(parrafo);
 
        <p id="provisional">...</p>*/
    