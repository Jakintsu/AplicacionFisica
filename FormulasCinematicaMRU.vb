Module FormulasCinematicaMRU
    Public Function CalculoEspacioMRU(ByVal EspacioInicial As Double, ByVal Velocidad As Double, ByVal TiempoTranscurrido As Double) As Double
        Return EspacioInicial + (Velocidad * TiempoTranscurrido)
    End Function
    Public Function CalculoVelocidadMRU(ByVal PosicionInicial As Double, ByVal PosicionFinal As Double, ByVal TiempoTranscurrido As Double) As Double
        Return (PosicionFinal - PosicionInicial) / TiempoTranscurrido
    End Function

End Module
