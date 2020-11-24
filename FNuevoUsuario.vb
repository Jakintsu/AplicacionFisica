Imports System.Text.RegularExpressions

Public Class FNuevoUsuario

    Public UsuarioNombre As String
    Public PasswordUsuario As String


    Private Sub BtnCrearNuevoUsuario_Click(sender As Object, e As EventArgs) Handles BtnCrearNuevoUsuario.Click
        'Estas variables deben ser guardadas en BBDD

        If Not IsNotTextNull(TxtUsuario.Text.Trim()) Then
            MsgBox("Por favor, introduzca su nombre de usuario")
        End If

        If Not IsNotTextNull(TxtContrasenia.Text.Trim()) Then
            MsgBox("Por favor, introduzca una contraseña.")
        End If

        If IsNotTextNull(TxtUsuario.Text.Trim()) AndAlso TxtUsuario.Text.Trim().Length > 2 Then
            UsuarioNombre = TxtUsuario.Text.Trim()


        Else
            MessageBox.Show("Nombre de usuario incorrecto. No cumple las reglas de seguridad. (AL MENOS TRES CARACTERES),")
        End If

        If IsNotTextNull(TxtContrasenia.Text.Trim()) AndAlso CheckNoLowerCase(TxtContrasenia.Text.Trim()) Then
            MessageBox.Show("La contraseña debe contener al menos una minúscula; al menos una mayúscula y al menos un número")
            TxtContrasenia.Text = ""

        End If

        If IsNotTextNull(TxtContrasenia.Text.Trim()) AndAlso CheckNoUpperCase(TxtContrasenia.Text.Trim()) Then
            MessageBox.Show("La contraseña debe contener al menos una minúscula; al menos una mayúscula y al menos un número")
            TxtContrasenia.Text = ""

        End If

        If IsNotTextNull(TxtContrasenia.Text.Trim()) AndAlso CheckNoNumbers(TxtContrasenia.Text.Trim()) Then
            MessageBox.Show("La contraseña debe contener al menos una minúscula; al menos una mayúscula y al menos un número")
            TxtContrasenia.Text = ""

        End If

        If IsNotTextNull(TxtContrasenia.Text.Trim()) AndAlso TxtContrasenia.Text.Trim().Length < 5 Then
            MessageBox.Show("La contraseña no cumple la longirud mínima (6 caracteres)")
            TxtContrasenia.Text = ""
        Else
            PasswordUsuario = TxtContrasenia.Text.Trim()
        End If
        'Si tanto usuario como password son correctos, pasamos a otro formulario
        If DatosValidos(UsuarioNombre, PasswordUsuario) Then
            FormConfirmacionNuevoUsuario.Show()
            Me.Close()
        End If
    End Sub


    Private Function DatosValidos(NombreUsuario As String, Password As String)
        If NombreUsuario <> "" AndAlso NombreUsuario <> Nothing AndAlso Password <> "" AndAlso Password <> Nothing Then


            Return NombreUsuario.Length > 2 And Password.Length > 5

        End If
        Return False
    End Function
    'Metodos de comprobación para contraseña y usuario
    Private Function CheckNoUpperCase(ByVal Password As String) As Boolean
        Dim PatronMayus As String = "[A-Z]"
        Dim RegularExpress As New Regex(PatronMayus, RegexOptions.ExplicitCapture)

        Dim Coincidencia As MatchCollection = RegularExpress.Matches(Password)

        If Coincidencia.Count = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function CheckNoNumbers(ByVal Password As String) As Boolean
        Dim PatronNumeros As String = "[\d]"
        Dim RegularExpress As New Regex(PatronNumeros, RegexOptions.ExplicitCapture)

        Dim Coincidencia As MatchCollection = RegularExpress.Matches(Password)

        If Coincidencia.Count = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function CheckNoLowerCase(ByVal Password As String) As Boolean
        Dim PatronMinus As String = "[a-z]"
        Dim RegularExpress As New Regex(PatronMinus, RegexOptions.ExplicitCapture)

        Dim Coincidencia As MatchCollection = RegularExpress.Matches(Password)

        If Coincidencia.Count = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function IsNotTextNull(ByVal Texto As String) As Boolean
        Return Texto <> "" AndAlso Texto <> Nothing
    End Function


End Class