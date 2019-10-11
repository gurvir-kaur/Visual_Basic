Public Class Form1

    Private n1 As Integer
    Private n2 As Integer
    Private res As Integer

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

        Me.res = Val(TextBox3.Text)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (Me.res = (Me.n1 + Me.n2)) Then
            TextBox3.BackColor = Color.Green
        Else
            TextBox3.BackColor = Color.Red
        End If

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Randomize()
        Me.n1 = Rnd() * 10
        TextBox1.Text = Me.n1

        Randomize()
        Me.n2 = Rnd() * 10
        TextBox2.Text = Me.n2

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        TextBox1.Text = " "
        TextBox2.Text = " "

        Randomize()
        Me.n1 = Rnd() * 10
        TextBox1.Text = Me.n1

        Randomize()
        Me.n2 = Rnd() * 10
        TextBox2.Text = Me.n2

    End Sub
End Class
