Imports System.IO

Public Class JuegoAhorcado
    Private misPalabras As New List(Of Palabra)  'From {New Palabra("Nombre de ciclo", "DAM"), New Palabra("Provincia española", "Navarra"), New Palabra("Saludo", "Adios"), New Palabra("Sustantivo", "persona"), New Palabra("Juego", "Ahorcado"), New Palabra("Despedida", "Hola")}
    Private nPal As Integer = -1
    Private errores As Integer = 0
    Private aciertos As Integer = 0
    Private palActual As String
    Dim archivo As String = "../../Archivo/palabras.txt"

    Sub New()
        'archivo = "Archivo/palabras.txt"
        If Not System.IO.File.Exists(archivo) Then
            misPalabras = New List(Of Palabra) From {New Palabra("Nombre de ciclo", "DAM"), New Palabra("Provincia española", "Navarra"), New Palabra("Saludo", "Adios"), New Palabra("Sustantivo", "persona"), New Palabra("Juego", "Ahorcado"), New Palabra("Despedida", "Hola")}
            GrabarPalabras()
            Exit Sub
        End If
        Try
            Dim lineas() As String = File.ReadAllLines(archivo)
            For Each linea In lineas
                Dim datos() As String = linea.Split(";")
                misPalabras.Add(New Palabra(datos(0), datos(1)))
            Next
        Catch ex As Exception
            Dim errorea As String = ex.Message
        End Try

    End Sub
    Private Function GrabarPalabras() As String
        Try
            Using fic As New StreamWriter(archivo)
                For Each pal In misPalabras
                    fic.WriteLine(pal.Descripcion & ";" & pal.Valor)
                Next
                fic.Close() ' No haría falta por using
            End Using
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Private Function GrabarNuevaPalabra(ByVal pal As Palabra) As String
        Try
            Using fic As New StreamWriter(archivo, True)

                fic.WriteLine(pal.Descripcion & ";" & pal.Valor)

                fic.Close() ' No haría falta por using
            End Using
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Function Adivinar() As Palabra
        nPal += 1
        If nPal = misPalabras.Count Then nPal = 0
        errores = 0
        aciertos = 0
        palActual = misPalabras(nPal).Valor
        Return misPalabras(nPal)
    End Function
    Public Function AñadirPalabra(ByVal palabra As Palabra) As String
        If misPalabras.Contains(palabra) Then Return "Ya existía"
        misPalabras.Add(palabra)
        Return GrabarNuevaPalabra(palabra)
    End Function

    Public Sub BorrarTodas()
        misPalabras.Clear()
        Using fic As New StreamWriter(archivo)
            fic.Close()
        End Using
    End Sub
    Public Function BorrarPalabra(ByVal pal As String) As Boolean
        Dim palBorrar As New Palabra(pal)
        If Not misPalabras.Contains(palBorrar) Then Return False
        misPalabras.Remove(palBorrar)
        GrabarPalabras()
        Return True
    End Function
    Public ReadOnly Property Adivinado As Boolean
        Get
            Return aciertos = palActual.Length
        End Get
    End Property
    Public ReadOnly Property Ahorcado As Boolean
        Get
            Return errores = 5
        End Get
    End Property

    Public Function PosicionesLetra(ByVal car As String) As List(Of Integer)
        Dim posiciones As New List(Of Integer)
        If nPal = -1 Then Throw New Exception("No tienes palabra elegida")
        If Ahorcado Then Throw New Exception("Ya ha finalizado")
        Dim palabra As String = misPalabras(nPal).Valor
        For i As Integer = 0 To palabra.Length - 1
            If palabra.Substring(i, 1).ToUpper = car.ToUpper Then
                posiciones.Add(i)
            End If
        Next
        If posiciones.Count = 0 Then errores += 1 Else aciertos += posiciones.Count
        Return posiciones
    End Function

End Class
