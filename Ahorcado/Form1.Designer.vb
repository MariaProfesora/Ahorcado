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
        Me.btnSacarPalabra = New System.Windows.Forms.Button()
        Me.grbLetras = New System.Windows.Forms.GroupBox()
        Me.btnCrearLetras = New System.Windows.Forms.Button()
        Me.grbAdivinar = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'btnSacarPalabra
        '
        Me.btnSacarPalabra.Location = New System.Drawing.Point(179, 245)
        Me.btnSacarPalabra.Name = "btnSacarPalabra"
        Me.btnSacarPalabra.Size = New System.Drawing.Size(91, 40)
        Me.btnSacarPalabra.TabIndex = 0
        Me.btnSacarPalabra.Text = "&Sacar palabra"
        Me.btnSacarPalabra.UseVisualStyleBackColor = True
        '
        'grbLetras
        '
        Me.grbLetras.Location = New System.Drawing.Point(98, 109)
        Me.grbLetras.Name = "grbLetras"
        Me.grbLetras.Size = New System.Drawing.Size(329, 114)
        Me.grbLetras.TabIndex = 1
        Me.grbLetras.TabStop = False
        Me.grbLetras.Text = "Letras"
        '
        'btnCrearLetras
        '
        Me.btnCrearLetras.Location = New System.Drawing.Point(12, 245)
        Me.btnCrearLetras.Name = "btnCrearLetras"
        Me.btnCrearLetras.Size = New System.Drawing.Size(77, 26)
        Me.btnCrearLetras.TabIndex = 2
        Me.btnCrearLetras.Text = "&CrearLetras"
        Me.btnCrearLetras.UseVisualStyleBackColor = True
        '
        'grbAdivinar
        '
        Me.grbAdivinar.Location = New System.Drawing.Point(67, 26)
        Me.grbAdivinar.Name = "grbAdivinar"
        Me.grbAdivinar.Size = New System.Drawing.Size(395, 59)
        Me.grbAdivinar.TabIndex = 3
        Me.grbAdivinar.TabStop = False
        Me.grbAdivinar.Text = "Palabra a adivinar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 310)
        Me.Controls.Add(Me.grbAdivinar)
        Me.Controls.Add(Me.btnCrearLetras)
        Me.Controls.Add(Me.grbLetras)
        Me.Controls.Add(Me.btnSacarPalabra)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSacarPalabra As System.Windows.Forms.Button
    Friend WithEvents grbLetras As System.Windows.Forms.GroupBox
    Friend WithEvents btnCrearLetras As System.Windows.Forms.Button
    Friend WithEvents grbAdivinar As System.Windows.Forms.GroupBox

End Class
