Public Class Login
    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click
        If TxtUsuario.Text = "ejemplo" Or TxtUsuario.Text = "Ejemplo" Or TxtUsuario.Text = "EJEMPLO" And TxtPass.Text = "1234" Then
            Me.Hide()
            'Ir a otro formulario
            FSeleccionMateria.Show()
        Else
            MsgBox("Usuario y/o password incorrectos")
            TxtUsuario.Text = ""
            TxtPass.Text = ""
            TxtUsuario.Focus()

        End If
    End Sub


    Private Sub TxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuario.TextChanged
        TxtUsuario.ForeColor = Color.DarkOrange
    End Sub

    Private Sub TxtPass_TextChanged(sender As Object, e As EventArgs) Handles TxtPass.TextChanged
        TxtPass.ForeColor = Color.DarkOrange
    End Sub

    Private Sub CheckMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckMostrar.CheckedChanged
        If CheckMostrar.Checked Then
            TxtPass.UseSystemPasswordChar = False
        Else
            TxtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtPass.UseSystemPasswordChar = True
    End Sub

    Private Sub BtnCrearUsu_Click(sender As Object, e As EventArgs) Handles BtnCrearUsu.Click
        FNuevoUsuario.Show()
        Me.Hide()
    End Sub
End Class
