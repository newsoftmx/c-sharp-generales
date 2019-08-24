<%@ Page Language="C#" AutoEventWireup="true" CodeFile="controles1.aspx.cs" Inherits="controles1" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                </asp:ToolkitScriptManager>
<br />
                Escriba el nombre a buscar:&nbsp;&nbsp;
                <asp:TextBox ID="txtBusqueda" runat="server" Height="29px" Width="297px"></asp:TextBox>
                <asp:TextBoxWatermarkExtender ID="txtBusqueda_TextBoxWatermarkExtender" runat="server" Enabled="True" TargetControlID="txtBusqueda" WatermarkText="Escriba el nombre que desea buscar">
                </asp:TextBoxWatermarkExtender>
                <asp:AutoCompleteExtender ID="txtBusqueda_AutoCompleteExtender" runat="server" CompletionInterval="10" DelimiterCharacters="" Enabled="True" MinimumPrefixLength="1" ServiceMethod="traerDatos" ServicePath="" CompletionSetCount="10" TargetControlID="txtBusqueda">
                </asp:AutoCompleteExtender>
<br />
<br />
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
