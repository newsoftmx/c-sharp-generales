Imports System.Web
Imports System.Web.Services
Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Services.Protocols


<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Service
     Inherits System.Web.Services.WebService
    Dim Conexion As New SqlConnection("Data Source=VICTOR1;Initial Catalog=Principal;User ID=sa; Password=victornash1982")

    <WebMethod()> _
        Public Function Guardar(ByVal Nombre As String, _
                                ByVal Domicilio As String, _
                                ByVal Telefono As String, _
                                ByVal Edad As Integer, _
                                ByVal Saldo As Double) As Boolean
        Dim Insertar As New SqlCommand("INSERT INTO DatosGenerales(Nombre, Domicilio, Telefono, Edad, Saldo) VALUES ('" & Nombre & "','" & Domicilio & "','" & Telefono & "','" & Edad & "','" & Saldo & "')", Conexion)
        Try
            Conexion.Open()
            Insertar.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
            Conexion.Close()

        End Try

    End Function
    <WebMethod()> _
    Public Function Eliminar(ByVal Id As Integer) As Boolean
        Dim Elimina As New SqlCommand("DELETE FROM DatosGenerales WHERE ID='" & Id & "'", Conexion)
        Try
            Conexion.Open()
            Elimina.ExecuteNonQuery()
            Conexion.Close()
            Return True

        Catch ex As Exception
            Conexion.Close()
            Return False

        End Try
    End Function
    <WebMethod()> _
        Public Function Actualizar(ByVal Id As Integer, ByVal Saldo As Double) As Boolean
        Dim Actualiza As New SqlCommand("UPDATE DatosGenerales SET Saldo ='" & Saldo & "' WHERE ID ='" & Id & "'", Conexion)
        Try
            Conexion.Open()
            Actualiza.ExecuteNonQuery()
            Conexion.Close()
            Return True

        Catch ex As Exception
            Conexion.Close()
            Return False

        End Try
    End Function
    <WebMethod()> _
        Public Function Verificar(ByVal Id As Integer) As Boolean
        Dim Verifica As New SqlCommand("SELECT COUNT(*) FROM DatosGenerales WHERE ID ='" & Id & "'", Conexion)
        Dim x As Integer = 0
        Try
            Conexion.Open()
            x = CInt(Verifica.ExecuteScalar)
            Conexion.Close()
            If x = 1 Then
                Return True
            Else
                Return False
            End If
            Return True
        Catch ex As Exception
            Conexion.Close()
            Return False

        End Try
    End Function
    <WebMethod()> _
    Public Function BuscarTodo() As DataSet
        Dim Buscar As New SqlDataAdapter("SELECT * FROM DatosGenerales", Conexion)
        Dim conjunto As New DataSet
        Try
            Conexion.Open()
            Buscar.Fill(conjunto, "DatosGenerales")
            Conexion.Close()
            Return conjunto
        Catch ex As Exception
            Conexion.Close()
            Return conjunto

        End Try
    End Function
    <WebMethod()> _
    Public Function BuscarRegistro(ByVal Id As Integer) As DataSet
        Dim Buscar As New SqlDataAdapter("SELECT * FROM DatosGenerales WHERE ID='" & Id & "'", Conexion)
        Dim conjunto As New DataSet
        Try
            Conexion.Open()
            Buscar.Fill(conjunto, "DatosGenerales")
            Conexion.Close()
            Return conjunto
        Catch ex As Exception
            Conexion.Close()
            Return conjunto

        End Try
    End Function
    <WebMethod()> _
    Public Function BuscarSaldo(ByVal Id As Integer) As Double
        Dim Buscar As New SqlDataAdapter("SELECT Saldo FROM DatosGenerales WHERE ID='" & Id & "'", Conexion)
        Dim conjunto As New DataSet
        Dim Saldo As Double = 0
        Dim Renglon As DataRow
        Try
            Conexion.Open()
            Buscar.Fill(conjunto, "DatosGenerales")
            Conexion.Close()
            Renglon = conjunto.Tables("DatosGenerales").Rows(0)
            Saldo = Renglon("Saldo")
            Return Saldo
        Catch ex As Exception
            Conexion.Close()
            Return Saldo

        End Try
    End Function
End Class
