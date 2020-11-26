Public Class FMovimientos1DCalculoEspacio
    Private Sub BtnCalculoEspacioMRU_Click(sender As Object, e As EventArgs) Handles BtnCalculoEspacioMRU.Click
        Dim Espacio As Double = If(TxtEspacioMRU.Text.Equals(""), 0, Val(TxtEspacioMRU.Text))

        Dim Velocidad As Double = Val(TxtVelocidadEspacioMRU.Text)
        Dim TiempoPasado As Double = Val(TxtTiempoEspacioMRU.Text)

        Dim EspacioRecorrido As Double

        EspacioRecorrido = CalculoEspacioMRU(Espacio, Velocidad, TiempoPasado)

        MsgBox("El espacio con esos datos es: " & EspacioRecorrido & " metros. La fórmula del espacio en MRU es: ESPACIO INICIAL + VELOCIDAD·TIEMPO")




    End Sub

    Private Sub BtnCalculoEspacioMRUA_Click(sender As Object, e As EventArgs) Handles BtnCalculoEspacioMRUA.Click
        Dim EspacioInicial As Double = If(TxtEspacioIniMRUA.Text.Equals(""), 0, Val(TxtEspacioIniMRUA.Text))

        Dim VelocidadMRUA As Double = Val(TxtVelocidadMRUA.Text)
        Dim TiempoPasadoMRUA As Double = Val(TxtTiempoMRUA.Text)
        Dim Aceleracion As Double = Val(TxtAceleracionMRUA.Text)

        Dim EspacioRecorridoMRUA As Double

        EspacioRecorridoMRUA = CalculoEspacioMRUA(EspacioInicial, VelocidadMRUA, TiempoPasadoMRUA, Aceleracion)

        MsgBox("El espacio con esos datos es: " & EspacioRecorridoMRUA & " metros. La fórmula del espacio en MRUA es: ESPACIO INICIAL + VELOCIDAD·TIEMPO + (ACELERACIÓN·TIEMPO·TIEMPO)/2")
    End Sub
End Class