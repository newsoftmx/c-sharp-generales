<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Using the Animation Extender in AJAX Control Toolkit</title>
   
   <style type="text/css">
<!--
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
}
a:link {
	color: #0000FF;
}
a:visited {
	color: #0000FF;
}
a:hover {
	color: #0000FF;
	text-decoration: none;
}
a:active {
	color: #0000FF;
	}
.basix {
	font-family: Verdana, Arial, Helvetica, sans-serif;
	font-size: 11px;
}
.header1 {
	font-family: Verdana, Arial, Helvetica, sans-serif;
	font-size: 11px;
	font-weight: bold;
	color: #006699;
}
.lgHeader1 {
	font-family: Arial, Helvetica, sans-serif;
	font-size: 18px;
	font-weight: bold;
	color: #0066CC;
	background-color: #CEE9FF;
}

.Animation1
{
	position: absolute;
	padding:3px;
	border: solid 1px #000;	
}
.Animation2
{
	display:none;
	position:absolute;
	width:1px;
	height:1px;
	left:400px;
	top:600px;
	padding:3px;
	border:solid 1px #000;
}
-->
</style> 
</head>
<body>
  

        <br />
        &nbsp;<table align="center" border="0" cellpadding="0" cellspacing="0" style="position: static"
            width="752">
            <tr bgcolor="#5482fc">
                <td colspan="4">
                    <img height="1" src="/media/spacer.gif" width="1" /></td>
            </tr>
            <tr>
                <td bgcolor="#5482fc" width="1">
                    <img alt="Server Intellect" height="1" src="media/spacer.gif" width="1" /></td>
                <td width="250">
                    <a href="http://www.serverintellect.com">
                        <img alt="Server Intellect" border="0" height="75" src="media/logo.gif" width="250" /></a></td>
                <td bgcolor="#3399ff" width="500">
                    <a href="http://www.serverintellect.com">
                        <img alt="Server Intellect" border="0" height="75" src="media/headerR1.gif" width="500" /></a></td>
                <td bgcolor="#5482fc" width="1">
                    <img alt="Server Intellect" height="1" src="media/spacer.gif" width="1" /></td>
            </tr>
            <tr bgcolor="#5482fc">
                <td colspan="4">
                    <img height="1" src="media/spacer.gif" width="1" /></td>
            </tr>
        </table>
        <br />
        <table align="center" bgcolor="#5482fc" border="0" cellpadding="5" cellspacing="1"
            style="position: static; width: 692px;">
            <tr>
                <td align="center" class="lgHeader1" height="50">
                    Using the Animation Extender in AJAX Control Toolkit</td>
            </tr>
        </table>
        <br />
        <br />
        
    <fieldset style="width: 804px" align="center">
   
    <legend>Using the Animation Extender in AJAX Control Toolkit</legend>
    <div align="left" style="text-align: center">







    <form id="form1" runat="server">
        <asp:ScriptManager ID="SM1" runat="server" />
        <br />
        <asp:Panel ID="panel_Animated" runat="server" CssClass="Animation1">
            Animation imminent.
        </asp:Panel>
        <br />
        <cc1:AnimationExtender ID="AnimationExtender1" runat="server" TargetControlID="panel_Animated">
            <Animations>
                <OnLoad>
                    <Sequence>
                        <Move Horizontal="300" Duration="1" Fps="20" />
                        <FadeOut Duration="1" Fps="20" />
                    </Sequence>
                </OnLoad>
            </Animations>
        </cc1:AnimationExtender>
        <br />
        <br />
        <asp:Button ID="btn_Animate" runat="server" Text="Animate" OnClientClick="return false;" />
        <br />
        <asp:Panel ID="panel_Animated2" runat="server" CssClass="Animation2">
            Animation2 imminent.
        </asp:Panel>
        <br />
        <cc1:AnimationExtender ID="AnimationExtender2" runat="server" TargetControlID="btn_Animate">
            <Animations>
                <OnClick>
                    <Sequence AnimationTarget="panel_Animated2">
                        <EnableAction AnimationTarget="btn_Animate" Enabled="false" />
                        <StyleAction Attribute="display" Value="Block" />
                        <Parallel>
                            <FadeIn Duration="1" Fps="20" />
                            <Scale Duration="1" Fps="20" ScaleFactor="30.0" Center="true" />
                        </Parallel>
                    </Sequence>
                </OnClick>
            </Animations>
        </cc1:AnimationExtender>
    </form>
    
    






   </div>
    </fieldset>    
      
        <table align="center" cellpadding="0" cellspacing="0" style="position: static" width="500">
            <tr>
                <td align="center" class="basix" height="50">
                    <strong>Power. Stability. Flexibility.</strong><br />
                    Hosting from <a href="http://www.serverintellect.com">Server Intellect</a><br />
                    <br />
                    For more AJAX Tutorials visit <a href="http://ajaxtutorials.com">www.ajaxtutorials.com</a></td>
            </tr>
        </table>
</body>
</html>
