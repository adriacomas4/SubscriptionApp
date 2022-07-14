Public Class addSubscriptionToBusiness

    Sub New(subtobusRepo As SubsToBusinessRepository, transactionRepo As addTransactionBusinessRepository, empresa As Empresa, subs As VOSubscripcions)
        subtobusRepo.Add(empresa.Id, subs.Quantity)
        Dim t = New Transaction(subs.Quantity, subs.Price, empresa.Id)
        transactionRepo.Add(t)
    End Sub

End Class
