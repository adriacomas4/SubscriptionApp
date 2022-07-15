Public Class BusinessDatabase
    Implements BusinessRepository

    Private _conn As DBConnection
    Sub New()
        _conn = New DBConnection()
    End Sub

    Public Sub Create(Id As Integer, quantity As Integer) Implements BusinessRepository.Create
        Dim result = New ActionQueryDB(_conn.Connection).executeActionQuery($"UPDATE Empresas SET quantity = quantity + {quantity} WHERE id = '{Id}'")
        If result = 1 Then
            MsgBox("Actualitzat")
        End If
    End Sub

    Public Function [Get]() As Object Implements BusinessRepository.Get
        Dim result = New SelectQueryDB(_conn.Connection).executeSelectQuery("SELECT id, name, quantity FROM Empresas")
        Return result
    End Function
End Class
