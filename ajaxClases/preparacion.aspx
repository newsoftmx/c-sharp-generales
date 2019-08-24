<%@ Page Language="C#" AutoEventWireup="true" CodeFile="preparacion.aspx.cs" Inherits="preparacion" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %> 


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/estilo.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Colocar un scrip manager<br />
        <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </ajaxToolkit:ToolkitScriptManager>
        <br />
                Busqueda:
                <asp:TextBox ID="TextBox1" runat="server" Height="21px" Width="412px"></asp:TextBox>
                <ajaxToolkit:TextBoxWatermarkExtender ID="TextBox1_TextBoxWatermarkExtender" runat="server" Enabled="True" TargetControlID="TextBox1" WatermarkText="Por favor escriba el nombre a buscar">
        </ajaxToolkit:TextBoxWatermarkExtender>
                <ajaxToolkit:AutoCompleteExtender ID="txt_AutoCompleteExtender" runat="server" CompletionInterval="10" DelimiterCharacters="" Enabled="True" ServiceMethod="traerDatos" ServicePath="" TargetControlID="TextBox1" UseContextKey="True" CompletionListCssClass="CompletionList" CompletionListHighlightedItemCssClass="CompletionListHighlightedItem" CompletionListItemCssClass="CompletionItemListItem" MinimumPrefixLength="1">
                </ajaxToolkit:AutoCompleteExtender>
        <br />
        <br />
        Busqueda con SP: <asp:TextBox ID="txtBusquedaSP" runat="server" Height="16px" Width="365px" OnTextChanged="txtBusquedaSP_TextChanged"></asp:TextBox>
        <ajaxToolkit:AnimationExtender ID="txtBusquedaSP_AnimationExtender" runat="server" Enabled="True" TargetControlID="txtBusquedaSP">
        </ajaxToolkit:AnimationExtender>
        <ajaxToolkit:TextBoxWatermarkExtender ID="txtBusquedaSP_TextBoxWatermarkExtender" runat="server" Enabled="True" TargetControlID="txtBusquedaSP" WatermarkText="Por favor escriba el nombre a buscar">
        </ajaxToolkit:TextBoxWatermarkExtender>
        <ajaxToolkit:AutoCompleteExtender ID="txtBusquedaSP_AutoCompleteExtender" runat="server" CompletionInterval="10" DelimiterCharacters="" Enabled="True" MinimumPrefixLength="1" ServiceMethod="traerDatosSP" ServicePath="" TargetControlID="txtBusquedaSP">
        </ajaxToolkit:AutoCompleteExtender>
        <br />
        <br />
        Busqueda con WS:
        <asp:TextBox ID="txtBusquedaWS" runat="server" Height="23px" Width="355px" OnTextChanged="txtBusquedaWS_TextChanged"></asp:TextBox>
        <ajaxToolkit:AutoCompleteExtender ID="txtBusquedaWS_AutoCompleteExtender" runat="server" CompletionInterval="10" DelimiterCharacters="" Enabled="True" MinimumPrefixLength="1" ServiceMethod="traerDatosWS" ServicePath="" TargetControlID="txtBusquedaWS">
        </ajaxToolkit:AutoCompleteExtender>
        <br />
        <br />
        <br />
        Fecha: <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
        <ajaxToolkit:ColorPickerExtender ID="txtFecha_ColorPickerExtender" runat="server" Enabled="True" TargetControlID="txtFecha">
        </ajaxToolkit:ColorPickerExtender>
        <ajaxToolkit:CalendarExtender ID="txtFecha_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtFecha" TodaysDateFormat="DD,MMMM,YYYY">
        </ajaxToolkit:CalendarExtender>
        <br />
        <br />
        <ajaxToolkit:ComboBox ID="ComboBox1" runat="server" AutoCompleteMode="SuggestAppend">
            <asp:ListItem>Bajo</asp:ListItem>
            <asp:ListItem>Medio</asp:ListItem>
            <asp:ListItem>Alto</asp:ListItem>
        </ajaxToolkit:ComboBox>
        <br />
        <br />
        Escoje tu color favorito:
        <asp:TextBox ID="txtColorFavorito" runat="server"></asp:TextBox>
        <ajaxToolkit:ColorPickerExtender ID="txtColorFavorito_ColorPickerExtender" runat="server" Enabled="True" TargetControlID="txtColorFavorito">
        </ajaxToolkit:ColorPickerExtender>
        <br />
        <br />
        <ajaxToolkit:Accordion
    ID="MyAccordion"
    runat="Server"
    SelectedIndex="0"
    HeaderCssClass="accordionHeader"
    HeaderSelectedCssClass="accordionHeaderSelected"
    ContentCssClass="accordionContent"
    AutoSize="None"
    FadeTransitions="true"
    TransitionDuration="250"
    FramesPerSecond="40"
    RequireOpenedPane="false"
    SuppressHeaderPostbacks="true">
    <Panes>
        <ajaxToolkit:AccordionPane
            HeaderCssClass="accordionHeader"
            HeaderSelectedCssClass="accordionHeaderSelected"
            ContentCssClass="accordionContent">
            <Header> Uno </Header>
            <Content> Contenido de Uno,  </Content>
            
        </ajaxToolkit:AccordionPane>        
        <ajaxToolkit:AccordionPane
            HeaderCssClass="accordionHeader"
            HeaderSelectedCssClass="accordionHeaderSelected"
            ContentCssClass="accordionContent">
            <Header>Dos</Header>
            <Content>Estamos mostrando el contenido del panel 2, donde se pueden agregar varias cosas</Content>
         </ajaxToolkit:AccordionPane>        
    </Panes>            
    <HeaderTemplate>...</HeaderTemplate>
    <ContentTemplate>...</ContentTemplate>
</ajaxToolkit:Accordion>
        <br />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
