Public Class FormPortada
    Private Sub BtnAcceso_Click(sender As Object, e As EventArgs) Handles BtnAcceso.Click
        'Abre el formulario Login
        MsgBox("Recuerda que en Física se trabaja mucho con vectores (un vector es un punto de recta que parte de un punto hacia otro, es decir, tiene magnitud y sentido)")
        Login.Show()
        Me.Hide()
    End Sub
End Class
