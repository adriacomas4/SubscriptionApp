Public Class addSubscriptionToBusiness

    Sub New(empresa As Empresa, subs As VOSubscripcions)
        Dim subtobusRepo = New SubsToBusinessDatabase
        subtobusRepo.Add(empresa.Id, subs.Quantity)
        Dim t = New Transaction(subs.Quantity, subs.Price, empresa.Id)
        Dim transactionRepo = New AddTransactionBusinessDatabase
        transactionRepo.Add(t)
    End Sub

End Class
