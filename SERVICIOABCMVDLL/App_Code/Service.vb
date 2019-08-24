Imports System.Web
Imports System.Web.Services
Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Services.Protocols

Public Class Service
    Inherits System.Web.Services.WebService
    Dim Guardado As New ClaseHGuardar
    Dim Actualizado As New ClaseHActualizar
    Dim Eliminado As New ClaseHEliminar
    Dim Verificado As New ClaseHVerificar
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
    Public Function Eliminar(ByVal Id As Integer) As Boolean
        If Eliminado.Eliminar(Id) Then
            Return True
        Else
            Return False
        End If
    End Function
    <WebMethod()> _
        Public Function Actualizar(ByVal Id As Integer, ByVal Saldo As Double) As Boolean
        If Actualizado.Actualizar(Id, Saldo) Then
            Return True
        Else
            Return False
        End If
    End Function
    <WebMethod()> _
        Public Function Verificar(ByVal Id As Integer) As Boolean
        If Verificado.Verificar(Id) Then
            Return True
        Else
            Return False
        End If
    End Function
    <WebMethod()> _
    Public Function BuscarTodo() As DataSet
        Dim Conjunto As New DataSet
        Conjunto = Buscar.BuscarTodo
        Return Conjunto
    End Function
    <WebMethod()> _
    Public Function BuscarRegistro(ByVal Id As Integer) As DataSet
        Dim Conjunto As New DataSet
        Conjunto = Buscar.BuscarRegistro(Id)
        Return Conjunto
    End Function
    <WebMethod()> _
    Public Function BuscarSaldo(ByVal Id As Integer) As Double
        Dim Saldo As Double
        Saldo = Buscar.BuscarSaldo(Id)
        Return Saldo
    End Function


End Class
