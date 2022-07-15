Public Class TransQuantity

    Private _quantity As Integer

    Public ReadOnly Property Value As Integer
        Get
            Return _quantity
        End Get
    End Property

    Sub New(quantity As Integer)
        _quantity = quantity
    End Sub
End Class
