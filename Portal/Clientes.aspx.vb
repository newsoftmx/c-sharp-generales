Imports System.Data.SqlClient
Imports System.Data
Partial Class Clientes
    Inherits System.Web.UI.Page
    Dim WSVibe As New WSVibebanco.Service
    Dim Conjunto As New DataSet
    Dim idcli, CreditoDisponible As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        idcli = Session("idcliente")
        lblIdcleinte.Text = idcli
        Conjunto = WSVibe.BuscarClienteID(idcli)
        lblNombre.Text = Conjunto.Tables(0).Rows(0)("nombre")
        lblPaterno.Text = Conjunto.Tables(0).Rows(0)("paterno")
        lblMaterno.Text = Conjunto.Tables(0).Rows(0)("materno")
        lblCredito.Text = Conjunto.Tables(0).Rows(0)("creditodisponible")
        
        lblVisita.Text = Conjunto.Tables(0).Rows(0)("visita")
        If lblVisita.Text = 0 Then
            lblMensaje.Visible = True
            WSVibe.ActualizarVisitas(idcli)

            'ACTVISI.ActualizarVisita(ID)
        End If

    End Sub
    Public Sub limpiarCajas()
        txtReferencia.Text = ""
        txtTipoServicio.Text = ""
        txtReferencia2.Text = ""
        txtCantidad.Text = ""
        txtFecha.Text = ""
        txtmeses.Text = ""
    End Sub
    Protected Sub BTNbUSCARsERVICIO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNbUSCARsERVICIO.Click

        Dim Idts As Integer
        Dim Referencia As String
        Idts = LISTA.Text
        Referencia = txtReferencia.Text
        Conjunto = WSVibe.BuscarIdtsRefe(Idts, Referencia)
        If Not Conjunto Is Nothing Then
            If Conjunto.Tables(0).Rows.Count = 1 Then
                txtTipoServicio.Text = Conjunto.Tables(0).Rows(0)("idts")
                txtReferencia2.Text = Conjunto.Tables(0).Rows(0)("referencia")
                txtCantidad.Text = Conjunto.Tables(0).Rows(0)("cantidad")
                txtFecha.Text = Conjunto.Tables(0).Rows(0)("fechavencimiento")
            End If
        End If



    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtTipoServicio.Text = ""
        txtReferencia2.Text = ""
        txtCantidad.Text = ""
        txtFecha.Text = ""
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If listaFormapago.Text = "Contado" Then
            idcli = Session("idcliente")
            Conjunto = WSVibe.BuscarClienteID(idcli)
            CreditoDisponible = Conjunto.Tables(0).Rows(0)("creditodisponible")


            If CreditoDisponible > 0 Then
                Dim cantidad, debe As Double
                cantidad = txtCantidad.Text
                If cantidad <= CreditoDisponible Then
                    Dim fecha, condiciones As String
                    Dim idcliente, idsr As Integer
                    fecha = txtFecha.Text
                    condiciones = listaFormapago.Text
                    idcliente = lblIdcleinte.Text
                    idsr = txtTipoServicio.Text
                    cantidad = txtCantidad.Text
                    debe = cantidad - debe
                    WSVibe.GuardarMovimientos(fecha, idcliente, idsr, condiciones, cantidad, debe)
                Else
                    lblImposiblepagar.Visible = True
                End If
            Else
                lblCreditonodisponible.Visible = True
            End If
        Else
            'credito
            

        End If
        



    End Sub

    '    Protected Sub btnpagarcredito_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnpagarcredito.Click
    '       idcli = Session("idcliente")
    '      Conjunto = WSVibe.BuscarClienteID(idcli)
    '     CreditoDisponible = Conjunto.Tables(0).Rows(0)("creditodisponible")
    '
    '
    '   If CreditoDisponible > 0 Then
    'Dim cantidad, debe As Double
    '       cantidad = txtCantidad.Text
    '      If cantidad <= CreditoDisponible Then
    'Dim fecha, condiciones As String
    'Dim idcliente, idsr As Integer
    '           fecha = txtFecha.Text
    '          condiciones = listaFormapago.Text
    '         idcliente = lblIdcleinte.Text
    '        idsr = txtTipoServicio.Text
    '       cantidad = txtCantidad.Text
    '      debe = cantidad - debe
    '     WSVibe.GuardarMovimientos(fecha, idcliente, idsr, condiciones, cantidad, debe)
    'Else
    '        lblImposiblepagar.Visible = True
    '   End If
    'Else
    '   lblCreditonodisponible.Visible = True
    '  txtmeses.Visible = True
    ' End If
    'End Sub

    Protected Sub btnpagar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnpagarcredito.Click
        Dim cantidadMeses, Meses, Idmovimiento As Integer
        'aqui guardamos los cobros a realizar
        idcli = Session("idcliente")
        Conjunto = WSVibe.BuscarClienteID(idcli)
        CreditoDisponible = Conjunto.Tables(0).Rows(0)("creditodisponible")


        If CreditoDisponible > 0 Then
            Dim cantidad, debe, saldo As Double
            cantidad = txtCantidad.Text
            If cantidad <= CreditoDisponible Then
                Dim fecha, condiciones As String
                Dim idcliente, idsr As Integer
                fecha = txtFecha.Text
                condiciones = listaFormapago.Text
                idcliente = lblIdcleinte.Text
                idsr = txtTipoServicio.Text
                cantidad = txtCantidad.Text
                saldo = cantidad
                debe = cantidad - debe
                Meses = txtmeses.Text
                cantidadMeses = txtmeses.Text
                Idmovimiento = 1
                WSVibe.GuardarMovimientos(fecha, idcliente, idsr, condiciones, cantidad, debe)
                WSVibe.GuardarMovCredito(idcliente, Idmovimiento, fecha, Meses, cantidad, saldo)
                Dim idmovcredito As Integer
                Dim Saldoinsoluto, Abonocapital, Intereses, Saldos As Double
                idmovcredito = 1
                For x = 1 To cantidadMeses
                    Saldoinsoluto = saldo
                    Abonocapital = Saldoinsoluto / cantidadMeses - x
                    Intereses = Abonocapital * 0.05
                    Saldos = Saldoinsoluto - Abonocapital
                    WSVibe.GuardarConMov(idmovcredito, Saldoinsoluto, Abonocapital, Intereses, Saldos)
                Next
                limpiarCajas()
            End If
        End If


    End Sub
End Class
