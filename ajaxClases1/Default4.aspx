<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/cssGeneral.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <br />
        <br />
        <asp:Button ID="btnConfirmacion" runat="server" Height="32px" Text="Confirmar Pago" Width="142px" OnClick="btnConfirmacion_Click" />
        <asp:ConfirmButtonExtender ID="btnConfirmacion_ConfirmButtonExtender" 
            runat="server" 
            ConfirmText="Estas seguro de aceptar el proceso" 
            Enabled="True" 
            TargetControlID="btnConfirmacion">
        </asp:ConfirmButtonExtender>
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <br />
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        <br />
<br />
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <br />
        <asp:Accordion ID="Accordion1" AutoSize="None" 
            FramesPerSecond="30" SelectedIndex="0" 
            TransitionDuration="350"
             runat="server" Height="177px" Width="844px" HeaderCssClass="encabezado">
            <Panes>
            <asp:AccordionPane runat="server" ID="info1">
                <Header >
                        Información 1
                </Header>
                <Content>
                    Contenido de la información 1
                </Content>
            </asp:AccordionPane>
                <asp:AccordionPane runat="server" ID="info2">
                <Header>
                        Información 2
                </Header>
                <Content>
                    Contenido de la información 2
                </Content>
            </asp:AccordionPane>
                <asp:AccordionPane runat="server" ID="info3">
                <Header>
                        Información 3
                </Header>
                <Content>
                    Contenido de la información 3
                </Content>
            </asp:AccordionPane>
            </Panes>
        </asp:Accordion>
        

        <br />
        <br />
        <asp:TextBox ID="txtFechaNacimiento" runat="server" Height="41px" Width="205px"></asp:TextBox>
        <asp:MaskedEditExtender ID="txtFechaNacimiento_MaskedEditExtender" runat="server" Century="2000" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" Mask="99/99/9999" TargetControlID="txtFechaNacimiento">
        </asp:MaskedEditExtender>
        <asp:CalendarExtender ID="txtFechaNacimiento_CalendarExtender" runat="server" DaysModeTitleFormat="DD,MM,YYYY" Enabled="True" TargetControlID="txtFechaNacimiento">
        </asp:CalendarExtender>
        <br />
        <br />
        Escribe tu contraseña:&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" AutoCompleteType="Disabled" Height="31px" Width="226px"></asp:TextBox>
        <asp:PasswordStrength ID="TextBox1_PasswordStrength" runat="server" Enabled="True" MinimumLowerCaseCharacters="2" MinimumNumericCharacters="2" MinimumSymbolCharacters="2" MinimumUpperCaseCharacters="2" PreferredPasswordLength="8" PrefixText="Su contraseña es " TargetControlID="TextBox1">
        </asp:PasswordStrength>
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:MaskedEditExtender ID="TextBox2_MaskedEditExtender" runat="server" Century="2000" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" Mask="99" MaskType="Number" TargetControlID="TextBox2">
        </asp:MaskedEditExtender>
        <asp:NumericUpDownExtender ID="TextBox2_NumericUpDownExtender" runat="server" Enabled="True" Maximum="35" Minimum="18" RefValues="" ServiceDownMethod="" ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" TargetButtonUpID="" TargetControlID="TextBox2" Width="100">
        </asp:NumericUpDownExtender>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
