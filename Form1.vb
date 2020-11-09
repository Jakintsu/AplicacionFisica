Public Class FormPortada
    Private Sub BtnAcceso_Click(sender As Object, e As EventArgs) Handles BtnAcceso.Click
        'Abre el formulario Login
        Login.Show()
        Me.Hide()
    End Sub
End Class
