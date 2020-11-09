<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.BtnIniciar = New System.Windows.Forms.Button()
        Me.CheckMostrar = New System.Windows.Forms.CheckBox()
        Me.BtnCrearUsu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TxtUsuario.Location = New System.Drawing.Point(158, 78)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(370, 20)
        Me.TxtUsuario.TabIndex = 0
        '
        'TxtPass
        '
        Me.TxtPass.BackColor = System.Drawing.SystemColors.WindowText
        Me.TxtPass.Location = New System.Drawing.Point(158, 171)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(368, 20)
        Me.TxtPass.TabIndex = 1
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.Location = New System.Drawing.Point(161, 55)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(76, 20)
        Me.LblUsuario.TabIndex = 2
        Me.LblUsuario.Text = "Usuario:"
        '
        'LblPass
        '
        Me.LblPass.AutoSize = True
        Me.LblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPass.Location = New System.Drawing.Point(159, 143)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(86, 20)
        Me.LblPass.TabIndex = 3
        Me.LblPass.Text = "Password"
        '
        'BtnIniciar
        '
        Me.BtnIniciar.BackColor = System.Drawing.SystemColors.ControlText
        Me.BtnIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIniciar.ForeColor = System.Drawing.Color.DarkOrange
        Me.BtnIniciar.Location = New System.Drawing.Point(177, 376)
        Me.BtnIniciar.Name = "BtnIniciar"
        Me.BtnIniciar.Size = New System.Drawing.Size(153, 50)
        Me.BtnIniciar.TabIndex = 7
        Me.BtnIniciar.Text = "Iniciar"
        Me.BtnIniciar.UseVisualStyleBackColor = False
        '
        'CheckMostrar
        '
        Me.CheckMostrar.AutoSize = True
        Me.CheckMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckMostrar.Location = New System.Drawing.Point(276, 276)
        Me.CheckMostrar.Name = "CheckMostrar"
        Me.CheckMostrar.Size = New System.Drawing.Size(89, 24)
        Me.CheckMostrar.TabIndex = 8
        Me.CheckMostrar.Text = "Mostrar"
        Me.CheckMostrar.UseVisualStyleBackColor = True
        '
        'BtnCrearUsu
        '
        Me.BtnCrearUsu.BackColor = System.Drawing.SystemColors.ControlText
        Me.BtnCrearUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrearUsu.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.BtnCrearUsu.Location = New System.Drawing.Point(397, 382)
        Me.BtnCrearUsu.Name = "BtnCrearUsu"
        Me.BtnCrearUsu.Size = New System.Drawing.Size(149, 43)
        Me.BtnCrearUsu.TabIndex = 9
        Me.BtnCrearUsu.Text = "Crear Usuario"
        Me.BtnCrearUsu.UseCompatibleTextRendering = True
        Me.BtnCrearUsu.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnCrearUsu)
        Me.Controls.Add(Me.CheckMostrar)
        Me.Controls.Add(Me.BtnIniciar)
        Me.Controls.Add(Me.LblPass)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Name = "Login"
        Me.Text = "SuperLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblPass As Label
    Friend WithEvents BtnIniciar As Button
    Friend WithEvents CheckMostrar As CheckBox
    Friend WithEvents BtnCrearUsu As Button
End Class
