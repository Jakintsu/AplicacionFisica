Public Class FMovimientos1D
    Private Sub GoToCalculateSpace(sender As Object, e As EventArgs) Handles LblEspacio1D.Click
        FMovimientos1DCalculoEspacio.Show()
        Me.Hide()
    End Sub



    Private Sub MostrarInfoEspacio(sender As Object, e As EventArgs) Handles LblEspacio1D.MouseHover
        InfoEspacio.SetToolTip(LblEspacio1D, "El espacio (e) es la distancia recorrida por el móvil. \nNo confundir con la trayectoria, que es el camino que seguimos de la posición inicial a la posición final. La unidad de medida es el metro (m) en el Sistema Internacional.")
        InfoEspacio.ToolTipTitle = "Información sobre el espacio en cinemática"
        InfoEspacio.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub MostrarInfoVelocidad(sender As Object, e As EventArgs) Handles LblEspacio1D.MouseHover
        InfoEspacio.SetToolTip(LblVelocidad, "La velocidad (v) es la variación del espacio en el tiempo. No confundir con la rapidez. La velocidad se mide en metros por segundo (m/s) en el Sistema Internacional (S.I.) ")
        InfoEspacio.ToolTipTitle = "Información sobre el concepto de velocidad en cinemática"
        InfoEspacio.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub MostrarInfoAceleracion(sender As Object, e As EventArgs) Handles LblEspacio1D.MouseHover
        InfoEspacio.SetToolTip(LblAceleracion, "La aceleración (a) es la variación de la velocidad por unidad de tiempo (metros/segundo·segundo). Al igual que la velocidad se trata de una magnitud vectorial. En el S.I. su unidad de medida es metro/segundo·segundo")
        InfoEspacio.ToolTipTitle = "Información sobre el concepto de aceleración en cinemática."
        InfoEspacio.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub MostrarInfoTiempo(sender As Object, e As EventArgs) Handles LblEspacio1D.MouseHover
        InfoEspacio.SetToolTip(LblTiempo, "El tiempo (t) se mide en segundos.")
        InfoEspacio.ToolTipTitle = "Información sobre el concepto de tiempo en cinemática"
        InfoEspacio.ToolTipIcon = ToolTipIcon.Info

    End Sub
End Class