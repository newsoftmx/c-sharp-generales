<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
    <link href="css/general.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="alex">
        Bienvenido a la página Pirma Brasil<br />
    
    </div>
    </form>
    <div class="menu" id="menu">
        <ul>
            <li><a href="http://delasalle.edu.mx"> conocenos</a></li>
            <li><a href="">compra ahora</a></li>
            <li><a href="#">sucursales</a>
                <ul>
                    <li><a href="">León</a></li>
                    <li><a href="">San Francisco</a></li>
                    <li><a href="">Irapuato</a></li>
                </ul>
            </li>
            <li><a href="#">promociones</a>
                <ul>
                    <li><a href="">Tenis</a></li>
                    <li><a href="">Runners</a></li>
                    <li><a href="">Soccer</a></li>
                    <li><a href="">Basket</a></li>
                </ul>
            </li>

            <li><a href="">unete</a></li>
            <li><a href="">contactanos</a></li>
        </ul>

    </div>
</body>
</html>
