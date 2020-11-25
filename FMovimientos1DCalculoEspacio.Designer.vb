<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMovimientos1DCalculoEspacio
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
        Me.components = New System.ComponentModel.Container()
        Me.LblMRU = New System.Windows.Forms.Label()
        Me.LblEspacioMRU = New System.Windows.Forms.Label()
        Me.LblEspacioInicial = New System.Windows.Forms.Label()
        Me.TxtEspacioMRU = New System.Windows.Forms.TextBox()
        Me.TxtVelocidadEspacioMRU = New System.Windows.Forms.TextBox()
        Me.LblVelocidad = New System.Windows.Forms.Label()
        Me.TxtTiempoEspacioMRU = New System.Windows.Forms.TextBox()
        Me.LblTiempoTranscurrido = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCalculoEspacioMRU = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblMRU
        '
        Me.LblMRU.AutoSize = True
        Me.LblMRU.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMRU.Location = New System.Drawing.Point(12, 26)
        Me.LblMRU.Name = "LblMRU"
        Me.LblMRU.Size = New System.Drawing.Size(897, 37)
        Me.LblMRU.TabIndex = 0
        Me.LblMRU.Text = "Cálculo del espacio en MRU (Movimiento Rectilíneo Uniforme)"
        '
        'LblEspacioMRU
        '
        Me.LblEspacioMRU.AutoSize = True
        Me.LblEspacioMRU.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEspacioMRU.Location = New System.Drawing.Point(31, 84)
        Me.LblEspacioMRU.Name = "LblEspacioMRU"
        Me.LblEspacioMRU.Size = New System.Drawing.Size(129, 20)
        Me.LblEspacioMRU.TabIndex = 1
        Me.LblEspacioMRU.Text = "Espacio en MRU"
        '
        'LblEspacioInicial
        '
        Me.LblEspacioInicial.AutoSize = True
        Me.LblEspacioInicial.Location = New System.Drawing.Point(32, 125)
        Me.LblEspacioInicial.Name = "LblEspacioInicial"
        Me.LblEspacioInicial.Size = New System.Drawing.Size(129, 13)
        Me.LblEspacioInicial.TabIndex = 2
        Me.LblEspacioInicial.Text = "Espacio inicial (en metros)"
        '
        'TxtEspacioMRU
        '
        Me.TxtEspacioMRU.Location = New System.Drawing.Point(187, 125)
        Me.TxtEspacioMRU.Name = "TxtEspacioMRU"
        Me.TxtEspacioMRU.Size = New System.Drawing.Size(109, 20)
        Me.TxtEspacioMRU.TabIndex = 3
        '
        'TxtVelocidadEspacioMRU
        '
        Me.TxtVelocidadEspacioMRU.Location = New System.Drawing.Point(429, 125)
        Me.TxtVelocidadEspacioMRU.Name = "TxtVelocidadEspacioMRU"
        Me.TxtVelocidadEspacioMRU.Size = New System.Drawing.Size(109, 20)
        Me.TxtVelocidadEspacioMRU.TabIndex = 5
        '
        'LblVelocidad
        '
        Me.LblVelocidad.AutoSize = True
        Me.LblVelocidad.Location = New System.Drawing.Point(318, 125)
        Me.LblVelocidad.Name = "LblVelocidad"
        Me.LblVelocidad.Size = New System.Drawing.Size(96, 13)
        Me.LblVelocidad.TabIndex = 4
        Me.LblVelocidad.Text = "Velocidad (en m/s)"
        '
        'TxtTiempoEspacioMRU
        '
        Me.TxtTiempoEspacioMRU.Location = New System.Drawing.Point(744, 125)
        Me.TxtTiempoEspacioMRU.Name = "TxtTiempoEspacioMRU"
        Me.TxtTiempoEspacioMRU.Size = New System.Drawing.Size(109, 20)
        Me.TxtTiempoEspacioMRU.TabIndex = 7
        '
        'LblTiempoTranscurrido
        '
        Me.LblTiempoTranscurrido.AutoSize = True
        Me.LblTiempoTranscurrido.Location = New System.Drawing.Point(553, 125)
        Me.LblTiempoTranscurrido.Name = "LblTiempoTranscurrido"
        Me.LblTiempoTranscurrido.Size = New System.Drawing.Size(174, 13)
        Me.LblTiempoTranscurrido.TabIndex = 6
        Me.LblTiempoTranscurrido.Text = "Tiempo Transcurrido (en segundos)"
        '
        'BtnCalculoEspacioMRU
        '
        Me.BtnCalculoEspacioMRU.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculoEspacioMRU.Location = New System.Drawing.Point(412, 169)
        Me.BtnCalculoEspacioMRU.Name = "BtnCalculoEspacioMRU"
        Me.BtnCalculoEspacioMRU.Size = New System.Drawing.Size(237, 47)
        Me.BtnCalculoEspacioMRU.TabIndex = 8
        Me.BtnCalculoEspacioMRU.Text = "Cálculo del espacio en MRU"
        Me.BtnCalculoEspacioMRU.UseVisualStyleBackColor = True
        '
        'FMovimientos1DCalculoEspacio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 463)
        Me.Controls.Add(Me.BtnCalculoEspacioMRU)
        Me.Controls.Add(Me.TxtTiempoEspacioMRU)
        Me.Controls.Add(Me.LblTiempoTranscurrido)
        Me.Controls.Add(Me.TxtVelocidadEspacioMRU)
        Me.Controls.Add(Me.LblVelocidad)
        Me.Controls.Add(Me.TxtEspacioMRU)
        Me.Controls.Add(Me.LblEspacioInicial)
        Me.Controls.Add(Me.LblEspacioMRU)
        Me.Controls.Add(Me.LblMRU)
        Me.Name = "FMovimientos1DCalculoEspacio"
        Me.Text = "Cálculo del espacio en una dimensión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblMRU As Label
    Friend WithEvents LblEspacioMRU As Label
    Friend WithEvents LblEspacioInicial As Label
    Friend WithEvents TxtEspacioMRU As TextBox
    Friend WithEvents TxtVelocidadEspacioMRU As TextBox
    Friend WithEvents LblVelocidad As Label
    Friend WithEvents TxtTiempoEspacioMRU As TextBox
    Friend WithEvents LblTiempoTranscurrido As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnCalculoEspacioMRU As Button
End Class
