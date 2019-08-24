<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/estilos.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script>
<script>
    $(document).ready(function () {
        $('.menu ul ul').css({
            position: "absolute",
            display: "none"
        });

        $('.menu li').hover(function () {
            $(this).find('>ul').stop(true, true).slideDown('slow');
        }, function () {
            $(this).find('>ul').stop(true, true).slideUp('slow');
        });
    });
	</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="color:#f00; font-size:large;" id="karla" class="lopez">Bienvenidos</h1>
        <p style="color:#f00; font-size:large;">Hello hacks</p>
        
    </div>
        <!--esto es un comentario-->
        <br /><!-- esto es un brinco de linea-->
        <p>Esto es un parrafo</p>
        Hola ingenieros<br />sonrian siempre<br />
        <table><!-- esto es una tabla-->
            <tr><!-- esto es una fila-->
                <td><!-- esto es una columna-->
                    Clave
                </td>
                <td>Nombre</td>
                <td>Ciudad</td>
            </tr>
            <tr></tr><!--otro renglon-->
            <tr></tr><!--otro renglon-->
        </table>
        <ol><!-- lista ordenada-->
            <li>Itzel</li><!--Muestro un elemento de la lista-->
            <li>Angel</li>
            <li>Urincho</li>
        </ol>
        <ul><!-- listas desordenadas-->
            <li>El Vitor</li><!-- Muestro un elemento-->
            <li>Poncho Aurelio</li>
            <li>Steve Ballmer</li>
            <li>Steve Elop</li>
        </ul>
 </form>
    <div id="menu" class="menu">
        <ul>
            <li><a href="index.html" target="_self">Inicio</a></li>
            <li><a href="#">Conócenos</a>
            <ul>
                <li><a href="nosotros.html">Nosotros</a></li>
                <li><a href="mision_vision.html">Misión y Visión</a></li>
                <li><a href="valores.html">Valores</a></li>
            </ul>
            </li>
			<li><a href="#">Productos</a>
            <ul>
                <li><a href="">Hardware</a></li>
                <li><a href="">Software</a></li>
                <li><a href="">Redes</a></li>                 
            </ul></li>
            <li><a href="#">Sucursales</a>
			<ul>
                <li><a href="zonas.html">Zonas</a></li>
                <li><a href="distribuidores.html">Distribuidores</a></li>
            </ul>                            
            </li>
            <li><a href="contacto.html">Contáctanos</a></li>
            </ul> 
        </div>   
<br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
   
    <img src="image/Penguins.jpg" />
    <a href="http:delasalle.edu.mx" target="_parent">dede</a>
</body>
</html>
