<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="subirArchivo._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FileUpload ID="fluSubir" runat="server" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnSubir" runat="server" Height="29px" OnClick="btnSubir_Click" Text="Subir" Width="121px" />
        <br />
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" Height="325px" Width="424px" />
    
    </div>
    </form>
</body>
</html>
