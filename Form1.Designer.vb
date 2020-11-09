<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPortada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPortada))
        Me.ImgBienvenida1 = New System.Windows.Forms.PictureBox()
        Me.BtnAcceso = New System.Windows.Forms.Button()
        CType(Me.ImgBienvenida1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImgBienvenida1
        '
        Me.ImgBienvenida1.Image = CType(resources.GetObject("ImgBienvenida1.Image"), System.Drawing.Image)
        Me.ImgBienvenida1.Location = New System.Drawing.Point(0, 2)
        Me.ImgBienvenida1.Name = "ImgBienvenida1"
        Me.ImgBienvenida1.Size = New System.Drawing.Size(802, 451)
        Me.ImgBienvenida1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBienvenida1.TabIndex = 1
        Me.ImgBienvenida1.TabStop = False
        '
        'BtnAcceso
        '
        Me.BtnAcceso.BackColor = System.Drawing.Color.Transparent
        Me.BtnAcceso.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAcceso.ForeColor = System.Drawing.Color.Transparent
        Me.BtnAcceso.Location = New System.Drawing.Point(150, 361)
        Me.BtnAcceso.Name = "BtnAcceso"
        Me.BtnAcceso.Size = New System.Drawing.Size(465, 60)
        Me.BtnAcceso.TabIndex = 2
        Me.BtnAcceso.Text = "Accede al mundo de la Física"
        Me.BtnAcceso.UseVisualStyleBackColor = False
        '
        'FormPortada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnAcceso)
        Me.Controls.Add(Me.ImgBienvenida1)
        Me.Name = "FormPortada"
        Me.Text = "Portada"
        CType(Me.ImgBienvenida1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImgBienvenida1 As PictureBox
    Friend WithEvents BtnAcceso As Button
End Class
