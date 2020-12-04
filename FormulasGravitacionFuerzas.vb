Module FormulasGravitacionFuerzas
    Public Function CalculoLeyHooke(ByVal ConstanteMuelle As Double, ByVal LongitudInicial As Double, ByVal LongitudFinal As Double) As Double
        Dim CambioLongitud As Double = LongitudFinal - LongitudInicial
        Return ConstanteMuelle * CambioLongitud
    End Function

    Public Function CalculoFuerzaSegundaLeyDeNewton(ByVal Masa As Double, ByVal Aceleracion As Double) As Double
        Return Masa * Aceleracion
    End Function

    Public Function CalculoAceleracionNormalMovimientoCircular(ByVal Velocidad As Double, ByVal Radio As Double) As Double
        Return Math.Pow(Velocidad, 2) / Radio
    End Function

    Public Function CalculoPeso(ByVal Masa As Double) As Double
        Return Masa * ACELERACION_GRAVEDAD_TIERRA
    End Function

    Public Function CalculoFuerzaNormalVertical(ByVal Masa As Double, ByVal AnguloInclinacion As Double) As Double
        Return Masa * ACELERACION_GRAVEDAD_TIERRA * Math.Cos(AnguloInclinacion)
    End Function

    Public Function CalculoFuerzaNormalHorizontal(ByVal Masa As Double, ByVal AnguloInclinacion As Double) As Double
        Return Masa * ACELERACION_GRAVEDAD_TIERRA * Math.Sin(AnguloInclinacion)
    End Function

    Public Function CalculoFuerzaRozamiento(ByVal FuerzaNormal As Double, ByVal CoeficienteRozamiento As Double) As Double
        Return FuerzaNormal * CoeficienteRozamiento
    End Function

    Public Function CalculoFuerzaGravitacionUniversal(ByVal MasaPlaneta1 As Double, ByVal MasaPlaneta2 As Double, ByVal Radio As Double) As Double
        Dim Distancia_Cuadrado As Double = Math.Pow(Radio, 2)
        Return CONSTANTE_GRAVITACION_UNIVERSAL_NEWTON * (MasaPlaneta1 * MasaPlaneta2) / Distancia_Cuadrado
    End Function
End Module
