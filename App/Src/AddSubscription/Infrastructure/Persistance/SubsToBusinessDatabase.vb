Public Class SubsToBusinessDatabase
    Implements SubsToBusinessRepository

    Private _conn As DBConnection
    Sub New()
        _conn = New DBConnection()
    End Sub

    Public Sub Add(Id As Integer, quantity As Integer) Implements SubsToBusinessRepository.Add
        Dim result = _conn.DoInsertUpdateQuery($"UPDATE Empreses SET quantity = quantity + {quantity} WHERE id = '{Id}'")
        If result = 1 Then
            MsgBox("Actualitzat")
        End If
    End Sub
End Class
