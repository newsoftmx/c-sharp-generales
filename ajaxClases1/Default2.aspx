<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
    <link href="css/cssGeneral.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Hola a todos<br />
        <asp:Button ID="btnSinAjax" runat="server" Height="25px" Text="Sin Ajax" Width="191px" />
        <br />
        <br />
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                Escribe tu nombre:
                <asp:TextBox ID="txtNombre" runat="server" Height="35px" Width="162px"></asp:TextBox>
                <br />

                <br />
                <asp:Button ID="btnContratoPrivacidad" runat="server" 
                    Height="50px" Text="Contrato de Privacidad" 
                    Width="261px" OnClick="btnContratoPrivacidad_Click" />
                <asp:ModalPopupExtender 
                    ID="btnContratoPrivacidad_ModalPopupExtender" 
                    runat="server" DynamicServicePath="" 
                    Enabled="True" BackgroundCssClass="modalBackground"
                    TargetControlID="btnInicializador" 
                    PopupControlID="UpdatePanel2">
                </asp:ModalPopupExtender>
                <br />
                <asp:Button ID="btnInicializador" CssClass="ocultar"
                     runat="server" Text="Inicializa el popup y pasa los valores" />
                <br />
                <asp:UpdatePanel ID="UpdatePanel2" 
                    class="ocultarPanel" 
                    runat="server">
                    <ContentTemplate>
                        Hola A Todos<br />
                        <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                        <h3>Modal header</h3>
                      </div>
                      <div class="modal-body">
                        <p>One fine body…</p>
                          Escribe tu Nombre: 
                          <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                          <br />
                          Escribe tu password:
                          <input type="password" placeholder="Escribe tu contraseña" />
                      </div>
                      <div class="modal-footer">
                        <a href="" class="btn">Cerrar</a>
                          <asp:Button CssClass="btn" 
                              ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                        <a href="" class="btn btn-primary">Guardar Cambios</a>
                      </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <br />
                <br />
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
