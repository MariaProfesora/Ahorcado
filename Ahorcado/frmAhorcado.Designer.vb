<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAhorcado
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
        Me.btnOtraPalabra = New System.Windows.Forms.Button()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.picAhorcado = New System.Windows.Forms.PictureBox()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        CType(Me.picAhorcado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOtraPalabra
        '
        Me.btnOtraPalabra.Location = New System.Drawing.Point(132, 245)
        Me.btnOtraPalabra.Name = "btnOtraPalabra"
        Me.btnOtraPalabra.Size = New System.Drawing.Size(91, 40)
        Me.btnOtraPalabra.TabIndex = 0
        Me.btnOtraPalabra.Text = "&Otra palabra"
        Me.btnOtraPalabra.UseVisualStyleBackColor = True
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(81, 21)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(108, 16)
        Me.lblDescripcion.TabIndex = 3
        Me.lblDescripcion.Text = "lblDescripcion"
        '
        'picAhorcado
        '
        Me.picAhorcado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAhorcado.Location = New System.Drawing.Point(389, 92)
        Me.picAhorcado.Name = "picAhorcado"
        Me.picAhorcado.Size = New System.Drawing.Size(96, 107)
        Me.picAhorcado.TabIndex = 4
        Me.picAhorcado.TabStop = False
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Location = New System.Drawing.Point(304, 245)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(91, 40)
        Me.btnFinalizar.TabIndex = 5
        Me.btnFinalizar.Text = "&Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'frmAhorcado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 310)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.picAhorcado)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.btnOtraPalabra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAhorcado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Juego del ahorcado"
        CType(Me.picAhorcado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOtraPalabra As System.Windows.Forms.Button
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents picAhorcado As System.Windows.Forms.PictureBox
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button

End Class
