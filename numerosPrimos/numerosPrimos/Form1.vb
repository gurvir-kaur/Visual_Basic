Public Class Form1

    Private n1 As Integer
    Private n2 As Integer

    Private Sub reiniciar_Click(sender As Object, e As EventArgs) Handles reiniciar.Click

        rango1.Text = " "
        rango2.Text = " "
        ListBox1.Items.Clear()


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged



    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click

        Me.Close()

    End Sub

    Private Sub rango1_TextChanged(sender As Object, e As EventArgs) Handles rango1.TextChanged

        Me.n1 = Val(rango1.Text)

    End Sub

    Private Sub rango2_TextChanged(sender As Object, e As EventArgs) Handles rango2.TextChanged

        Me.n2 = Val(rango2.Text)

    End Sub

    Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click

        While Me.n1 <= Me.n2
            If Me.primeNumber(Me.n1) = True Then
                ListBox1.Items.Add(Me.n1)

            End If
            Me.n1 = Me.n1 + 1
        End While

    End Sub

    Function primeNumber(ByVal a As Integer) As Boolean

        If a < 2 Then
            Return False
        ElseIf a = 2 Then
            Return True
        Else
            For i As Integer = 2 To a - 1
                If a Mod i = 0 Then
                    Return False

                End If
            Next

            Return True

        End If

    End Function

End Class

