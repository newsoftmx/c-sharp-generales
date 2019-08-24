<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dom1.aspx.cs" Inherits="dom1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p id="parrafo1">Comenzamos el aprendizaje de DOM</p>
        <p>Esto es el parrafo2</p>
        <p>
            <input type="text" id="texto1" />
        </p>
        <p id="parrafoReceptor"> Todo se borrara
            <input type="text" id="texto2" value="Caja2" />
            <input type="text" id="texto3" value="Caja3"/>
            <input type="text" id="texto4" value="Caja4"/>
        </p>
    </div>
    </form>
    <script src="js/jsDom.js"></script>
</body>
</html>
