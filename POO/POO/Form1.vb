Public Class Form1

    Private r1 As Racional
    Private r2 As Racional

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        r1 = New Racional(Val(TextBox1.Text), Val(TextBox2.Text))
        TextBox3.Text = r1.to_String()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        r2 = r1.escalar(Val(TextBox4.Text))
        TextBox5.Text = r2.to_String()

    End Sub

    Private Sub comprobar_Click(sender As Object, e As EventArgs) Handles comprobar.Click

        If (r1.iguales(New Racional(Val(nuevoNumerador.Text), Val(nuevoDenominador.Text))) = True) Then
            MessageBox.Show("Son iguales")
        Else
            MessageBox.Show("No son iguales")
        End If

    End Sub


End Class
