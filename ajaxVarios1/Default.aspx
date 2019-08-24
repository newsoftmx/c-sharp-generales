<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/cssGen.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
    
        Ejemplo de Ajax<br />
        <br />
        <br />
        <br />
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <br />
        <br />
        Escriba su Nombre:
        <asp:TextBox ID="txtNombre1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnContratoPrivacidad" runat="server" Height="41px" Text="Contrato Privacidad" Width="218px" OnClick="btnContratoPrivacidad_Click" />
        <asp:ModalPopupExtender ID="btnContratoPrivacidad_ModalPopupExtender" runat="server" DynamicServicePath="" Enabled="True" TargetControlID="btnContratoPrivacidad" BackgroundCssClass="modalBackground" PopupControlID="UpdatePanel1">
        </asp:ModalPopupExtender>
        <br />
        <br />
        <br />
        Agregamos panel para colocar dentro de el el contenido que deseos se muestre<br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" style=" background:white;
width:60%; height:auto">
            

            <ContentTemplate>

                Todos los controles a mostrar van aquí adentro<br />
                <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                <h3>Modal header</h3>
              </div>
              <div class="modal-body">
                  <p>Aquí escribimos todo el contenido de mi body</p>
                  <p>Escribe tu nombre: <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                      <br />
                      Escribe tu contraseña: <input type="password" placeholder="Escribe la contraseña de tu correo" />
                  </p>
                <p>One fine body…</p>
              </div>
              <div class="modal-footer">
                <a href="" class="btn">Close</a>
                <a href="" class="btn btn-primary">Save changes</a>
              </div>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
    
    </div>
    </form>
</body>
</html>
