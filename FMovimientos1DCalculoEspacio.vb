Public Class FMovimientos1DCalculoEspacio
    Private Sub BtnCalculoEspacioMRU_Click(sender As Object, e As EventArgs) Handles BtnCalculoEspacioMRU.Click
        Dim Espacio As Double = Val(TxtEspacioMRU.Text)
        Dim Velocidad As Double = Val(TxtVelocidadEspacioMRU)
        Dim TiempoPasado As Double = Val(TxtTiempoEspacioMRU)




    End Sub

    Private Function CalculoEspacioMRU(ByVal EspacioInicial As Double, ByVal Velocidad As Double, ByVal TiempoTranscurrido As Double) As Double
        Return EspacioInicial + Velocidad * TiempoTranscurrido
    End Function
    Private Function ComprobacionNegativos(ByVal Cantidad As Double) As Boolean
        Return Cantidad < 0
    End Function
End Class