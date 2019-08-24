<%@ WebService Language="VB" Class="servicioVB2" %>

Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
'agregar
Imports System.Data
Imports System.Data.SqlClient

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace := "http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _  
Public Class servicioVB2
    Inherits System.Web.Services.WebService
    Dim Conexion As New SqlConnection("Data Source=vibecohack; Initial Catalog=programacionpw; User ID=sa; Password=victornash1982;")
    
	<WebMethod()> _
	Public Function HelloWorld() As String
		Return "Hello World"
    End Function
    <WebMethod()> _
    Public Function deportistaGuardar(ByVal nombre As String, _
                                      ByVal apePaterno As String, _
                                      ByVal apeMaterno As String, _
                                      ByVal edad As Integer, _
                                      ByVal estatus As Boolean, _
                                      ByVal nivel As String
                                      ) As Boolean
        Dim insertar As New SqlCommand("INSERT INTO deportista(nombre, apePaterno, apeMaterno, edad, estatus, nivel) VALUES ('" & nombre & "', '" & apePaterno & "', '" & apeMaterno & "', '" & edad & "', '" & estatus & "', '" & nivel & "')", Conexion)
        Try
            Conexion.Open()
            insertar.ExecuteNonQuery()
            Conexion.Close()
            Return True
        Catch ex As Exception
            Conexion.Close()
            Return False
        End Try
    End Function
    <WebMethod> _
    Public Function deportistaEliminar(ByVal id As Integer) As Boolean
        Dim eliminar As New SqlCommand("DELETE from deportista WHERE cveDeportista='" & id & "'", Conexion)
        Try
            Conexion.Open()
            eliminar.ExecuteNonQuery()
            Conexion.Close()
            Return True
        Catch ex As Exception
            Conexion.Close()
            Return False
        End Try
    End Function
    <WebMethod> _
    Public Function deportistaBuscarID(ByVal id As Integer) As DataSet
        Dim buscarID As New SqlDataAdapter("SELECT * FROM deportista WHERE cveDeportista='" & id & "'", Conexion)
        Dim conjunto As New DataSet
        Try
            Conexion.Open()
            buscarID.Fill(conjunto, "DatosGenerales")
            Conexion.Close()
            Return conjunto
        Catch ex As Exception
            Conexion.Close()
            Return conjunto
        End Try
    End Function
    <WebMethod> _
    Public Function deportistaBuscarTodos() As DataSet
        Dim buscarTodos As New SqlDataAdapter("SELECT * FROM deportista", Conexion)
        Dim conjunto As New DataSet
        Try
            Conexion.Open()
            buscarTodos.Fill(conjunto, "DatosGenerales")
            Conexion.Close()
            Return conjunto
        Catch ex As Exception
            Conexion.Close()
            Return conjunto
        End Try
    End Function
    <WebMethod> _
    Public Function deportistaVerificar(ByVal id As Integer) As Boolean
        Dim deportistaVerificado As New SqlCommand("SELECT COUNT(*) FROM deportista WHERE cveDeportista='" & id & "'", Conexion)
        Dim x As Integer
        Try
            Conexion.Open()
            x = CInt(deportistaVerificado.ExecuteScalar) 'devuelve el primer registro
            Conexion.Close()
            If x = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Conexion.Close()
            Return False
        End Try
    End Function
    <WebMethod> _
    Public Function deportistaGuardarSP(ByVal nombre As String, _
                                      ByVal apePaterno As String, _
                                      ByVal apeMaterno As String, _
                                      ByVal edad As Integer, _
                                      ByVal estatus As Boolean, _
                                      ByVal nivel As String
                                      ) As Boolean
        Dim insertar As New SqlCommand("deportistaGuardar", Conexion)
        insertar.CommandType = CommandType.StoredProcedure
        insertar.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre
        insertar.Parameters.Add("@apePaterno", SqlDbType.NVarChar).Value = apeMaterno
        insertar.Parameters.Add("@apeMaterno", SqlDbType.NVarChar).Value = apeMaterno
        insertar.Parameters.Add("@edad", SqlDbType.Int).Value = edad
        insertar.Parameters.Add("@estatus", SqlDbType.Bit).Value = estatus
        insertar.Parameters.Add("@nivel", SqlDbType.NVarChar).Value = nivel
        Try
            Conexion.Open()
            insertar.ExecuteNonQuery()
            Conexion.Close()
            Return True
        Catch ex As Exception
            Conexion.Close()
            Return False
        End Try
    End Function

End Class
