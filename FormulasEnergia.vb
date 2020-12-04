Module FormulasEnergia
    Public Function CalculoEnergiaPotencial(ByVal Masa As Double, ByVal Altura As Double) As Double
        Return Masa * ACELERACION_GRAVEDAD_TIERRA * Altura
    End Function

    Public Function CalculoEnergiaCinetica(ByVal Masa As Double, ByVal Velocidad As Double) As Double
        Return (Masa * Math.Pow(Velocidad, 2)) / 2
    End Function


End Module
