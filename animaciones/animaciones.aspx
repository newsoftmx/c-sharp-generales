<%@ Page Language="C#" AutoEventWireup="true" CodeFile="animaciones.aspx.cs" Inherits="animaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/animate.css" type="text/css"
        media="all" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox class="option animated wobble" placeholder="Escriba su usuario" ID="TextBox1" runat="server">

        </asp:TextBox>
    </div>
    <div class="option animated wobble">
        Este texto será animado.</div>
    </form>
    <div class="miclase animated">
        <p>Animaremos este texto, con un click 
            <a href="" id="ref">AQUI></a>
        </p>
    </div>
     <h1 class="tunombre animated" id="miidentificador">
            TU NOMBRE
     </h1>
       
    <!--<script src="js/jquerymin.js"></script> -->
    <script type="text/javascript" src="http://code.jquery.com/jquery-latest.min.js"></script>
    <script src="js/jsGeneral.js"></script>
</body>
</html>
