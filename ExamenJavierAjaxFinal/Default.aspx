<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        &nbsp;
    </p>
    <form id="form1" runat="server">
        <p>
            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
            </asp:ToolkitScriptManager>
        </p>

        <div>


            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <br />
                    Password con ajax<br />
                    <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="262px"></asp:TextBox>
                    <asp:PasswordStrength ID="TextBox1_PasswordStrength" runat="server" Enabled="True" MinimumLowerCaseCharacters="10" MinimumNumericCharacters="2" MinimumUpperCaseCharacters="1" PreferredPasswordLength="12" TargetControlID="TextBox1">
                    </asp:PasswordStrength>
                    <br />
                    <br />
                    Tab container<br />
                    <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0">
                        <asp:TabPanel ID="TabPanel1" runat="server" HeaderText="TabPanel1">
                            <ContentTemplate>
                                Hola este es el tab1
                                <br />

                                Informacion sobre el producto
                                <asp:Button ID="Button1" runat="server" Text="More Info" />
                            </ContentTemplate>
                        </asp:TabPanel>

                        <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="TabPanel1">
                            <ContentTemplate>
                                Hola estes es el 
                                <br />

                                Comprar el producto
                                
                                 <asp:Button ID="Button2" runat="server" Text="Comprar" />
                            </ContentTemplate>
                        </asp:TabPanel>

                        <asp:TabPanel ID="TabPanel3" runat="server" HeaderText="TabPanel1">
                            <ContentTemplate>
                                Hola este es el tab3
                                <br />
                                Ver aviso de privacidad
                                
                                 <asp:Button ID="Button3" runat="server" Text="Aviso de privacidad" />
                            </ContentTemplate>
                        </asp:TabPanel>

                    </asp:TabContainer>
                    <br />
                    <br />
                    Control1<br />
                    <asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="298px"></asp:TextBox>
                    <asp:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" DaysModeTitleFormat="dd,MMMM, yyyy" Enabled="True" TargetControlID="TextBox2">
                    </asp:CalendarExtender>
                    <br />
                    <br />
                    <br />
                    Control2<br />
                    <asp:TextBox ID="TextBox3" runat="server" Height="16px" Width="287px"></asp:TextBox>
                    <asp:TextBoxWatermarkExtender ID="TextBox3_TextBoxWatermarkExtender" runat="server" Enabled="True" TargetControlID="TextBox3" WatermarkText="Marca de agua :)">
                    </asp:TextBoxWatermarkExtender>
                    <br />
                    <br />
                    <br />
                    Control3<br />
                    <asp:TextBox ID="TextBox4" runat="server" Height="21px" Width="233px"></asp:TextBox>
                    <asp:MaskedEditExtender ID="TextBox4_MaskedEditExtender" runat="server" Century="2000" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" Mask="Hola" TargetControlID="TextBox4">
                    </asp:MaskedEditExtender>
                    <br />
                    <br />
                    <br />
                    <br />
                    Control4<br />
                    <asp:TextBox ID="TextBox5" runat="server" Height="16px" Width="283px"></asp:TextBox>
                    <asp:FilteredTextBoxExtender ID="TextBox5_FilteredTextBoxExtender" runat="server" Enabled="True" FilterType="Numbers" InvalidChars="%" TargetControlID="TextBox5">
                    </asp:FilteredTextBoxExtender>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </ContentTemplate>
            </asp:UpdatePanel>


        </div>
    </form>
</body>
</html>
