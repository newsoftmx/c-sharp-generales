Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Data
Imports System.Data.SqlClient

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class servicioVBSP
    Inherits System.Web.Services.WebService
    Dim Conexion As New SqlConnection("Data Source=vibecohack; Initial Catalog=programacionpw; User ID=sa; password=victornash1982;")

    <WebMethod()> _
    Public Function HelloWorld() As String
        Return "Hola a todos"
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
        insertar.Parameters.Add("@apePaterno", SqlDbType.NVarChar).Value = apePaterno
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
    <WebMethod> _
    Public Function deportistaBuscarTodosSP() As DataSet
        Dim buscar As New SqlCommand("deportistaBuscar", Conexion)
        buscar.CommandType = CommandType.StoredProcedure
        Dim datos As New SqlDataAdapter
        datos.SelectCommand = buscar
        Dim conjunto As New DataSet
        Try
            Conexion.Open()
            datos.Fill(conjunto, "DatosGenerales")
            Conexion.Close()
            Return conjunto
        Catch ex As Exception
            Conexion.Close()
            Return conjunto
        End Try
    End Function
    <WebMethod> _
    Public Function deportistaBuscarIDSP(ByVal id As Integer) As DataSet
        Dim buscarID As New SqlCommand("deportistaBuscarID", Conexion)
        buscarID.CommandType = CommandType.StoredProcedure
        Dim datos As New SqlDataAdapter()
        Dim conjunto As New DataSet
        Try
            buscarID.Parameters.Add("@id", SqlDbType.Int).Value = id
            Conexion.Open()
            datos.SelectCommand = buscarID
            datos.Fill(conjunto)
            Conexion.Close()
            Return conjunto
        Catch ex As Exception
            Conexion.Close()
            Return conjunto
        End Try
    End Function
    <WebMethod> _
    Public Function deportistaActualizarSP(ByVal id As Integer, _
                                         ByVal nombre As String, _
                                      ByVal apePaterno As String, _
                                      ByVal apeMaterno As String, _
                                      ByVal edad As Integer, _
                                      ByVal estatus As Boolean, _
                                      ByVal nivel As String
                                      ) As Boolean
        Dim insertar As New SqlCommand("deportistaActualizar", Conexion)
        insertar.CommandType = CommandType.StoredProcedure
        insertar.Parameters.Add("@id", SqlDbType.Int).Value = id
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

    <WebMethod> _
    Public Function deportistaEliminarSP(ByVal id As Integer) As Boolean
        Dim eliminar As New SqlCommand("deportistaEliminar", Conexion)
        eliminar.CommandType = CommandType.StoredProcedure

        Try
            eliminar.Parameters.Add("@id", SqlDbType.Int).Value = id
            Conexion.Open()
            eliminar.ExecuteNonQuery()
            Conexion.Close()
            Return True
        Catch ex As Exception
            Conexion.Close()
            Return False
        End Try
    End Function
End Class