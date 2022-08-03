Public Class getAllBusiness

    Private _repo As IBusinessRepository
    Sub New(business As IBusinessRepository)
        _repo = business
    End Sub

    Public Function getBusiness()
        Return _repo.Get()
    End Function
End Class
