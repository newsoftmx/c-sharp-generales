Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
'agregar
Imports System.Data
Imports System.Data.SqlClient

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class servicioVB
    Inherits System.Web.Services.WebService

    Dim Conexion As New SqlConnection _
("Data Source=vibecohack; Initial Catalog=programacionpw;  User ID=sa; Password=victornash1982;")
    <WebMethod()> _
    Public Function HelloWorld() As String
        Return "Hola grandes hacks"
    End Function

    <WebMethod()> _
    Public Function saludo() As String
        Return "Guardado"
    End Function






    <WebMethod()> _
    Public Function deportistaGuardar(ByVal nombre As String, _
                                      ByVal apePaterno As String, _
                                      ByVal apeMaterno As String, _
                                      ByVal edad As Integer, _
                                      ByVal estatus As Boolean, _
                                      ByVal nivel As String
                                      ) As Boolean
        Dim insertar As New SqlCommand("INSERT INTO deportista(nombre, apePaterno, apeMaterno, edad,  estatus, nivel) VALUES ('" & nombre & "', '" & apePaterno & "', '" & apeMaterno & "', '" & edad & "', '" & estatus & "','" & nivel & "')", Conexion)
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
        Dim eliminar As New SqlCommand _
            ("DELETE from deportista WHERE cveDeportista='" & id & "'", Conexion)
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
        Dim deportistaVerificado As New SqlCommand _
            ("SELECT COUNT(*) FROM deportista WHERE cveDeportista='" & id & "'", Conexion)
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
    Public Function deportistaActualizar(ByVal id As Integer, _
                                         ByVal nombre As String, _
                                      ByVal apePaterno As String, _
                                      ByVal apeMaterno As String, _
                                      ByVal edad As Integer, _
                                      ByVal estatus As Boolean, _
                                      ByVal nivel As String
                                      ) As Boolean
        Dim deportistaActualiza As New SqlCommand("UPDATE deportista SET nombre='" & nombre & "', apePaterno='" & apePaterno & "', apeMaterno='" & apeMaterno & "', edad='" & edad & "', estatus='" & estatus & "', nivel ='" & nivel & "' WHERE cveDeportista ='" & id & "'", Conexion)
        Try
            Conexion.Open()
            deportistaActualiza.ExecuteNonQuery()
            Conexion.Close()
            Return True

        Catch ex As Exception
            Conexion.Close()
            Return False

        End Try
    End Function
End Class
