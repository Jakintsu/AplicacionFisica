Module FormulasPresion

    Public Function CalculoDensidad(ByVal Masa As Double, ByVal Volumen As Double) As Double
        Return Masa / Volumen
    End Function

    Public Function CalculoPresionFluidos(ByVal Masa As Double, ByVal Volumen As Double, ByVal Altura As Double) As Double
        Dim Densidad As Double = CalculoDensidad(Masa, Volumen)
        Return Densidad * Altura * ACELERACION_GRAVEDAD_TIERRA
    End Function
End Module
