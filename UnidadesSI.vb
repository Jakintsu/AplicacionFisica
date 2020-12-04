Module UnidadesSI
    Public Function PasarHorasASegundos(ByVal NumeroHoras As Single) As Double
        Return NumeroHoras * SEGUNDOS_HORA
    End Function
    Public Function PasarMinutosASegundos(ByVal NumeroMinutos As Single) As Double
        Return NumeroMinutos * SEGUNDOS_MINUTO

    End Function

    Public Function PasarDeKilometrosAMetros(ByVal NumeroKilometros As Double) As Double
        Return NumeroKilometros * METROS_KILOMETRO
    End Function

    Public Function PasarPulgadasAMetros(ByVal NumeroPulgadas As Double) As Double
        Return NumeroPulgadas * METROS_PULGADA
    End Function

    Public Function PasarPiesAMetros(ByVal NumeroPies As Double) As Double
        Return NumeroPies * METROS_PIE
    End Function

    Public Function PasarYardasAMetros(ByVal NumeroYardas As Double) As Double
        Return NumeroYardas * METROS_YARDA
    End Function

    Public Function PasarMillasAMetros(ByVal NumeroMillas As Double) As Double
        Return NumeroMillas * METROS_MILLA
    End Function

    Public Function PasarMillasNauticasAMetros(ByVal NumeroMillasNauticas As Double) As Double
        Return NumeroMillasNauticas * METROS_MILLA_NAUTICA
    End Function

    Public Function PasarLibrasAKilogramos(ByVal NumeroLibras As Double) As Double
        Return NumeroLibras * KILOGRAMOS_LIBRA
    End Function

    Public Function PasarToneladasAKilogramos(ByVal NumeroToneladas As Double) As Double
        Return NumeroToneladas * KILOGRAMOS_TONELADA
    End Function

    Public Function PasarOnzasAKilogramos(ByVal NumeroOnzas As Double) As Double
        Return NumeroOnzas * KILOGRAMOS_ONZA
    End Function
End Module
