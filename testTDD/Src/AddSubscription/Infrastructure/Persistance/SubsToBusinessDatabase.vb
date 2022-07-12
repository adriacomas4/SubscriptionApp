Public Class SubsToBusinessDatabase
    Implements SubsToBusinessRepository

    Private _conn As DBConnection
    Sub New()
        _conn = New DBConnection()
    End Sub

    Public Sub add(name As String, quantity As Integer) Implements SubsToBusinessRepository.add
        Dim result = _conn.doUpdateQuery($"UPDATE Empreses SET quantity = quantity + {quantity} WHERE Name = '{name}'")
        If result = 1 Then
            MsgBox("Actualitzat")
        End If
    End Sub
End Class
