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
        Me.primero = New System.Windows.Forms.Label()
        Me.segundo = New System.Windows.Forms.Label()
        Me.tercero = New System.Windows.Forms.Label()
        Me.cuarto = New System.Windows.Forms.Label()
        Me.p1 = New System.Windows.Forms.TextBox()
        Me.s1 = New System.Windows.Forms.TextBox()
        Me.t1 = New System.Windows.Forms.TextBox()
        Me.c1 = New System.Windows.Forms.TextBox()
        Me.start1 = New System.Windows.Forms.Button()
        Me.total = New System.Windows.Forms.Label()
        Me.p2 = New System.Windows.Forms.TextBox()
        Me.s2 = New System.Windows.Forms.TextBox()
        Me.t2 = New System.Windows.Forms.TextBox()
        Me.c2 = New System.Windows.Forms.TextBox()
        Me.p3 = New System.Windows.Forms.TextBox()
        Me.s3 = New System.Windows.Forms.TextBox()
        Me.t3 = New System.Windows.Forms.TextBox()
        Me.c3 = New System.Windows.Forms.TextBox()
        Me.total1 = New System.Windows.Forms.TextBox()
        Me.total2 = New System.Windows.Forms.TextBox()
        Me.total3 = New System.Windows.Forms.TextBox()
        Me.total4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.start2 = New System.Windows.Forms.Button()
        Me.start3 = New System.Windows.Forms.Button()
        Me.finish = New System.Windows.Forms.Button()
        Me.playAgain = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'primero
        '
        Me.primero.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.primero.Location = New System.Drawing.Point(29, 95)
        Me.primero.Name = "primero"
        Me.primero.Size = New System.Drawing.Size(100, 23)
        Me.primero.TabIndex = 0
        Me.primero.Text = "Primero"
        Me.primero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'segundo
        '
        Me.segundo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.segundo.Location = New System.Drawing.Point(29, 155)
        Me.segundo.Name = "segundo"
        Me.segundo.Size = New System.Drawing.Size(100, 23)
        Me.segundo.TabIndex = 1
        Me.segundo.Text = "Segundo"
        Me.segundo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tercero
        '
        Me.tercero.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tercero.Location = New System.Drawing.Point(29, 219)
        Me.tercero.Name = "tercero"
        Me.tercero.Size = New System.Drawing.Size(100, 23)
        Me.tercero.TabIndex = 2
        Me.tercero.Text = "Tercero"
        Me.tercero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cuarto
        '
        Me.cuarto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuarto.Location = New System.Drawing.Point(29, 281)
        Me.cuarto.Name = "cuarto"
        Me.cuarto.Size = New System.Drawing.Size(100, 23)
        Me.cuarto.TabIndex = 3
        Me.cuarto.Text = "Cuarto"
        Me.cuarto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'p1
        '
        Me.p1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.p1.Location = New System.Drawing.Point(145, 97)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(100, 20)
        Me.p1.TabIndex = 4
        Me.p1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        's1
        '
        Me.s1.Location = New System.Drawing.Point(145, 155)
        Me.s1.Name = "s1"
        Me.s1.Size = New System.Drawing.Size(100, 20)
        Me.s1.TabIndex = 5
        Me.s1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        't1
        '
        Me.t1.Location = New System.Drawing.Point(145, 219)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(100, 20)
        Me.t1.TabIndex = 6
        Me.t1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'c1
        '
        Me.c1.Location = New System.Drawing.Point(145, 281)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(100, 20)
        Me.c1.TabIndex = 7
        Me.c1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'start1
        '
        Me.start1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start1.Location = New System.Drawing.Point(148, 325)
        Me.start1.Name = "start1"
        Me.start1.Size = New System.Drawing.Size(81, 46)
        Me.start1.TabIndex = 8
        Me.start1.Text = "Start"
        Me.start1.UseVisualStyleBackColor = True
        '
        'total
        '
        Me.total.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Location = New System.Drawing.Point(559, 50)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 23)
        Me.total.TabIndex = 9
        Me.total.Text = "Total"
        Me.total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'p2
        '
        Me.p2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.p2.Location = New System.Drawing.Point(274, 98)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(100, 20)
        Me.p2.TabIndex = 10
        Me.p2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        's2
        '
        Me.s2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.s2.Location = New System.Drawing.Point(274, 155)
        Me.s2.Name = "s2"
        Me.s2.Size = New System.Drawing.Size(100, 20)
        Me.s2.TabIndex = 11
        Me.s2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        't2
        '
        Me.t2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.t2.Location = New System.Drawing.Point(274, 219)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(100, 20)
        Me.t2.TabIndex = 12
        Me.t2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'c2
        '
        Me.c2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c2.Location = New System.Drawing.Point(274, 281)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(100, 20)
        Me.c2.TabIndex = 13
        Me.c2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'p3
        '
        Me.p3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.p3.Location = New System.Drawing.Point(400, 97)
        Me.p3.Name = "p3"
        Me.p3.Size = New System.Drawing.Size(100, 20)
        Me.p3.TabIndex = 14
        Me.p3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        's3
        '
        Me.s3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.s3.Location = New System.Drawing.Point(400, 157)
        Me.s3.Name = "s3"
        Me.s3.Size = New System.Drawing.Size(100, 20)
        Me.s3.TabIndex = 15
        Me.s3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        't3
        '
        Me.t3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.t3.Location = New System.Drawing.Point(400, 219)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(100, 20)
        Me.t3.TabIndex = 16
        Me.t3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'c3
        '
        Me.c3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c3.Location = New System.Drawing.Point(400, 281)
        Me.c3.Name = "c3"
        Me.c3.Size = New System.Drawing.Size(100, 20)
        Me.c3.TabIndex = 17
        Me.c3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'total1
        '
        Me.total1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.total1.Location = New System.Drawing.Point(562, 95)
        Me.total1.Name = "total1"
        Me.total1.Size = New System.Drawing.Size(100, 20)
        Me.total1.TabIndex = 18
        Me.total1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'total2
        '
        Me.total2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.total2.Location = New System.Drawing.Point(562, 155)
        Me.total2.Name = "total2"
        Me.total2.Size = New System.Drawing.Size(100, 20)
        Me.total2.TabIndex = 19
        Me.total2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'total3
        '
        Me.total3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.total3.Location = New System.Drawing.Point(562, 219)
        Me.total3.Name = "total3"
        Me.total3.Size = New System.Drawing.Size(100, 20)
        Me.total3.TabIndex = 20
        Me.total3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'total4
        '
        Me.total4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.total4.Location = New System.Drawing.Point(562, 281)
        Me.total4.Name = "total4"
        Me.total4.Size = New System.Drawing.Size(100, 20)
        Me.total4.TabIndex = 21
        Me.total4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Round 1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(271, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Round 2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(397, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Round 3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'start2
        '
        Me.start2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start2.Location = New System.Drawing.Point(289, 325)
        Me.start2.Name = "start2"
        Me.start2.Size = New System.Drawing.Size(85, 46)
        Me.start2.TabIndex = 25
        Me.start2.Text = "Start"
        Me.start2.UseVisualStyleBackColor = True
        '
        'start3
        '
        Me.start3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start3.Location = New System.Drawing.Point(415, 325)
        Me.start3.Name = "start3"
        Me.start3.Size = New System.Drawing.Size(82, 46)
        Me.start3.TabIndex = 26
        Me.start3.Text = "Start"
        Me.start3.UseVisualStyleBackColor = True
        '
        'finish
        '
        Me.finish.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finish.Location = New System.Drawing.Point(562, 325)
        Me.finish.Name = "finish"
        Me.finish.Size = New System.Drawing.Size(113, 61)
        Me.finish.TabIndex = 27
        Me.finish.Text = "Show result and Finish"
        Me.finish.UseVisualStyleBackColor = True
        '
        'playAgain
        '
        Me.playAgain.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playAgain.Location = New System.Drawing.Point(241, 397)
        Me.playAgain.Name = "playAgain"
        Me.playAgain.Size = New System.Drawing.Size(183, 41)
        Me.playAgain.TabIndex = 28
        Me.playAgain.Text = "Play again"
        Me.playAgain.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.playAgain)
        Me.Controls.Add(Me.finish)
        Me.Controls.Add(Me.start3)
        Me.Controls.Add(Me.start2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.total4)
        Me.Controls.Add(Me.total3)
        Me.Controls.Add(Me.total2)
        Me.Controls.Add(Me.total1)
        Me.Controls.Add(Me.c3)
        Me.Controls.Add(Me.t3)
        Me.Controls.Add(Me.s3)
        Me.Controls.Add(Me.p3)
        Me.Controls.Add(Me.c2)
        Me.Controls.Add(Me.t2)
        Me.Controls.Add(Me.s2)
        Me.Controls.Add(Me.p2)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.start1)
        Me.Controls.Add(Me.c1)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.s1)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.cuarto)
        Me.Controls.Add(Me.tercero)
        Me.Controls.Add(Me.segundo)
        Me.Controls.Add(Me.primero)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents primero As Label
    Friend WithEvents segundo As Label
    Friend WithEvents tercero As Label
    Friend WithEvents cuarto As Label
    Friend WithEvents p1 As TextBox
    Friend WithEvents s1 As TextBox
    Friend WithEvents t1 As TextBox
    Friend WithEvents c1 As TextBox
    Friend WithEvents start1 As Button
    Friend WithEvents total As Label
    Friend WithEvents p2 As TextBox
    Friend WithEvents s2 As TextBox
    Friend WithEvents t2 As TextBox
    Friend WithEvents c2 As TextBox
    Friend WithEvents p3 As TextBox
    Friend WithEvents s3 As TextBox
    Friend WithEvents t3 As TextBox
    Friend WithEvents c3 As TextBox
    Friend WithEvents total1 As TextBox
    Friend WithEvents total2 As TextBox
    Friend WithEvents total3 As TextBox
    Friend WithEvents total4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents start2 As Button
    Friend WithEvents start3 As Button
    Friend WithEvents finish As Button
    Friend WithEvents playAgain As Button
End Class
