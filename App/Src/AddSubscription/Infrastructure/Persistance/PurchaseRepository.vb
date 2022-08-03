Public Class PurchaseRepository
    Implements IPurchaseRepository

    Private _conn As DBConnection
    Sub New()
        _conn = New DBConnection()
    End Sub
    Public Sub Create(trans As Purchase) Implements IPurchaseRepository.Create
        Dim result = New ActionQueryDB(_conn.Connection).executeActionQuery($"INSERT SubsTransaction(quantity, price, datatrans, empresa) VALUES
                                                ({trans.Quantity.Value},{trans.Price.Value},'{trans.Datetrans.Value}',{trans.Empresa.Value})")
        If result <> 1 Then
            MsgBox("No s'ha pogut inserir la transacció a la taula.")
        End If
    End Sub

    Public Function [Get](filter As PurchaseFilter) As DataTable Implements IPurchaseRepository.Get

        Return New SelectQueryDB(_conn.Connection).executeSelectQuery($"SELECT quantity, price, datatrans FROM SubsTransaction {AddArgs(filter)}")
    End Function

    Private Function AddArgs(filter As PurchaseFilter) As Object
        Dim args As String = String.Empty

        args += empresaArg(filter.empresa)

        If Not filter.fromDate Is Nothing Then
            If Not String.IsNullOrEmpty(args) Then args += " AND "
            args += fromDateArg(filter.fromDate)
        End If

        If Not filter.toDate Is Nothing Then
            If Not String.IsNullOrEmpty(args) Then args += " AND "
            args += toDateArg(filter.toDate)
        End If

        If Not String.IsNullOrEmpty(args) Then
            args = " WHERE " & args
        End If
        Return args
    End Function

    Private Function empresaArg(empresa As Integer) As Object
        Return $"empresa = {empresa}"
    End Function

    Private Function fromDateArg(fromDate As Date) As Object
        Return $"datatrans >= CAST('{fromDate.ToString("yyyyMMdd")}' AS DATE)"
    End Function

    Private Function toDateArg(toDate As Date) As Object
        Return $"datatrans <= CAST('{toDate.ToString("yyyyMMdd")}' AS DATE)"
    End Function

End Class
