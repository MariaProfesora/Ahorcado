Public Class frmAnadir
    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        Dim mens As String = miJuego.AñadirPalabra(New Clases.Palabra(txtDescripcion.Text, txtValor.Text))
        If mens <> "" Then
            MessageBox.Show(mens)
        End If
    End Sub
End Class