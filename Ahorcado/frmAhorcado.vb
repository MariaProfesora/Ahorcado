
Imports Clases

Public Class frmAhorcado
    'http://pasatiempos.elmundo.es/ahorcado/ahorcado.html
    Private btnLetras As New List(Of Button)
    Private lblPalabra As New List(Of Label)

    Private Recursos() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6}
    Private nRec As Integer = 0

    Private Sub btnOtraPalabra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtraPalabra.Click
        Dim adivinar As Palabra = miJuego.Adivinar
        Dim palabra As String = adivinar.Valor
        If palabra = "" Then Exit Sub
        Dim x As Integer = 80
        Dim y As Integer = 50
        ' Consigo que parezca una línea poniendo una etiqueta con el texto _
        For i As Integer = 0 To lblPalabra.Count - 1
            Me.Controls.Remove(lblPalabra(i))
        Next
        For i As Integer = 0 To palabra.Length - 1
            Dim lbl As New Label
            lbl.Location = New Point(x, y)
            lbl.Size = New Size(30, 30)
            lbl.Tag = palabra.Substring(i, 1)
            lbl.BorderStyle = BorderStyle.None ' BorderStyle.FixedSingle
            lbl.Font = New Font("Microsoft Sans Serif", 20)
            lbl.Text = "_"
            x += lbl.Width
            Me.Controls.Add(lbl)
            AddHandler lbl.Click, AddressOf btnLetras_Click
            lblPalabra.Add(lbl)
        Next
        Me.lblDescripcion.Text = adivinar.Descripcion
        nRec = 0
        Me.picAhorcado.BackgroundImage = Recursos(nRec)
        LimpiarLetras()
    End Sub
    Private Sub btnLetras_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim letra As String = TryCast(sender, Button).Text
        Dim pos As List(Of Integer) = miJuego.PosicionesLetra(letra)
        Dim existe As Boolean = pos.Count > 0
        For i As Integer = 0 To pos.Count - 1
            lblPalabra(pos(i)).Text = letra
        Next
        Dim btn As Button = sender
        If existe Then
            btn.BackColor = Color.Green
            If miJuego.Adivinado Then MessageBox.Show("Has adivinado")
        Else
            btn.BackColor = Color.Red
            nRec += 1
            Me.picAhorcado.BackgroundImage = Recursos(nRec)
            If miJuego.Ahorcado Then
                MessageBox.Show("Ahorcado")
            End If
        End If
        If miJuego.Adivinado OrElse miJuego.Ahorcado Then
            For Each b As Button In btnLetras
                b.Enabled = False
            Next
        Else
            btn.Enabled = False
        End If
    End Sub

    Private Sub CrearBotonesLetras()
        Const letras = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ"
        Dim x As Integer = Me.lblDescripcion.Left - 40
        Dim y As Integer = 110
        Dim clf As Integer = 0
        For i As Integer = 0 To letras.Length - 1
            Dim btn As New Button
            btn.Location = New Point(x, y)
            btn.Size = New Size(30, 30)
            btn.Text = letras.Substring(i, 1)
            x += btn.Width
            clf += 1
            If clf = 9 Then
                x = Me.lblDescripcion.Left - 40
                y += btn.Height
                clf = 0
            End If
            'Me.grbLetras.Controls.Add(btn)
            btn.BackColor = Color.Gray
            Me.Controls.Add(btn)
            AddHandler btn.Click, AddressOf btnLetras_Click
            btnLetras.Add(btn)
        Next
    End Sub
    Private Sub LimpiarLetras()
        For Each btn As Button In btnLetras
            btn.BackColor = Color.Gray
            btn.Enabled = True
        Next
    End Sub

    Private Sub frmAhorcado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrearBotonesLetras()
        btnOtraPalabra_Click(btnOtraPalabra, New EventArgs)
    End Sub

    Private Sub btnFinalizar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFinalizar.Click
        Me.Close()
    End Sub
End Class
