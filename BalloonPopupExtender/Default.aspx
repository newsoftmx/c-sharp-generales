<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="CS" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </cc1:ToolkitScriptManager>
    <u>Cloud Style Balloon Popup</u><br />
    <br />
    <asp:TextBox ID="TextBox2" runat="server" />
    <cc1:BalloonPopupExtender ID="BalloonPopupExtender2" TargetControlID="TextBox2" UseShadow="true"
        DisplayOnFocus="true" Position="BottomRight" BalloonPopupControlID="Panel2" BalloonStyle="Cloud"
        runat="server" />
    <asp:Panel ID="Panel2" runat="server">
        This is a Cloud Balloon Popup
    </asp:Panel>
    <hr />
    <u>Rectangle Style Balloon Popup</u><br />
    <br />
    <asp:TextBox ID="TextBox3" runat="server" />
    <cc1:BalloonPopupExtender ID="BalloonPopupExtender3" TargetControlID="TextBox3" UseShadow="true"
        DisplayOnFocus="true" Position="BottomRight" BalloonPopupControlID="Panel3" BalloonStyle="Rectangle"
        runat="server" />
    <asp:Panel ID="Panel3" runat="server">
        This is a Rectangle Balloon Popup
    </asp:Panel>
    <hr />
    <u>Custom Style Balloon Popup</u><br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" />
    <cc1:BalloonPopupExtender ID="BalloonPopupExtender1" TargetControlID="TextBox1" UseShadow="true"
        DisplayOnFocus="true" Position="BottomRight" BalloonPopupControlID="Panel1" BalloonStyle="Custom"
        CustomCssUrl="~/Styles/Css.css" CustomClassName="oval" runat="server" />
    <asp:Panel ID="Panel1" runat="server">
        This is a Custom Balloon Popup
    </asp:Panel>
    </form>
</body>
</html>
