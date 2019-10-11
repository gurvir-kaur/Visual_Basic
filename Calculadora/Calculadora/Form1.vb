Public Class Form1


    Dim operacion As String
    Dim valor1 As Nullable(Of Double) = Nothing
    Dim valor2 As Nullable(Of Double) = Nothing
    Dim operador As Boolean

    Private Sub Resultado_TextChanged(sender As Object, e As EventArgs) Handles Resultado.TextChanged

    End Sub

    Private Sub AC_Click(sender As Object, e As EventArgs) Handles AC.Click

        Resultado.Text = "0"
        valor1 = Nothing
        valor2 = Nothing

    End Sub


    Private Sub OFF_Click(sender As Object, e As EventArgs) Handles OFF.Click

    End Sub

    Private Sub dividir_Click(sender As Object, e As EventArgs) Handles dividir.Click

        evaluarOperacion()
        operacion = "/"

    End Sub

    Private Sub multiplicar_Click(sender As Object, e As EventArgs) Handles multiplicar.Click

        evaluarOperacion()
        operacion = "*"

    End Sub

    Private Sub restar_Click(sender As Object, e As EventArgs) Handles restar.Click

        evaluarOperacion()
        operacion = "-"

    End Sub

    Private Sub sumar_Click(sender As Object, e As EventArgs) Handles sumar.Click

        evaluarOperacion()
        operacion = "+"

    End Sub

    Private Sub igual_Click(sender As Object, e As EventArgs) Handles igual.Click

        evaluarOperacion()
        operacion = ""

    End Sub

    Private Sub punto_Click(sender As Object, e As EventArgs) Handles punto.Click

        restricciones()
        If InStr(Resultado.Text, ".", CompareMethod.Text) = 0 Then
            Resultado.Text &= "."
        End If

    End Sub

    Private Sub zero_Click(sender As Object, e As EventArgs) Handles zero.Click

        restricciones()
        Resultado.Text &= "0"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        restricciones()
        Resultado.Text &= "1"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        restricciones()
        Resultado.Text &= "2"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        restricciones()
        Resultado.Text &= "3"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        restricciones()
        Resultado.Text &= "4"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        restricciones()
        Resultado.Text &= "5"

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        restricciones()
        Resultado.Text &= "6"

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        restricciones()
        Resultado.Text &= "7"

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        restricciones()
        Resultado.Text &= "8"

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        restricciones()
        Resultado.Text &= "9"

    End Sub

    Private Sub evaluarOperacion()

        operador = True
        valor2 = Val(Resultado.Text)

        If valor1 IsNot Nothing Then
            Select Case operacion
                Case "+"
                    valor1 = valor1 + valor2

                Case "-"
                    valor1 = valor1 - valor2

                Case "*"
                    valor1 = valor1 * valor2

                Case "/"
                    valor1 = valor1 / valor2
                Case "sqr"
                    valor1 = Sqrt(valor1)

            End Select
        Else
            valor1 = valor2

        End If
        Resultado.Text = valor1
    End Sub

    Private Sub restricciones()

        If operador = True Then
            Resultado.Text = " "
            operador = False

        ElseIf Resultado.Text = "0" Then
            Resultado.Text = " "
        End If

    End Sub

End Class
