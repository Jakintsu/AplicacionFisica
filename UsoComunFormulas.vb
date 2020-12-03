Imports System.Text.RegularExpressions

Module UsoComunFormulas
    Public Function ComprobacionNegativos(ByVal Cantidad As Double) As Boolean
        Return Cantidad < 0
    End Function

    Public Function DatosValidos(NombreUsuario As String, Password As String)
        Dim Resultado As Boolean = False
        If NombreUsuario <> "" AndAlso NombreUsuario <> Nothing AndAlso Password <> "" AndAlso Password <> Nothing Then


            Resultado = NombreUsuario.Length > 2 And Password.Length > 5

        End If
        Return Resultado
    End Function
    'Metodos de comprobación para contraseña y usuario
    Public Function CheckNoUpperCase(ByVal Password As String) As Boolean
        Dim PatronMayus As String = "[A-Z]"
        Dim RegularExpress As New Regex(PatronMayus, RegexOptions.ExplicitCapture)

        Dim Coincidencia As MatchCollection = RegularExpress.Matches(Password)

        If Coincidencia.Count = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function CheckNoNumbers(ByVal Password As String) As Boolean
        Dim PatronNumeros As String = "[\d]"
        Dim RegularExpress As New Regex(PatronNumeros, RegexOptions.ExplicitCapture)

        Dim Coincidencia As MatchCollection = RegularExpress.Matches(Password)

        If Coincidencia.Count = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function CheckNoLowerCase(ByVal Password As String) As Boolean
        Dim PatronMinus As String = "[a-z]"
        Dim RegularExpress As New Regex(PatronMinus, RegexOptions.ExplicitCapture)

        Dim Coincidencia As MatchCollection = RegularExpress.Matches(Password)

        If Coincidencia.Count = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function IsNotTextNull(ByVal Texto As String) As Boolean
        Return Texto <> "" AndAlso Texto <> Nothing
    End Function

    Public Function CheckWhiteSpace(ByVal Texto As String) As Boolean
        Dim PatronEspaciosBlanco As String = "[\s]"

        Dim RegularExpress As New Regex(PatronEspaciosBlanco, RegexOptions.ExplicitCapture)

        Dim Coincidencia As MatchCollection = RegularExpress.Matches(Texto)

        If Coincidencia.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function FormatNumbersWith4Decimals(ByVal Numero As Double) As String
        Return Format(Numero, "##,##0.0000")
    End Function
End Module
