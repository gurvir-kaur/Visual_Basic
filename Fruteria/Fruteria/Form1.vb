Public Class Form1

    Private platano As Integer = 440
    Private manzanas As Integer = 380
    Private peras As Integer = 560

    Private preioP As Double = 1.34
    Private precioM As Double = 1.15
    Private precioPe As Double = 0.99

    Private dinero As Double = 256.9

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cajaDinero.Text = Me.dinero

        stockPlatano.Text = Me.platano
        stockManzanas.Text = Me.manzanas
        stockPeras.Text = Me.peras

        kgPlatanos.Text = Me.preioP
        kgManzanas.Text = Me.precioM
        kgPeras.Text = Me.precioPe

    End Sub


    Private Sub compraPlatanos_TextChanged(sender As Object, e As EventArgs) Handles compraPlatanos.TextChanged

        precioCompra.Text = ((Me.preioP * Val(compraPlatanos.Text)) + (Me.precioM * Val(compraManzanas.Text)) +
           (Me.precioPe * Val(compraPeras.Text)))

    End Sub

    Private Sub compraManzanas_TextChanged(sender As Object, e As EventArgs) Handles compraManzanas.TextChanged

        precioCompra.Text = ((Me.preioP * Val(compraPlatanos.Text)) + (Me.precioM * Val(compraManzanas.Text)) +
           (Me.precioPe * Val(compraPeras.Text)))

    End Sub

    Private Sub compraPeras_TextChanged(sender As Object, e As EventArgs) Handles compraPeras.TextChanged

        precioCompra.Text = ((Me.preioP * Val(compraPlatanos.Text)) + (Me.precioM * Val(compraManzanas.Text)) +
           (Me.precioPe * Val(compraPeras.Text)))

    End Sub


    Private Sub precioCompra_TextChanged(sender As Object, e As EventArgs) Handles precioCompra.TextChanged

        precioCompra.Text = ((Me.preioP * Val(compraPlatanos.Text)) + (Me.precioM * Val(compraManzanas.Text)) +
            (Me.precioPe * Val(compraPeras.Text)))

    End Sub

    Private Sub pagado_TextChanged(sender As Object, e As EventArgs) Handles pagado.TextChanged

        cambio.Text = Val(pagado.Text) - Val(precioCompra.Text)

    End Sub

    Private Sub cambio_TextChanged(sender As Object, e As EventArgs) Handles cambio.TextChanged

        cambio.Text = Val(pagado.Text) - Val(precioCompra.Text)
        cajaDinero.Text += Val(precioCompra.Text)

    End Sub



    Private Sub nuevaCompra_Click(sender As Object, e As EventArgs) Handles nuevaCompra.Click

        compraPlatanos.Text = " "
        compraManzanas.Text = " "
        compraPeras.Text = " "

        precioCompra.Text = " "
        pagado.Text = " "
        cambio.Text = " "

    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click

        Close()

    End Sub
End Class
