Public Class Racional

    Private numerador As Integer
    Private denominador As Integer


    'constructor
    Public Sub New(ByVal numerador As Integer, ByVal denominador As Integer)

        Me.numerador = numerador
        Me.denominador = denominador

    End Sub

    Public Function to_String()

        Return "Racional(" + Me.numerador.ToString + ", " + Me.denominador.ToString + ")"

    End Function

    Public Function escalar(ByVal numero As Integer)

        Return New Racional(Me.numerador * numero, Me.denominador)

    End Function

    Public Function iguales(ByVal racional As Racional) As Boolean

        Return ((Me.numerador = racional.numerador) And (Me.denominador = racional.denominador))

    End Function

    '----------------- get/set NUMERADOR ----------------
    'obtener solo numerador
    Public Function getNumerador()

        Return Me.numerador

    End Function


    'para poder cambiar el valor de numerador
    Public Function setNumerador(ByVal numerador As Integer)

        Me.numerador = numerador

    End Function


    '----------------get/set DENOMINADOR -----------------

    Public Function getDenominador()

        Return Me.denominador

    End Function


    'para poder cambiar el valor de denominador
    Public Function setDenominador(ByVal denominador As Integer)

        If (denominador <> 0) Then
            Me.denominador = denominador
        Else
            MessageBox.Show("No se puede poner valor null")
        End If

    End Function

End Class
