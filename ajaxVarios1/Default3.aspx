<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Hola a todos<br />
        <br />
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <br />
        Fecha de nacimento sin ajax:
        <br />
        <br />
        <br />
        Fecha de nacimiento:
        <asp:TextBox ID="TextBox1" runat="server" Height="29px" Width="274px"></asp:TextBox>
        <asp:TextBoxWatermarkExtender ID="TextBox1_TextBoxWatermarkExtender" runat="server" Enabled="True" TargetControlID="TextBox1" WatermarkText="Selecciona tu contraseña">
        </asp:TextBoxWatermarkExtender>
        <asp:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" Enabled="True" TargetControlID="TextBox1">
        </asp:CalendarExtender>
        <br />
        <br />
        Escribe tus comentarios:<br />
&nbsp;<asp:TextBox ID="TextBox2" runat="server" Height="57px" Width="407px" TextMode="MultiLine"></asp:TextBox>
        <asp:ResizableControlExtender ID="TextBox2_ResizableControlExtender" runat="server" Enabled="True" HandleCssClass="textarea" TargetControlID="TextBox2">
        </asp:ResizableControlExtender>
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                Update Panel<br />
                <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Height="158px" UseVerticalStripPlacement="True" Width="467px">
                    <asp:TabPanel ID="TabPanel1" runat="server" HeaderText="General">
                        <ContentTemplate>
                            <asp:Button ID="btnConexion" runat="server" Height="36px" OnClick="btnConexion_Click" Text="Probar Conexión" Width="226px" />
                        </ContentTemplate>
                    </asp:TabPanel>
                    <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="Personal">
                        <ContentTemplate>
                            <p>
                                Capture su información personal por favor</p>
                        </ContentTemplate>
                    </asp:TabPanel>
                    <asp:TabPanel ID="TabPanel3" runat="server" HeaderText="Pagos">
                    </asp:TabPanel>
                    <asp:TabPanel ID="TabPanel4" runat="server" HeaderText="Preferencias">
                    </asp:TabPanel>
                </asp:TabContainer>
                <br />
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        Usando tab container<br />
        <br />
        <br />
        <br />
        <asp:TabContainer ID="TabContainer2" runat="server" ActiveTabIndex="3" 
            Height="35px" Width="681px">
            <asp:TabPanel runat="server" HeaderText="General" ID="TabPanel5">
            </asp:TabPanel>
            <asp:TabPanel ID="TabPanel6" runat="server" HeaderText="TabPanel6">
            </asp:TabPanel>
            <asp:TabPanel ID="TabPanel7" runat="server" HeaderText="TabPanel7">
            </asp:TabPanel>
            <asp:TabPanel ID="TabPanel8" runat="server" HeaderText="TabPanel8">
            </asp:TabPanel>
        </asp:TabContainer>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
