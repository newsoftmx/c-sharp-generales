<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="sesiones2.Login" %>
<script runat="server">
    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        string usuario, password;
        usuario = txtUsuario.Text;
        password = txtPassword.Text;
        if (txtUsuario.Text!="")
        {
            ///si la caja no esta vacia entonces
            ///creare la sesion
            ///usando el comando Session["variable"]
            Session["usuario"]=usuario;
            //Session["usuario"] = txtUsuario.Text;
            //Response.Redirect("Default.aspx");
            
            ///aquí comienza la verificacion con la bd
            ///
            //declarar una variable cadena para usarla como usuario valido
            string usuarioBD = "ernesto";
            if(usuarioBD==txtUsuario.Text)
            {
                //quiere decir que si existe en la bd y debe ingresar
                //agrego una variable de session llamada usuarioBD
                Session["usuarioBD"]=usuarioBD;
                Response.Redirect("Default.aspx");
            }
            else
            {
                ///quiere decir que si escribio en el formulario, pero
                ///no existe en la bd
                ///
                lblErrorSesion.Text = "El usuario o password, no han sido registrados";
            }
        }
        else
        {
            //si esta vacia, debera mostrar la etiqueta 
            //y permanecer en el login
            lblErrorSesion.Visible = true;
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
    
        Usuario:&nbsp;&nbsp;
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br />
        <br />
        Password:&nbsp;&nbsp;
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblErrorSesion" runat="server" ForeColor="Red" Text="Los datos proporcionados no son correctos" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnIngresar" runat="server" OnClick="btnIngresar_Click" Text="Ingresar" />
    
    </div>
    </form>
</body>
</html>
