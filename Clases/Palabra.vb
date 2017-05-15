Public Class Palabra : Implements IEquatable(Of Palabra)

    Public Property Descripcion As String
    Public Property Valor As String
    Sub New()

    End Sub
    Sub New(ByVal descripcion As String)
        Me.Descripcion = descripcion
    End Sub
    Sub New(ByVal descripcion As String, ByVal valor As String)
        Me.Descripcion = descripcion
        Me.Valor = valor
    End Sub

    Public Overloads Function Equals(ByVal other As Palabra) As Boolean Implements System.IEquatable(Of Palabra).Equals
        Return other.Descripcion.ToUpper.Equals(Me.Descripcion.ToUpper)
    End Function
End Class
