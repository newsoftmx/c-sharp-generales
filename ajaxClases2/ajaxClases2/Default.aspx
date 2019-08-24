<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ajaxClases2.Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <cc1:AutoCompleteExtender ID="TextBox1_AutoCompleteExtender" runat="server" 
                    CompletionInterval="100" CompletionSetCount="10" DelimiterCharacters="" Enabled="True" EnableCaching="false" 
                    MinimumPrefixLength="2" ServiceMethod="traerDatos" FirstRowSelected = "false" TargetControlID="TextBox1">
                </cc1:AutoCompleteExtender>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
