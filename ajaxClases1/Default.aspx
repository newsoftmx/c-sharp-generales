<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Auto Completar con AJAX 4.5 de .NET
        <br />
        <br />
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
<br />
                Escribe el nombre de empleado a buscar:
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                <asp:AutoCompleteExtender 
                    ID="txtNombre_AutoCompleteExtender" 
                    runat="server" DelimiterCharacters=""
                     Enabled="True" ServicePath="" 
                    TargetControlID="txtNombre" CompletionInterval="10" MinimumPrefixLength="1" ServiceMethod="traerDatos">
                </asp:AutoCompleteExtender>

                <br />
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
