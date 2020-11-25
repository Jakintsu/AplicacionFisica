<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMovimientos1D
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
        Me.LblInformativo = New System.Windows.Forms.Label()
        Me.LblEspacio1D = New System.Windows.Forms.Label()
        Me.LblVelocidad = New System.Windows.Forms.Label()
        Me.LblAceleracion = New System.Windows.Forms.Label()
        Me.LblTiempo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblInformativo
        '
        Me.LblInformativo.AutoSize = True
        Me.LblInformativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInformativo.Location = New System.Drawing.Point(12, 22)
        Me.LblInformativo.Name = "LblInformativo"
        Me.LblInformativo.Size = New System.Drawing.Size(521, 29)
        Me.LblInformativo.TabIndex = 0
        Me.LblInformativo.Text = "Haga clic sobre el concepto que desee calcular"
        '
        'LblEspacio1D
        '
        Me.LblEspacio1D.AutoSize = True
        Me.LblEspacio1D.Font = New System.Drawing.Font("Palatino Linotype", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEspacio1D.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LblEspacio1D.Location = New System.Drawing.Point(428, 88)
        Me.LblEspacio1D.Name = "LblEspacio1D"
        Me.LblEspacio1D.Size = New System.Drawing.Size(195, 65)
        Me.LblEspacio1D.TabIndex = 1
        Me.LblEspacio1D.Text = "Espacio"
        '
        'LblVelocidad
        '
        Me.LblVelocidad.AutoSize = True
        Me.LblVelocidad.Font = New System.Drawing.Font("Palatino Linotype", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVelocidad.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LblVelocidad.Location = New System.Drawing.Point(424, 169)
        Me.LblVelocidad.Name = "LblVelocidad"
        Me.LblVelocidad.Size = New System.Drawing.Size(248, 65)
        Me.LblVelocidad.TabIndex = 2
        Me.LblVelocidad.Text = "Velocidad"
        '
        'LblAceleracion
        '
        Me.LblAceleracion.AutoSize = True
        Me.LblAceleracion.Font = New System.Drawing.Font("Palatino Linotype", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAceleracion.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LblAceleracion.Location = New System.Drawing.Point(424, 243)
        Me.LblAceleracion.Name = "LblAceleracion"
        Me.LblAceleracion.Size = New System.Drawing.Size(286, 65)
        Me.LblAceleracion.TabIndex = 3
        Me.LblAceleracion.Text = "Aceleración"
        '
        'LblTiempo
        '
        Me.LblTiempo.AutoSize = True
        Me.LblTiempo.Font = New System.Drawing.Font("Palatino Linotype", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTiempo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LblTiempo.Location = New System.Drawing.Point(424, 331)
        Me.LblTiempo.Name = "LblTiempo"
        Me.LblTiempo.Size = New System.Drawing.Size(199, 65)
        Me.LblTiempo.TabIndex = 4
        Me.LblTiempo.Text = "Tiempo"
        '
        'FMovimientos1D
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 450)
        Me.Controls.Add(Me.LblTiempo)
        Me.Controls.Add(Me.LblAceleracion)
        Me.Controls.Add(Me.LblVelocidad)
        Me.Controls.Add(Me.LblEspacio1D)
        Me.Controls.Add(Me.LblInformativo)
        Me.Name = "FMovimientos1D"
        Me.Text = "Conceptos del movimiento en una dimensión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblInformativo As Label
    Friend WithEvents LblEspacio1D As Label
    Friend WithEvents LblVelocidad As Label
    Friend WithEvents LblAceleracion As Label
    Friend WithEvents LblTiempo As Label
End Class
