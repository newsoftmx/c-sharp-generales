<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 706px">
    
        Usando marca de agua, calendario y el tab container<br />
        <br />
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <br />
        Selecciona la fecha de cumpleaños:
        <asp:TextBox CssClass="button" ID="TextBox1" runat="server" Height="31px" Width="548px"></asp:TextBox>
        <asp:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" Enabled="True" FirstDayOfWeek="Sunday" TargetControlID="TextBox1">
        </asp:CalendarExtender>
        
        <asp:TextBoxWatermarkExtender ID="TextBox1_CornejoMarker" runat="server" Enabled="True" TargetControlID="TextBox1" WatermarkText="Dijo Vega que escribas su fecha de nacimiento">
        </asp:TextBoxWatermarkExtender>
        <br />
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="4" Height="180px" Width="744px">
                    <asp:TabPanel ID="General" runat="server" HeaderText="General">
                        <ContentTemplate>
                            Hola atodos
                        </ContentTemplate>
                    </asp:TabPanel>
                    <asp:TabPanel ID="Personal" runat="server" HeaderText="Personal">
                        <ContentTemplate>
                            Debemos festehjas cada mes
                        </ContentTemplate>
                    </asp:TabPanel>
                    <asp:TabPanel ID="Pagos" runat="server" HeaderText="Pagos">
                        <ContentTemplate>
                            Un cumpleaños del salon
                        </ContentTemplate>
                    </asp:TabPanel>
                    <asp:TabPanel ID="Preferencias" runat="server" HeaderText="Preferencias">
                        <ContentTemplate>
                            En el sam venden pasteles buenos, bonitos ybaratos, 3
                    <br />
                        </ContentTemplate>
                    </asp:TabPanel>
                    <asp:TabPanel ID="pruebaDivina" runat="server" HeaderText="Prueba divina">
                        <ContentTemplate>
                            <asp:Button ID="btnDiosMeEscucha" runat="server" Height="73px" OnClick="btnDiosMeEscucha_Click" Text="¿Prueba si Dios Te Escucha?" Width="388px" />
                    <br />
                    <br />
                    <br />
                    <br />
                        </ContentTemplate>
                    </asp:TabPanel>
                </asp:TabContainer>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <br />
        <asp:TabContainer ID="TabContainer2" runat="server" ActiveTabIndex="0" Height="199px" Width="726px">
            <asp:TabPanel ID="TabPanel1" runat="server" HeaderText="TabPanel1">
                <ContentTemplate>
                    Hola Mundo
                </ContentTemplate>
            </asp:TabPanel>
            <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="TabPanel2">
                <ContentTemplate>
                    Carlos no te pierdas
                </ContentTemplate>
            </asp:TabPanel>
            <asp:TabPanel ID="TabPanel3" runat="server" HeaderText="TabPanel3">
                <ContentTemplate>
                    Paula, no me olvides Paula
                </ContentTemplate>
            </asp:TabPanel>
            <asp:TabPanel ID="TabPanel4" runat="server" HeaderText="TabPanel4">
                <ContentTemplate>
                    Lunaaaaa, no me abandones mas
                </ContentTemplate>
            </asp:TabPanel>
            <asp:TabPanel ID="TabPanel5" runat="server" HeaderText="TabPanel5">
                <ContentTemplate>
                    Quisiera ser un microbito
                </ContentTemplate>
            </asp:TabPanel>
        </asp:TabContainer>
    
        <br />
    
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
