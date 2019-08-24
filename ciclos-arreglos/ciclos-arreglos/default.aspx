<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ciclos_arreglos._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
<br />
                    Ciclo for<br />
                    <br />
                    <asp:TextBox ID="txtCicloFor" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblCicloFor" runat="server" Text="valor ciclo"></asp:Label>
                    <br />
                    <asp:Button ID="btnCicloFor" runat="server" OnClick="btnCicloFor_Click" Text="Ciclo For" />
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    <br />
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
            <br />
            Ciclo while<br />
            ¿Cuantas veces deseas repetir el cálculo?<br />
            <br />
            <asp:TextBox ID="txtWhile" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblWhile" runat="server" Text="valor while"></asp:Label>
            <br />
            <asp:Button ID="btnWhile" runat="server" OnClick="btnWhile_Click" Text="While" />
            <br />
            <br />
            <br />
            Switch<br />
            <asp:TextBox ID="txtSwitch" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblSwitch" runat="server" Text="Valor Switch"></asp:Label>
            <br />
            <asp:Button ID="btnSwitch" runat="server" OnClick="btnSwitch_Click" Text="Switch" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
