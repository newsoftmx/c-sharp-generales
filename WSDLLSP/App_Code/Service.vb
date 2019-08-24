Imports System.Web
Imports System.Web.Services
Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Services.Protocols

Public Class Service
    Inherits System.Web.Services.WebService
    Dim Guardado As New ClaseHGuardar   
    Dim Buscar As New ClaseHBuscar
    <WebMethod()> _
    Public Function Guardar(ByVal Nombre As String, _
                            ByVal Domicilio As String, _
                            ByVal Telefono As String, _
                            ByVal Edad As Integer, _
                            ByVal Saldo As Double) As Boolean
        If Guardado.Guardar(Nombre, Domicilio, Telefono, Edad, Saldo) Then
            Return True
        Else
            Return False
        End If
    End Function

    <WebMethod()> _
    Public Function BuscarRegistro(ByVal Id As Integer) As DataSet
        Dim Conjunto As New DataSet
        Conjunto = Buscar.BuscarRegistro(Id)
        Return Conjunto
    End Function

End Class
