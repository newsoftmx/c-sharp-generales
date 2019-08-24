

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="principal.aspx.cs" Inherits="principal" %>

<!DOCTYPE html>
<script runat="server">
  void Page_Load(object sender, EventArgs e)
  {
    Welcome.Text = "Hello, " + Context.User.Identity.Name;
  }

  void Signout_Click(object sender, EventArgs e)
  {
    FormsAuthentication.SignOut();
    FormsAuthentication.RedirectToLoginPage();
    //Response.Redirect("login.aspx");
  }
  void lbnSalir_Click(object sender, EventArgs e)
  {
      FormsAuthentication.SignOut();
      FormsAuthentication.RedirectToLoginPage();
      //Response.Redirect("login.aspx");
  }
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta content="10" http-equiv="REFRESH"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:label ID="lblSession" runat="server" text="Su Nombre va Aquí"></asp:label>
        <%: this.Session["Usuario"] %>
        <br />
        <br />
        <asp:Button ID="btnEliminarSession" runat="server" OnClick="btnEliminarSession_Click" Text="Clic aquí para eliminar la sesión" />

         <h3>
    Uso de Autenticacion por Formulario</h3>
  <asp:Label ID="Welcome" runat="server" />
 
    <asp:Button ID="Submit1" OnClick="Signout_Click" 
       Text="Sign Out" runat="server" />
        <br />
        <br />
        <br />
        <br />
    <asp:LinkButton ID="lbnSalir" OnClick="lbnSalir_Click" runat="server">Salir</asp:LinkButton>
    &nbsp;</div>
    </form>
</body>
</html>
