Public Class addSubscriptionToBusiness

    Sub New(subtobusRepo As SubsToBusinessRepository, transactionRepo As addTransactionBusinessRepository, empresa As Empresa, quantity As Integer)
        subtobusRepo.Add(empresa.Id.Value, quantity)
        Dim trans As Transaction = New Transaction(New TransQuantity(quantity), New TransBusiness(empresa.Id.Value))
        transactionRepo.Add(trans)
    End Sub

End Class
