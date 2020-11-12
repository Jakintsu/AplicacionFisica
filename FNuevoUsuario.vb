Public Class FNuevoUsuario

    Public UsuarioNombre As String
    Public PasswordUsuario As String


    Private Sub BtnCrearNuevoUsuario_Click(sender As Object, e As EventArgs) Handles BtnCrearNuevoUsuario.Click
        'Estas variables deben ser guardadas en BBDD
        Dim CajaUsuVacia As Boolean = TxtUsuario.Text = Nothing
        Dim CajaPassVacia As Boolean = TxtContrasenia.Text = Nothing

        If CajaUsuVacia AndAlso TxtUsuario.Text.Equals("") Then
            MessageBox.Show("Nombre de usuario vacío. Escriba su nombre, por favor.")

        ElseIf TxtUsuario.Text.Length > 2 Then
            UsuarioNombre = TxtUsuario.Text
        Else

            TxtUsuario.ForeColor = Color.Red
            TxtUsuario.Font = New Font(FontFamily.GenericSansSerif,
            20.0F, FontStyle.Bold)

            MessageBox.Show("Nombre de usuario incorrecto. No cumple las reglas de seguridad.")
        End If
        If CajaPassVacia OrElse TxtContrasenia.Text.Equals("") Then
            MessageBox.Show("Password vacío. Rellene la caja de texto")
            TxtContrasenia.Text = ""
        ElseIf TxtContrasenia.Text.Length > 5 Then

            PasswordUsuario = TxtContrasenia.Text
        Else
            TxtContrasenia.ForeColor = Color.Red
            TxtContrasenia.Font = New Font(FontFamily.GenericSansSerif,
            20.0F, FontStyle.Bold)
            MessageBox.Show("Password inválido. No cumple las reglas")


        End If
        'Si tanto usuario como password son correctos, pasamos a otro formulario
        If DatosValidos(UsuarioNombre, PasswordUsuario) Then
            FormConfirmacionNuevoUsuario.Show()
        End If
    End Sub

    Private Sub TxtUsuario_Click(sender As Object, e As EventArgs) Handles TxtUsuario.Click
        TxtUsuario.Text = Nothing
    End Sub

    Private Sub TxtContrasenia_Click(sender As Object, e As EventArgs) Handles TxtContrasenia.Click
        TxtContrasenia.Text = Nothing
    End Sub

    Private Function DatosValidos(NombreUsuario As String, Password As String)
        Return NombreUsuario.Length > 2 And Password.Length > 5
    End Function

    Private Sub FNuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class