<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfirmacionNuevoUsuario
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
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtNombreNuevo = New System.Windows.Forms.TextBox()
        Me.TxtPassNuevo = New System.Windows.Forms.TextBox()
        Me.LblPresentacionNuevos = New System.Windows.Forms.Label()
        Me.BtnConforme = New System.Windows.Forms.Button()
        Me.BtnNoConforme = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(16, 102)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(57, 13)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "NOMBRE:"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(12, 178)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(73, 13)
        Me.LblPassword.TabIndex = 1
        Me.LblPassword.Text = "PASSWORD:"
        '
        'TxtNombreNuevo
        '
        Me.TxtNombreNuevo.Location = New System.Drawing.Point(191, 95)
        Me.TxtNombreNuevo.Name = "TxtNombreNuevo"
        Me.TxtNombreNuevo.Size = New System.Drawing.Size(326, 20)
        Me.TxtNombreNuevo.TabIndex = 2
        '
        'TxtPassNuevo
        '
        Me.TxtPassNuevo.Location = New System.Drawing.Point(191, 178)
        Me.TxtPassNuevo.Name = "TxtPassNuevo"
        Me.TxtPassNuevo.Size = New System.Drawing.Size(326, 20)
        Me.TxtPassNuevo.TabIndex = 3
        '
        'LblPresentacionNuevos
        '
        Me.LblPresentacionNuevos.AutoSize = True
        Me.LblPresentacionNuevos.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPresentacionNuevos.Location = New System.Drawing.Point(12, 24)
        Me.LblPresentacionNuevos.Name = "LblPresentacionNuevos"
        Me.LblPresentacionNuevos.Size = New System.Drawing.Size(793, 37)
        Me.LblPresentacionNuevos.TabIndex = 4
        Me.LblPresentacionNuevos.Text = "Estos son sus datos para entrar en nuestra aplicación."
        '
        'BtnConforme
        '
        Me.BtnConforme.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnConforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConforme.ForeColor = System.Drawing.Color.Coral
        Me.BtnConforme.Location = New System.Drawing.Point(110, 268)
        Me.BtnConforme.Name = "BtnConforme"
        Me.BtnConforme.Size = New System.Drawing.Size(201, 95)
        Me.BtnConforme.TabIndex = 5
        Me.BtnConforme.Text = "No quiero cambiar mis datos"
        Me.BtnConforme.UseCompatibleTextRendering = True
        Me.BtnConforme.UseVisualStyleBackColor = False
        '
        'BtnNoConforme
        '
        Me.BtnNoConforme.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnNoConforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNoConforme.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnNoConforme.Location = New System.Drawing.Point(418, 268)
        Me.BtnNoConforme.Name = "BtnNoConforme"
        Me.BtnNoConforme.Size = New System.Drawing.Size(201, 95)
        Me.BtnNoConforme.TabIndex = 6
        Me.BtnNoConforme.Text = "Quiero cambiar mis datos"
        Me.BtnNoConforme.UseVisualStyleBackColor = False
        '
        'FormConfirmacionNuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnNoConforme)
        Me.Controls.Add(Me.BtnConforme)
        Me.Controls.Add(Me.LblPresentacionNuevos)
        Me.Controls.Add(Me.TxtPassNuevo)
        Me.Controls.Add(Me.TxtNombreNuevo)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblNombre)
        Me.Name = "FormConfirmacionNuevoUsuario"
        Me.Text = "FormConfirmacionNuevoUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNombre As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtNombreNuevo As TextBox
    Friend WithEvents TxtPassNuevo As TextBox
    Friend WithEvents LblPresentacionNuevos As Label
    Friend WithEvents BtnConforme As Button
    Friend WithEvents BtnNoConforme As Button
End Class
