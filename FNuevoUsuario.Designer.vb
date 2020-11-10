<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FNuevoUsuario
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
        Me.LBienvenidaUsu = New System.Windows.Forms.Label()
        Me.LblNombreNuevoUsu = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtContrasenia = New System.Windows.Forms.TextBox()
        Me.LblNuevaContrasenia = New System.Windows.Forms.Label()
        Me.BtnCrearNuevoUsuario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBienvenidaUsu
        '

        Me.LBienvenidaUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBienvenidaUsu.ForeColor = System.Drawing.Color.Red
        Me.LBienvenidaUsu.Location = New System.Drawing.Point(30, 32)
        Me.LBienvenidaUsu.Name = "LBienvenidaUsu"
        Me.LBienvenidaUsu.Size = New System.Drawing.Size(654, 20)
        Me.LBienvenidaUsu.TabIndex = 0
        Me.LBienvenidaUsu.Text = "Inserte un nombre de usuario y contraseña en el lugar correspondiente. Gracias."
        Me.LBienvenidaUsu.UseMnemonic = False
        '
        'LblNombreNuevoUsu
        '

        Me.LblNombreNuevoUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreNuevoUsu.Location = New System.Drawing.Point(37, 97)
        Me.LblNombreNuevoUsu.Name = "LblNombreNuevoUsu"
        Me.LblNombreNuevoUsu.Size = New System.Drawing.Size(146, 17)
        Me.LblNombreNuevoUsu.TabIndex = 1
        Me.LblNombreNuevoUsu.Text = "Nombre de usuario"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(219, 94)
        Me.TxtUsuario.MaxLength = 255
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(455, 20)
        Me.TxtUsuario.TabIndex = 2
        Me.TxtUsuario.Tag = ""
        Me.TxtUsuario.Text = "Longitud mínima: 3 caracteres"
        '
        'TxtContrasenia
        '
        Me.TxtContrasenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasenia.Location = New System.Drawing.Point(219, 170)
        Me.TxtContrasenia.MaxLength = 255
        Me.TxtContrasenia.Name = "TxtContrasenia"
        Me.TxtContrasenia.Size = New System.Drawing.Size(455, 23)
        Me.TxtContrasenia.TabIndex = 4
        Me.TxtContrasenia.Text = "Longitud mínima: 6 caracteres"
        '
        'LblNuevaContrasenia
        '

        Me.LblNuevaContrasenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNuevaContrasenia.Location = New System.Drawing.Point(37, 173)
        Me.LblNuevaContrasenia.Name = "LblNuevaContrasenia"
        Me.LblNuevaContrasenia.Size = New System.Drawing.Size(77, 17)
        Me.LblNuevaContrasenia.TabIndex = 3
        Me.LblNuevaContrasenia.Text = "Password"
        '
        'BtnCrearNuevoUsuario
        '
        Me.BtnCrearNuevoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrearNuevoUsuario.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnCrearNuevoUsuario.Location = New System.Drawing.Point(219, 248)
        Me.BtnCrearNuevoUsuario.Name = "BtnCrearNuevoUsuario"
        Me.BtnCrearNuevoUsuario.Size = New System.Drawing.Size(465, 110)
        Me.BtnCrearNuevoUsuario.TabIndex = 5
        Me.BtnCrearNuevoUsuario.Text = "Confirmar creación de nuevo usuario"

        '
        'FNuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnCrearNuevoUsuario)
        Me.Controls.Add(Me.TxtContrasenia)
        Me.Controls.Add(Me.LblNuevaContrasenia)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.LblNombreNuevoUsu)
        Me.Controls.Add(Me.LBienvenidaUsu)
        Me.Name = "FNuevoUsuario"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBienvenidaUsu As Label
    Friend WithEvents LblNombreNuevoUsu As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtContrasenia As TextBox
    Friend WithEvents LblNuevaContrasenia As Label
    Friend WithEvents BtnCrearNuevoUsuario As Button
End Class
