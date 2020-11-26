Module FormulasCinematicasMRUA
    Private Const FRACCION_MITAD As Double = 1 / 2
    Private Const DOBLE As Integer = 2
    Public Function CalculoVelocidadMRUA(ByVal VelocidadInicial As Double, ByVal Tiempo As Double, ByVal Aceleracion As Double) As Double
        Return VelocidadInicial + Aceleracion * Tiempo

    End Function

    Public Function CalculoEspacioMRUA(ByVal EspacioInicial As Double, ByVal VelocidadInicial As Double, ByVal TiempoTranscurrido As Double, ByVal Aceleracion As Double) As Double
        Return EspacioInicial + VelocidadInicial * TiempoTranscurrido + FRACCION_MITAD * Aceleracion * Math.Pow(TiempoTranscurrido, 2)
    End Function

    Public Function CalculoVelocidadSinTiempo(ByVal EspacioRecorrido As Double, ByVal VelocidadInicial As Double, ByVal Aceleracion As Double) As Double
        Dim VelocidadInicialCuadrado As Double = Math.Pow(VelocidadInicial, 2)

        Return Math.Sqrt(VelocidadInicialCuadrado + DOBLE * Aceleracion * EspacioRecorrido)
    End Function
End Module
