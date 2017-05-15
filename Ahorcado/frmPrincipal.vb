Imports Clases
Public Class frmPrincipal
    'Private miJuego As JuegoAhorcado
    'Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
    '    miJuego = New JuegoAhorcado ' Crea un nuevo juego
    '    Dim pal As New Palabra("Nombre de mujer", "Marta")
    '    miJuego.AñadirPalabra(pal) ' La añadiría si no estuviese ya entre las iniciales
    '    miJuego.AñadirPalabra(pal) ' En este caso, debería darme información de que ya existe
    '    pal = New Palabra("Nombre de mujer", "Itziar")
    '    miJuego.AñadirPalabra(pal) ' Esta también se añadiría (si no estuviese desde el comienzo)

    'End Sub

    Private Sub JugarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JugarToolStripMenuItem.Click
        frmAhorcado.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AñadirPalabrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirPalabrasToolStripMenuItem.Click
        Dim frmAn As New frmAnadir
        frmAn.ShowDialog()
    End Sub
End Class