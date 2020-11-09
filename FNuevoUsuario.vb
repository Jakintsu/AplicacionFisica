Public Class FNuevoUsuario
    Dim UsuarioNombre As String
    Dim PasswordUsuario As String
    Private Sub BtnCrearNuevoUsuario_Click(sender As Object, e As EventArgs) Handles BtnCrearNuevoUsuario.Click
        'Estas variables deben ser guardadas en BBDD
        If TxtUsuario.Text <> "" AndAlso TxtUsuario.Text.Length > 2 Then

            UsuarioNombre = TxtUsuario.Text
        Else
            TxtUsuario.ForeColor = Color.Red
            MessageBox.Show("Nombre de usuario incorrecto. No cumple las reglas de seguridad")
        End If
        If TxtContrasenia.Text IsNot Nothing AndAlso TxtContrasenia.Text.Length > 5 Then

            PasswordUsuario = TxtContrasenia.Text
        Else
            TxtContrasenia.ForeColor = Color.Red
            MessageBox.Show("Password inválido. No cumple las reglas de seguridad")
            TxtContrasenia.Text = ""
        End If
    End Sub


End Class