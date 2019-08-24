<%@ Page Language="C#" AutoEventWireup="true" CodeFile="variosForms.aspx.cs" Inherits="variosForms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post">
    <div>
    Formulario usado para método POST<br />
        <asp:Label ID="Label1" runat="server" Text="Usuario "></asp:Label>
&nbsp;<asp:TextBox ID="txtUsuarioPost" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password "></asp:Label>
        <asp:TextBox ID="txtPasswordPost" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" PostBackUrl="BienvenidoPOST.aspx" Text="Enviar por POST" />
&nbsp;<br />
    </div>
    </form>
    
    <form id="form2" method="post" 
action="http://www.teresianolagos.edu.mx/php/variablesPost.php" >
        Formulario usado para método POST<br />
        <br /><
            &nbsp;Usuario:
        <input hidden="hidden" value="Usuario" name="txtUsuarioPost" id="txtUsuarioPost" type="text" /><br />
&nbsp;Password:
        <input hidden="true" value="Hola123" name="txtPasswordPost" id="txtPasswordPost" type="text" /><br />
            &nbsp;<br />
        <input id="btnEnviarPost" type="submit" value="Enviar por Post" /><br />
    </form>
    
    <form id="form3" method="get"
action="http://www.teresianolagos.edu.mx/php/variablesGet.php" >
        Formulario usado para método GET<br />
        <br />
            &nbsp;Usuario:
        <input name="txtUsuarioGet" id="txtUsuarioGet" type="text" /><br />
&nbsp;Password:
        <input name="txtPasswordGet" id="txtPasswordGet" type="text" /><br />
            &nbsp;<br />
        <input id="Submit1" type="submit" value="Enviar por GET" /><br />
    </form>
    <p>
        <a href="variablesGET.aspx?txtUsuario=Juan&txtPassword=Hola123">Mandar variable get sin formulario</a>
    </p>
</body>
</html>
