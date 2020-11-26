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
        If IsNotTextNull(TxtContrasenia.Text.Trim()) AndAlso CheckWhiteSpace(TxtContrasenia.Text.Trim()) Then
            MessageBox.Show("No puede haber espacios en blanco en la contraseña")
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





End Class