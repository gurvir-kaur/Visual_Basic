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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.reiniciar = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.rango1 = New System.Windows.Forms.TextBox()
        Me.rango2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(161, 41)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(296, 95)
        Me.ListBox1.TabIndex = 0
        '
        'reiniciar
        '
        Me.reiniciar.Location = New System.Drawing.Point(265, 249)
        Me.reiniciar.Name = "reiniciar"
        Me.reiniciar.Size = New System.Drawing.Size(93, 59)
        Me.reiniciar.TabIndex = 1
        Me.reiniciar.Text = "Reiniciar"
        Me.reiniciar.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(265, 337)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(93, 59)
        Me.salir.TabIndex = 2
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'rango1
        '
        Me.rango1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rango1.Location = New System.Drawing.Point(323, 169)
        Me.rango1.Name = "rango1"
        Me.rango1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.rango1.Size = New System.Drawing.Size(54, 20)
        Me.rango1.TabIndex = 3
        '
        'rango2
        '
        Me.rango2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rango2.Location = New System.Drawing.Point(403, 169)
        Me.rango2.Name = "rango2"
        Me.rango2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.rango2.Size = New System.Drawing.Size(54, 20)
        Me.rango2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Escribe dos numero:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ok
        '
        Me.ok.Location = New System.Drawing.Point(482, 158)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(57, 40)
        Me.ok.TabIndex = 6
        Me.ok.Text = "ok"
        Me.ok.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rango2)
        Me.Controls.Add(Me.rango1)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.reiniciar)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents reiniciar As Button
    Friend WithEvents salir As Button
    Friend WithEvents rango1 As TextBox
    Friend WithEvents rango2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ok As Button
End Class
