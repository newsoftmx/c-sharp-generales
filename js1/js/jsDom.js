/*Obtengo el objeto raiz de mi web*/
var objetoHTMLWEB = document.documentElement;
//obtengo el primer nodo
var objetoHead = objetoHTMLWEB.firstChild;
//obtengo el último nodo
var objetoBody = objetoHTMLWEB.lastChild;
//obteno¿go el total de nodos
var numeroNodos = objetoHTMLWEB.childNodes.length;
alert("El valor de numero de nodos es: " + numeroNodos);
var objetoParrafo = document.getElementById("parrafo1")
    .textContent;
alert("Ahora pasamos el contenido del parrafo1 
    al parrafoReceptor");
document.getElementById("parrafoReceptor").textContent
= objetoParrafo.toString();