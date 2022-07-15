Public Class getAllBusiness

    Private _repo As BusinessRepository
    Sub New(business As BusinessRepository)
        _repo = business
    End Sub

    Public Function getBusiness()
        Return _repo.Get()
    End Function
End Class
