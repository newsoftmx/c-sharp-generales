<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/login.aspx.cs" Inherits="login" %>
<%@ Import Namespace="System.Web.Security" %>
<script runat="server">
    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        string usuario, password;
        usuario = txtCorreo.Text;
        password = txtPassword.Text;
        if (txtCorreo.Text != "")
        {
            Session["Usuario"] = txtCorreo.Text;
            Response.Redirect("principal.aspx");
        }
        else
        {
            lblErrorNombreUsuario.Visible = true;
        }

       /* if(FormsAuthentication.Authenticate
            (usuario,password))
        {
            FormsAuthentication.RedirectFromLoginPage
                (usuario, chkAutenticacion.Checked);
            //Response.Redirect("");
        }
        else
        {
            lblMensajeError.Text = "Datos incorrectos, por favor escribe un correo y password validos";
        }*/
        /*if ((txtCorreo.Text == "vibeco@hotmail.com") && (txtPassword.Text == "Hola123"))
        {
            FormsAuthentication.RedirectFromLoginPage(txtCorreo.Text, chkAutenticacion.Checked);
        }
        else
        {
            lblMensajeError.Text = "Datos incorrectos, por favor escribe un correo y password validos";
        }*/
    }
</script>

<html>
<head id="Head1" runat="server">
  <title>Forms Authentication - Login</title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body style="text-align:center;">
  <form id="form1" runat="server">
  
      <h3 class="auto-style1">
        Inicie Sesión</h3>
    <table>
      <tr>
        <td class="auto-style1">
            Correo:</td>
        <td>
          <asp:TextBox ID="txtCorreo" runat="server" /></td>
        <td class="auto-style1">
          <asp:RequiredFieldValidator ID="requerirCorreo" 
            ControlToValidate="txtCorreo"
            Display="Dynamic" 
            ErrorMessage="Debe escribir el correo del usuario" 
            runat="server" ForeColor="Red" />
        </td>
      </tr>
      <tr>
        <td class="auto-style1">
            Password:</td>
        <td>
          <asp:TextBox ID="txtPassword" TextMode="Password" 
             runat="server" />
        </td>
        <td class="auto-style1">
          <asp:RequiredFieldValidator ID="requerirPassword" 
            ControlToValidate="txtPassword"
            ErrorMessage="Debe escribir un password" 
            runat="server" ForeColor="Red" />
        </td>
      </tr>
      <tr>
        <td class="auto-style1">
            Recordar?</td>
        <td>
            <asp:CheckBox ID="chkAutenticacion" runat="server" />
          </td>
      </tr>
    </table>
    <asp:Button ID="btnIngresar"  Text="Entrar" 
       runat="server" OnClick="btnIngresar_Click" />
    <p class="auto-style1">
      <asp:Label ID="lblMensajeError" ForeColor="Red" runat="server" />
    </p>
  </form>
</body>
</html>