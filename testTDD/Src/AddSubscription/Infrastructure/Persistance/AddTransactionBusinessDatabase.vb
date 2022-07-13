Public Class AddTransactionBusinessDatabase
    Implements addTransactionBusinessRepository

    Private _conn As DBConnection
    Sub New()
        _conn = New DBConnection()
    End Sub
    Public Sub Add(trans As Transaction) Implements addTransactionBusinessRepository.Add
        Dim result = _conn.DoInsertUpdateQuery($"INSERT SubsTransaction(quantity, price, empresa) VALUES ({trans._quantity},{trans._price},{trans._empresa})")

    End Sub
End Class
