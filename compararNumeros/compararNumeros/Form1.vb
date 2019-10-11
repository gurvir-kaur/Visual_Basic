Public Class Form1

    Private n1 As Integer
    Private n2 As Integer

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If IsNumeric(TextBox1.Text) Then
            Me.n1 = Val(TextBox1.Text)
        Else
            MessageBox.Show("No es un numero !")
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        If IsNumeric(TextBox2.Text) Then
            Me.n2 = Val(TextBox2.Text)
        Else
            MessageBox.Show("No es un numero !")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Me.n1 > Me.n2 Then
            MessageBox.Show(" Mayor es " & n1)
        ElseIf Me.n2 > Me.n1 Then
            MessageBox.Show("Mayor es " & n2)
        Else
            MessageBox.Show("Son iguales")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = " "
        TextBox2.Text = " "

    End Sub
End Class
