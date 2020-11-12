Public Class FormConfirmacionNuevoUsuario
    Private Sub BtnNoConforme_Click(sender As Object, e As EventArgs) Handles BtnNoConforme.Click
        FNuevoUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub FormConfirmacionNuevoUsuario_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TxtNombreNuevo.Text = FNuevoUsuario.UsuarioNombre
        TxtPassNuevo.Text = FNuevoUsuario.PasswordUsuario
        TxtNombreNuevo.Enabled = False
        TxtPassNuevo.Enabled = False
    End Sub

    Private Sub BtnConforme_Click(sender As Object, e As EventArgs) Handles BtnConforme.Click
        'Habría que guardar en la BBDD correspondiente
        FSeleccionMateria.Show()
        Me.Hide()
    End Sub
End Class