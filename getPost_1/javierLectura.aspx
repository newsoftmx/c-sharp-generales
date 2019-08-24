<%@ Page Language="C#" AutoEventWireup="true" CodeFile="javierLectura.aspx.cs" Inherits="javierLectura" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   

<form id="form2" runat="server" method="post">
    <div>
     Su Información es:&nbsp;&nbsp;
        <asp:Label ID="lblUsuario" runat="server" Text="Su pedido>"></asp:Label>
            <br />
            <br />
            
            <%
                Response.Write(Request.Form["txtUser"].ToString());
            %>
    </div>
    </form>

</body>
</html>
