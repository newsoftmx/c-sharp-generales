<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .Animation1
        {
	        position: absolute;
	        padding:3px;
	        border: solid 1px #000;	
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <br />
        <br />
        Clase 2 de Ajax<br />
        Mensaje Cloud<br />
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <asp:BalloonPopupExtender ID="txtNombre_BalloonPopupExtender" runat="server" BalloonPopupControlID="Panel1" BalloonSize="Medium" BalloonStyle="Cloud" CustomCssUrl="" DynamicServicePath="" Enabled="True" ExtenderControlID="" Position="TopRight" TargetControlID="txtNombre">
        </asp:BalloonPopupExtender>
        <asp:Panel ID="Panel1" runat="server">
            Mensaje que deseo que aparezca en popup, como cloud</asp:Panel>
        <br />
        Mensaje Rectangule<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:BalloonPopupExtender ID="TextBox1_BalloonPopupExtender" runat="server" BalloonPopupControlID="Panel2" CustomCssUrl="" DisplayOnMouseOver="True" DynamicServicePath="" Enabled="True" ExtenderControlID="" Position="BottomRight" TargetControlID="TextBox1">
        </asp:BalloonPopupExtender>
        <asp:Panel ID="Panel2" runat="server">
            Este mensaje aparece como Rectangulo</asp:Panel>
        <br />
        Mesaje Custom<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:BalloonPopupExtender ID="TextBox2_BalloonPopupExtender" runat="server" BalloonPopupControlID="Panel3" BalloonStyle="Custom" CustomClassName="oval" CustomCssUrl="~/Style/Css.css" DisplayOnFocus="True" DynamicServicePath="" Enabled="True" ExtenderControlID="" Position="BottomLeft" TargetControlID="TextBox2" BalloonSize="Medium">
        </asp:BalloonPopupExtender>
        <asp:Panel ID="Panel3" runat="server">
            Este mensaje aparecerá como Custom,Globo Circular</asp:Panel>
        <br />
        <asp:TextBox ID="TextBox3" runat="server" CssClass="Animation1">Escribe algun texto</asp:TextBox>
        <asp:AnimationExtender ID="AnimationExtender" runat="server" Enabled="True" TargetControlID="TextBox3">
            <Animations>
                <OnLoad>
                    <Sequence>
                        <Move Horizontal="300" Duration="1" Fps="20" />
                        <FadeOut Duration="3" Fps="20" />
                    </Sequence>
                </OnLoad></Animations>
        </asp:AnimationExtender>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
