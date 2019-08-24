Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.Sql
Public Class Form1
    Dim consumirSP As New WSVC.servicioVCSoapClient
    Dim nombre, apePaterno, apeMaterno, nivel As String
    Dim edad, id As Integer
    Dim estatus As Boolean
    Dim conjunto As New DataSet
    Dim datos As New SqlDataAdapter
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardarSP.Click
        nombre = txtNombre.Text
        apePaterno = txtPaterno.Text
        apeMaterno = txtMaterno.Text
        edad = txtEdad.Text
        estatus = ckbEstatus.Checked
        nivel = cmbNivel.SelectedItem.ToString()
        If (consumirSP.deportistaGuardarSP(nombre, apePaterno, apeMaterno, edad, estatus, nivel) = True) Then
            MessageBox.Show("guardado")
        Else
            MessageBox.Show("Error al guardar")
        End If
    End Sub

    Private Sub btnBuscarTodosSP_Click(sender As Object, e As EventArgs) Handles btnBuscarTodosSP.Click
        conjunto = consumirSP.deprtistaBuscarTodosSP()
        If (conjunto.Tables(0).Rows.Count > 0) Then
            dgvDepostistas.DataSource = conjunto.Tables("DatosGenerales")
        Else
            MessageBox.Show("No existen registros")
        End If
    End Sub

    Private Sub btnBuscarIDSP_Click(sender As Object, e As EventArgs) Handles btnBuscarIDSP.Click
        id = txtID.Text
        conjunto = consumirSP.deportistaBuscarIDSP(id)
        dgvDepostistas.DataSource = conjunto.Tables("DatosGenerales")
        'bajamos los datos al grid
        If (conjunto.Tables(0).Rows.Count > 0) Then
            txtNombre.Text = conjunto.Tables(0).Rows(0)(1).ToString()
            txtPaterno.Text = conjunto.Tables(0).Rows(0)(2).ToString()
            txtMaterno.Text = conjunto.Tables(0).Rows(0)(3).ToString()
            txtEdad.Text = conjunto.Tables(0).Rows(0)(4).ToString()
            ckbEstatus.Checked = conjunto.Tables(0).Rows(0)(5).ToString()
            cmbNivel.SelectedItem = conjunto.Tables(0).Rows(0)(6).ToString()
        Else
            MessageBox.Show("No tenemos registros")
        End If
    End Sub

    Private Sub btnEliminarSP_Click(sender As Object, e As EventArgs) Handles btnEliminarSP.Click
        id = txtID.Text
        If (consumirSP.deportistaEliminarSP(id) = True) Then
            MessageBox.Show("Registro eliminado correctamente")
        Else
            MessageBox.Show("No se pudo eliminar el registro")
        End If
    End Sub

    Private Sub btnActualizarSP_Click(sender As Object, e As EventArgs) Handles btnActualizarSP.Click
        nombre = txtNombre.Text
        apePaterno = txtPaterno.Text
        apeMaterno = txtMaterno.Text
        edad = txtEdad.Text
        estatus = ckbEstatus.Checked
        nivel = cmbNivel.SelectedItem.ToString()
        id = txtID.Text
        If (consumirSP.deportistaActualizarSP(id, nombre, apePaterno, apeMaterno, edad, estatus, nivel) = True) Then
            MessageBox.Show("Actualizado correctamente")
        Else
            MessageBox.Show("Error al actualizar")
        End If
    End Sub
End Class
