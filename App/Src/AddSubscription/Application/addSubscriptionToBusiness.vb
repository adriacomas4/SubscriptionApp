Public Class addSubscriptionToBusiness

    Sub New(subtobusRepo As BusinessRepository, transactionRepo As PurchaseRepository, empresa As Business, quantity As Integer)
        subtobusRepo.Create(empresa.Id.Value, quantity)
        Dim pur As Purchase = New Purchase(New VOPurchaseQuantity(quantity), New VOPurchaseBusiness(empresa.Id.Value))
        transactionRepo.Create(pur)
    End Sub

End Class
