Public Class AddTransactionBusinessDatabase
    Implements addTransactionBusinessRepository

    Private _conn As DBConnection
    Sub New()
        _conn = New DBConnection()
    End Sub
    Public Sub Add(trans As Transaction) Implements addTransactionBusinessRepository.Add
        Dim result = _conn.DoInsertUpdateQuery($"INSERT SubsTransaction(quantity, price, empresa) VALUES ({trans.Quantity.Value},{trans.Price.Value},{trans.Empresa.Value})")
        If result <> 1 Then
            MsgBox("No s'ha pogut inserir la transacció a la taula.")
        End If
    End Sub
End Class
