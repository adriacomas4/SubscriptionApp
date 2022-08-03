Public Class FilterDataWithDate
    Private _from As Date
    Private _to As Date
    Private _empresa As Integer
    Private _repoPurchase As PurchaseRepository

    Public Sub New(empresaId As Integer, fromDate As Date, toDate As Date)
        _repoPurchase = New PurchaseRepository
        Me._from = fromDate
        Me._to = toDate
        Me._empresa = empresaId
    End Sub

    Public Function filterDate() As DataTable
        Dim filter As PurchaseFilter = New PurchaseFilter
        filter.fromDate = _from
        filter.toDate = _to
        filter.empresa = _empresa
        Return _repoPurchase.Get(filter)
    End Function
End Class
