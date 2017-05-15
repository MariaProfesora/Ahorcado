<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JugarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AñadirPalabrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarPalabrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrartodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JugarToolStripMenuItem, Me.ToolStripMenuItem2, Me.AñadirPalabrasToolStripMenuItem, Me.BorrarPalabrasToolStripMenuItem, Me.BorrartodasToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'JugarToolStripMenuItem
        '
        Me.JugarToolStripMenuItem.Name = "JugarToolStripMenuItem"
        Me.JugarToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.JugarToolStripMenuItem.Text = "&Jugar"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(153, 6)
        '
        'AñadirPalabrasToolStripMenuItem
        '
        Me.AñadirPalabrasToolStripMenuItem.Name = "AñadirPalabrasToolStripMenuItem"
        Me.AñadirPalabrasToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AñadirPalabrasToolStripMenuItem.Text = "&Añadir palabras"
        '
        'BorrarPalabrasToolStripMenuItem
        '
        Me.BorrarPalabrasToolStripMenuItem.Name = "BorrarPalabrasToolStripMenuItem"
        Me.BorrarPalabrasToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.BorrarPalabrasToolStripMenuItem.Text = "&Borrar palabras"
        '
        'BorrartodasToolStripMenuItem
        '
        Me.BorrartodasToolStripMenuItem.Name = "BorrartodasToolStripMenuItem"
        Me.BorrartodasToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.BorrartodasToolStripMenuItem.Text = "Borrar &todas"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(153, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Juego del ahorcado"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AñadirPalabrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarPalabrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JugarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrartodasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
