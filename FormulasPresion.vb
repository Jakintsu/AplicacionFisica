Module FormulasPresion

    Public Function CalculoDensidad(ByVal Masa As Double, ByVal Volumen As Double) As Double
        Return Masa / Volumen
    End Function

    Public Function CalculoPresionFluidos(ByVal Masa As Double, ByVal Volumen As Double, ByVal Altura As Double) As Double
        Dim Densidad As Double = CalculoDensidad(Masa, Volumen)
        Return Densidad * Altura * ACELERACION_GRAVEDAD_TIERRA
    End Function

    Public Function ComprobarSiCumpleLeyPascal(ByVal Masa1 As Double, ByVal Masa2 As Double, ByVal Superficie1 As Double, ByVal Superficie2 As Double) As Boolean
        Dim Fuerza1 As Double = CalculoFuerzaSegundaLeyDeNewton(Masa1, ACELERACION_GRAVEDAD_TIERRA)
        Dim Fuerza2 As Double = CalculoFuerzaSegundaLeyDeNewton(Masa2, ACELERACION_GRAVEDAD_TIERRA)

        Dim Resultado As Boolean = False
        Dim Cociente1 As Double = Fuerza1 / Superficie1
        Dim Cociente2 As Double = Fuerza2 / Superficie2

        If Cociente1 = Cociente2 Then
            Resultado = True
        End If

        Return Resultado

    End Function

    Public Function ComprobarPrincipioArquimedes() As Boolean

    End Function
End Module
