<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ckbEstatus = New System.Windows.Forms.CheckBox()
        Me.cmbNivel = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPaterno = New System.Windows.Forms.TextBox()
        Me.txtMaterno = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.dgvDepostistas = New System.Windows.Forms.DataGridView()
        Me.btnGuardarSP = New System.Windows.Forms.Button()
        Me.btnBuscarIDSP = New System.Windows.Forms.Button()
        Me.btnEliminarSP = New System.Windows.Forms.Button()
        Me.btnBuscarTodosSP = New System.Windows.Forms.Button()
        Me.btnActualizarSP = New System.Windows.Forms.Button()
        CType(Me.dgvDepostistas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Paterno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Materno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Edad"
        '
        'ckbEstatus
        '
        Me.ckbEstatus.AutoSize = True
        Me.ckbEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbEstatus.Location = New System.Drawing.Point(28, 212)
        Me.ckbEstatus.Name = "ckbEstatus"
        Me.ckbEstatus.Size = New System.Drawing.Size(90, 24)
        Me.ckbEstatus.TabIndex = 4
        Me.ckbEstatus.Text = "Estatus"
        Me.ckbEstatus.UseVisualStyleBackColor = True
        '
        'cmbNivel
        '
        Me.cmbNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNivel.FormattingEnabled = True
        Me.cmbNivel.Items.AddRange(New Object() {"Estandar", "Medio", "Profesional", "Experto"})
        Me.cmbNivel.Location = New System.Drawing.Point(28, 250)
        Me.cmbNivel.Name = "cmbNivel"
        Me.cmbNivel.Size = New System.Drawing.Size(175, 28)
        Me.cmbNivel.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(116, 68)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(160, 26)
        Me.txtNombre.TabIndex = 6
        '
        'txtPaterno
        '
        Me.txtPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaterno.Location = New System.Drawing.Point(116, 107)
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.Size = New System.Drawing.Size(160, 26)
        Me.txtPaterno.TabIndex = 7
        '
        'txtMaterno
        '
        Me.txtMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterno.Location = New System.Drawing.Point(116, 143)
        Me.txtMaterno.Name = "txtMaterno"
        Me.txtMaterno.Size = New System.Drawing.Size(160, 26)
        Me.txtMaterno.TabIndex = 8
        '
        'txtEdad
        '
        Me.txtEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.Location = New System.Drawing.Point(116, 179)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(160, 26)
        Me.txtEdad.TabIndex = 9
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(383, 49)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 26)
        Me.txtID.TabIndex = 10
        '
        'dgvDepostistas
        '
        Me.dgvDepostistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDepostistas.Location = New System.Drawing.Point(293, 81)
        Me.dgvDepostistas.Name = "dgvDepostistas"
        Me.dgvDepostistas.Size = New System.Drawing.Size(580, 218)
        Me.dgvDepostistas.TabIndex = 11
        '
        'btnGuardarSP
        '
        Me.btnGuardarSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarSP.Location = New System.Drawing.Point(28, 303)
        Me.btnGuardarSP.Name = "btnGuardarSP"
        Me.btnGuardarSP.Size = New System.Drawing.Size(104, 35)
        Me.btnGuardarSP.TabIndex = 12
        Me.btnGuardarSP.Text = "Guardar SP"
        Me.btnGuardarSP.UseVisualStyleBackColor = True
        '
        'btnBuscarIDSP
        '
        Me.btnBuscarIDSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarIDSP.Location = New System.Drawing.Point(138, 303)
        Me.btnBuscarIDSP.Name = "btnBuscarIDSP"
        Me.btnBuscarIDSP.Size = New System.Drawing.Size(162, 35)
        Me.btnBuscarIDSP.TabIndex = 13
        Me.btnBuscarIDSP.Text = "Buscar ID SP"
        Me.btnBuscarIDSP.UseVisualStyleBackColor = True
        '
        'btnEliminarSP
        '
        Me.btnEliminarSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarSP.Location = New System.Drawing.Point(28, 344)
        Me.btnEliminarSP.Name = "btnEliminarSP"
        Me.btnEliminarSP.Size = New System.Drawing.Size(104, 30)
        Me.btnEliminarSP.TabIndex = 14
        Me.btnEliminarSP.Text = "Eliminar ID SP"
        Me.btnEliminarSP.UseVisualStyleBackColor = True
        '
        'btnBuscarTodosSP
        '
        Me.btnBuscarTodosSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarTodosSP.Location = New System.Drawing.Point(138, 344)
        Me.btnBuscarTodosSP.Name = "btnBuscarTodosSP"
        Me.btnBuscarTodosSP.Size = New System.Drawing.Size(162, 30)
        Me.btnBuscarTodosSP.TabIndex = 15
        Me.btnBuscarTodosSP.Text = "Buscar Todos SP"
        Me.btnBuscarTodosSP.UseVisualStyleBackColor = True
        '
        'btnActualizarSP
        '
        Me.btnActualizarSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarSP.Location = New System.Drawing.Point(85, 380)
        Me.btnActualizarSP.Name = "btnActualizarSP"
        Me.btnActualizarSP.Size = New System.Drawing.Size(135, 33)
        Me.btnActualizarSP.TabIndex = 16
        Me.btnActualizarSP.Text = "Actualizar SP"
        Me.btnActualizarSP.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 476)
        Me.Controls.Add(Me.btnActualizarSP)
        Me.Controls.Add(Me.btnBuscarTodosSP)
        Me.Controls.Add(Me.btnEliminarSP)
        Me.Controls.Add(Me.btnBuscarIDSP)
        Me.Controls.Add(Me.btnGuardarSP)
        Me.Controls.Add(Me.dgvDepostistas)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtMaterno)
        Me.Controls.Add(Me.txtPaterno)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.cmbNivel)
        Me.Controls.Add(Me.ckbEstatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvDepostistas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ckbEstatus As System.Windows.Forms.CheckBox
    Friend WithEvents cmbNivel As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtPaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtMaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents dgvDepostistas As System.Windows.Forms.DataGridView
    Friend WithEvents btnGuardarSP As System.Windows.Forms.Button
    Friend WithEvents btnBuscarIDSP As System.Windows.Forms.Button
    Friend WithEvents btnEliminarSP As System.Windows.Forms.Button
    Friend WithEvents btnBuscarTodosSP As System.Windows.Forms.Button
    Friend WithEvents btnActualizarSP As System.Windows.Forms.Button

End Class
