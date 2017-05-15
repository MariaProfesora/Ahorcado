Public Class Form1
    'http://pasatiempos.elmundo.es/ahorcado/ahorcado.html
    Private btnLetras As New List(Of Button)
    Private lblPalabra As New List(Of Label)
    Private misPalabras As New Palabras
    Private Sub btnComenzar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSacarPalabra.Click
        Dim palabra As String = misPalabras.Palabra
        If palabra = "" Then Exit Sub
        Dim x As Integer = 10
        Dim y As Integer = 20
        'El control Line de Visual Basic 6.0 no tiene equivalente en Visual Basic .NET. Durante la actualización, los controles Line horizontales y verticales se reemplazan por el control Label de formularios Windows Forms, con la propiedad Text establecida en una cadena vacía, la propiedad BorderStyle establecida en none y las propiedades BackColor, Width y Height establecidas de modo que coincidan con el control original.
        Me.grbAdivinar.Controls.Clear()
        For i As Integer = 0 To palabra.Length - 1
            Dim lbl As New Label
            lbl.Location = New Point(x, y)
            lbl.Size = New Size(30, 30)
            lbl.Tag = palabra.Substring(i, 1)
            x += lbl.Width
            If x + lbl.Width > grbLetras.Width Then
                x = 10
                y += lbl.Height
            End If
            lbl.BorderStyle = BorderStyle.None ' BorderStyle.FixedSingle
            Me.grbAdivinar.Controls.Add(lbl)
            AddHandler lbl.Click, AddressOf btnLetras_Click
            lblPalabra.Add(lbl)
        Next

    End Sub
    Private Sub btnLetras_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim letra As String = TryCast(sender, Button).Text
        Dim pos As List(Of Integer) = misPalabras.PosicionesLetra(letra)
        For i As Integer = 0 To pos.Count - 1
            lblPalabra(pos(i)).Text = letra
        Next
        Me.grbLetras.Enabled = Not misPalabras.Fin
        sender.enabled = False
    End Sub

    Private Sub btnCrearLetras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearLetras.Click

        Const letras = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ"
        Dim x As Integer = 10
        Dim y As Integer = 10
        For i As Integer = 0 To letras.Length - 1
            Dim btn As New Button
            btn.Location = New Point(x, y)
            btn.Size = New Size(30, 30)
            btn.Text = letras.Substring(i, 1)
            x += btn.Width
            If x + btn.Width > grbLetras.Width Then
                x = 10
                y += btn.Height
            End If
            Me.grbLetras.Controls.Add(btn)
            AddHandler btn.Click, AddressOf btnLetras_Click
            btnLetras.Add(btn)
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnCrearLetras_Click(btnCrearLetras, New EventArgs)
        Me.btnCrearLetras.Visible = False
    End Sub

End Class
