Public Class VOPurchaseBusiness
    Private _bus As Integer

    Public ReadOnly Property Value As Integer
        Get
            Return _bus
        End Get
    End Property

    Sub New(bus As Integer)
        _bus = bus
    End Sub
End Class
