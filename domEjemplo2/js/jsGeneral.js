/*Java Script de uso general*/
//variables de uso general
var valorIF=true;
function verificarIF() {
    if (valorIF)
    {
        document.getElementById("lblCambiar").textContent = "Se ha cumplido";
        document.getElementById("texto1").value = "Hola";
    }
}
function verificarParametro(variableParametro) {
    if (variableParametro==true)
    {
        document.getElementById("texto2").value = "Se cumplio";
    }
    else
    {
        document.getElementById("texto2").value = "No se cumplio";
    }
}
function verificarValor(variable) {
    if  (variable=="Hola")
    {
        document.getElementById("texto3").value = "juan";
    }
    else
    {
        document.getElementById("texto3").value = "No es correcto";
    }
}