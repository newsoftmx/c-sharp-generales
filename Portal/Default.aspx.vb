Imports System.Security.Cryptography.X509Certificates
Imports System.Net
Imports System.Net.Security
Imports System.Data
Imports System.Data.SqlClient
Partial Class _Default
    Inherits System.Web.UI.Page
    Dim WSlogeo As New WSLogo.Service
    Dim WSVibe As New WSVibebanco.Service
    Dim Conjunto As New DataSet
    Public Function ValidateCertificate(ByVal sender As Object, ByVal certificate As X509Certificate, ByVal chain As X509Chain, ByVal sslPolicyErrors As SslPolicyErrors) As Boolean
        Return True
    End Function

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim idcli As Integer
        Dim Usuario, Password As String
        Usuario = txtUsuario.Text
        Password = txtPassword.Text
        ServicePointManager.ServerCertificateValidationCallback = _
           New System.Net.Security.RemoteCertificateValidationCallback _
          (AddressOf ValidateCertificate)


        Conjunto = WSlogeo.LogueoVB(Usuario, Password)
        If Not Conjunto Is Nothing Then
            If Conjunto.Tables(0).Rows.Count = 1 Then
                RE1.Visible = True
                idcli = Conjunto.Tables(0).Rows(0)("idcliente")
                txtusu.Text = Conjunto.Tables(0).Rows(0)("usuario")
                txtpas.Text = Conjunto.Tables(0).Rows(0)("password")
                If txtusu.Text = txtUsuario.Text Then
                    If txtpas.Text = txtpas.Text Then
                        Session.Add("idcliente", idcli)
                        Response.Redirect("Clientes.aspx")

                    Else
                        'Response.Redirect("Default.aspx")
                        RE2.Visible = True
                    End If
                Else
                    'Response.Redirect("Default.aspx")
                    RE1.Visible = True
                End If
            End If
        Else

        End If


        'If Usuario==usu then


    End Sub
End Class
