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
    
        Ejemplos básicos de Ajax Control Tool Kit, preparación de clase<br />
        <br />
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <br />
        Contraseña:
        <asp:TextBox ID="txtContrasena" runat="server"></asp:TextBox>
        <asp:PasswordStrength ID="txtContrasena_PasswordStrength" runat="server" CalculationWeightings="50;15;15;20" Enabled="True" MinimumLowerCaseCharacters="1" MinimumNumericCharacters="1" MinimumSymbolCharacters="1" MinimumUpperCaseCharacters="1" PreferredPasswordLength="10" PrefixText="Su nivel de password es" TargetControlID="txtContrasena" TextStrengthDescriptions="Bajo;Medio;Alto;Muy Alto; Excelente">
        </asp:PasswordStrength>
        <br />
        <br />
        Fecha Naciemiento:
        <asp:TextBox ID="txtFechaNacimiento" runat="server"></asp:TextBox>
        <asp:MaskedEditExtender ID="txtFechaNacimiento_MaskedEditExtender" runat="server" Century="2000" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" Mask="99/99/9999" TargetControlID="txtFechaNacimiento">
        </asp:MaskedEditExtender>
        <br />
        <br />
        Fecha de Inicio:
        <asp:TextBox ID="txtFechaInicio" runat="server"></asp:TextBox>
        <asp:CalendarExtender ID="txtFechaInicio_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtFechaInicio">
        </asp:CalendarExtender>
        <br />
        <br />
        Telefono:
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        <asp:MaskedEditExtender ID="txtTelefono_MaskedEditExtender" runat="server" Century="2000" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" Mask="9999999999" TargetControlID="txtTelefono">
        </asp:MaskedEditExtender>
        <br />
        <br />
        Seleccione su nivel de Inglés (1 a 10)
        <asp:TextBox ID="txtNivelIngles" runat="server"></asp:TextBox>
        <asp:NumericUpDownExtender ID="txtNivelIngles_NumericUpDownExtender" runat="server" Enabled="True" Maximum="10" Minimum="1" RefValues="" ServiceDownMethod="" ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" TargetButtonUpID="" TargetControlID="txtNivelIngles" Width="50">
        </asp:NumericUpDownExtender>
        <br />
        <br />
        Incremente/Decremente el numero de revoluciones <asp:TextBox ID="txtNivel" runat="server"></asp:TextBox>
        <asp:SliderExtender ID="txtNivel_SliderExtender" runat="server" BoundControlID="lblNivel" Enabled="True" Maximum="100" Minimum="0" TargetControlID="txtNivel" TooltipText="lblNivel">
        </asp:SliderExtender>
        <asp:Label ID="lblNivel" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        Globos de ayuda<br />
        Nombre:
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <asp:BalloonPopupExtender ID="txtNombre_BalloonPopupExtender" runat="server" CustomCssUrl="" DynamicServicePath="" Enabled="True" ExtenderControlID="" Position="TopRight" TargetControlID="txtNombre">
        </asp:BalloonPopupExtender>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        Escriba un valor a buscar:<asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBuscar" runat="server" Height="22px" Text="Buscar" Width="119px" />
&nbsp;<asp:Panel ID="Panel2" runat="server" BackColor="#9DE2FD" Font-Bold="True" Height="21px" Width="338px">
            Recuerde que debe escribir un valor a buscar</asp:Panel>
        <asp:CollapsiblePanelExtender ID="Panel2_CollapsiblePanelExtender" runat="server" ExpandControlID="btnBuscar" CollapseControlID="btnBuscar" Collapsed="True" Enabled="True" TargetControlID="Panel2">
        </asp:CollapsiblePanelExtender>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
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
