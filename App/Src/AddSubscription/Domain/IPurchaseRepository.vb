Public Interface IPurchaseRepository
    Sub Create(trans As Purchase)

    Function [Get](filter As PurchaseFilter) As DataTable
End Interface
