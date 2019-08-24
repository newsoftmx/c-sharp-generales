<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Ejemplos básicos de Ajax Control Tool Kit<br />
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <br />
        <br />
        Password:
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <asp:PasswordStrength ID="txtPassword_PasswordStrength" runat="server" CalculationWeightings="50;15;15;20" Enabled="True" MinimumLowerCaseCharacters="1" MinimumNumericCharacters="1" MinimumSymbolCharacters="1" MinimumUpperCaseCharacters="1" PreferredPasswordLength="10" PrefixText="Su nivel de contraseña es " StrengthIndicatorType="BarIndicator" TargetControlID="txtPassword" TextStrengthDescriptions="Bajo;Medio;Alto;Muy Alto;Excelente">
        </asp:PasswordStrength>
        <br />
        <br />
        Fecha de Nacimiento: <asp:TextBox ID="txtFechaMask" runat="server"></asp:TextBox>
        <asp:MaskedEditExtender ID="txtFechaMask_MaskedEditExtender" runat="server" Century="2000" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" Mask="99/99/9999" TargetControlID="txtFechaMask">
        </asp:MaskedEditExtender>
        <br />
        <br />
        Fecha de inicio:
        <asp:TextBox ID="txtFechaCalendar" runat="server"></asp:TextBox>
        <asp:CalendarExtender ID="txtFechaCalendar_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtFechaCalendar">
        </asp:CalendarExtender>
        <br />
        <br />
        Telefono:
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        <asp:MaskedEditExtender ID="txtTelefono_MaskedEditExtender" runat="server" Century="2000" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" Mask="9999999999" TargetControlID="txtTelefono">
        </asp:MaskedEditExtender>
        <br />
        <br />
        Seleccione el color que mas le agrade:
        <asp:TextBox ID="txtColor" runat="server"></asp:TextBox>
        <asp:ColorPickerExtender ID="txtColor_ColorPickerExtender" runat="server" Enabled="True" TargetControlID="txtColor">
        </asp:ColorPickerExtender>
        <br />
        <br />
        Seleccione el nivel de ingles con el que cuenta:
        <asp:TextBox ID="txtNivelIngles" runat="server"></asp:TextBox>
        <asp:NumericUpDownExtender ID="txtNivelIngles_NumericUpDownExtender" runat="server" Enabled="True" Maximum="10" Minimum="0" RefValues="" ServiceDownMethod="" ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" TargetButtonUpID="" TargetControlID="txtNivelIngles" Width="50">
        </asp:NumericUpDownExtender>
        <br />
        <br />
        Indique el nivel de llenado:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:SliderExtender ID="TextBox1_SliderExtender" runat="server" BoundControlID="lblNivel" Enabled="True" Maximum="100" Minimum="0" TargetControlID="TextBox1" TooltipText="lblNivel">
        </asp:SliderExtender>
        <asp:Label ID="lblNivel" runat="server"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
