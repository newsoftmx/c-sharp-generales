<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Desplegando un mensaje de confirmación<br />
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <br />
        <br />
        <asp:Button ID="btnContinuar" runat="server" Height="35px" 
            OnClick="btnContinuar_Click" Text="Continuar" Width="174px" />
        <asp:ConfirmButtonExtender ID="confirmacion" runat="server" 
            ConfirmText="Esta seguro que desea continuar" Enabled="True" TargetControlID="btnContinuar">
        </asp:ConfirmButtonExtender>
        <br />
        <br />
        <asp:Button ID="btnConfirmar2" runat="server" Height="34px" Text="Hola" Width="216px" OnClick="btnConfirmar2_Click" />
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <br />
                <br />
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <br />
        Escriba su contraseña :&nbsp;
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <asp:PasswordStrength ID="txtPassword_PasswordStrength" runat="server" DisplayPosition="BelowRight" Enabled="True" MinimumLowerCaseCharacters="2" MinimumNumericCharacters="3" MinimumSymbolCharacters="1" MinimumUpperCaseCharacters="2" PreferredPasswordLength="8" PrefixText="Grado de Dificultad" RequiresUpperAndLowerCaseCharacters="True" TargetControlID="txtPassword">
        </asp:PasswordStrength>
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <asp:Accordion ID="Accordion1" runat="server"
                     AutoSize="None" FadeTransitions="true" FramesPerSecond="30" SelectedIndex="1" TransitionDuration="350">
                    <Panes>
                        <asp:AccordionPane ID="AccordionPane1" runat="server">
                            <Header>
                                Info1
                            </Header>
                            <Content>
                                Bienvenidos a info1<br />
                                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                                <asp:Button ID="btnConexion" runat="server" Text="Probar Conexion" />
                            </Content>
                        </asp:AccordionPane>
                        <asp:AccordionPane ID="AccordionPane2" runat="server">
                            <Header>
                                Info2
                            </Header>
                            <Content>
                                Gracias por ver la info 2
                            </Content>
                        </asp:AccordionPane>
                    </Panes>
                </asp:Accordion>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        Fecha de nacimiento:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" Enabled="True" TargetControlID="TextBox1">
        </asp:CalendarExtender>
        <asp:MaskedEditExtender ID="TextBox1_MaskedEditExtender" runat="server" Century="2000" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" Mask="99/99/9999" TargetControlID="TextBox1">
        </asp:MaskedEditExtender>
        <br />
        <br />
        Edad:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:NumericUpDownExtender ID="TextBox2_NumericUpDownExtender" runat="server" Enabled="True" Maximum="80" Minimum="18" RefValues="" ServiceDownMethod="" ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" TargetButtonUpID="" TargetControlID="TextBox2" Width="150">
        </asp:NumericUpDownExtender>
        <br />
        <br />
        <br />
        
        <br />
        <br />
        <br />
        <asp:ConfirmButtonExtender ID="ConfirmButtonExtender1" 
            runat="server" ConfirmText="Desea continuar" TargetControlID="btnConfirmar2"></asp:ConfirmButtonExtender>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
