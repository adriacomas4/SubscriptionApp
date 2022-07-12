Public Class addSubscriptionToBusiness

    Sub New(empresa As VOEmpreses, quantity As VOSubscripcions)
        Dim subtobusRepo = New SubsToBusinessDatabase
        subtobusRepo.add(empresa.Name, quantity.Quantity)
    End Sub

End Class
