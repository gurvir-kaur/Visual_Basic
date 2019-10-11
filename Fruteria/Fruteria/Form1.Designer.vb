<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.stockPlatano = New System.Windows.Forms.TextBox()
        Me.stockPeras = New System.Windows.Forms.TextBox()
        Me.compraManzanas = New System.Windows.Forms.TextBox()
        Me.kgManzanas = New System.Windows.Forms.TextBox()
        Me.stockManzanas = New System.Windows.Forms.TextBox()
        Me.compraPlatanos = New System.Windows.Forms.TextBox()
        Me.kgPlatanos = New System.Windows.Forms.TextBox()
        Me.pagado = New System.Windows.Forms.TextBox()
        Me.precioCompra = New System.Windows.Forms.TextBox()
        Me.compraPeras = New System.Windows.Forms.TextBox()
        Me.kgPeras = New System.Windows.Forms.TextBox()
        Me.cajaDinero = New System.Windows.Forms.TextBox()
        Me.cambio = New System.Windows.Forms.TextBox()
        Me.nuevaCompra = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Platanos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Manzanas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Peras"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio Compra"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pagado"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(59, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cambio"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(59, 346)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Dinero Caja"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(265, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 24)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Stock"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(394, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 24)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Kg/€"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(502, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 24)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Kg/compra"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'stockPlatano
        '
        Me.stockPlatano.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockPlatano.Location = New System.Drawing.Point(254, 79)
        Me.stockPlatano.Name = "stockPlatano"
        Me.stockPlatano.Size = New System.Drawing.Size(82, 31)
        Me.stockPlatano.TabIndex = 10
        '
        'stockPeras
        '
        Me.stockPeras.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockPeras.Location = New System.Drawing.Point(254, 162)
        Me.stockPeras.Name = "stockPeras"
        Me.stockPeras.Size = New System.Drawing.Size(82, 31)
        Me.stockPeras.TabIndex = 11
        '
        'compraManzanas
        '
        Me.compraManzanas.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compraManzanas.Location = New System.Drawing.Point(506, 119)
        Me.compraManzanas.Name = "compraManzanas"
        Me.compraManzanas.Size = New System.Drawing.Size(82, 31)
        Me.compraManzanas.TabIndex = 12
        '
        'kgManzanas
        '
        Me.kgManzanas.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kgManzanas.Location = New System.Drawing.Point(375, 119)
        Me.kgManzanas.Name = "kgManzanas"
        Me.kgManzanas.Size = New System.Drawing.Size(82, 31)
        Me.kgManzanas.TabIndex = 13
        '
        'stockManzanas
        '
        Me.stockManzanas.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockManzanas.Location = New System.Drawing.Point(254, 119)
        Me.stockManzanas.Name = "stockManzanas"
        Me.stockManzanas.Size = New System.Drawing.Size(82, 31)
        Me.stockManzanas.TabIndex = 14
        '
        'compraPlatanos
        '
        Me.compraPlatanos.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compraPlatanos.Location = New System.Drawing.Point(506, 79)
        Me.compraPlatanos.Name = "compraPlatanos"
        Me.compraPlatanos.Size = New System.Drawing.Size(82, 31)
        Me.compraPlatanos.TabIndex = 15
        '
        'kgPlatanos
        '
        Me.kgPlatanos.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kgPlatanos.Location = New System.Drawing.Point(375, 79)
        Me.kgPlatanos.Name = "kgPlatanos"
        Me.kgPlatanos.Size = New System.Drawing.Size(82, 31)
        Me.kgPlatanos.TabIndex = 16
        '
        'pagado
        '
        Me.pagado.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pagado.Location = New System.Drawing.Point(254, 262)
        Me.pagado.Name = "pagado"
        Me.pagado.Size = New System.Drawing.Size(82, 31)
        Me.pagado.TabIndex = 17
        '
        'precioCompra
        '
        Me.precioCompra.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.precioCompra.Location = New System.Drawing.Point(254, 221)
        Me.precioCompra.Name = "precioCompra"
        Me.precioCompra.Size = New System.Drawing.Size(82, 31)
        Me.precioCompra.TabIndex = 18
        '
        'compraPeras
        '
        Me.compraPeras.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compraPeras.Location = New System.Drawing.Point(506, 162)
        Me.compraPeras.Name = "compraPeras"
        Me.compraPeras.Size = New System.Drawing.Size(82, 31)
        Me.compraPeras.TabIndex = 19
        '
        'kgPeras
        '
        Me.kgPeras.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kgPeras.Location = New System.Drawing.Point(375, 162)
        Me.kgPeras.Name = "kgPeras"
        Me.kgPeras.Size = New System.Drawing.Size(82, 31)
        Me.kgPeras.TabIndex = 20
        '
        'cajaDinero
        '
        Me.cajaDinero.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cajaDinero.Location = New System.Drawing.Point(254, 346)
        Me.cajaDinero.Name = "cajaDinero"
        Me.cajaDinero.Size = New System.Drawing.Size(82, 31)
        Me.cajaDinero.TabIndex = 21
        '
        'cambio
        '
        Me.cambio.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cambio.Location = New System.Drawing.Point(254, 304)
        Me.cambio.Name = "cambio"
        Me.cambio.Size = New System.Drawing.Size(82, 31)
        Me.cambio.TabIndex = 22
        '
        'nuevaCompra
        '
        Me.nuevaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.nuevaCompra.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevaCompra.Location = New System.Drawing.Point(433, 221)
        Me.nuevaCompra.Name = "nuevaCompra"
        Me.nuevaCompra.Size = New System.Drawing.Size(108, 72)
        Me.nuevaCompra.TabIndex = 23
        Me.nuevaCompra.Text = "Nueva Compra"
        Me.nuevaCompra.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.salir.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salir.Location = New System.Drawing.Point(433, 304)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(108, 53)
        Me.salir.TabIndex = 24
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.nuevaCompra)
        Me.Controls.Add(Me.cambio)
        Me.Controls.Add(Me.cajaDinero)
        Me.Controls.Add(Me.kgPeras)
        Me.Controls.Add(Me.compraPeras)
        Me.Controls.Add(Me.precioCompra)
        Me.Controls.Add(Me.pagado)
        Me.Controls.Add(Me.kgPlatanos)
        Me.Controls.Add(Me.compraPlatanos)
        Me.Controls.Add(Me.stockManzanas)
        Me.Controls.Add(Me.kgManzanas)
        Me.Controls.Add(Me.compraManzanas)
        Me.Controls.Add(Me.stockPeras)
        Me.Controls.Add(Me.stockPlatano)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents stockPlatano As TextBox
    Friend WithEvents stockPeras As TextBox
    Friend WithEvents compraManzanas As TextBox
    Friend WithEvents kgManzanas As TextBox
    Friend WithEvents stockManzanas As TextBox
    Friend WithEvents compraPlatanos As TextBox
    Friend WithEvents kgPlatanos As TextBox
    Friend WithEvents pagado As TextBox
    Friend WithEvents precioCompra As TextBox
    Friend WithEvents compraPeras As TextBox
    Friend WithEvents kgPeras As TextBox
    Friend WithEvents cajaDinero As TextBox
    Friend WithEvents cambio As TextBox
    Friend WithEvents nuevaCompra As Button
    Friend WithEvents salir As Button
End Class
