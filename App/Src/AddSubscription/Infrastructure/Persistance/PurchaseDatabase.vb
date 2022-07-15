Public Class PurchaseDatabase
    Implements PurchaseRepository

    Private _conn As DBConnection
    Sub New()
        _conn = New DBConnection()
    End Sub
    Public Sub Create(trans As Purchase) Implements PurchaseRepository.Create
        Dim result = New ActionQueryDB(_conn.Connection).executeActionQuery($"INSERT SubsTransaction(quantity, price, datatrans, empresa) VALUES
                                                ({trans.Quantity.Value},{trans.Price.Value},'{trans.Datetrans.Value}',{trans.Empresa.Value})")
        If result <> 1 Then
            MsgBox("No s'ha pogut inserir la transacció a la taula.")
        End If
    End Sub
End Class
