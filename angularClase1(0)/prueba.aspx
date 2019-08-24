<%@ Page Language="C#" AutoEventWireup="true" CodeFile="prueba.aspx.cs" Inherits="prueba" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <script type="text/javascript">
        setInterval("reloj()", 1000);
        function reloj() {
            var fObj = new Date();
            var horas = fObj.getHours();
            var minutos = fObj.getMinutes();
            var segundos = fObj.getSeconds();
            if (horas <= 9) horas = "0" + horas;
            if (minutos <= 9) minutos = "0" + minutos;
            if (segundos <= 9) segundos = "0" + segundos;
            window.status = horas + ":" + minutos + ":" + segundos;
        }
        var id = setInterval("reloj()", 1000);
        setTimeout("clearInterval(" + id + ")", 15000);

        setTimeout("document.location.href='http://www.google.es';", 5000);

    </script>
        
    </div>
    </form>
</body>
</html>
