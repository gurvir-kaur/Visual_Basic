Public Class Form1

    'crear 3 arrays
    Private first(2) As Integer
    Private second(2) As Integer
    Private third(2) As Integer
    Private fourth(2) As Integer

    'crear un contador 
    Private i As Integer

    Private Sub primero_Click(sender As Object, e As EventArgs) Handles primero.Click

    End Sub

    Private Sub segundo_Click_1(sender As Object, e As EventArgs) Handles segundo.Click

    End Sub

    Private Sub tercero_Click(sender As Object, e As EventArgs) Handles tercero.Click

    End Sub

    Private Sub cuarto_Click(sender As Object, e As EventArgs) Handles cuarto.Click

    End Sub

    Private Sub start1_Click(sender As Object, e As EventArgs) Handles start1.Click

        'en primer round i = 0 para dar primera posicion de arrays
        Me.i = 0

        p1.Text = createRandom()
        Me.first(i) = Val(p1.Text)

        s1.Text = createRandom()
        Me.second(i) = Val(s1.Text)

        t1.Text = createRandom()
        Me.third(i) = Val(t1.Text)

        c1.Text = createRandom()
        Me.fourth(i) = Val(c1.Text)

    End Sub




    Private Function createRandom() As Integer
        Dim rNumber As Integer
        rNumber = Int((6 * Rnd()) + 1) ' Generate random value between 1 and 6.
        Return rNumber
    End Function




    Private Sub p1_TextChanged(sender As Object, e As EventArgs) Handles p1.TextChanged

    End Sub

    Private Sub start2_Click(sender As Object, e As EventArgs) Handles start2.Click

        'en segundo round i = 1 para dar la segunda posicion de arrays
        Me.i = 1

        p2.Text = createRandom()
        Me.first(i) = Val(p2.Text)

        s2.Text = createRandom()
        Me.second(i) = Val(s2.Text)

        t2.Text = createRandom()
        Me.third(i) = Val(t2.Text)

        c2.Text = createRandom()
        Me.fourth(i) = Val(c2.Text)


    End Sub

    Private Sub start3_Click(sender As Object, e As EventArgs) Handles start3.Click

        'en tercero round i = 2 para asignar la ultima posicion de arrays
        Me.i = 2

        p3.Text = createRandom()
        Me.first(i) = Val(p3.Text)

        s3.Text = createRandom()
        Me.second(i) = Val(s3.Text)

        t3.Text = createRandom()
        Me.third(i) = Val(t3.Text)

        c3.Text = createRandom()
        Me.fourth(i) = Val(c3.Text)


    End Sub

    Private Sub total1_TextChanged(sender As Object, e As EventArgs) Handles total1.TextChanged

    End Sub

    Private Sub finish_Click(sender As Object, e As EventArgs) Handles finish.Click

        Dim j, n, m, o, p As Integer

        For j = 0 To 2
            n = n + first(j)
        Next j

        total1.Text = n

        For j = 0 To 2
            m = m + second(j)
        Next j

        total2.Text = m

        For j = 0 To 2
            o = o + third(j)
        Next j

        total3.Text = o

        For j = 0 To 2
            p = p + fourth(j)
        Next j

        total4.Text = p

        Dim max As String

        If ((n > m) And (n > o) And (n > p)) Then max = "Primero"

        If ((m > n) And (m > o) And (m > p)) Then max = "Segundo"

        If ((o > n) And (o > m) And (o > p)) Then max = "Tercero"

        If ((p > n) And (p > m) And (p > o)) Then max = "Cuarto"

        MessageBox.Show($"The Winner is {max}")

    End Sub

    Private Sub playAgain_Click(sender As Object, e As EventArgs) Handles playAgain.Click

        p1.Text = " "
        p2.Text = " "
        p3.Text = " "

        s1.Text = " "
        s2.Text = " "
        s3.Text = " "

        t1.Text = " "
        t2.Text = " "
        t3.Text = " "

        c1.Text = " "
        c2.Text = " "
        c3.Text = " "

        total1.Text = " "
        total2.Text = " "
        total3.Text = " "
        total4.Text = " "

    End Sub


End Class
