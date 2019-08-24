Imports System.Web
Imports System.Web.Services
Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Services.Protocols


Public Class Service
    Inherits System.Web.Services.WebService
    Dim GuCliVB As New ClaseHGuCliVB
    Dim GuSerReg As New ClaseHGuSerR
    Dim GuMov As New ClaseHGuMov
    Dim GuConMov As New ClaseHGuConMov
    Dim GuMovCred As New ClaseHGuMovCred
    Dim BuClientes As New ClaseHBuClientes
    Dim BuClientesAll As New ClaseHBuClientesALL
    Dim BuConMovCred As New ClaseHConMovCred
    Dim BuMovCred As New ClaseHBuMovCredVB
    Dim BuMovimientos As New ClaseHBuscarMovimiento
    Dim BuCoMoId As New ClaseHBuCoMoId
    Dim BuMovCredID As New ClaseHMovCredID
    Dim BuMovIDVB As New ClaseBuMovIDVB
    Dim ActCliVB As New ClaseHActCliVB
    Dim ACTVISI As New ClaseHActVisita
    Dim BuscarIdtsRef As New ClaseHBuIdtsRe
    Dim buscarflex As New ClaseHFlex
    Dim Conexion As New ClaseHCadVB
    <WebMethod()> _
    Public Function ActualizarClientes(ByVal ID As Integer, ByVal Usuario As String, _
                            ByVal Password As String, _
                            ByVal Nombre As String, _
                            ByVal Paterno As String, _
                            ByVal Materno As String, _
                            ByVal idcuenta As Integer, _
                            ByVal Cantcredito As Double, _
                            ByVal Creditodisponible As Double, _
                            ByVal Visita As Integer, _
                            ByVal Idautorizacion As Integer, _
                            ByVal Domicilio As String, _
                            ByVal Ciudad As String, _
                            ByVal Estado As String, _
                            ByVal Correo As String, _
                            ByVal Codpos As Integer, _
                            ByVal Numife As String, _
                            ByVal Saldo As Double) As Boolean
        If ActCliVB.Guardar(ID, Usuario, Password, Nombre, Paterno, Materno, idcuenta, Cantcredito, Creditodisponible, Visita, Idautorizacion, Domicilio, Ciudad, Estado, Correo, Codpos, Numife, Saldo) Then
            Return True
        Else
            Return False
        End If

    End Function

    <WebMethod()> _
    Public Function GuardarClientes(ByVal Usuario As String, _
                            ByVal Password As String, _
                            ByVal Nombre As String, _
                            ByVal Paterno As String, _
                            ByVal Materno As String, _
                            ByVal idcuenta As Integer, _
                            ByVal Cantcredito As Double, _
                            ByVal Creditodisponible As Double, _
                            ByVal Visita As Integer, _
                            ByVal Idautorizacion As Integer, _
                            ByVal Domicilio As String, _
                            ByVal Ciudad As String, _
                            ByVal Estado As String, _
                            ByVal Correo As String, _
                            ByVal Codpos As Integer, _
                            ByVal Numife As String, _
                            ByVal Saldo As Double) As Boolean
        If GuCliVB.Guardar(Usuario, Password, Nombre, Paterno, Materno, idcuenta, Cantcredito, Creditodisponible, Visita, Idautorizacion, Domicilio, Ciudad, Estado, Correo, Codpos, Numife, Saldo) Then
            Return True
        Else
            Return False
        End If

    End Function
    <WebMethod()> _
    Public Function Conectividad() As Boolean
        Dim testconectividad As New SqlConnection(Conexion.Cadena)
        Try
            'inicia la verificacion de la conectividad
            testconectividad.Open()
            testconectividad.Close()

            'GuCliVB.Open()
            'conexion.Cadena
            'Conexion.Close()
            Return True


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function 

    <WebMethod()> _
        Public Function GuardarServiciosReg(ByVal Idts As Integer, _
                            ByVal Referencia As String, _
                            ByVal Cantidad As Double, _
                            ByVal Fechavencimiento As String) As Boolean

        If GuSerReg.GuardarServiciosReg(Idts, Referencia, Cantidad, Fechavencimiento) Then
            Return True
        Else
            Return False
        End If      
    End Function
    <WebMethod()> _
        Public Function GuardarMovimientos(ByVal Fecha As String, _
                                       ByVal Idcliente As Integer, _
                                       ByVal Idsr As Integer, _
                                       ByVal Condiciones As String, _
                                        ByVal Cantidad As Double, _
                                        ByVal Debe As Double) As Boolean
        If GuMov.GuardarMovimientos(Fecha, Idcliente, Idsr, Condiciones, Cantidad, Debe) Then
            Return True
        Else
            Return False
        End If
    End Function
    <WebMethod()> _
        Public Function GuardarConMov(ByVal Idmovcredito As Integer, _
                                       ByVal Saldoinsoluto As Double, _
                                       ByVal Abonocapital As Double, _
                                       ByVal Intereses As Double, _
                                       ByVal Saldo As Double) As Boolean
        If GuConMov.GuardarConsecutivoMovimientos(Idmovcredito, Saldoinsoluto, Abonocapital, Intereses, Saldo) Then
            Return True
        Else
            Return False
        End If

    End Function
    <WebMethod()> _
        Public Function GuardarMovCredito(ByVal Idcliente As Integer, _
                                              ByVal Idmovimiento As Integer, _
                                              ByVal Fecha As String, _
                                              ByVal Meses As Integer, _
                                              ByVal Cantidad As Double, _
                                              ByVal Saldo As Double) As Boolean
        If GuMovCred.GuardarMovimientosCredito(Idcliente, Idmovimiento, Fecha, Meses, Cantidad, Saldo) Then
            Return True
        Else
            Return False
        End If

    End Function
    <WebMethod()> _
   Public Function BuscarClienteID(ByVal Id As Integer) As DataSet
        Dim Conjunto As New DataSet
        Conjunto = BuClientes.BuscarRegistro(Id)
        Return Conjunto
    End Function
    <WebMethod()> _
Public Function BuscarIdtsRefe(ByVal Idts As Integer, ByVal Referencia As String) As DataSet
        Dim Conjunto As New DataSet
        Conjunto = BuscarIdtsRef.BuscarRegistroIdtsRef(Idts, Referencia)
        Return Conjunto
    End Function
    <WebMethod()> _
   Public Function ActualizarVisitas(ByVal ID As Integer) As Boolean
        If ACTVISI.ActualizarVisita(ID) Then
            Return True
        Else
            Return False
        End If

    End Function
    <WebMethod()> _
Public Function BuscarClientes() As DataSet
        Dim Conjunto As New DataSet
        Conjunto = BuClientesAll.BuscarClientesAll
        Return Conjunto
    End Function
    <WebMethod()> _
Public Function BuscarConsecutivoMoviCred() As DataSet
        Dim Conjunto As New DataSet
        Conjunto = BuConMovCred.BuscarConMovCred
        Return Conjunto
    End Function
    <WebMethod()> _
Public Function BuscarMovCred() As DataSet
        Dim Conjunto As New DataSet
        Conjunto = BuMovCred.BuscarMoviCred
        Return Conjunto
    End Function
    <WebMethod()> _
Public Function BuscarMovimientos() As DataSet
        Dim Conjunto As New DataSet
        Conjunto = BuMovimientos.BuscarMovimientos
        Return Conjunto
    End Function
    <WebMethod()> _
 Public Function BuscarConseMoviID(ByVal Id As Integer) As DataSet
        Dim Conjunto As New DataSet
        Conjunto = BuCoMoId.BuscarRegistro(Id)
        Return Conjunto
    End Function
    <WebMethod()> _
Public Function BuscarMovCredID(ByVal Id As Integer) As DataSet
        Dim Conjunto As New DataSet
        Conjunto = BuMovCredID.BuscarRegistro(Id)
        Return Conjunto
    End Function
    <WebMethod()> _
Public Function BuscarMovimientoID(ByVal Id As Integer) As DataSet
        Dim Conjunto As New DataSet
        Conjunto = BuMovIDVB.BuscarRegistro(Id)
        Return Conjunto
    End Function

    <WebMethod()> _
    Public Function ConsultaFlex(ByVal Id As Integer) As Servicio()
        Try
            Dim Conjunto As New DataSet
            Conjunto = buscarflex.BuscarFlex(Id)
            Dim Objetoarreglo As Servicio() = New Servicio(Conjunto.Tables(0).Rows.Count - 1) {}
            Dim cont As Int16
            For cont = 0 To Conjunto.Tables(0).Rows.Count - 1
                Objetoarreglo(cont) = New Servicio
                Objetoarreglo(cont).idconmov = Conjunto.Tables(0).Rows(cont)("idconsecutivomovimientocredito")
                Objetoarreglo(cont).idmovcred = Conjunto.Tables(0).Rows(cont)("idmovimientocredito")
                Objetoarreglo(cont).saldoinsoluto = Conjunto.Tables(0).Rows(cont)("saldoinsoluto")
                Objetoarreglo(cont).abonocapital = Conjunto.Tables(0).Rows(cont)("abonocapital")
                Objetoarreglo(cont).intereses = Conjunto.Tables(0).Rows(cont)("intereses")
                Objetoarreglo(cont).saldo = Conjunto.Tables(0).Rows(cont)("saldo")
            Next
            Return Objetoarreglo
        Catch ex As Exception
            Throw
        End Try
    End Function
    <WebMethod()> _
        Public Function HelloWorld4() As String
        Return "Hello World"
    End Function
    Public Class Servicio
        Public idconmov As Integer
        Public idmovcred As Integer
        Public saldoinsoluto As Double
        Public abonocapital As Double
        Public intereses As Double
        Public saldo As Double
    End Class
End Class
