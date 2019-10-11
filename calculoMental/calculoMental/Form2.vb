Public Class Form2

    Private i As Integer = 0
    Private j As Integer = 0

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        play()

    End Sub

    Function play()

        While Me.i <= 5

            TextBox6.Text = 10
            Timer1.Enabled = True

            TextBox5.Text = i
            refill()

            'comprobar el resultado
            check()

            If Val(TextBox6.Text) < 10 Then
                If TextBox4.BackColor = Color.LightGreen Then

                End If
            End If

            i = i + 1

        End While

    End Function

    Function createRandomOperador() As Integer

        Dim x As Integer
        x = Int((2 * Rnd()) + 1)
        Return x
    End Function

    Function createRandomNumber() As Integer

        Dim x As Integer
        x = Int((99 * Rnd()) + 1)
        Return x
    End Function



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        TextBox6.Text = Val(TextBox6.Text) - 1
        If TextBox6.Text = 0 Then
            Timer1.Enabled = False
        End If

    End Sub

    Function check()

        If TextBox4.Text.Length <> 0 Then

            If TextBox2.Text = "+" Then

                If Val(TextBox1.Text) + Val(TextBox3.Text) = Val(TextBox4.Text) Then
                    TextBox4.BackColor = Color.LightGreen
                    j += 1
                Else
                    TextBox4.BackColor = Color.OrangeRed
                End If

            Else
                If Val(TextBox1.Text) - Val(TextBox3.Text) = Val(TextBox4.Text) Then
                    TextBox4.BackColor = Color.LightGreen
                    j += 1
                Else
                    TextBox4.BackColor = Color.OrangeRed
                End If

            End If

        End If

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        check()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If Val(TextBox6.Text) < 10 Then
            seguiente()

        End If

    End Sub

    Function seguiente()

        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "

        refill()



    End Function

    Function refill()

        'mostrar primer numero
        TextBox1.Text = createRandomNumber()

        'mostrar operador
        If createRandomOperador() = 1 Then
            TextBox2.Text = "+"
        Else
            TextBox2.Text = "-"
        End If

        'mostrar segundo numero
        TextBox3.Text = createRandomNumber()

    End Function

End Class