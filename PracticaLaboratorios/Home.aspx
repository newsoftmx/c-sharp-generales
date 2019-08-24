<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Laboratorios</title>
    <link href="Estilos.css" rel="stylesheet" />
    <link href="Css.css" rel="stylesheet" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script>
    <script>
        $(document).ready(function () {
            $('.menu ul ul').css({
                position: "absolute",
                display: "none"
            });

            $('.menu li').hover(function () {
                $(this).find('>ul').stop(true, true).slideDown('slow');
            }, function () {
                $(this).find('>ul').stop(true, true).slideUp('slow');
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div id="menu" class="menu">
                        <ul>
                            <li><a href="Default.aspx">INICIO</a></li>
                            <li><a>CLIENTES</a></li>
                            <li><a>INFORMACIÓN</a></li>
                            <li><a>LABORATORIO</a></li>
                            <li><a>MYDOM</a></li>
                        </ul>
                    </div>
    </div>

        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <br />
        <br />
        Nombre:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtNombre" runat="server" style="margin-left: 2px" CssClass="Css.css" OnTextChanged="txtNombre_TextChanged"></asp:TextBox>
        <asp:BalloonPopupExtender ID="txtNombre_BalloonPopupExtender" runat="server" BalloonPopupControlID="Panel1" BalloonStyle="Cloud" CustomCssUrl="" DynamicServicePath="" Enabled="True" ExtenderControlID="" TargetControlID="txtNombre">
        </asp:BalloonPopupExtender>
        <br />
        <asp:Panel ID="Panel1" runat="server">
            Escriba su nombre</asp:Panel>
        <br />
        Paterno:&nbsp;&nbsp; <asp:TextBox ID="txtPaterno" runat="server" CssClass="Css.css"></asp:TextBox>
        <asp:BalloonPopupExtender ID="txtPaterno_BalloonPopupExtender" runat="server" BalloonPopupControlID="Panel2" BalloonStyle="Cloud" CustomCssUrl="" DynamicServicePath="" Enabled="True" ExtenderControlID="" TargetControlID="txtPaterno">
        </asp:BalloonPopupExtender>
        <br />
        <asp:Panel ID="Panel2" runat="server">
            Escriba su apellido paterno</asp:Panel>
        <br />
        Materno:&nbsp; <asp:TextBox ID="txtMaterno" runat="server" CssClass="Css.css"></asp:TextBox>
        <asp:BalloonPopupExtender ID="txtMaterno_BalloonPopupExtender" runat="server" BalloonPopupControlID="Panel3" CustomCssUrl="" DynamicServicePath="" Enabled="True" ExtenderControlID="" TargetControlID="txtMaterno">
        </asp:BalloonPopupExtender>
        <br />
        <asp:Panel ID="Panel3" runat="server">
            Escriba su apellido materno</asp:Panel>
        <br />
        Username:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtUsername" runat="server" CssClass="Css.css"></asp:TextBox>
        <asp:BalloonPopupExtender ID="txtUsername_BalloonPopupExtender" runat="server" BalloonPopupControlID="Panel4" BalloonStyle="Custom" CustomCssUrl="Css.css" DynamicServicePath="" Enabled="True" ExtenderControlID="" TargetControlID="txtUsername" CustomClassName="oval">
        </asp:BalloonPopupExtender>
        <br />
        <asp:Panel ID="Panel4" runat="server">
            Escriba su username</asp:Panel>
        <br />
        Password: <asp:TextBox ID="txtPassword" runat="server" CssClass="Css.css"></asp:TextBox>
        <asp:BalloonPopupExtender ID="txtPassword_BalloonPopupExtender" runat="server" BalloonPopupControlID="Panel5" CustomCssUrl="" DynamicServicePath="" Enabled="True" ExtenderControlID="" TargetControlID="txtPassword">
        </asp:BalloonPopupExtender>
        <asp:PasswordStrength ID="txtPassword_PasswordStrength" runat="server" CalculationWeightings="50;15;15;20" Enabled="True" MinimumLowerCaseCharacters="1" MinimumNumericCharacters="1" MinimumSymbolCharacters="1" MinimumUpperCaseCharacters="1" PreferredPasswordLength="12" PrefixText="La seguridad de su password es:" TargetControlID="txtPassword">
        </asp:PasswordStrength>
        <br />
        <asp:Panel ID="Panel5" runat="server">
            Escriba su password</asp:Panel>
        <br />
        Repite password: <asp:TextBox ID="txtRepitePassword" runat="server" CssClass="Css.css"></asp:TextBox>
        <asp:BalloonPopupExtender ID="txtRepitePassword_BalloonPopupExtender" runat="server" BalloonPopupControlID="Panel6" CustomCssUrl="" DynamicServicePath="" Enabled="True" ExtenderControlID="" TargetControlID="txtRepitePassword">
        </asp:BalloonPopupExtender>
        <br />
        <asp:Panel ID="Panel6" runat="server">
            Repita su password</asp:Panel>
        <br />
        Calle :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtCalle" runat="server" style="margin-bottom: 0px" CssClass="Css.css"></asp:TextBox>
        <asp:BalloonPopupExtender ID="txtCalle_BalloonPopupExtender" runat="server" BalloonPopupControlID="Panel7" CustomCssUrl="" DynamicServicePath="" Enabled="True" ExtenderControlID="" TargetControlID="txtCalle">
        </asp:BalloonPopupExtender>
        <br />
        <asp:Panel ID="Panel7" runat="server">
            Escriba su calle</asp:Panel>
        <br />
        Número:&nbsp; <asp:TextBox ID="txtNumero" runat="server" Height="22px" CssClass="Css.css"></asp:TextBox>
        <asp:BalloonPopupExtender ID="txtNumero_BalloonPopupExtender" runat="server" BalloonPopupControlID="Panel8" CustomCssUrl="" DynamicServicePath="" Enabled="True" ExtenderControlID="" TargetControlID="txtNumero">
        </asp:BalloonPopupExtender>
        <br />
        <asp:Panel ID="Panel8" runat="server">
            Escriba su número</asp:Panel>
        <br />
        Colonia:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtColonia" runat="server" CssClass="Css.css"></asp:TextBox>
        <asp:BalloonPopupExtender ID="txtColonia_BalloonPopupExtender" runat="server" BalloonPopupControlID="Panel9" CustomCssUrl="" DynamicServicePath="" Enabled="True" ExtenderControlID="" TargetControlID="txtColonia">
        </asp:BalloonPopupExtender>
        <br />
        <asp:Panel ID="Panel9" runat="server">
            Escriba su colonia</asp:Panel>
        <br />
        Teléfono:&nbsp;&nbsp; <asp:TextBox ID="txtTelefono" runat="server" CssClass="Css.css"></asp:TextBox>
        <asp:BalloonPopupExtender ID="txtTelefono_BalloonPopupExtender" runat="server" BalloonPopupControlID="Panel10" CustomCssUrl="" DynamicServicePath="" Enabled="True" ExtenderControlID="" TargetControlID="txtTelefono">
        </asp:BalloonPopupExtender>
        <asp:MaskedEditExtender ID="txtTelefono_MaskedEditExtender" runat="server" Century="2000" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" Mask="9999999999" TargetControlID="txtTelefono">
        </asp:MaskedEditExtender>
        <br />
        <br />
        <asp:Panel ID="Panel10" runat="server">
            Escriba su teléfono</asp:Panel>
        <br />
        Código Postal:&nbsp; <asp:TextBox ID="txtCP" runat="server" CssClass="Css.css"></asp:TextBox>
        <asp:BalloonPopupExtender ID="txtCP_BalloonPopupExtender" runat="server" BalloonPopupControlID="Panel11" CustomCssUrl="" DynamicServicePath="" Enabled="True" ExtenderControlID="" TargetControlID="txtCP">
        </asp:BalloonPopupExtender>
        <asp:MaskedEditExtender ID="txtCP_MaskedEditExtender" runat="server" Century="2000" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" Mask="99999" TargetControlID="txtCP">
        </asp:MaskedEditExtender>
        <br />
        <asp:Panel ID="Panel11" runat="server">
            Escriba su código postal</asp:Panel>
        <br />
        Exámenes:&nbsp;&nbsp; <asp:TextBox ID="txtCantidad" runat="server" CssClass="Css.css"></asp:TextBox>
        <asp:NumericUpDownExtender ID="txtCantidad_NumericUpDownExtender" runat="server" Enabled="True" Maximum="5" Minimum="1" RefValues="" ServiceDownMethod="" ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" TargetButtonUpID="" TargetControlID="txtCantidad" Width="0">
        </asp:NumericUpDownExtender>
        <br />
        <asp:Panel ID="Panel12" runat="server">
        </asp:Panel>
        <br />
        <br />
        <br />
        Intensidad de exámenes;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtIntensidad" runat="server"></asp:TextBox>
        <asp:SliderExtender ID="txtIntensidad_SliderExtender" runat="server" Enabled="True" Length="100" Maximum="100" Minimum="0" TargetControlID="txtIntensidad">
        </asp:SliderExtender>
        <br />
        <br />
        <br />
        Color: <asp:TextBox ID="txtColor" runat="server"></asp:TextBox>
        <asp:ColorPickerExtender ID="txtColor_ColorPickerExtender" runat="server" Enabled="True" TargetControlID="txtColor">
        </asp:ColorPickerExtender>
        <br />
        <br />
        <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar Campos" OnClick="btnLimpiar_Click" />
        <br />
        <br />
        <asp:Button ID="btnEnviar" runat="server" Text="Enviar Datos" OnClick="btnEnviar_Click" />
        <br />
        <br />
    </form>
</body>
</html>