<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <!--Ahora indico en el body la función a ejecutar al momento de mover
        el mouse, imporante el colocar la variable event y el ; -->
<body onmousemove="obtenerCoordenadas(event);">
    <form id="form1" runat="server">
    <div>
        <!--Agregamos una etiqueta llamada canvas, se utiliza para hacer figuras
            es HTML5, recuerde que tambien se le asigna un nombre, se usa la
            propiedad id -->
        <canvas id="canv" width="400" height="400" style="border:1px solid #000000;">Sorry, no puedo mostrar el dibujo u objeto</canvas>
        <!--el siguiente script genera la figura cuadrada
            -->
    </div>
   </form>
    <script type="text/javascript">
        /*Declaramos una variable, puede llamarse como desee, ctx=contexto
        lo que hara es tomar el canvas, usado anteriormente y le específíco 
        que hare un dibujo en 2d*/
        var ctx = document.getElementById('canv').getContext("2d");
        /*declaro las variables directamente les asigno valor, al igual que 
        en java o en c++ o c#, estas son para el punto donde incia y el 
        punto donde terminará*/
        var x1 = 100, y1 = 200, x2 = 300, y2 = 100;

        var dx = x2 - x1; // se utilizarán para determinar el tamaño de x
        var dy = y2 - y1; // se utilizarán para determinar el tamaño de y

        /*vamos a indicar que dibuje con el ciclo for, 
        para ello establecemos la variable x donde se inicia con el
        valor actual de x1 y llegara hasta igualarse a x2*/
        for (var x = x1; x <= x2; x++)
        {
            /*hasta aqui se creo el eje X, ahora realizaremos los trazos 
            del eje Y, se multiplica dy para saber la distancia sobre la 
            que se traza la figura, ententiendo que son dos rectas */
            var y = y1 + (dy) * (x - x1) / (dx);
            /*Ahora dibujo un rectangulo lleno, con fillRect, mandando llamar 
            el area de canvas, iniciando a partir del valor recibido en 
            X y Y, si X=10, se recorre 10 pixeles y comienza el dibujo*/
            ctx.fillRect(x, y, 1, 1);
        }
    </script>
    <!-- Accediendo por la jerarquia name=""-->
    <form name ="formulario">
        Nombre: <input type="text" name="nombre" id="nombre" onchange="alert('Ha cambiando el contenido');" />
    </form>
    <input type="button" value="Comprar" onclick="alert('Gracias por su compra');" />
    <script type="text/javascript">
        document.formulario.nombre.value = "Barcelona";
        document.formulario.nombre.focus();
    </script>
    <!--Accediendo por identificador id=""-->
    <script>
        //document.getElementById("nombre").disabled = true;
        //document.getElementById("nombre").style.color = "#A52";
        //document.getElementById("nombre").style.fontSize = "2em";
    </script>
        <p>
            <label>x</label><input type="text" id="ejex" />
            <label>y</label><input type="text" id="ejey" />
       </p>
   
    <script type="text/javascript">
        /*Esta función obtendra las coordenadas de mi mouse, declaramos un event,
        esta función recibira ese evento*/
        function obtenerCoordenadas(event) {
            /*con la siguiente linea se obtiene la coordenada xy, al usar el evento y
            la propiedad clientX*/
            x = event.clientX;
            y = event.clientY;
            /*ahora mandamos los valores de las variables a los labels, con
            la propiedad getElementById, con el se especifica a que id
            se cargara el valor indicado*/
            document.getElementById("ejex").value = x;
            document.getElementById("ejey").value = y;
            /*ahora pasamod al body para obtener accionar la funcion */
        }
    </script>
    <!-- Esto es lo correcto, nunca mezclar las funciones con html-->



    <script>
        /*Ahora mandamos un mensaje de bienvenida, recuerden que va a final para 
        que sea despues de cargar toda la pagina*/
        alert("Bienvenido a la mejor WEB, usted es el mejor");
    </script>
</body>
</html>
