<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="sesiones.login" %>


<script runat="server">
    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        string usuario, password;
        usuario = txtUsuario.Text;
        password = txtPassword.Text;
        if (txtUsuario.Text != "")
        {
            //creo la sesion
            Session["Usuario"] = txtUsuario.Text;
            //lo redirecciono a una pagina
            //Response.Redirect("Default.aspx");
            ///despues de enseñarles este acceso, lo que hacemos es verificar
            ///pero ya con una base de datos, como no tengo conexion aun, pues
            ///simplemente lo hago simulado
            //codigo para verificar con base de datos
            string valorUsuarioBD= "SuperAlumnoSonLosMejoresLosQuiero";
            if (valorUsuarioBD == txtUsuario.Text)
            {
                ///entonces el usuario existe en la bd y debe ingresar
                ///y creo la variable de session llamada usuarioBD
                Session["usuarioBD"]=txtUsuario.Text;
                Response.Redirect("Default.aspx");
            }
            else
            {
                lblErrorNombreUsuario.Text = "El nombre de usuario es incorrecto, verifique nuevamente";
                lblErrorNombreUsuario.Visible = true;
            }
        }
        else
        {
            //si no existe el usuario pues entonces lo que hago es motrar la pagina WEB
            lblErrorNombreUsuario.Visible = true;
        }
        

    }
</script>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Ingrese sus datos<br />
        Usuario:&nbsp;
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br />
        <br />
        Password:
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblErrorNombreUsuario" runat="server" BorderStyle="None" ForeColor="#CC0000" Text="El correo con el que desea  ingresar no es correcto o no existe en el sistema" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnIngresar" runat="server" OnClick="btnIngresar_Click" Text="Ingresar" />
    
    </div>
    </form>
</body>
</html>
