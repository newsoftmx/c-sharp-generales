<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Correcto.aspx.cs" Inherits="Correcto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form name="Formulario" >
    <div>
        <span id="nombre"> Nombre: </span>
        <input type="text" name="nombre" id="camponombre" />
        <label id="prueba" value="hola">holas</label>
        <input type="button" id="botonPersonalizado" value="Por favor pulsa aquí" />
    </div>
    </form>


    <!--El fin de la página y entonces escribo las funciones-->
    <script>
        /* 2 document.getElementById("botonPersonalizado").onclick = function () {
            alert("Ha pulsado el boton ");
        }*
        /* Una forma no tan limpia */
       /* 1 function presionarClic() {
            document.getElementById("nombre").innerHTML="Por favor escriba su nombre";
        }
        document.getElementById("botonPersonalizado").onclick = presionarClic();*/

        /*document.getElementById("botonPersonalizado").onclick = function () {
            alert("Ha pulsado el boton " + document.getElementById("botonPersonalizado").value);
        }*/
        /*Ahora usaremos la propiedad innerHTML para modificar el contenido de esa etiqueta
        lo mejor sin hacer postback*/
        document.getElementById("botonPersonalizado").onclick =
            function () {
                document.getElementById("nombre").innerHTML = "Por favor escriba su nombre: ";
                document.getElementById("prueba").innerHTML = "OSvaldo";
            }

        /* Lo ultimo a enseñar
        Carácter	Función
\n	Salto de línea
\t	Tabulador
\\	Carácter \
\’	Comilla simple
\"	Comilla doble

operadores de asignación
	Asigna a la vble de la parte izquierda el valor de la parte derecha.
+=	Suma los operandos izquierdo y derecho y asigna el resultado al operando izquierdo.
-=	Resta el operando derecho del operando izquierdo y asigna el resultado al operando izquierdo.
*=	Multiplica ambos operandos y asigna el resultado al operando izquierdo.
/=	Divide ambos operandos y asigna el resultado al operando izquierdo.
%=	Divide ambos operandos y asigna el resto al operando izquierdo.

operadores aritmeticos
dor	Descripción
+	Suma.
-	Resta.
*	Multiplica.
/	Divide.
%	Calcula el resto de una división.


operadores de comparación
Operador	Descripción
= =	Devuelve el valor true cuando los dos operandos son iguales.
!=	Devuelve el valor true cuando los dos operandos son distintos.
>	Devuelve el valor true cuando el operando de la izquierda es mayor que el de la derecha.
<	Devuelve el valor true cuando el operando de la derecha es menor que el de la izquierda.
>=	Devuelve el valor true cuando el operando de la izquierda es mayor o igual que el de la derecha.
<=	Devuelve el valor true cuando el operando de la derecha es menor o igual que el de la izquierda.

logicos
&&	Y lógica. El valor de devolución es true cuando ambos operandos son verdaderos.
||	O lógica. El valor de devolución es true cuando alguno de los operandos es verdadero o lo son los dos.
!	No lógica. El valor de devolución es true cuando el valor es falso.


        */

    </script>
</body>
</html>
