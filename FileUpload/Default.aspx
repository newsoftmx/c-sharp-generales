<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:FileUpload ID="fluArchivo" runat="server" />
        <asp:Button ID="btnSubirArchivo" runat="server" OnClick="btnSubirArchivo_Click" Text="Subir" />
    <br />
    <asp:Button runat="server" id="btnSubir" text="Subir Imagen" 
            onclick="UploadButton_Click" />
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" />
    </div>
    </form>
</body>
</html>
